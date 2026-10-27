'use strict';
// Declarative tree -> Unity prefab/scene documents. Two passes so a serialized field can
// point at a sibling that is built later.
const E = require('./emit');

function makeAlloc(start) {
  let n = start;
  return () => String(n++);
}

// node: { key, name, active, rect:{aMin,aMax,pos,size,pivot,scale,rotZ}, img, tmp, btn, group,
//         mono:[{guid,className,fields}], children:[] }
// fields may be an array of strings or a function(refs) => string[]
function build(node, fatherId, alloc, out, refs) {
  const goId = alloc();
  const rtId = alloc();
  const comps = [rtId];
  const entry = { go: goId, rt: rtId };

  let crId = null;
  if (node.img || node.tmp) { crId = alloc(); comps.push(crId); entry.cr = crId; }
  let imgId = null, tmpId = null, btnId = null, grpId = null;
  if (node.img) { imgId = alloc(); comps.push(imgId); entry.image = imgId; }
  if (node.tmp) { tmpId = alloc(); comps.push(tmpId); entry.tmp = tmpId; }
  if (node.btn) { btnId = alloc(); comps.push(btnId); entry.button = btnId; }
  if (node.group) { grpId = alloc(); comps.push(grpId); entry.group = grpId; }
  const monoIds = (node.mono || []).map(() => alloc());
  for (const m of monoIds) comps.push(m);
  entry.monos = monoIds;
  if (node.key) refs[node.key] = entry;

  const childEntries = (node.children || []).map(c => build(c, rtId, alloc, out, refs));
  const childRts = childEntries.map(c => c.rt);

  out.push(E.gameObject(goId, { name: node.name, comps, active: node.active === undefined ? 1 : node.active, layer: node.layer === undefined ? 5 : node.layer }));
  const r = node.rect || {};
  out.push(E.rectTransform(rtId, { go: goId, children: childRts, father: fatherId, ...r }));
  if (crId) out.push(E.canvasRenderer(crId, goId));
  if (imgId) out.push(E.image(imgId, { go: goId, ...node.img }));
  if (tmpId) out.push(E.tmpText(tmpId, { go: goId, ...node.tmp }));
  if (btnId) out.push(() => E.button(btnId, { go: goId, target: node.btn.target ? (refs[node.btn.target] || {}).image || 0 : (imgId || 0), ...node.btn }));
  if (grpId) out.push(E.canvasGroup(grpId, { go: goId, ...node.group }));
  (node.mono || []).forEach((m, i) => {
    out.push(() => E.mono(monoIds[i], { go: goId, guid: m.guid, className: m.className, fields: typeof m.fields === 'function' ? m.fields(refs) : (m.fields || []) }));
  });
  return entry;
}

function flush(out) {
  return out.map(x => (typeof x === 'function' ? x() : x)).join('');
}

// ---- helpers for rect maths (panel space is 1242 x 2688, origin at centre) ----
const PANEL_W = 1242, PANEL_H = 2688;
// centred element, y measured from the panel BOTTOM
const fromBottom = (yB, w, h, x) => ({ aMin: [0.5, 0], aMax: [0.5, 0], pivot: [0.5, 0.5], pos: [x || 0, yB], size: [w, h] });
// centred element, y measured from the panel TOP
const fromTop = (yT, w, h, x) => ({ aMin: [0.5, 1], aMax: [0.5, 1], pivot: [0.5, 0.5], pos: [x || 0, -yT], size: [w, h] });
// full stretch
const stretch = (inset) => ({ aMin: [0, 0], aMax: [1, 1], pivot: [0.5, 0.5], pos: [0, 0], size: [-(2 * (inset || 0)), -(2 * (inset || 0))] });
// vertical band pinned to both edges: constant gaps on any screen shape
const band = (bottomGap, topGap, w) => ({ aMin: [0.5, 0], aMax: [0.5, 1], pivot: [0.5, 0.5], pos: [0, (bottomGap - topGap) / 2], size: [w, -(bottomGap + topGap)] });

module.exports = { build, flush, makeAlloc, PANEL_W, PANEL_H, fromBottom, fromTop, stretch, band };
