'use strict';
const k = require('./yamlkit');
const path = process.argv[2];
const doc = k.parse(path);
const map = k.byId(doc);

const CLS = {1:'GameObject',4:'Transform',224:'RectTransform',222:'CanvasRenderer',114:'MonoBehaviour',
 223:'Canvas',225:'CanvasGroup',212:'SpriteRenderer',20:'Camera',108:'Light',82:'AudioSource',
 1001:'PrefabInstance',1002:'?',1660057539:'SceneRoots',114000:'?'};

function nameOf(go){ return k.getField(go,'m_Name'); }
function compsOf(go){
  const out=[]; let inC=false;
  for(const l of go.body){
    if(/^  m_Component:/.test(l)){inC=true;continue;}
    if(inC){ const m=/component: \{fileID: (\d+)\}/.exec(l); if(m) out.push(m[1]); else if(/^  [A-Za-z_]/.test(l)) break; }
  }
  return out;
}
function childrenOf(tr){
  const out=[]; let inC=false;
  for(const l of tr.body){
    if(/^  m_Children:/.test(l)){inC=true;continue;}
    if(inC){ const m=/- \{fileID: (\d+)\}/.exec(l); if(m) out.push(m[1]); else if(/^  [A-Za-z_]/.test(l)) break; }
  }
  return out;
}

// build: transform id -> gameObject
const transforms = new Map(); // trId -> {tr, go}
for(const d of doc.docs){
  if(d.cls===4||d.cls===224){ const goId=(/m_GameObject: \{fileID: (\d+)\}/.exec(d.body.join('\n'))||[])[1];
    transforms.set(d.id,{tr:d, go: map.get(goId)}); }
}
// roots: transforms with m_Father fileID 0
const roots=[];
for(const [id,v] of transforms){ const f=(/m_Father: \{fileID: (\d+)\}/.exec(v.tr.body.join('\n'))||[])[1];
  if(f==='0') roots.push(id); }

const SCRIPTGUID = {};
function compDesc(cid){
  const c=map.get(cid); if(!c) return `?${cid}`;
  if(c.cls===114){
    const g=(/m_Script: \{fileID: \d+, guid: ([0-9a-f]+)/.exec(c.body.join('\n'))||[])[1];
    const eci=(/m_EditorClassIdentifier: (.*)$/m.exec(c.body.join('\n'))||[])[1]||'';
    return `MB(${cid}) guid=${g} ${eci.trim()}`;
  }
  return `${CLS[c.cls]||c.cls}(${cid})`;
}

function rect(tr){
  const b=tr.body.join('\n');
  const g=(re)=>{const m=re.exec(b);return m?m[1]:'';};
  if(tr.cls!==224) return '';
  return ` aMin{${g(/m_AnchorMin: \{x: ([^,]+), y: ([^}]+)\}/)||''},${(/m_AnchorMin: \{x: [^,]+, y: ([^}]+)\}/.exec(b)||[])[1]}} aMax{${(/m_AnchorMax: \{x: ([^,]+)/.exec(b)||[])[1]},${(/m_AnchorMax: \{x: [^,]+, y: ([^}]+)\}/.exec(b)||[])[1]}} pos{${(/m_AnchoredPosition: \{x: ([^,]+)/.exec(b)||[])[1]},${(/m_AnchoredPosition: \{x: [^,]+, y: ([^}]+)\}/.exec(b)||[])[1]}} size{${(/m_SizeDelta: \{x: ([^,]+)/.exec(b)||[])[1]},${(/m_SizeDelta: \{x: [^,]+, y: ([^}]+)\}/.exec(b)||[])[1]}}`;
}

function walk(trId, depth){
  const v=transforms.get(trId); if(!v) return;
  const go=v.go; if(!go) return;
  const active=k.getField(go,'m_IsActive');
  const comps=compsOf(go).map(compDesc).join(' ');
  const txt=[];
  for(const cid of compsOf(go)){ const c=map.get(cid); if(!c) continue;
    const b=c.body.join('\n');
    const t=/m_text: (.*)/.exec(b); if(t) txt.push('text='+t[1].slice(0,50));
    const s=/m_Sprite: \{fileID: (\d+), guid: ([0-9a-f]+)/.exec(b); if(s) txt.push('sprite='+s[2].slice(0,8));
    else if(/m_Sprite: \{fileID: 0\}/.test(b)) txt.push('sprite=NONE');
  }
  console.log('  '.repeat(depth)+`[${go.id}/tr${trId}] ${nameOf(go)} act=${active} ${comps}${rect(v.tr)} ${txt.join(' ')}`);
  for(const c of childrenOf(v.tr)) walk(c, depth+1);
}
for(const r of roots) walk(r,0);

// prefab instances
console.log('\n=== PrefabInstances ===');
for(const d of doc.docs){ if(d.cls!==1001) continue;
  const src=(/m_SourcePrefab: \{fileID: \d+, guid: ([0-9a-f]+)/.exec(d.body.join('\n'))||[])[1];
  const parent=(/m_TransformParent: \{fileID: (\d+)\}/.exec(d.body.join('\n'))||[])[1];
  const nameMod=(/propertyPath: m_Name\n\s+value: (.*)/.exec(d.body.join('\n'))||[])[1];
  console.log(`PI &${d.id} src=${src} parent=tr${parent} name=${nameMod||''} mods=${(d.body.join('\n').match(/- target:/g)||[]).length}`);
}
