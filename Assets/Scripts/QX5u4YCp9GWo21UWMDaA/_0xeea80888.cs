using TMPro;
using UnityEngine;

/// <summary>Every caption this game touches goes through here: word wrap off, autosize on
/// with the readability floor, line breaks only where the caller put a \n, and an outline
/// that contrasts with the face colour (CLAUDE-unity.md C.10 / C.12 / C.14).</summary>
public static class _0xeea80888
{
    public static void Apply(TMP_Text _0x9081a70a, string _0xfbb99b02, float _0xff2f66bc, Color _0x2a547c4a)
    {
        if (_0x9081a70a == null)
            return;
        _0x9081a70a.enableWordWrapping = false;
        _0x9081a70a.textWrappingMode = TextWrappingModes.NoWrap;
        _0x9081a70a.overflowMode = TextOverflowModes.Overflow;
        _0x9081a70a.enableAutoSizing = true;
        _0x9081a70a.fontSizeMin = 24f;
        _0x9081a70a.fontSizeMax = Mathf.Max(_0xff2f66bc, UiFloor);
        _0x9081a70a.fontSize = Mathf.Max(_0xff2f66bc, UiFloor);
        _0x9081a70a.color = _0x2a547c4a;
        _0x9081a70a.text = _0xfbb99b02;
        ApplyOutline(_0x9081a70a, _0x2a547c4a);
    }

    public static void SetText(TMP_Text _0xbed36149, string _0xaac889bb)
    {
        if (_0xbed36149 == null)
            return;
        _0xbed36149.enableWordWrapping = false;
        _0xbed36149.textWrappingMode = TextWrappingModes.NoWrap;
        _0xbed36149.overflowMode = TextOverflowModes.Overflow;
        _0xbed36149.enableAutoSizing = true;
        if (_0xbed36149.fontSizeMin < UiFloor)
            _0xbed36149.fontSizeMin = 24f;
        _0xbed36149.text = _0xaac889bb;
    }

    public const float UiFloor = 24f;
    /// <summary>Reading fontMaterial creates a per-label material instance; the shared asset
    /// is left alone. Light faces get the ink outline, dark faces a light one.</summary>
    public static void ApplyOutline(TMP_Text _0x622af2be, Color _0xf58ac6cc)
    {
        if (_0x622af2be == null)
            return;
        Material _0x1b767658 = _0x622af2be.fontMaterial;
        if (_0x1b767658 == null)
            return;
        float _0x43d53cd3 = 0.299f * _0xf58ac6cc.r + 0.587f * _0xf58ac6cc.g + 0.114f * _0xf58ac6cc.b;
        Color _0x837f3342 = _0x43d53cd3 < 0.5f ? _0x5219e5ac.TextPrimary : _0x5219e5ac.Deepest;
        _0x1b767658.SetColor(ShaderUtilities.ID_OutlineColor, _0x837f3342);
        _0x1b767658.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
    }
}