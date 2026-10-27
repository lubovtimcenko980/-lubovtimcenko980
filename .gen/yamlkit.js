'use strict';
const fs = require('fs');

// ---------- document-level parsing of a Unity YAML file ----------
// A Unity asset is a list of documents:  --- !u!<class> &<fileID>\n<body>
function parse(path) {
  const raw = fs.readFileSync(path, 'utf8');
  const nl = raw.includes('\r\n') ? '\r\n' : '\n';
  const lines = raw.split(/\r?\n/);
  const header = [];
  const docs = [];
  let cur = null;
  for (const line of lines) {
    const m = /^--- !u!(\d+) &(\d+)(.*)$/.exec(line);
    if (m) {
      if (cur) docs.push(cur);
      cur = { cls: +m[1], id: m[2], tail: m[3] || '', body: [] };
      continue;
    }
    if (cur) cur.body.push(line);
    else header.push(line);
  }
  if (cur) docs.push(cur);
  // strip trailing empty lines of the last doc
  return { path, nl, header, docs };
}

function render(doc) {
  const parts = [...doc.header];
  for (const d of doc.docs) {
    parts.push(`--- !u!${d.cls} &${d.id}${d.tail}`);
    for (const l of d.body) parts.push(l);
  }
  return parts.join(doc.nl);
}

function write(doc, path) {
  fs.writeFileSync(path || doc.path, render(doc), 'utf8');
}

function byId(doc) {
  const m = new Map();
  for (const d of doc.docs) m.set(d.id, d);
  return m;
}

function typeOf(d) {
  for (const l of d.body) {
    const m = /^([A-Za-z_][A-Za-z0-9_]*):\s*$/.exec(l);
    if (m) return m[1];
  }
  return null;
}

// field access inside a doc body (top-level, 2-space indent "  key: value")
function getField(d, key) {
  const re = new RegExp('^  ' + key.replace(/[.[\]]/g, '\$&') + ': (.*)$');
  for (const l of d.body) { const m = re.exec(l); if (m) return m[1]; }
  return null;
}
function setField(d, key, value) {
  const re = new RegExp('^  ' + key.replace(/[.[\]]/g, '\$&') + ': (.*)$');
  for (let i = 0; i < d.body.length; i++) {
    if (re.test(d.body[i])) { d.body[i] = `  ${key}: ${value}`; return true; }
  }
  return false;
}
// nested: "  m_Colors:\n  - ..." etc. generic indent-aware setter for "    key: v"
function setNested(d, parentKey, key, value, indent) {
  indent = indent || '    ';
  let inParent = false;
  for (let i = 0; i < d.body.length; i++) {
    const l = d.body[i];
    if (new RegExp('^  ' + parentKey + ':').test(l)) { inParent = true; continue; }
    if (inParent) {
      if (/^  [A-Za-z_]/.test(l)) return false;           // left the parent block
      if (new RegExp('^' + indent + key + ': ').test(l)) {
        d.body[i] = `${indent}${key}: ${value}`; return true;
      }
    }
  }
  return false;
}

module.exports = { parse, render, write, byId, typeOf, getField, setField, setNested };
