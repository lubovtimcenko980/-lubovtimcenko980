using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>Owns the board: geometry, the stack, the sweeping slab, the trim and the slide that
/// keeps the next floor at the same screen height. Everything moves by assigning rects or by
/// DOTween — no body drives anything here.</summary>
public sealed class _0xb0f6cff5 : MonoBehaviour
{
    private _0x495de4b2 _0x3f2da7cd;
    [SerializeField]
    private RectTransform _movingSlab;
    public _0x495de4b2 _0x5155c1fd
    {
        get
        {
            this._0x6cec4211();
            return this._0x3f2da7cd;
        }
    }

    [SerializeField]
    private RectTransform _trimLayer;
    public void _0x079e0bd9(_0xacc286a4 _0xa676fea7)
    {
        this._0x6cec4211();
        this._0xf6aaeabd = _0xa676fea7;
        this._0x7b1506f9 = true;
        this._0x51ea95ba = false;
        for (int _0xa65e3dfb = this._towerStack.childCount - 1; _0xa65e3dfb >= 0; _0xa65e3dfb--)
            Destroy(this._towerStack.GetChild(_0xa65e3dfb).gameObject);
        for (int _0xd91a80aa = this._trimLayer.childCount - 1; _0xd91a80aa >= 0; _0xd91a80aa--)
            Destroy(this._trimLayer.GetChild(_0xd91a80aa).gameObject);
        float _0x2f0ffbd4 = this._0x3f2da7cd.BaseW * _0xa676fea7.StartWidthFactor;
        float _0x7db754b2 = this._0x3f2da7cd.FieldW * _0xa676fea7.PerfectWindowFactor;
        this._0xd4a6c14f = new _0x4c375b28()._0x325e08d1(this._0x3f2da7cd, _0x2f0ffbd4, _0x7db754b2, _0xa676fea7.StubFloors);
        Color _0xd9b8f40b = _0xae21ba7c.Selected().Accent;
        for (int _0x28913da3 = 0; _0x28913da3 < _0xa676fea7.StubFloors; _0x28913da3++)
        {
            float _0x56da7428 = _0x2f0ffbd4 * (1f + (_0xa676fea7.StubFloors - 1 - _0x28913da3) * 0.035f);
            this._0x6bdae803(_0x56da7428, 0f, _0x28913da3, _0x5219e5ac.With(_0x5219e5ac.Surface, 0.92f + _0x28913da3 * 0.02f));
        }

        this._0xfec338f2 = this._0x3f2da7cd.TopY - _0xa676fea7.StubFloors * this._0x3f2da7cd.FloorH;
        this._towerStack.anchoredPosition = new Vector2(0f, this._0xfec338f2);
        // The plinth hangs off the stack root (pivot at its own top edge), so it stays
        // welded to the bottom floor and rides the stack slide instead of drifting.
        if (this._plinth != null)
        {
            this._plinth.sizeDelta = new Vector2(_0x2f0ffbd4 * 1.42f, this._0x3f2da7cd.PlinthH);
            this._plinth.anchoredPosition = Vector2.zero;
        }

        if (this._guideBeam != null)
        {
            this._guideBeam.sizeDelta = new Vector2(this._0x3f2da7cd.FieldW * 0.0115f, this._0x3f2da7cd._0x33d06762());
            this._guideBeam.anchoredPosition = new Vector2(0f, this._0x3f2da7cd._0x33d06762() * 0.5f);
            if (this._guideImage != null)
                this._guideImage.color = _0x5219e5ac.With(_0xd9b8f40b, 0.30f);
        }

        this._0x7959fc58();
    }

    public _0x4c375b28 _0xa81a27fb
    {
        get
        {
            return this._0xd4a6c14f;
        }
    }

    [SerializeField]
    private _0xa80ca35a _sweep;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
        if (this._towerStack != null)
            DOTween.Kill(this._towerStack);
    }

    [SerializeField]
    private RectTransform _plinth;
    [SerializeField]
    private _0xef3f0dea _director;
    [SerializeField]
    private Image _guideImage;
    [SerializeField]
    private Sprite _slabGlowSprite;
    [SerializeField]
    private RectTransform _calloutLayer;
    /// <summary>One tap: freeze, fall, resolve, trim, slide. Returns false when the board is busy.</summary>
    public bool _0xe2b80b43()
    {
        if (!this._0x7b1506f9 || this._0x51ea95ba || this._0xd4a6c14f == null)
            return false;
        this._0x51ea95ba = true;
        if (this._sweep != null)
            this._sweep._0x5baac4aa();
        float _0x1c0dda9a = this._movingSlab.anchoredPosition.x;
        float _0x2f342bd3 = _0x002cd05a.Duration(0.16f);
        if (this._guideImage != null)
            this._guideImage.DOFade(0.6f, _0x2f342bd3).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        this._movingSlab.DOAnchorPosY(this._0x3f2da7cd.TopY, _0x2f342bd3).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        DOVirtual.DelayedCall(_0x2f342bd3, () => this._0xbfa37b54(_0x1c0dda9a)).SetLink(this.gameObject);
        return true;
    }

    private void _0x9ceeee4a(Vector2 _0x62ce16f5, string _0x94ae1922, Color _0x31fd3375)
    {
        if (this._calloutPrefab == null || this._calloutLayer == null)
            return;
        GameObject _0x20bd6d9c = Instantiate(this._calloutPrefab, this._calloutLayer, false);
        _0x269ad97d _0x8d3f2b53 = _0x20bd6d9c.GetComponent<_0x269ad97d>();
        if (_0x8d3f2b53 != null)
            _0x8d3f2b53._0xd523d3e0(_0x62ce16f5, _0x94ae1922, _0x31fd3375);
    }

    [SerializeField]
    private Sprite _slabSprite;
    private float _0xfec338f2;
    public void _0x1affc1f3()
    {
        this._0x7b1506f9 = false;
        if (this._sweep != null)
            this._sweep._0x5baac4aa();
        if (this._movingSlab != null)
            this._movingSlab.gameObject.SetActive(false);
    }

    private _0xacc286a4 _0xf6aaeabd;
    [SerializeField]
    private RectTransform _towerStack;
    private void _0x7959fc58()
    {
        if (!this._0x7b1506f9)
            return;
        this._0x51ea95ba = false;
        float _0x9d70c7b3 = this._0xd4a6c14f._0x1fd0e203;
        this._movingSlab.gameObject.SetActive(true);
        this._movingSlab.sizeDelta = new Vector2(_0x9d70c7b3, this._0x3f2da7cd.FloorH);
        if (this._movingImage != null)
        {
            this._movingImage.sprite = this._slabSprite;
            this._movingImage.color = _0x5219e5ac.With(_0x5219e5ac.Secondary, 0.95f);
        }

        if (this._sweep != null)
        {
            this._sweep._0x3545700e();
            this._sweep._0x504b5b85(this._0x3f2da7cd._0x7e8acb04(_0x9d70c7b3), this._0xf6aaeabd._0x43e1db78(this._0xd4a6c14f._0x44f62d10), this._0xf6aaeabd.FirstDirection, this._0x3f2da7cd.LaneY);
        }

        if (this._guideBeam != null)
            this._guideBeam.anchoredPosition = new Vector2(this._0xd4a6c14f._0x6fd5306c, this._0x3f2da7cd._0x33d06762() * 0.5f);
    }

    private void _0x6bdae803(float width, float _0xfb69ca99, int _0xc55fa53c, Color _0x4ed965c1)
    {
        if (this._floorPrefab == null || this._towerStack == null)
            return;
        GameObject _0x058a9728 = Instantiate(this._floorPrefab, this._towerStack, false);
        RectTransform _0xeca1d815 = _0x058a9728.transform as RectTransform;
        if (_0xeca1d815 == null)
            return;
        _0xeca1d815.anchorMin = new Vector2(0.5f, 0f);
        _0xeca1d815.anchorMax = new Vector2(0.5f, 0f);
        _0xeca1d815.pivot = new Vector2(0.5f, 0f);
        _0xeca1d815.sizeDelta = new Vector2(width, this._0x3f2da7cd.FloorH);
        _0xeca1d815.anchoredPosition = new Vector2(_0xfb69ca99, _0xc55fa53c * this._0x3f2da7cd.FloorH);
        Image _0xcf81ca29 = _0x058a9728.GetComponent<Image>();
        if (_0xcf81ca29 != null)
        {
            // A 9-slice plate, so the slab keeps its corner radius at any width; preserveAspect
            // is deliberately NOT set - that would fight the slicing (F.2a).
            _0xcf81ca29.type = Image.Type.Sliced;
            _0xcf81ca29.sprite = this._slabSprite;
            _0xcf81ca29.color = _0x4ed965c1;
        }
    }

    private void _0xfecf9404(float _0x8d20c89f, float width, int _0x627065f0, Color _0xe8554e93)
    {
        if (this._trimPrefab == null || this._trimLayer == null)
            return;
        GameObject _0x503a0a2e = Instantiate(this._trimPrefab, this._trimLayer, false);
        _0x565d206b _0x03d084fe = _0x503a0a2e.GetComponent<_0x565d206b>();
        if (_0x03d084fe == null)
            return;
        float _0x00306a7c = this._0x3f2da7cd.TopY;
        _0x03d084fe._0x51c56361(new Vector2(_0x8d20c89f, _0x00306a7c), new Vector2(width, this._0x3f2da7cd.FloorH), _0x627065f0, this._0x3f2da7cd.FieldH * 0.32f, _0xe8554e93);
    }

    public bool _0x1b8c41ea
    {
        get
        {
            return this._0x7b1506f9;
        }
    }

    private bool _0x7b1506f9;
    [SerializeField]
    private Image _movingImage;
    private bool _0x51ea95ba;
    [SerializeField]
    private GameObject _floorPrefab;
    public void _0x6cec4211()
    {
        if (this._0x3f2da7cd != null)
            return;
        Rect _0x6f7c4a79 = this._field != null ? this._field.rect : new Rect(0f, 0f, 1242f, 1918f);
        if (_0x6f7c4a79.width < 1f || _0x6f7c4a79.height < 1f)
            _0x6f7c4a79 = new Rect(0f, 0f, 1242f, 1918f);
        this._0x3f2da7cd = new _0x495de4b2()._0x8c56e6d0(_0x6f7c4a79);
    }

    [SerializeField]
    private RectTransform _field;
    private _0x4c375b28 _0xd4a6c14f;
    [SerializeField]
    private GameObject _trimPrefab;
    [SerializeField]
    private GameObject _calloutPrefab;
    [SerializeField]
    private RectTransform _guideBeam;
    private void _0xbfa37b54(float _0x95b3f0e5)
    {
        if (!this._0x7b1506f9 || this._0xd4a6c14f == null)
            return;
        _0xa10a6a07 _0xdb1c5138 = this._0xd4a6c14f._0x027a4b17(_0x95b3f0e5);
        Color _0xd677e0bc = _0xae21ba7c.Selected().Accent;
        if (_0xdb1c5138.Kind == _0xa10a6a07.Miss)
        {
            this._0xd4a6c14f._0xd7d702c4();
            this._0xfecf9404(_0x95b3f0e5, this._movingSlab.sizeDelta.x, _0xdb1c5138.TrimSign, _0x5219e5ac.With(_0x5219e5ac.Surface, 0.9f));
            this._movingSlab.anchoredPosition = new Vector2(_0x95b3f0e5, this._0x3f2da7cd.LaneY);
            if (this._director != null)
                this._director._0xbf237863(_0xdb1c5138);
            if (this._0x7b1506f9)
                this._0x7959fc58();
            return;
        }

        if (_0xdb1c5138.Kind == _0xa10a6a07.Trim && _0xdb1c5138.TrimWidth > 1f)
            this._0xfecf9404(_0xdb1c5138.TrimCentre, _0xdb1c5138.TrimWidth, _0xdb1c5138.TrimSign, _0x5219e5ac.With(_0x5219e5ac.Surface, 0.95f));
        Color _0xe27abb60 = _0xdb1c5138.Kind == _0xa10a6a07.Perfect ? _0x5219e5ac.With(_0x002cd05a._0x3e16228f, 0.95f) : _0x5219e5ac.With(_0x5219e5ac.Secondary, 0.88f);
        this._0x6bdae803(_0xdb1c5138.NewWidth, _0xdb1c5138.NewCentre, this._0xd4a6c14f._0x44f62d10 - 1, _0xe27abb60);
        if (_0xdb1c5138.Kind == _0xa10a6a07.Perfect)
        {
            Vector2 _0x06d29f4b = new Vector2(_0xdb1c5138.NewCentre, this._0x3f2da7cd.TopY + this._0x3f2da7cd.FloorH * 0.5f);
            if (this._flash != null)
                this._flash._0x1ca4305f(_0x06d29f4b, this._0x3f2da7cd.FieldW * 0.19f);
            if (this._movingImage != null && this._slabGlowSprite != null)
                this._movingImage.sprite = this._slabGlowSprite;
            this._0x9ceeee4a(_0x06d29f4b, _0x85514c8e._0xdcadccec(new byte[7] { 149, 128, 151, 131, 128, 134, 145 }, 197), _0x002cd05a._0x3e16228f);
        }

        this._movingSlab.gameObject.SetActive(false);
        float _0xb8f03b73 = _0x002cd05a.Duration(0.22f);
        this._0xfec338f2 -= this._0x3f2da7cd.FloorH;
        this._towerStack.DOAnchorPosY(this._0xfec338f2, _0xb8f03b73).SetEase(Ease.InOutSine).SetLink(this.gameObject);
        if (this._director != null)
        {
            this._director._0xbf237863(_0xdb1c5138);
            this._director._0xdb7c907c(this._0x3f2da7cd.FloorH, _0xb8f03b73);
        }

        DOVirtual.DelayedCall(_0xb8f03b73, () => this._0x7959fc58()).SetLink(this.gameObject);
    }

    [SerializeField]
    private _0x83d99e47 _flash;
}

internal static class _0x85514c8e
{
    internal static string _0xdcadccec(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}