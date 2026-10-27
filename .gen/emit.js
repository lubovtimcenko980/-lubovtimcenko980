'use strict';
// Unity YAML document emitters (Unity 6000.3 serialization shapes, copied off this template).
const T = require('./theme');

const G = {
  Image: 'fe87c0e1cc204ed48ad3b37840f39efc',
  TMP: 'f4688fdb7df04437aeb418b961361dc5',
  Button: '4e29b1a8efbd4b44bb3f3716e73f07ff',
  LoadSceneButton: '557e9bfa96dc47fca5769a35e5db9622',
  ShowPopButton: '10465983d7ef4cf28fbdf12803afc35f',
  SetPhysicsRunButton: '43327b7e6e4e45c2bcce66d6c1ca203a',
  Pop: 'bb9fafdf6b9542d58b040fb24bb4ffcf',
  Panel: '326156d24fae4015911529147d1aae1e',
  fontAssetGuid: '2acf3e88cc944f58b1d7e0543d045427',
};

const HEAD = '%YAML 1.1\n%TAG !u! tag:unity3d.com,2011:\n';
const PREFAB_HEADER = (rootId) => `--- !u!1001 &100100000
PrefabInstance:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_Modification:
    serializedVersion: 3
    m_TransformParent: {fileID: 0}
    m_Modifications: []
    m_RemovedComponents: []
    m_RemovedGameObjects: []
    m_AddedGameObjects: []
    m_AddedComponents: []
  m_SourcePrefab: {fileID: 0}
`;

function v2(v) { return `{x: ${v[0]}, y: ${v[1]}}`; }

function gameObject(id, { name, comps, active = 1, layer = 5 }) {
  return `--- !u!1 &${id}
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
${comps.map(c => `  - component: {fileID: ${c}}`).join('\n')}
  m_Layer: ${layer}
  m_Name: ${name}
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: ${active}
`;
}

function rectTransform(id, { go, children = [], father = 0, aMin = [0, 0], aMax = [1, 1], pos = [0, 0], size = [0, 0], pivot = [0.5, 0.5], scale = [1, 1, 1], rotZ = 0 }) {
  const rot = rotZ === 0 ? '{x: 0, y: 0, z: 0, w: 1}' : (() => {
    const r = rotZ * Math.PI / 360; return `{x: 0, y: 0, z: ${+Math.sin(r).toFixed(7)}, w: ${+Math.cos(r).toFixed(7)}}`;
  })();
  return `--- !u!224 &${id}
RectTransform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: ${go}}
  m_LocalRotation: ${rot}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: ${scale[0]}, y: ${scale[1]}, z: ${scale[2]}}
  m_ConstrainProportionsScale: 0
  m_Children:${children.length ? '\n' + children.map(c => `  - {fileID: ${c}}`).join('\n') : ' []'}
  m_Father: {fileID: ${father}}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: ${rotZ}}
  m_AnchorMin: ${v2(aMin)}
  m_AnchorMax: ${v2(aMax)}
  m_AnchoredPosition: ${v2(pos)}
  m_SizeDelta: ${v2(size)}
  m_Pivot: ${v2(pivot)}
`;
}

function transform(id, { go, children = [], father = 0 }) {
  return `--- !u!4 &${id}
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: ${go}}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:${children.length ? '\n' + children.map(c => `  - {fileID: ${c}}`).join('\n') : ' []'}
  m_Father: {fileID: ${father}}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
`;
}

function canvasRenderer(id, go) {
  return `--- !u!222 &${id}
CanvasRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: ${go}}
  m_CullTransparentMesh: 1
`;
}

function canvasGroup(id, { go, alpha = 1, interactable = 1, blocksRaycasts = 1 }) {
  return `--- !u!225 &${id}
CanvasGroup:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: ${go}}
  m_Enabled: 1
  m_Alpha: ${alpha}
  m_Interactable: ${interactable}
  m_BlocksRaycasts: ${blocksRaycasts}
  m_IgnoreParentGroups: 0
`;
}

// sprite: null -> no sprite (solid tinted quad); {guid} -> project sprite; {builtin: 10905} -> engine plate
function image(id, { go, color = '{r: 1, g: 1, b: 1, a: 1}', raycast = 0, sprite = null, type = 0, ppu = 1, preserveAspect = 0, fillCenter = 1 }) {
  let spr = '{fileID: 0}';
  if (sprite && sprite.guid) spr = `{fileID: 21300000, guid: ${sprite.guid}, type: 3}`;
  else if (sprite && sprite.builtin) spr = `{fileID: ${sprite.builtin}, guid: 0000000000000000f000000000000000, type: 0}`;
  return `--- !u!114 &${id}
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: ${go}}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: ${G.Image}, type: 3}
  m_Name:
  m_EditorClassIdentifier:
  m_Material: {fileID: 0}
  m_Color: ${color}
  m_RaycastTarget: ${raycast}
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_Sprite: ${spr}
  m_Type: ${type}
  m_PreserveAspect: ${preserveAspect}
  m_FillCenter: ${fillCenter}
  m_FillMethod: 4
  m_FillAmount: 1
  m_FillClockwise: 1
  m_FillOrigin: 0
  m_UseSpriteMesh: 0
  m_PixelsPerUnitMultiplier: ${ppu}
`;
}

// hAlign: 1 left, 2 centre, 4 right ; vAlign: 256 top, 512 middle, 1024 bottom
function tmpText(id, { go, text, size = 40, min = 24, max = 72, colorHex = T.HEX.textPrimary, alpha = 1, hAlign = 2, vAlign = 512, raycast = 0, tracking = 0, style = 0, margin = [0, 0, 0, 0] }) {
  if (/[\r\n]/.test(text)) throw new Error('newline in m_text is not serialisable — set multi-line labels from Start()');
  return `--- !u!114 &${id}
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: ${go}}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: ${G.TMP}, type: 3}
  m_Name:
  m_EditorClassIdentifier:
  m_Material: {fileID: 0}
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_RaycastTarget: ${raycast}
  m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
  m_Maskable: 1
  m_OnCullStateChanged:
    m_PersistentCalls:
      m_Calls: []
  m_text: ${text}
  m_isRightToLeft: 0
  m_fontAsset: {fileID: 11400000, guid: ${G.fontAssetGuid}, type: 2}
  m_sharedMaterial: {fileID: -3226640968860151095, guid: ${G.fontAssetGuid}, type: 2}
  m_fontSharedMaterials: []
  m_fontMaterial: {fileID: 0}
  m_fontMaterials: []
  m_fontColor32:
    serializedVersion: 2
    rgba: ${T.col32(colorHex, alpha)}
  m_fontColor: ${T.col(colorHex, alpha)}
  m_enableVertexGradient: 0
  m_colorMode: 3
  m_fontColorGradient:
    topLeft: {r: 1, g: 1, b: 1, a: 1}
    topRight: {r: 1, g: 1, b: 1, a: 1}
    bottomLeft: {r: 1, g: 1, b: 1, a: 1}
    bottomRight: {r: 1, g: 1, b: 1, a: 1}
  m_fontColorGradientPreset: {fileID: 0}
  m_spriteAsset: {fileID: 0}
  m_tintAllSprites: 0
  m_StyleSheet: {fileID: 0}
  m_TextStyleHashCode: -1183493901
  m_overrideHtmlColors: 0
  m_faceColor:
    serializedVersion: 2
    rgba: 4294967295
  m_fontSize: ${size}
  m_fontSizeBase: ${size}
  m_fontWeight: 400
  m_enableAutoSizing: 1
  m_fontSizeMin: ${min}
  m_fontSizeMax: ${max}
  m_fontStyle: ${style}
  m_HorizontalAlignment: ${hAlign}
  m_VerticalAlignment: ${vAlign}
  m_textAlignment: 65535
  m_characterSpacing: ${tracking}
  m_characterHorizontalScale: 1
  m_wordSpacing: 0
  m_lineSpacing: 0
  m_lineSpacingMax: 0
  m_paragraphSpacing: 0
  m_charWidthMaxAdj: 0
  m_TextWrappingMode: 0
  m_wordWrappingRatios: 0.4
  m_overflowMode: 0
  m_linkedTextComponent: {fileID: 0}
  parentLinkedComponent: {fileID: 0}
  m_enableKerning: 1
  m_ActiveFontFeatures: 6e72656b
  m_enableExtraPadding: 0
  checkPaddingRequired: 0
  m_isRichText: 1
  m_EmojiFallbackSupport: 1
  m_parseCtrlCharacters: 1
  m_isOrthographic: 1
  m_isCullingEnabled: 0
  m_horizontalMapping: 0
  m_verticalMapping: 0
  m_uvLineOffset: 0
  m_geometrySortingOrder: 0
  m_IsTextObjectScaleStatic: 0
  m_VertexBufferAutoSizeReduction: 0
  m_useMaxVisibleDescender: 1
  m_pageToDisplay: 1
  m_margin: {x: ${margin[0]}, y: ${margin[1]}, z: ${margin[2]}, w: ${margin[3]}}
  m_isUsingLegacyAnimationComponent: 0
  m_isVolumetricText: 0
  m_hasFontAssetChanged: 0
  m_baseMaterial: {fileID: 0}
  m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
`;
}

function button(id, { go, target = 0, normal, highlighted, pressed, disabled }) {
  return `--- !u!114 &${id}
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: ${go}}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: ${G.Button}, type: 3}
  m_Name:
  m_EditorClassIdentifier:
  m_Navigation:
    m_Mode: 3
    m_WrapAround: 0
    m_SelectOnUp: {fileID: 0}
    m_SelectOnDown: {fileID: 0}
    m_SelectOnLeft: {fileID: 0}
    m_SelectOnRight: {fileID: 0}
  m_Transition: 1
  m_Colors:
    m_NormalColor: ${normal || '{r: 1, g: 1, b: 1, a: 1}'}
    m_HighlightedColor: ${highlighted || '{r: 1, g: 1, b: 1, a: 1}'}
    m_PressedColor: ${pressed || '{r: 0.8, g: 0.8, b: 0.8, a: 1}'}
    m_SelectedColor: ${highlighted || '{r: 1, g: 1, b: 1, a: 1}'}
    m_DisabledColor: ${disabled || '{r: 0.6, g: 0.6, b: 0.6, a: 0.5}'}
    m_ColorMultiplier: 1
    m_FadeDuration: 0.1
  m_SpriteState:
    m_HighlightedSprite: {fileID: 0}
    m_PressedSprite: {fileID: 0}
    m_SelectedSprite: {fileID: 0}
    m_DisabledSprite: {fileID: 0}
  m_AnimationTriggers:
    m_NormalTrigger: Normal
    m_HighlightedTrigger: Highlighted
    m_PressedTrigger: Pressed
    m_SelectedTrigger: Selected
    m_DisabledTrigger: Disabled
  m_Interactable: 1
  m_TargetGraphic: {fileID: ${target}}
  m_OnClick:
    m_PersistentCalls:
      m_Calls: []
`;
}

// generic MonoBehaviour; fields is an array of raw YAML lines (already indented with 2 spaces)
function mono(id, { go, guid, className, fields = [] }) {
  return `--- !u!114 &${id}
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: ${go}}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: ${guid}, type: 3}
  m_Name:
  m_EditorClassIdentifier: ${className ? 'NewAssembly::' + className : ''}
${fields.map(f => '  ' + f).join('\n')}${fields.length ? '\n' : ''}`;
}

function stripped(id, cls, { corr, guid, instance }) {
  const TYPE = { 1: 'GameObject', 4: 'Transform', 224: 'RectTransform', 114: 'MonoBehaviour', 222: 'CanvasRenderer', 223: 'Canvas' };
  return `--- !u!${cls} &${id} stripped
${TYPE[cls]}:
  m_CorrespondingSourceObject: {fileID: ${corr}, guid: ${guid}, type: 3}
  m_PrefabInstance: {fileID: ${instance}}
  m_PrefabAsset: {fileID: 0}
`;
}

function prefabAssetTail() {
  return '';
}

function metaScript(guid) {
  return `fileFormatVersion: 2
guid: ${guid}
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData:
  assetBundleName:
  assetBundleVariant:
`;
}

function metaPrefab(guid) {
  return `fileFormatVersion: 2
guid: ${guid}
PrefabImporter:
  externalObjects: {}
  userData:
  assetBundleName:
  assetBundleVariant:
`;
}

function metaSprite(guid, border) {
  const b = border || [0, 0, 0, 0];
  return `fileFormatVersion: 2
guid: ${guid}
TextureImporter:
  internalIDToNameTable: []
  externalObjects: {}
  serializedVersion: 13
  mipmaps:
    mipMapMode: 0
    enableMipMap: 0
    sRGBTexture: 1
    linearTexture: 0
    fadeOut: 0
    borderMipMap: 0
    mipMapsPreserveCoverage: 0
    alphaTestReferenceValue: 0.5
    mipMapFadeDistanceStart: 1
    mipMapFadeDistanceEnd: 3
  bumpmap:
    convertToNormalMap: 0
    externalNormalMap: 0
    heightScale: 0.25
    normalMapFilter: 0
    flipGreenChannel: 0
  isReadable: 0
  streamingMipmaps: 0
  streamingMipmapsPriority: 0
  vTOnly: 0
  ignoreMipmapLimit: 0
  grayScaleToAlpha: 0
  generateCubemap: 6
  cubemapConvolution: 0
  seamlessCubemap: 0
  textureFormat: 1
  maxTextureSize: 2048
  textureSettings:
    serializedVersion: 2
    filterMode: 1
    aniso: 1
    mipBias: 0
    wrapU: 1
    wrapV: 1
    wrapW: 1
  nPOTScale: 0
  lightmap: 0
  compressionQuality: 50
  spriteMode: 1
  spriteExtrude: 1
  spriteMeshType: 0
  alignment: 0
  spritePivot: {x: 0.5, y: 0.5}
  spritePixelsToUnits: 100
  spriteBorder: {x: ${b[0]}, y: ${b[1]}, z: ${b[2]}, w: ${b[3]}}
  spriteGenerateFallbackPhysicsShape: 0
  alphaUsage: 1
  alphaIsTransparency: 1
  spriteTessellationDetail: -1
  textureType: 8
  textureShape: 1
  singleChannelComponent: 0
  flipbookRows: 1
  flipbookColumns: 1
  maxTextureSizeSet: 0
  compressionQualitySet: 0
  textureFormatSet: 0
  ignorePngGamma: 0
  applyGammaDecoding: 0
  swizzle: 50462976
  cookieLightType: 0
  platformSettings:
  - serializedVersion: 4
    buildTarget: DefaultTexturePlatform
    maxTextureSize: 2048
    resizeAlgorithm: 0
    textureFormat: -1
    textureCompression: 1
    compressionQuality: 50
    crunchedCompression: 0
    allowsAlphaSplitting: 0
    overridden: 0
    ignorePlatformSupport: 0
    androidETC2FallbackOverride: 0
    forceMaximumCompressionQuality_BC6H_BC7: 0
  spriteSheet:
    serializedVersion: 2
    sprites: []
    outline: []
    physicsShape: []
    bones: []
    spriteID:
    internalID: 0
    vertices: []
    indices:
    edges: []
    weights: []
    secondaryTextures: []
    spriteCustomMetadata:
      entries: []
    nameFileIdTable: {}
  mipmapLimitGroupName:
  pSDRemoveMatte: 0
  userData:
  assetBundleName:
  assetBundleVariant:
`;
}

module.exports = { G, HEAD, v2, gameObject, rectTransform, transform, canvasRenderer, canvasGroup,
  image, tmpText, button, mono, stripped, metaScript, metaPrefab, metaSprite, prefabAssetTail };
