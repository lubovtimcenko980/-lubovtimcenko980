'use strict';
// Offline Unity scene/prefab resolver.
// Flattens nested PrefabInstances with the composed-fileID rule: outerId = rawId XOR (accumulated instance ids).
const fs = require('fs');
const path = require('path');

const ROOT = path.resolve(__dirname, '..');
const ASSETS = path.join(ROOT, 'Assets');

let GUID2PATH = null;
function guidIndex() {
  if (GUID2PATH) return GUID2PATH;
  GUID2PATH = new Map();
  const walk = (dir) => {
    for (const e of fs.readdirSync(dir, { withFileTypes: true })) {
      const p = path.join(dir, e.name);
      if (e.isDirectory()) walk(p);
      else if (e.name.endsWith('.meta')) {
        let txt = '';
        try { txt = fs.readFileSync(p, 'utf8'); } catch (err) { continue; }
        const m = /^guid: ([0-9a-f]{32})/m.exec(txt);
        if (m) GUID2PATH.set(m[1], p.slice(0, -5));
      }
    }
  };
  walk(ASSETS);
  return GUID2PATH;
}

function splitDocs(file) {
  const raw = fs.readFileSync(file, 'utf8');
  const lines = raw.split(/\r?\n/);
  const docs = [];
  let cur = null;
  for (const line of lines) {
    const m = /^--- !u!(\d+) &(\d+)(.*)$/.exec(line);
    if (m) { if (cur) docs.push(cur); cur = { cls: +m[1], id: m[2], stripped: /stripped/.test(m[3] || ''), body: [] }; continue; }
    if (cur) cur.body.push(line);
  }
  if (cur) docs.push(cur);
  return docs;
}

const X = (a, b) => (BigInt(a) ^ BigInt(b)).toString();

function fieldOf(body, key) {
  const re = new RegExp('^\\s*' + key.replace(/[.[\]()]/g, '\\$&') + ':\\s*(.*)$', 'm');
  const m = re.exec(body.join('\n'));
  return m ? m[1] : null;
}
function refOf(body, key) {
  const v = fieldOf(body, key);
  if (v === null) return null;
  const m = /\{fileID: (-?\d+)(?:, guid: ([0-9a-f]+), type: (\d+))?\}/.exec(v);
  if (!m) return null;
  return { fileID: m[1], guid: m[2] || null, type: m[3] || null };
}
function listOf(body, key) {
  const out = []; let on = false; let indent = null;
  for (const l of body) {
    if (!on) { const m = new RegExp('^(\\s*)' + key + ':\\s*$').exec(l); if (m) { on = true; indent = m[1]; } continue; }
    const mm = /^(\s*)- \{fileID: (-?\d+)\}/.exec(l);
    if (mm && mm[1].length > indent.length - 1) { out.push(mm[2]); continue; }
    const mc = /^(\s*)- component: \{fileID: (-?\d+)\}/.exec(l);
    if (mc && mc[1].length > indent.length - 1) { out.push(mc[2]); continue; }
    if (/^\s*$/.test(l)) continue;
    break;
  }
  return out;
}

function flatten(file, xk, out, guid, piChain) {
  piChain = piChain || [];
  const docs = splitDocs(file);
  for (const d of docs) {
    if (d.cls === 1001 || d.cls === 1660057539 || d.stripped) continue;
    out.objs.set(X(d.id, xk), { cls: d.cls, body: d.body, srcFile: file, srcGuid: guid, srcId: d.id, xk, piChain });
  }
  for (const d of docs) {
    if (d.cls !== 1001) continue;
    const pid = d.id;
    const src = refOf(d.body, 'm_SourcePrefab');
    if (!src || !src.guid) continue;
    const sub = guidIndex().get(src.guid);
    const subXk = X(pid, xk);
    const outerPI = X(pid, xk);
    out.instances.set(outerPI, { guid: src.guid, file: sub, xk, rawId: pid, subXk });
    if (sub && fs.existsSync(sub)) flatten(sub, subXk, out, src.guid, [outerPI].concat(piChain));
    const text = d.body.join('\n');
    const re = /- target: \{fileID: (-?\d+), guid: ([0-9a-f]+), type: \d+\}\s*\r?\n\s*propertyPath: (.*)\r?\n\s*value: (.*)\r?\n\s*objectReference: \{fileID: (-?\d+)(?:, guid: ([0-9a-f]+), type: (\d+))?\}/g;
    let m;
    while ((m = re.exec(text))) {
      const outerT = X(m[1], subXk);
      if (!out.mods.has(outerT)) out.mods.set(outerT, new Map());
      out.mods.get(outerT).set(m[3].trim(), { value: m[4].trim(), objRef: m[5], objGuid: m[6] || null, owner: outerPI, rawTarget: m[1], ownerGuid: src.guid });
    }
    const tp = refOf(d.body, 'm_TransformParent');
    out.piParent.set(outerPI, tp && tp.fileID !== '0' ? X(tp.fileID, xk) : '0');
    const rmBlock = /m_RemovedGameObjects:([\s\S]*?)\n    m_[A-Za-z]/.exec(text);
    if (rmBlock) for (const rm of rmBlock[1].matchAll(/\{fileID: (-?\d+), guid: ([0-9a-f]+)/g)) out.removed.add(X(rm[1], subXk));
  }
  for (const d of docs) {
    if (!d.stripped) continue;
    const corr = refOf(d.body, 'm_CorrespondingSourceObject');
    const pi = refOf(d.body, 'm_PrefabInstance');
    if (!corr || !pi) continue;
    out.strips.set(X(d.id, xk), X(corr.fileID, X(pi.fileID, xk)));
  }
}

function load(file) {
  const out = { file, objs: new Map(), strips: new Map(), mods: new Map(), piParent: new Map(), instances: new Map(), removed: new Set() };
  flatten(file, '0', out, null, []);
  return out;
}

function deref(S, id) { let n = 0; while (S.strips.has(id) && n++ < 8) id = S.strips.get(id); return id; }
function modOf(S, id, prop) { const m = S.mods.get(id); return m && m.has(prop) ? m.get(prop) : null; }
function val(S, id, prop, fallbackKey) {
  const mo = modOf(S, id, prop); if (mo) return mo.value;
  const o = S.objs.get(id); if (!o) return null;
  return fieldOf(o.body, fallbackKey || prop);
}
function nameOf(S, id) { const mo = modOf(S, id, 'm_Name'); if (mo) return mo.value; const o = S.objs.get(id); return o ? (fieldOf(o.body, 'm_Name') || '?') : '?'; }
function activeOf(S, id) { const mo = modOf(S, id, 'm_IsActive'); if (mo) return mo.value; const o = S.objs.get(id); return o ? fieldOf(o.body, 'm_IsActive') : '?'; }
function componentsOf(S, goId) {
  const o = S.objs.get(goId); if (!o) return [];
  return listOf(o.body, 'm_Component').filter(c => c !== '0').map(c => deref(S, X(c, o.xk)));
}
function childrenOf(S, trId) {
  const o = S.objs.get(trId); if (!o) return [];
  return listOf(o.body, 'm_Children').filter(c => c !== '0').map(c => deref(S, X(c, o.xk)));
}
function goOfComp(S, cid) {
  const o = S.objs.get(cid); if (!o) return null;
  const r = refOf(o.body, 'm_GameObject'); if (!r || r.fileID === '0') return null;
  return deref(S, X(r.fileID, o.xk));
}
function fatherOf(S, trId) {
  const o = S.objs.get(trId); if (!o) return '0';
  const r = refOf(o.body, 'm_Father');
  return (r && r.fileID !== '0') ? deref(S, X(r.fileID, o.xk)) : '0';
}
function childIndex(S) {
  if (S._kids) return S._kids;
  const kids = new Map();
  for (const [id, o] of S.objs) {
    if (o.cls !== 4 && o.cls !== 224) continue;
    const f = effFather(S, id);
    if (f === "0") continue;
    if (!kids.has(f)) kids.set(f, []);
    kids.get(f).push(id);
  }
  S._kids = kids; return kids;
}
function childrenAll(S, trId) {
  const ordered = childrenOf(S, trId);
  const set = new Set(ordered);
  for (const k of (childIndex(S).get(trId) || [])) if (!set.has(k)) { ordered.push(k); set.add(k); }
  return ordered;
}
function transformOf(S, goId) {
  for (const c of componentsOf(S, goId)) { const o = S.objs.get(c); if (o && (o.cls === 4 || o.cls === 224)) return c; }
  return null;
}
function scriptGuidOf(S, cid) {
  const o = S.objs.get(cid); if (!o || o.cls !== 114) return null;
  const mo = modOf(S, cid, 'm_Script'); if (mo && mo.objGuid) return mo.objGuid;
  const r = refOf(o.body, 'm_Script'); return r ? r.guid : null;
}
// effective parent of a transform taking prefab-instance parenting into account
function effFather(S, trId) {
  const f = fatherOf(S, trId);
  if (f !== "0") return f;
  const o = S.objs.get(trId);
  if (!o || !o.piChain) return "0";
  for (const pi of o.piChain) { const p = S.piParent.get(pi); if (p && p !== "0") return deref(S, p); }
  return "0";
}
function pathOf(S, trId) {
  const parts = []; let cur = trId; let n = 0;
  while (cur && cur !== '0' && n++ < 40) {
    const go = goOfComp(S, cur);
    parts.unshift(go ? nameOf(S, go) : '?' + cur);
    cur = effFather(S, cur);
  }
  return parts.join('/');
}

module.exports = { childrenAll, childIndex, load, deref, nameOf, activeOf, componentsOf, childrenOf, goOfComp, fatherOf, effFather,
  transformOf, scriptGuidOf, fieldOf, refOf, listOf, modOf, val, guidIndex, X, splitDocs, pathOf };
