using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>The game HUD, built from THIS game's own objects — nothing of it hangs on a
/// template placeholder (C.2). Counters tween, the streak row hides itself at zero.</summary>
public sealed class _0xacf544f2 : MonoBehaviour
{
    [SerializeField]
    private Image _pipB;
    public void _0xb9753797()
    {
        if (this._hint == null)
            return;
        this._hint.DOFade(0.45f, _0x002cd05a.Duration(0.4f)).SetEase(Ease.OutQuad).SetLink(this.gameObject);
    }

    private int _0x76bd10b4 = -1;
    private void _0x8ff37c8f(Image _0x9617cbf0, bool _0x8e2281a5)
    {
        if (_0x9617cbf0 == null)
            return;
        _0x9617cbf0.color = _0x8e2281a5 ? _0x5219e5ac.With(_0x5219e5ac.Accent, 1f) : _0x5219e5ac.With(_0x5219e5ac.TextSecondary, 0.25f);
    }

    public void _0x842c76cf(int _0x0b7d9071)
    {
        if (this._streakRow == null)
            return;
        this._streakRow.gameObject.SetActive(_0x0b7d9071 > 0);
        if (_0x0b7d9071 > 0)
            _0xeea80888.Apply(this._streakLabel, _0x2a67238b._0x9c27345c(new byte[9] { 227, 246, 225, 245, 246, 240, 231, 147, 203 }, 179) + _0x0b7d9071, 32f, _0x002cd05a._0x3e16228f);
    }

    [SerializeField]
    private RectTransform _streakRow;
    public void _0x1c851d34(int glass)
    {
        if (this._glassValue == null)
            return;
        int _0x1693afdd = this._0x76bd10b4 < 0 ? glass : this._0x76bd10b4;
        this._0x76bd10b4 = glass;
        DOVirtual.Float(_0x1693afdd, glass, _0x002cd05a.Duration(0.3f), _0xc78d10ec => this._0x2828b3b5(_0xc78d10ec)).SetEase(Ease.OutCubic).SetLink(this.gameObject);
    }

    [SerializeField]
    private Image _missionRailImage;
    private void _0x2828b3b5(float _0x507514bc)
    {
        _0xeea80888.SetText(this._glassValue, _0x2a67238b._0x9c27345c(new byte[6] { 96, 107, 102, 116, 116, 7 }, 39) + _0x7815908a.Thousands(Mathf.RoundToInt(_0x507514bc)));
    }

    public void _0x8ce34f00(int _0x76497252)
    {
        if (this._heightValue == null)
            return;
        int _0x5b3ae498 = this._0x5b4befa5 < 0 ? _0x76497252 : this._0x5b4befa5;
        this._0x5b4befa5 = _0x76497252;
        DOVirtual.Float(_0x5b3ae498, _0x76497252, _0x002cd05a.Duration(0.3f), _0xc78d10ec => this._0xcf161c81(_0xc78d10ec)).SetEase(Ease.OutCubic).SetLink(this.gameObject);
    }

    [SerializeField]
    private TMP_Text _hint;
    private int _0x5b4befa5 = -1;
    public void _0x30a82902(int _0x189b4bbe)
    {
        this._0x8ff37c8f(this._pipA, _0x189b4bbe >= 1);
        this._0x8ff37c8f(this._pipB, _0x189b4bbe >= 2);
        this._0x8ff37c8f(this._pipC, _0x189b4bbe >= 3);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    [SerializeField]
    private RectTransform _missionRailTrack;
    public void _0x52bb6fc3(string _0xe5bbdca8, float _0x0d6a1835)
    {
        _0xeea80888.Apply(this._missionLabel, _0xe5bbdca8, 30f, _0x5219e5ac.TextSecondary);
        if (this._missionRailFill != null && this._missionRailTrack != null)
        {
            float _0x6c29575d = this._missionRailTrack.rect.width * Mathf.Clamp01(_0x0d6a1835);
            this._missionRailFill.sizeDelta = new Vector2(_0x6c29575d, this._missionRailFill.sizeDelta.y);
        }

        if (this._missionRailImage != null)
            this._missionRailImage.color = _0x5219e5ac.With(_0x5219e5ac.Secondary, 0.9f);
    }

    [SerializeField]
    private RectTransform _scaffoldRow;
    [SerializeField]
    private TMP_Text _heightCaption;
    [SerializeField]
    private Image _pipA;
    [SerializeField]
    private TMP_Text _missionLabel;
    /// <summary>Tween callbacks live in their own methods so every tween statement stays on
    /// ONE line, which is what keeps .SetLink(...) attachable (C.56).</summary>
    private void _0xcf161c81(float _0x22154aa1)
    {
        _0xeea80888.SetText(this._heightValue, Mathf.RoundToInt(_0x22154aa1) + _0x2a67238b._0x9c27345c(new byte[2] { 220, 186 }, 252));
    }

    [SerializeField]
    private TMP_Text _heightValue;
    [SerializeField]
    private Image _pipC;
    private void Start()
    {
        _0xeea80888.Apply(this._heightCaption, _0x2a67238b._0x9c27345c(new byte[6] { 247, 250, 246, 248, 247, 235 }, 191), 28f, _0x5219e5ac.TextSecondary);
        _0xeea80888.Apply(this._heightValue, _0x2a67238b._0x9c27345c(new byte[3] { 77, 93, 59 }, 125), 62f, _0x5219e5ac.Accent);
        _0xeea80888.Apply(this._glassValue, _0x2a67238b._0x9c27345c(new byte[7] { 84, 95, 82, 64, 64, 51, 35 }, 19), 32f, _0x5219e5ac.Accent);
        _0xeea80888.Apply(this._streakLabel, _0x2a67238b._0x9c27345c(new byte[10] { 119, 98, 117, 97, 98, 100, 115, 7, 95, 23 }, 39), 32f, _0x5219e5ac.TextPrimary);
        _0xeea80888.Apply(this._missionLabel, _0x2a67238b._0x9c27345c(new byte[7] { 97, 101, 127, 127, 101, 99, 98 }, 44), 30f, _0x5219e5ac.TextSecondary);
        _0xeea80888.Apply(this._hint, _0x2a67238b._0x9c27345c(new byte[30] { 248, 237, 252, 140, 237, 226, 245, 251, 228, 233, 254, 233, 140, 248, 227, 140, 232, 254, 227, 252, 140, 248, 228, 233, 140, 234, 224, 227, 227, 254 }, 172), 30f, _0x5219e5ac.TextPrimary);
        this._0x842c76cf(0);
    }

    [SerializeField]
    private RectTransform _missionRailFill;
    [SerializeField]
    private TMP_Text _streakLabel;
    [SerializeField]
    private TMP_Text _glassValue;
}

internal static class _0x2a67238b
{
    internal static string _0x9c27345c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}