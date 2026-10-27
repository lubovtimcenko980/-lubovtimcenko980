'use strict';
const H = require('./hier');
const file = process.argv[2];
const S = H.load(file);

const CLS = { 1: 'GameObject', 4: 'Transform', 224: 'RectTransform', 222: 'CanvasRenderer', 114: 'MB',
  223: 'Canvas', 225: 'CanvasGroup', 212: 'SpriteRenderer', 20: 'Camera', 108: 'Light', 82: 'AudioSource',
  114: 'MB', 95: 'Animator', 65: 'BoxCollider', 61: 'BoxCollider2D', 50: 'Rigidbody2D' };

// script guid -> file name
const g2p = H.guidIndex();
function scriptName(guid) {
  const p = g2p.get(guid);
  return p ? p.split(/[\\/]/).pop().replace(/\.cs$/, '') : 'guid:' + guid.slice(0, 8);
}

function rectStr(S, trId) {
  const o = S.objs.get(trId); if (!o || o.cls !== 224) return '';
  const g = (p, k) => { const m = H.modOf(S, trId, p); if (m) return m.value; const f = H.fieldOf(o.body, k);
    return f; };
  const pair = (base) => {
    const mx = H.modOf(S, trId, base + '.x'), my = H.modOf(S, trId, base + '.y');
    const f = H.fieldOf(o.body, base);
    let x = '', y = '';
    if (f) { const m = /\{x: ([^,]+), y: ([^,}]+)/.exec(f); if (m) { x = m[1]; y = m[2]; } }
    if (mx) x = mx.value; if (my) y = my.value;
    return `${(+x).toFixed(0)},${(+y).toFixed(0)}`;
  };
  const pairf = (base) => {
    const mx = H.modOf(S, trId, base + '.x'), my = H.modOf(S, trId, base + '.y');
    const f = H.fieldOf(o.body, base);
    let x = '', y = '';
    if (f) { const m = /\{x: ([^,]+), y: ([^,}]+)/.exec(f); if (m) { x = m[1]; y = m[2]; } }
    if (mx) x = mx.value; if (my) y = my.value;
    return `${(+x).toFixed(3)},${(+y).toFixed(3)}`;
  };
  return ` aMin[${pairf('m_AnchorMin')}] aMax[${pairf('m_AnchorMax')}] piv[${pairf('m_Pivot')}] pos[${pair('m_AnchoredPosition')}] size[${pair('m_SizeDelta')}]`;
}

function compInfo(S, cid) {
  const o = S.objs.get(cid); if (!o) return `??${cid}`;
  if (o.cls === 114) {
    const gu = H.scriptGuidOf(S, cid);
    let extra = '';
    const b = o.body.join('\n');
    const t = H.modOf(S, cid, 'm_text') || (/^  m_text: (.*)$/m.exec(b) ? { value: /^  m_text: (.*)$/m.exec(b)[1] } : null);
    if (t) extra += ` text=${JSON.stringify(String(t.value).slice(0, 40))}`;
    const sp = H.modOf(S, cid, 'm_Sprite');
    if (sp) extra += ` sprite=${sp.objGuid ? sp.objGuid.slice(0, 8) : 'NONE'}`;
    else { const r = H.refOf(o.body, 'm_Sprite'); if (r) extra += ` sprite=${r.guid ? r.guid.slice(0, 8) : (r.fileID === '0' ? 'NONE' : r.fileID)}`; }
    const col = H.modOf(S, cid, 'm_Color.a'); if (col) extra += ` a=${col.value}`;
    const rt = H.modOf(S, cid, 'm_RaycastTarget'); if (rt) extra += ` ray=${rt.value}`;
    else { const f = H.fieldOf(o.body, 'm_RaycastTarget'); if (f !== null) extra += ` ray=${f}`; }
    const fs0 = H.modOf(S, cid, 'm_fontSize'); if (fs0) extra += ` fs=${fs0.value}`;
    return `${scriptName(gu || '')}(${cid})${extra}`;
  }
  return `${CLS[o.cls] || o.cls}(${cid})`;
}

const printed = new Set();
function walk(trId, depth) {
  if (printed.has(trId)) return; printed.add(trId);
  const go = H.goOfComp(S, trId); if (!go) return;
  const comps = H.componentsOf(S, go).map(c => compInfo(S, c)).join(' ');
  console.log('  '.repeat(depth) + `[go${go} tr${trId}] ${H.nameOf(S, go)} act=${H.activeOf(S, go)} ${comps}${rectStr(S, trId)}`);
  for (const c of H.childrenAll(S, trId)) walk(c, depth + 1);
}

// roots = transforms whose effective father is 0
const roots = [];
for (const [id, o] of S.objs) if (o.cls === 4 || o.cls === 224) { if (H.effFather(S, id) === '0') roots.push(id); }
for (const r of roots) walk(r, 0);

// unresolved modifications
let miss = 0, total = 0;
for (const [t, m] of S.mods) { for (const _ of m) { total++; if (!S.objs.has(t)) miss++; } }
console.error(`\n[resolver] objects=${S.objs.size} strips=${S.strips.size} mods=${total} unresolvedTargets=${miss} roots=${roots.length}`);
