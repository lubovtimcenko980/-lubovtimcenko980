using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>One list row / card, used by every hub sheet so the sheets read as one system.
/// The indicator gutter and the text column never share an x-band (C.25): the text column
/// starts after the gutter plus a gap, computed from the row's own width.</summary>
public sealed class _0x084c8230 : MonoBehaviour
{
    [SerializeField]
    private Image _knobTrack;
    [SerializeField]
    private TMP_Text _caption;
    [SerializeField]
    private RectTransform _root;
    public void _0x76db2939(Sprite _0x960ec50a, Color _0x4ea943f9)
    {
        if (this._thumbRect == null || this._thumb == null)
            return;
        this._thumbRect.gameObject.SetActive(_0x960ec50a != null);
        this._thumb.sprite = _0x960ec50a;
        this._thumb.color = _0x4ea943f9;
        this._thumb.preserveAspect = true;
    }

    [SerializeField]
    private RectTransform _valueRect;
    public void _0x76ae1526(float _0x815cc97f, Color _0xd477a7d5)
    {
        if (this._railTrack == null || this._railFill == null)
        {
            return;
        }

        bool _0xd219c55d = _0x815cc97f >= 0f;
        this._railTrack.gameObject.SetActive(_0xd219c55d);
        if (!_0xd219c55d)
            return;
        float _0xfdff2ee7 = this._railTrack.sizeDelta.x * Mathf.Clamp01(_0x815cc97f);
        this._railFill.anchorMin = new Vector2(0f, 0f);
        this._railFill.anchorMax = new Vector2(0f, 1f);
        this._railFill.pivot = new Vector2(0f, 0.5f);
        this._railFill.anchoredPosition = Vector2.zero;
        this._railFill.sizeDelta = new Vector2(_0xfdff2ee7, 0f);
        if (this._railFillImage != null)
            this._railFillImage.color = _0xd477a7d5;
    }

    [SerializeField]
    private RectTransform _thumbRect;
    public void _0x6077426a()
    {
        if (this._knobTrack != null)
            this._knobTrack.gameObject.SetActive(false);
    }

    [SerializeField]
    private RectTransform _knob;
    public Button _0xb3ae4394
    {
        get
        {
            return this._button;
        }
    }

    private const float Padding = 40f;
    private void _0x495ff207(RectTransform _0x4048a5a6, float _0x4c12d389, float width, float height, float _0xdcb90b4f)
    {
        if (_0x4048a5a6 == null)
            return;
        _0x4048a5a6.anchorMin = new Vector2(0.5f, 0.5f);
        _0x4048a5a6.anchorMax = new Vector2(0.5f, 0.5f);
        _0x4048a5a6.pivot = new Vector2(0.5f, 0.5f);
        _0x4048a5a6.sizeDelta = new Vector2(width, height);
        _0x4048a5a6.anchoredPosition = new Vector2(_0x4c12d389, _0xdcb90b4f);
    }

    [SerializeField]
    private Image _plate;
    [SerializeField]
    private Image _accent;
    public void _0x24e258ad(string _0x343cb204, Color _0x273906f5, float _0xb56f3fff)
    {
        this._0x1a2c7f4c(this._captionRect, this._caption, _0x343cb204, _0x273906f5, _0xb56f3fff);
    }

    private const float GutterWidth = 42f;
    public void _0x0894e786(string _0x6375602a, Color _0xcf6271ad, float _0xf6cd8cbe)
    {
        this._0x1a2c7f4c(this._titleRect, this._title, _0x6375602a, _0xcf6271ad, _0xf6cd8cbe);
    }

    [SerializeField]
    private RectTransform _railFill;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    [SerializeField]
    private Image _knobDot;
    [SerializeField]
    private TMP_Text _title;
    public void _0xd7a8bc2b(bool _0x80a912f9, Color _0x1d89d33e)
    {
        if (this._knobTrack == null || this._knob == null)
            return;
        this._knobTrack.gameObject.SetActive(true);
        this._knobTrack.color = _0x80a912f9 ? _0x5219e5ac.With(_0x1d89d33e, 0.42f) : _0x5219e5ac.With(_0x5219e5ac.Surface, 0.75f);
        this._knob.anchorMin = new Vector2(0.5f, 0.5f);
        this._knob.anchorMax = new Vector2(0.5f, 0.5f);
        this._knob.sizeDelta = new Vector2(50f, 50f);
        this._knob.DOAnchorPosX(_0x80a912f9 ? 32f : -32f, _0x002cd05a.Duration(0.14f)).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        if (this._knobDot != null)
            this._knobDot.color = _0x80a912f9 ? _0x1d89d33e : _0x5219e5ac.TextSecondary;
    }

    private void _0x1a2c7f4c(RectTransform _0x9fb54677, TMP_Text _0x907efd25, string _0xe7b4d51f, Color _0x4a109cbb, float _0x4598173a)
    {
        if (_0x907efd25 == null)
            return;
        bool _0x3a8e535c = !string.IsNullOrEmpty(_0xe7b4d51f);
        if (_0x9fb54677 != null)
            _0x9fb54677.gameObject.SetActive(_0x3a8e535c);
        if (!_0x3a8e535c)
            return;
        _0x907efd25.alignment = TextAlignmentOptions.Left;
        _0xeea80888.Apply(_0x907efd25, _0xe7b4d51f, _0x4598173a, _0x4a109cbb);
    }

    [SerializeField]
    private Image _railFillImage;
    [SerializeField]
    private Button _button;
    [SerializeField]
    private RectTransform _railTrack;
    public void _0x1d43a85b(string _0x840275dd, Color _0x496d76c8, float _0x75d05374)
    {
        this._0x1a2c7f4c(this._valueRect, this._value, _0x840275dd, _0x496d76c8, _0x75d05374);
    }

    [SerializeField]
    private Image _thumb;
    [SerializeField]
    private RectTransform _captionRect;
    public void _0xa6f10735(RectTransform _0xbf438772, Vector2 _0xd12c3d6d, Vector2 _0xe3198551)
    {
        this._0xf1eb017c();
        this._root.SetParent(_0xbf438772, false);
        this._root.anchorMin = new Vector2(0.5f, 0.5f);
        this._root.anchorMax = new Vector2(0.5f, 0.5f);
        this._root.pivot = new Vector2(0.5f, 0.5f);
        this._root.sizeDelta = _0xd12c3d6d;
        this._root.anchoredPosition = _0xe3198551;
        this._0x80f88ee3(_0xd12c3d6d);
    }

    public void _0xf1eb017c()
    {
        if (this._root == null)
            this._root = this.transform as RectTransform;
    }

    [SerializeField]
    private TMP_Text _value;
    public void _0x58f51a2a(Color _0xa6d5fd5e, Color _0x967719b5)
    {
        if (this._plate != null)
            this._plate.color = _0xa6d5fd5e;
        if (this._accent != null)
            this._accent.color = _0x967719b5;
    }

    private const float GutterCentre = 62f;
    private const float TextGap = 46f;
    [SerializeField]
    private RectTransform _titleRect;
    private void _0x80f88ee3(Vector2 _0xf9a38921)
    {
        float _0x45689435 = -_0xf9a38921.x * 0.5f;
        bool _0x9ae6f46f = this._thumbRect != null && this._thumbRect.gameObject.activeSelf;
        float _0x3c41293a = Mathf.Min(_0xf9a38921.y - 28f, 150f);
        float _0xe974ee0d = _0x9ae6f46f ? _0x45689435 + Padding + _0x3c41293a + TextGap : _0x45689435 + GutterCentre + GutterWidth * 0.5f + TextGap;
        float _0xa9fe861d = _0xf9a38921.x * 0.5f - Padding - _0xe974ee0d;
        if (_0xa9fe861d < 120f)
            _0xa9fe861d = 120f;
        float _0x7398a1d4 = _0xe974ee0d + _0xa9fe861d * 0.5f;
        if (this._accent != null)
        {
            RectTransform _0xe596fa94 = this._accent.rectTransform;
            _0xe596fa94.anchorMin = new Vector2(0.5f, 0.5f);
            _0xe596fa94.anchorMax = new Vector2(0.5f, 0.5f);
            _0xe596fa94.sizeDelta = new Vector2(GutterWidth * 0.3f, _0xf9a38921.y - 36f);
            _0xe596fa94.anchoredPosition = new Vector2(_0x45689435 + GutterCentre, 0f);
            this._accent.gameObject.SetActive(!_0x9ae6f46f);
        }

        if (_0x9ae6f46f)
        {
            this._thumbRect.anchorMin = new Vector2(0.5f, 0.5f);
            this._thumbRect.anchorMax = new Vector2(0.5f, 0.5f);
            this._thumbRect.sizeDelta = new Vector2(_0x3c41293a, _0x3c41293a);
            this._thumbRect.anchoredPosition = new Vector2(_0x45689435 + Padding + _0x3c41293a * 0.5f, 0f);
        }

        this._0x495ff207(this._titleRect, _0x7398a1d4, _0xa9fe861d, 54f, _0xf9a38921.y * 0.24f);
        this._0x495ff207(this._valueRect, _0x7398a1d4, _0xa9fe861d, 62f, -_0xf9a38921.y * 0.02f);
        this._0x495ff207(this._captionRect, _0x7398a1d4, _0xa9fe861d, 40f, -_0xf9a38921.y * 0.26f);
        if (this._railTrack != null)
        {
            this._railTrack.anchorMin = new Vector2(0.5f, 0.5f);
            this._railTrack.anchorMax = new Vector2(0.5f, 0.5f);
            this._railTrack.sizeDelta = new Vector2(_0xa9fe861d, 10f);
            this._railTrack.anchoredPosition = new Vector2(_0x7398a1d4, -_0xf9a38921.y * 0.36f);
        }

        if (this._knob != null && this._knobTrack != null)
        {
            RectTransform _0xb65a7926 = this._knobTrack.rectTransform;
            _0xb65a7926.anchorMin = new Vector2(0.5f, 0.5f);
            _0xb65a7926.anchorMax = new Vector2(0.5f, 0.5f);
            _0xb65a7926.sizeDelta = new Vector2(132f, 62f);
            _0xb65a7926.anchoredPosition = new Vector2(_0xf9a38921.x * 0.5f - Padding - 66f, 0f);
        }
    }
}