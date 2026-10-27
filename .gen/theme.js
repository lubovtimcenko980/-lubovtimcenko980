'use strict';
// Palette + stable guid allocation for SkylineBlockRush.
const fs = require('fs');
const path = require('path');
const crypto = require('crypto');

const ROOT = path.resolve(__dirname, '..');

// ---------- palette (SPACE_COSMOS with the brief's accents) ----------
const HEX = {
  deep: '17233C',
  deepest: '0A1326',
  surface: '263A5E',
  raised: '1B2B4B',
  primary: '2F80ED',
  secondary: '56CCF2',
  accent: 'F2C94C',
  textPrimary: 'F7FAFF',
  textSecondary: 'A8C4EA',
  shadow: '050B18',
  trim: '3E5C8A',
};
function rgb(hex) {
  const h = hex.replace('#', '');
  return { r: parseInt(h.slice(0, 2), 16) / 255, g: parseInt(h.slice(2, 4), 16) / 255, b: parseInt(h.slice(4, 6), 16) / 255 };
}
function col(hex, a) {
  const c = rgb(hex);
  const f = n => (Math.round(n * 1000000) / 1000000);
  return `{r: ${f(c.r)}, g: ${f(c.g)}, b: ${f(c.b)}, a: ${a === undefined ? 1 : a}}`;
}
function col32(hex, a) {
  const c = rgb(hex);
  const r = Math.round(c.r * 255), g = Math.round(c.g * 255), b = Math.round(c.b * 255), al = Math.round((a === undefined ? 1 : a) * 255);
  return (r | (g << 8) | (b << 16) | (al << 24)) >>> 0;
}

// ---------- guid allocation ----------
function existingGuids() {
  const set = new Set();
  const walk = (dir) => {
    for (const e of fs.readdirSync(dir, { withFileTypes: true })) {
      const p = path.join(dir, e.name);
      if (e.isDirectory()) walk(p);
      else if (e.name.endsWith('.meta')) {
        const m = /^guid: ([0-9a-f]{32})/m.exec(fs.readFileSync(p, 'utf8'));
        if (m) set.add(m[1]);
      }
    }
  };
  walk(path.join(ROOT, 'Assets'));
  return set;
}

const SALT = 'SkylineBlockRush-2026-10-16';
let _taken = null;
function guidFor(key) {
  if (!_taken) _taken = existingGuids();
  let n = 0, g;
  do {
    g = crypto.createHash('md5').update(SALT + '|' + key + '|' + n).digest('hex');
    n++;
  } while (_taken.has(g));
  _taken.add(g);
  return g;
}

// ---------- known engine references ----------
const REF = {
  spriteSub: 21300000,                       // main sprite of a single-sprite texture
  monoScript: 11500000,
  fontAsset: '{fileID: 11400000, guid: 2acf3e88cc944f58b1d7e0543d045427, type: 2}',
  fontMaterial: '{fileID: -3226640968860151095, guid: 2acf3e88cc944f58b1d7e0543d045427, type: 2}',
  spritesDefaultMat: '{fileID: 10754, guid: 0000000000000000f000000000000000, type: 0}',
  uiSpriteBuiltin: '{fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}',  // rounded 9-slice face (measured)
  uiPanelBuiltin: '{fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}',  // panel plate (measured)
  scripts: {
    Image: 'fe87c0e1cc204ed48ad3b37840f39efc',
    TMPUGUI: 'f4688fdb7b17482baa9f6d78eb0a3b5c',
    Button: '4e29b1a8ea4f3ad4dbbf4f0ae7a0c1b8',
    CanvasGroup: null,
    LoadSceneButton: '557e9bfa96dc47fca5769a35e5db9622',
  },
};

module.exports = { HEX, rgb, col, col32, guidFor, existingGuids, REF, ROOT };
