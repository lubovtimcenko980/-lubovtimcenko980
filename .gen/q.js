'use strict';
// Query helper: node q.js <scene> <mode> [arg]
//  find <substr>      -> print path + ids for every GameObject whose name matches
//  show <goId>        -> print object detail (components, rect, mods)
//  tree <trId> [d]    -> subtree from a transform
//  roots              -> list roots
const H = require('./hier');
const file = process.argv[2];
const mode = process.argv[3];
const arg = process.argv[4];
const S = H.load(file);
const g2p = H.guidIndex();
const sn = g => { const p = g2p.get(g || ''); return p ? p.split(/[\\/]/).pop().replace(/\.(cs|prefab|asset|png)$/, '') : 'guid:' + String(g).slice(0, 8); };
const CLS = { 1: 'GameObject', 4: 'Transform', 224: 'RectTransform', 222: 'CanvasRenderer', 223: 'Canvas', 225: 'CanvasGroup', 212: 'SpriteRenderer', 20: 'Camera', 114: 'MB' };

function rectOf(trId) {
  const o = S.objs.get(trId); if (!o) return {};
  const get2 = (base) => {
    const f = H.fieldOf(o.body, base); let x = 0, y = 0;
    if (f) { const m = /\{x: ([^,]+), y: ([^,}]+)/.exec(f); if (m) { x = +m[1]; y = +m[2]; } }
    const mx = H.modOf(S, trId, base + '.x'), my = H.modOf(S, trId, base + '.y');
    if (mx) x = +mx.value; if (my) y = +my.value;
    return { x, y };
  };
  return { aMin: get2('m_AnchorMin'), aMax: get2('m_AnchorMax'), piv: get2('m_Pivot'), pos: get2('m_AnchoredPosition'), size: get2('m_SizeDelta'), scale: get2('m_LocalScale') };
}
function compLine(cid) {
  const o = S.objs.get(cid); if (!o) return `??${cid}`;
  if (o.cls !== 114) return `${CLS[o.cls] || o.cls}(${cid})`;
  return `${sn(H.scriptGuidOf(S, cid))}(${cid})`;
}
function detail(goId) {
  console.log(`\n### go${goId} "${H.nameOf(S, goId)}" active=${H.activeOf(S, goId)}`);
  console.log('    path: ' + H.pathOf(S, H.transformOf(S, goId)));
  for (const c of H.componentsOf(S, goId)) {
    const o = S.objs.get(c); if (!o) { console.log(`    [missing ${c}]`); continue; }
    console.log(`    - ${compLine(c)}  srcGuid=${String(o.srcGuid).slice(0, 8)} srcId=${o.srcId} xk=${o.xk}`);
    if (o.cls === 224) { const r = rectOf(c); console.log(`        rect aMin(${r.aMin.x},${r.aMin.y}) aMax(${r.aMax.x},${r.aMax.y}) piv(${r.piv.x},${r.piv.y}) pos(${r.pos.x},${r.pos.y}) size(${r.size.x},${r.size.y})`); }
    const m = S.mods.get(c);
    if (m) for (const [k, v] of m) console.log(`        MOD ${k} = ${v.value}${v.objGuid ? ' guid:' + v.objGuid.slice(0, 8) : ''}`);
    if (o.cls === 114) {
      for (const l of o.body) {
        if (/^  (m_text|m_fontSize|m_Sprite|m_Color|m_RaycastTarget|m_Type|m_PixelsPerUnitMultiplier|m_fontColor|LoadSceneId|PopToShowIndex|IsLoadCurrentScene|IsHideAllPops|IsShowLastPop|IsPhysicsRunOnClick|m_enableWordWrapping|m_TextWrappingMode|m_enableAutoSizing|m_fontSizeMin|m_fontSizeMax|m_IsTutorialEnabled|Is[A-Za-z]+|Content|ContentHeaderText|ContentMainText|ContentAdditionalText|ContentImage|Panels|Pops|MoneyCountText|AnimationSlider|FirstAnimationTime|m_OnClick|m_TargetGraphic|m_Transition|m_Colors|m_Navigation|m_Interactable|m_Material):/.test(l)) console.log('        ' + l.trim().slice(0, 160));
      }
    }
  }
  const mg = S.mods.get(goId);
  if (mg) for (const [k, v] of mg) console.log(`    GOMOD ${k} = ${v.value}`);
}

if (mode === 'find') {
  for (const [id, o] of S.objs) {
    if (o.cls !== 1) continue;
    const n = H.nameOf(S, id);
    if (n && n.toLowerCase().includes(arg.toLowerCase())) {
      const tr = H.transformOf(S, id);
      console.log(`go${id} tr${tr} act=${H.activeOf(S, id)}  ${H.pathOf(S, tr)}`);
    }
  }
} else if (mode === 'show') {
  detail(arg);
} else if (mode === 'showdeep') {
  const seen = new Set();
  const rec = (tr) => { const go = H.goOfComp(S, tr); if (!go || seen.has(go)) return; seen.add(go); detail(go); for (const c of H.childrenAll(S, tr)) rec(c); };
  rec(arg);
} else if (mode === 'tree') {
  const maxd = arg2 => arg2;
  const lim = process.argv[5] ? +process.argv[5] : 99;
  const rec = (tr, d) => {
    if (d > lim) return;
    const go = H.goOfComp(S, tr); if (!go) return;
    const r = rectOf(tr);
    console.log('  '.repeat(d) + `[go${go} tr${tr}] ${H.nameOf(S, go)} act=${H.activeOf(S, go)} {${H.componentsOf(S, go).map(compLine).join(' ')}} pos(${r.pos.x},${r.pos.y}) size(${r.size.x},${r.size.y}) aMin(${r.aMin.x},${r.aMin.y}) aMax(${r.aMax.x},${r.aMax.y})`);
    for (const c of H.childrenAll(S, tr)) rec(c, d + 1);
  };
  rec(arg, 0);
} else if (mode === 'roots') {
  for (const [id, o] of S.objs) if ((o.cls === 4 || o.cls === 224) && H.effFather(S, id) === '0') {
    const go = H.goOfComp(S, id); console.log(`tr${id} go${go} ${go ? H.nameOf(S, go) : '?'}`);
  }
} else if (mode === 'unres') {
  let n = 0;
  for (const [t, m] of S.mods) if (!S.objs.has(t)) { n++; if (n < 30) console.log(`unresolved target ${t} props=${[...m.keys()].join(',')} ownerGuid=${[...m.values()][0].ownerGuid.slice(0,8)} raw=${[...m.values()][0].rawTarget}`); }
  console.log('total unresolved targets', n);
}
