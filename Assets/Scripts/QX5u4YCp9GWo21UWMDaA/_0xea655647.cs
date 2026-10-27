using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>The hub's own readouts: the GLASS pill (this game's copy of the template balance),
/// the district diorama, the mission banner and the stats line. None of it hangs on a template
/// placeholder — stage 5da switches those off and nothing of mine may depend on them (C.2).</summary>
public sealed class _0xea655647 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _hint;
    [SerializeField]
    private RectTransform _dioramaRect;
    [SerializeField]
    private Image _dioramaArt;
    [SerializeField]
    private TMP_Text _glassCaption;
    /// <summary>The skyline customiser recolours the diorama in the same frame the swatch is
    /// tapped — the change is visible behind the translucent sheet (C.7).</summary>
    public void _0xce575453(int _0x44d546a1)
    {
        if (this._dioramaArt == null)
            return;
        Color _0x5e7e6f7b = _0x44d546a1 == 1 ? _0x5219e5ac.With(_0x5219e5ac.Accent, 1f) : (_0x44d546a1 == 2 ? _0x5219e5ac.With(_0x5219e5ac.Secondary, 1f) : Color.white);
        this._dioramaArt.color = _0x5e7e6f7b;
        if (this._dioramaFrame != null)
            this._dioramaFrame.color = _0x5219e5ac.With(_0x5e7e6f7b, 0.35f);
    }

    private void _0x8dc207b4()
    {
        if (_0x002cd05a._0xa31c7051)
            return;
        this._0xffd5b7d9(this._glassPill, 24f, 0f);
        this._0xffd5b7d9(this._missionRailTrack, 18f, 0.05f);
        if (this._dioramaRect != null)
        {
            this._dioramaRect.localScale = Vector3.one * 0.95f;
            this._dioramaRect.DOScale(1f, 0.32f).SetEase(Ease.OutBack).SetLink(this._dioramaRect.gameObject);
        }
    }

    [SerializeField]
    private RectTransform _missionRailFill;
    [SerializeField]
    private TMP_Text _statsLine;
    [SerializeField]
    private Sprite[] _districtSprites;
    private void _0xffd5b7d9(RectTransform _0x051b6026, float _0x0479fe37, float _0xd76032a7)
    {
        if (_0x051b6026 == null)
            return;
        Vector2 _0xbe71ab9c = _0x051b6026.anchoredPosition;
        _0x051b6026.anchoredPosition = new Vector2(_0xbe71ab9c.x, _0xbe71ab9c.y - _0x0479fe37);
        _0x051b6026.DOAnchorPosY(_0xbe71ab9c.y, 0.26f).SetDelay(_0xd76032a7).SetEase(Ease.OutCubic).SetLink(_0x051b6026.gameObject);
    }

    [SerializeField]
    private RectTransform _missionRailTrack;
    [SerializeField]
    private TMP_Text _missionLabel;
    /// <summary>Welds this game's PLAY face onto the template button's own rect, so the
    /// visible plate and the invisible hit area are the same rectangle (rule H / G.3).</summary>
    public void _0xfb890f38(RectTransform _0x51ecd34d)
    {
        if (this._playFace == null || _0x51ecd34d == null)
            return;
        this._playFace.anchorMin = _0x51ecd34d.anchorMin;
        this._playFace.anchorMax = _0x51ecd34d.anchorMax;
        this._playFace.pivot = _0x51ecd34d.pivot;
        this._playFace.sizeDelta = _0x51ecd34d.sizeDelta;
        this._playFace.anchoredPosition = _0x51ecd34d.anchoredPosition;
    }

    private void OnDestroy()
    {
        if (this._0x85af28e6 != null)
            this._0x85af28e6.Kill();
        DOTween.Kill(this.gameObject);
        if (this._dioramaRect != null)
            DOTween.Kill(this._dioramaRect);
    }

    [SerializeField]
    private Image _playPlate;
    private void Start()
    {
        _0xeea80888.Apply(this._glassCaption, _0x62775007._0x4300c231(new byte[5] { 172, 167, 170, 184, 184 }, 235), 28f, _0x5219e5ac.TextSecondary);
        _0xeea80888.Apply(this._hint, _0x62775007._0x4300c231(new byte[26] { 96, 117, 100, 20, 96, 123, 20, 112, 102, 123, 100, 20, 25, 20, 96, 102, 125, 121, 20, 25, 20, 103, 96, 117, 119, 127 }, 52), 30f, _0x5219e5ac.TextSecondary);
        _0xeea80888.Apply(this._playCaption, _0x62775007._0x4300c231(new byte[4] { 246, 234, 231, 255 }, 166), 64f, _0x5219e5ac.TextPrimary);
        this._0xe6d63068();
        this._0xa5f1a700();
        this._0x8dc207b4();
    }

    [SerializeField]
    private Image _missionRailImage;
    [SerializeField]
    private TMP_Text _glassValue;
    [SerializeField]
    private Image _playGlow;
    /// <summary>Visible confirmation that a district tap landed, even when the player
    /// re-picks the one already selected: the diorama punches and the rail flashes (C.7).</summary>
    public void _0xa33d6b57()
    {
        this._0xe6d63068();
        if (this._dioramaRect != null)
        {
            this._dioramaRect.localScale = Vector3.one;
            this._dioramaRect.DOPunchScale(Vector3.one * 0.05f, _0x002cd05a.Duration(0.34f), 6, 0.6f).SetLink(this._dioramaRect.gameObject);
        }

        if (this._missionRailImage != null)
        {
            this._missionRailImage.color = _0x5219e5ac.With(_0x5219e5ac.Accent, 1f);
            this._missionRailImage.DOColor(_0x5219e5ac.With(_0xae21ba7c.Selected().Accent, 0.95f), _0x002cd05a.Duration(0.45f)).SetLink(this._missionRailImage.gameObject);
        }
    }

    [SerializeField]
    private TMP_Text _playCaption;
    [SerializeField]
    private RectTransform _playFace;
    private Tween _0x85af28e6;
    public void _0xe6d63068()
    {
        _0x226c8314 _0x900c1054 = _0xae21ba7c.Selected();
        _0xeea80888.Apply(this._glassValue, _0x7815908a.Thousands(_0x5a9a28e3._0xbe8fc6df._0x878e04e0), 46f, _0x5219e5ac.Accent);
        if (this._dioramaArt != null && this._districtSprites != null && _0x900c1054.ThumbIndex < this._districtSprites.Length)
        {
            this._dioramaArt.sprite = this._districtSprites[_0x900c1054.ThumbIndex];
            this._dioramaArt.preserveAspect = true;
            this._dioramaArt.color = Color.white;
        }

        if (this._dioramaFrame != null)
            this._dioramaFrame.color = _0x5219e5ac.With(_0x900c1054.Accent, 0.30f);
        if (this._playPlate != null)
            this._playPlate.color = _0x5219e5ac.With(_0x5219e5ac.Primary, 1f);
        if (this._playGlow != null)
            this._playGlow.color = _0x5219e5ac.With(_0x900c1054.Accent, 0.28f);
        int _0x65fdddb7 = _0x7815908a._0x042325e5;
        int _0x30bcd5de = _0x65fdddb7 < 8 ? 12 : _0x65fdddb7 + 4;
        float _0x034a9ea5 = _0x30bcd5de <= 0 ? 0f : Mathf.Clamp01((float)_0x65fdddb7 / _0x30bcd5de);
        _0xeea80888.Apply(this._missionLabel, _0x62775007._0x4300c231(new byte[16] { 159, 155, 129, 129, 155, 157, 156, 242, 255, 242, 128, 151, 147, 145, 154, 242 }, 210) + _0x30bcd5de + _0x62775007._0x4300c231(new byte[2] { 197, 163 }, 229), 34f, _0x5219e5ac.TextPrimary);
        if (this._missionRailTrack != null && this._missionRailFill != null)
        {
            this._missionRailFill.anchorMin = new Vector2(0f, 0f);
            this._missionRailFill.anchorMax = new Vector2(0f, 1f);
            this._missionRailFill.pivot = new Vector2(0f, 0.5f);
            this._missionRailFill.anchoredPosition = Vector2.zero;
            this._missionRailFill.sizeDelta = new Vector2(this._missionRailTrack.rect.width * _0x034a9ea5, 0f);
        }

        if (this._missionRailImage != null)
            this._missionRailImage.color = _0x5219e5ac.With(_0x900c1054.Accent, 0.95f);
        _0xeea80888.Apply(this._statsLine, _0x62775007._0x4300c231(new byte[5] { 234, 237, 251, 252, 136 }, 168) + _0x65fdddb7 + _0x62775007._0x4300c231(new byte[17] { 97, 7, 97, 97, 97, 17, 4, 19, 7, 4, 2, 21, 97, 19, 20, 15, 97 }, 65) + _0x7815908a._0x4cbdf272 + _0x62775007._0x4300c231(new byte[3] { 236, 236, 236 }, 204) + _0x900c1054.Title, 30f, _0x5219e5ac.TextSecondary);
        if (this._playCaption != null)
            _0xeea80888.Apply(this._playCaption, _0x65fdddb7 >= _0x900c1054.UnlockAt && _0xae21ba7c.SelectedIndex() > 0 ? _0x62775007._0x4300c231(new byte[5] { 28, 0, 13, 21, 108 }, 76) + _0x900c1054.Title : _0x62775007._0x4300c231(new byte[4] { 51, 47, 34, 58 }, 99), 64f, _0x5219e5ac.TextPrimary);
    }

    [SerializeField]
    private RectTransform _glassPill;
    [SerializeField]
    private Image _dioramaFrame;
    public void _0xa5f1a700()
    {
        if (this._0x85af28e6 != null)
        {
            this._0x85af28e6.Kill();
            this._0x85af28e6 = null;
        }

        if (this._dioramaRect == null)
            return;
        this._dioramaRect.localScale = Vector3.one;
        if (_0x002cd05a._0xa31c7051)
            return;
        this._0x85af28e6 = this._dioramaRect.DOScale(1.012f, 2.4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._dioramaRect.gameObject);
    }
}

internal static class _0x62775007
{
    internal static string _0x4300c231(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}