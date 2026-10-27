'use strict';
// node inspect.js <scene> <trId> [depth]  -> compact subtree with graphic state
const H = require('./hier');
const S = H.load(process.argv[2]);
const g2p = H.guidIndex();
const sn = g => { const p = g2p.get(g || ''); return p ? p.split(/[\\/]/).pop().replace(/\.cs$/, '') : 'g:' + String(g).slice(0, 8); };
const KNOWN = {
  'fe87c0e1cc204ed48ad3b37840f39efc': 'Image',
  'f4688fdb7b17482baa9f6d78eb0a3b5c': 'TMPUGUI',
  '4e29b1a8ea4f3ad4dbbf4f0ae7a0c1b8': 'Button',
};
function cname(S, cid) {
  const o = S.objs.get(cid); if (!o) return '??';
  if (o.cls === 224) return 'RT'; if (o.cls === 4) return 'TR'; if (o.cls === 222) return 'CR';
  if (o.cls === 223) return 'Canvas'; if (o.cls === 1) return 'GO';
  if (o.cls === 114) { const g = H.scriptGuidOf(S, cid); return KNOWN[g] || sn(g); }
  return String(o.cls);
}
function get(S, cid, prop, raw) {
  const m = H.modOf(S, cid, prop); if (m) return m.value;
  const o = S.objs.get(cid); if (!o) return null;
  return H.fieldOf(o.body, raw || prop);
}
function spriteOf(S, cid) {
  const m = H.modOf(S, cid, 'm_Sprite');
  if (m) return m.objGuid ? m.objGuid.slice(0, 8) : 'NONE';
  const o = S.objs.get(cid); const r = H.refOf(o.body, 'm_Sprite');
  if (!r) return null;
  if (r.fileID === '0') return 'NONE';
  return (r.guid || 'builtin') + ':' + r.fileID;
}
const lim = process.argv[4] ? +process.argv[4] : 99;
const seen = new Set();
function rec(tr, d) {
  if (d > lim || seen.has(tr)) return; seen.add(tr);
  const go = H.goOfComp(S, tr); if (!go) return;
  const bits = [];
  for (const c of H.componentsOf(S, go)) {
    const o = S.objs.get(c); if (!o) { bits.push('MISSING'); continue; }
    const n = cname(S, c);
    if (n === 'Image') {
      bits.push(`Image(${c}) spr=${spriteOf(S, c)} a=${get(S, c, 'm_Color.a') || (/(m_Color: \{[^}]*a: ([^}]+)\})/.exec(o.body.join('\n')) || [])[2]} ray=${get(S, c, 'm_RaycastTarget')} type=${get(S, c, 'm_Type')} ppu=${get(S, c, 'm_PixelsPerUnitMultiplier')}`);
    } else if (n === 'TMPUGUI') {
      bits.push(`TMP(${c}) text=${JSON.stringify(String(get(S, c, 'm_text') || '').slice(0, 30))} fs=${get(S, c, 'm_fontSize')} ray=${get(S, c, 'm_RaycastTarget')}`);
    } else if (n === 'Button') {
      bits.push(`Button(${c})`);
    } else if (n !== 'RT' && n !== 'TR' && n !== 'CR') bits.push(`${n}(${c})`);
  }
  console.log('  '.repeat(d) + `${H.nameOf(S, go)} [go${go} tr${tr}] act=${H.activeOf(S, go)} ${bits.join(' | ')}`);
  for (const c of H.childrenAll(S, tr)) rec(c, d + 1);
}
rec(process.argv[3], 0);
