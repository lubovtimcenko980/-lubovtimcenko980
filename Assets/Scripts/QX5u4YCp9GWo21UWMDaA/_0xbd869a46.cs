using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>Dresses the three template pops (PAUSE 6, WIN 7, LOSE 8) completely: wording in the
/// game's own language, a caption on every action button, a real cross glyph on the close
/// button, and the card illustration from this game's art (C.3, C.17, B.1).
/// The pops are reached by SETTINGS index, never by name; their buttons are told apart by
/// GEOMETRY (the close slot is the narrow one, the actions by which side they sit on), never by
/// traversal order. No listener is added to any of them: the template already drives every pop
/// button, and a second listener would fire twice.</summary>
public sealed class _0xbd869a46 : MonoBehaviour
{
    [SerializeField]
    private Sprite _crossSprite;
    /// <summary>A pop's Content is scaled to zero and switched off until it is shown, so
    /// activeInHierarchy says nothing; walk the chain ourselves.</summary>
    private static bool SelfActive(Transform _0xa5475c99, Transform _0x9ed555d5)
    {
        Transform _0x5dd51c76 = _0xa5475c99;
        int _0xee645573 = 0;
        while (_0x5dd51c76 != null && _0x5dd51c76 != _0x9ed555d5 && _0xee645573++ < 24)
        {
            if (!_0x5dd51c76.gameObject.activeSelf)
                return false;
            _0x5dd51c76 = _0x5dd51c76.parent;
        }

        return true;
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    private _0x73ff919b _0xdfa6befa;
    private void _0x26025270(_0x73ff919b _0x293f22b7, string _0x416c195d, string _0x302e8907, string _0xf8820155)
    {
        if (_0x293f22b7 == null)
            return;
        _0xeea80888.Apply(_0x293f22b7.Header, _0x416c195d, 68f, _0x5219e5ac.TextPrimary);
        _0xeea80888.Apply(_0x293f22b7.Body, _0x302e8907, 46f, _0x5219e5ac.Accent);
        _0xeea80888.Apply(_0x293f22b7.Extra, _0xf8820155, 30f, _0x5219e5ac.TextSecondary);
    }

    private void _0xc4bcbd97(TMP_Text _0xf84e889b, string _0x68b79f18)
    {
        if (_0xf84e889b == null)
            return;
        _0xf84e889b.gameObject.SetActive(true);
        _0xf84e889b.alignment = TextAlignmentOptions.Center;
        _0xeea80888.Apply(_0xf84e889b, _0x68b79f18, 40f, _0x5219e5ac.TextPrimary);
    }

    private static TMP_Text CaptionOf(Button _0xf12e9694)
    {
        return _0xf12e9694 == null ? null : _0xf12e9694.GetComponentInChildren<TMP_Text>(true);
    }

    /// <summary>Horizontal offset of a rect from the centre of an ancestor, computed from the
    /// anchors instead of world space (the pop is scaled to zero while it is hidden).</summary>
    private static float XRelativeTo(RectTransform _0x8accdc03, RectTransform _0x8b85a6c3)
    {
        float _0xe7141ec8 = 0f;
        RectTransform _0x8741ffdd = _0x8accdc03;
        int _0xf5643b13 = 0;
        while (_0x8741ffdd != null && _0x8741ffdd != _0x8b85a6c3 && _0xf5643b13++ < 24)
        {
            RectTransform _0x846fdb61 = _0x8741ffdd.parent as RectTransform;
            float _0xae18ecb4 = _0x846fdb61 == null ? 0f : _0x846fdb61.rect.width;
            float _0x7dd018e3 = _0x8741ffdd.rect.width;
            if (_0x7dd018e3 <= 1f)
                _0x7dd018e3 = _0x8741ffdd.sizeDelta.x;
            _0xe7141ec8 += (_0x8741ffdd.anchorMin.x + _0x8741ffdd.anchorMax.x) * 0.5f * _0xae18ecb4 + _0x8741ffdd.anchoredPosition.x + (0.5f - _0x8741ffdd.pivot.x) * _0x7dd018e3 - _0xae18ecb4 * 0.5f;
            _0x8741ffdd = _0x846fdb61;
        }

        return _0xe7141ec8;
    }

    public void _0xa3c83eba(int _0x3060d080, int _0xd423dc08, int glass)
    {
        this._0x0eac465d();
        this._0x26025270(this._0xd56e0006, _0x93356f8d._0x3d2e29c7(new byte[10] { 191, 184, 163, 205, 189, 172, 184, 190, 168, 169 }, 237), _0x93356f8d._0x3d2e29c7(new byte[7] { 227, 238, 226, 236, 227, 255, 139 }, 171) + _0x3060d080 + _0x93356f8d._0x3d2e29c7(new byte[2] { 227, 133 }, 195), _0x93356f8d._0x3d2e29c7(new byte[9] { 136, 157, 138, 158, 157, 155, 140, 248, 160 }, 216) + _0xd423dc08 + _0x93356f8d._0x3d2e29c7(new byte[9] { 27, 27, 27, 124, 119, 122, 104, 104, 27 }, 59) + _0x7815908a.Thousands(glass));
        _0xa748a6be.Instance._0x1dbf829b(_0x5a9a28e3._0xe57848ce.PAUSE);
    }

    /// <summary>Everything one pop needs, resolved once. The card itself is themed globally
    /// through BASE_PANEL, so what is built here is the content that sits on it.</summary>
    private _0x73ff919b _0x7531461f(_0x696568ef _0x4baa49e3, string _0xac8fa312, string _0x25a4330e, bool _0x5bd6fd37)
    {
        if (_0x4baa49e3 == null || _0x4baa49e3.Content == null)
            return null;
        RectTransform _0x8e3690ef = _0x4baa49e3.Content.transform as RectTransform;
        if (_0x8e3690ef == null)
            return null;
        Button _0x4f2e205d = null;
        Button _0xea89675b = null;
        Button _0x46d250e5 = null;
        Button[] _0x2b06a43c = _0x8e3690ef.GetComponentsInChildren<Button>(true);
        for (int _0x249dae4f = 0; _0x249dae4f < _0x2b06a43c.Length; _0x249dae4f++)
        {
            Button _0xfa3f04ba = _0x2b06a43c[_0x249dae4f];
            RectTransform _0x11ccb44e = _0xfa3f04ba.transform as RectTransform;
            if (_0x11ccb44e == null || !SelfActive(_0x11ccb44e, _0x8e3690ef))
                continue;
            float width = _0x11ccb44e.rect.width;
            if (width <= 1f)
                width = _0x11ccb44e.sizeDelta.x;
            // The close slot is the narrow one; the two action buttons are wide.
            if (width < 300f)
            {
                _0x4f2e205d = _0xfa3f04ba;
                continue;
            }

            if (XRelativeTo(_0x11ccb44e, _0x8e3690ef) < 0f)
                _0xea89675b = _0xfa3f04ba;
            else
                _0x46d250e5 = _0xfa3f04ba;
        }

        TMP_Text _0x150b81a1 = CaptionOf(_0xea89675b);
        TMP_Text _0xc8c478f8 = CaptionOf(_0x46d250e5);
        // C.17: every action button carries its own caption, the cross carries none.
        this._0xc4bcbd97(_0x150b81a1, _0xac8fa312);
        this._0xc4bcbd97(_0xc8c478f8, _0x25a4330e);
        // Nothing the template wrote is allowed on screen (C.15 / C.3): the stray "Score:",
        // "Reward:" and "100" rows all go, and so does the cross's own glyph text.
        TMP_Text[] _0xaff220a7 = _0x8e3690ef.GetComponentsInChildren<TMP_Text>(true);
        for (int _0xa5cd2e01 = 0; _0xa5cd2e01 < _0xaff220a7.Length; _0xa5cd2e01++)
        {
            TMP_Text _0x6a74e9ca = _0xaff220a7[_0xa5cd2e01];
            if (_0x6a74e9ca == null || _0x6a74e9ca == _0x150b81a1 || _0x6a74e9ca == _0xc8c478f8)
                continue;
            _0x6a74e9ca.text = string.Empty;
            _0x6a74e9ca.gameObject.SetActive(false);
        }

        if (_0x4f2e205d != null && this._crossSprite != null)
            this._0x666e5acc(_0x4f2e205d.transform as RectTransform, this._crossSprite, 62f, _0x5219e5ac.TextPrimary, 0f);
        if (_0x5bd6fd37 && this._markSprite != null)
            this._0x666e5acc(_0x8e3690ef, this._markSprite, 210f, _0x5219e5ac.With(_0xae21ba7c.Selected().Accent, 0.95f), CardHalfHeight * 0.66f);
        return new _0x73ff919b()._0xf8671646(this._0x14ae190e(_0x8e3690ef, 980f, 120f, CardHalfHeight * 0.28f, 68f, _0x5219e5ac.TextPrimary), this._0x14ae190e(_0x8e3690ef, 980f, 90f, CardHalfHeight * 0.04f, 46f, _0x5219e5ac.Accent), this._0x14ae190e(_0x8e3690ef, 980f, 70f, -CardHalfHeight * 0.16f, 30f, _0x5219e5ac.TextSecondary));
    }

    private TMP_Text _0x14ae190e(RectTransform _0x061325aa, float width, float height, float _0xcfb8070a, float _0xf976668b, Color _0xa7948a54)
    {
        GameObject _0x5b56b3c5 = new GameObject(_0x93356f8d._0x3d2e29c7(new byte[14] { 134, 190, 172, 185, 188, 187, 176, 133, 186, 165, 153, 188, 187, 176 }, 213), typeof(RectTransform), typeof(CanvasRenderer), typeof(TextMeshProUGUI));
        RectTransform _0xb00e3c47 = _0x5b56b3c5.transform as RectTransform;
        _0xb00e3c47.SetParent(_0x061325aa, false);
        _0xb00e3c47.anchorMin = new Vector2(0.5f, 0.5f);
        _0xb00e3c47.anchorMax = new Vector2(0.5f, 0.5f);
        _0xb00e3c47.pivot = new Vector2(0.5f, 0.5f);
        _0xb00e3c47.sizeDelta = new Vector2(width, height);
        _0xb00e3c47.anchoredPosition = new Vector2(0f, _0xcfb8070a);
        _0xb00e3c47.SetAsLastSibling();
        TextMeshProUGUI _0xeb6d9ec4 = _0x5b56b3c5.GetComponent<TextMeshProUGUI>();
        _0xeb6d9ec4.alignment = TextAlignmentOptions.Center;
        _0xeb6d9ec4.raycastTarget = false;
        _0xeea80888.Apply(_0xeb6d9ec4, string.Empty, _0xf976668b, _0xa7948a54);
        return _0xeb6d9ec4;
    }

    private _0x73ff919b _0xd56e0006;
    public void _0x437a73bc(int _0x25009747, int _0xd131d790, int _0xd5bc0dba, int glass)
    {
        this._0x0eac465d();
        this._0x26025270(this._0xdfa6befa, _0x93356f8d._0x3d2e29c7(new byte[18] { 25, 9, 11, 12, 12, 5, 6, 14, 106, 9, 5, 6, 6, 11, 26, 25, 15, 14 }, 74), _0x93356f8d._0x3d2e29c7(new byte[7] { 159, 146, 158, 144, 159, 131, 247 }, 215) + _0x25009747 + _0x93356f8d._0x3d2e29c7(new byte[2] { 18, 116 }, 50), _0x93356f8d._0x3d2e29c7(new byte[5] { 178, 181, 163, 164, 208 }, 240) + _0xd131d790 + _0x93356f8d._0x3d2e29c7(new byte[14] { 95, 57, 95, 95, 95, 47, 58, 45, 57, 58, 60, 43, 95, 7 }, 127) + _0xd5bc0dba + _0x93356f8d._0x3d2e29c7(new byte[4] { 19, 19, 19, 24 }, 51) + _0x7815908a.Thousands(glass) + _0x93356f8d._0x3d2e29c7(new byte[6] { 247, 144, 155, 150, 132, 132 }, 215));
        _0xa748a6be.Instance._0x1dbf829b(_0x5a9a28e3._0xe57848ce.LOSE);
    }

    private bool _0xaa10bd74;
    [SerializeField]
    private Sprite _markSprite;
    public void _0x0eac465d()
    {
        if (this._0xaa10bd74)
            return;
        this._0xaa10bd74 = true;
        if (_0xa748a6be.Instance == null)
            return;
        // The panels sit under an aspect fitter that only resolves in the layout pass, so a
        // rect read in Start() would still be zero. Force the pass before measuring.
        Canvas.ForceUpdateCanvases();
        this._0xd56e0006 = this._0x7531461f(_0xa748a6be.Instance._0x0003d531(_0x5a9a28e3._0xe57848ce.PAUSE), _0x93356f8d._0x3d2e29c7(new byte[8] { 107, 97, 124, 113, 8, 96, 125, 106 }, 40), _0x93356f8d._0x3d2e29c7(new byte[6] { 60, 43, 61, 59, 35, 43 }, 110), false);
        this._0x40e28a76 = this._0x7531461f(_0xa748a6be.Instance._0x0003d531(_0x5a9a28e3._0xe57848ce.WIN), _0x93356f8d._0x3d2e29c7(new byte[8] { 157, 151, 138, 135, 254, 150, 139, 156 }, 222), _0x93356f8d._0x3d2e29c7(new byte[11] { 216, 207, 211, 214, 222, 186, 219, 221, 219, 211, 212 }, 154), true);
        this._0xdfa6befa = this._0x7531461f(_0xa748a6be.Instance._0x0003d531(_0x5a9a28e3._0xe57848ce.LOSE), _0x93356f8d._0x3d2e29c7(new byte[8] { 107, 97, 124, 113, 8, 96, 125, 106 }, 40), _0x93356f8d._0x3d2e29c7(new byte[11] { 208, 199, 219, 222, 214, 178, 211, 213, 211, 219, 220 }, 146), true);
    }

    // The template pop card measures 1118 x 1011, centred on the pop's Content.
    private const float CardHalfHeight = 505f;
    public void _0x2e2dfcb7(string _0xc7c2dd1a, int _0xf389eb97, string _0xee676c90)
    {
        this._0x0eac465d();
        if (_0x59a642a8.Instance != null)
            _0x59a642a8.Instance._0xf550d936(false);
        this._0x26025270(this._0x40e28a76, _0x93356f8d._0x3d2e29c7(new byte[15] { 75, 79, 85, 85, 79, 73, 72, 38, 69, 74, 67, 71, 84, 67, 66 }, 6), _0xc7c2dd1a + _0x93356f8d._0x3d2e29c7(new byte[7] { 107, 102, 107, 15, 4, 5, 14 }, 75), _0x93356f8d._0x3d2e29c7(new byte[1] { 112 }, 91) + _0xf389eb97 + _0x93356f8d._0x3d2e29c7(new byte[9] { 13, 106, 97, 108, 126, 126, 13, 13, 13 }, 45) + _0xee676c90);
        _0xa748a6be.Instance._0x1dbf829b(_0x5a9a28e3._0xe57848ce.WIN);
    }

    private void _0x666e5acc(RectTransform _0x30edb386, Sprite _0x6b5f0518, float _0xcb17e051, Color _0x8a9f699a, float _0xed3e9f63)
    {
        if (_0x30edb386 == null || _0x6b5f0518 == null)
            return;
        GameObject _0xca2727db = new GameObject(_0x93356f8d._0x3d2e29c7(new byte[15] { 133, 189, 175, 186, 191, 184, 179, 134, 185, 166, 145, 186, 175, 166, 190 }, 214), typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        RectTransform _0xd8a43f8c = _0xca2727db.transform as RectTransform;
        _0xd8a43f8c.SetParent(_0x30edb386, false);
        _0xd8a43f8c.anchorMin = new Vector2(0.5f, 0.5f);
        _0xd8a43f8c.anchorMax = new Vector2(0.5f, 0.5f);
        _0xd8a43f8c.pivot = new Vector2(0.5f, 0.5f);
        _0xd8a43f8c.sizeDelta = new Vector2(_0xcb17e051, _0xcb17e051);
        _0xd8a43f8c.anchoredPosition = new Vector2(0f, _0xed3e9f63);
        _0xd8a43f8c.SetAsLastSibling();
        Image _0x450a3296 = _0xca2727db.GetComponent<Image>();
        _0x450a3296.sprite = _0x6b5f0518;
        _0x450a3296.color = _0x8a9f699a;
        _0x450a3296.preserveAspect = true;
        _0x450a3296.raycastTarget = false;
    }

    private void Start()
    {
        this._0x0eac465d();
    }

    private _0x73ff919b _0x40e28a76;
}

/// <summary>The three lines this game writes onto a pop card. No constructor (C.59).</summary>
public sealed class _0x73ff919b
{
    public _0x73ff919b _0xf8671646(TMP_Text _0xbe0c8fae, TMP_Text _0x4b7f7bb9, TMP_Text _0x0c246112)
    {
        this.Header = _0xbe0c8fae;
        this.Body = _0x4b7f7bb9;
        this.Extra = _0x0c246112;
        return this;
    }

    public TMP_Text Header;
    public TMP_Text Extra;
    public TMP_Text Body;
}

internal static class _0x93356f8d
{
    internal static string _0x3d2e29c7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}