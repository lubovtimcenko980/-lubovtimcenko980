using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>Run lifecycle, scoring and missions. The run is unbounded while nobody taps — there
/// is no timer and no draining meter anywhere in this game (C.5); three scaffold supports plus
/// the minimum-width clamp keep a tapped run alive well past the capture window.</summary>
public sealed class _0xef3f0dea : MonoBehaviour
{
    [SerializeField]
    private _0xb0f6cff5 _board;
    public const int StateIdle = 0;
    [SerializeField]
    private Button _pauseButton;
    private int _0xd316e6d8;
    /// <summary>Called by the board the moment a drop has been resolved.</summary>
    public void _0xbf237863(_0xa10a6a07 _0x1534ec47)
    {
        if (this._0x4807b167 == StateOver)
            return;
        int _0xdf978819 = this._board._0xa81a27fb._0x44f62d10 - this._0xef8a029d.StubFloors;
        if (_0xdf978819 < 0)
            _0xdf978819 = 0;
        if (_0x1534ec47.Kind == _0xa10a6a07.Perfect)
        {
            this._0xf6ef8940++;
            if (this._0xf6ef8940 > this._0x23d3b705)
                this._0x23d3b705 = this._0xf6ef8940;
            this._0xead2ee6c++;
            this._0x79779060(40 + Mathf.RoundToInt(10f * this._0x0cf13a4e()));
            _0x7815908a._0xe3f42192 = _0x7815908a._0xe3f42192 + 1;
        }
        else if (_0x1534ec47.Kind == _0xa10a6a07.Trim)
        {
            this._0xf6ef8940 = 0;
            if (_0x1534ec47.TrimWidth <= this._board._0x5155c1fd.BaseW * 0.15f)
                this._0xead2ee6c++;
            else
                this._0xead2ee6c = 0;
            this._0x79779060(Mathf.RoundToInt(10f * this._0x0cf13a4e()));
            if (_0x1534ec47.Clamped)
                this._0x4d349590();
        }
        else
        {
            this._0xf6ef8940 = 0;
            this._0xead2ee6c = 0;
            this._0x4d349590();
        }

        if (this._hud != null)
        {
            this._hud._0x8ce34f00(_0xdf978819);
            this._hud._0x842c76cf(this._0xf6ef8940);
            this._hud._0x30a82902(this._0x9dab0d2a);
            this._hud._0x1c851d34(this._0x05ce7282);
        }

        if (_0xdf978819 == 10 || _0xdf978819 == 20 || _0xdf978819 == 30)
        {
            this._0x9dab0d2a++;
            if (this._hud != null)
                this._hud._0x30a82902(this._0x9dab0d2a);
        }

        this._0x17e6ee3c(_0xdf978819);
        this._0xa1fce9e6(_0xdf978819);
        if (this._0x4807b167 != StateOver)
            this._0x4807b167 = StateIdle;
    }

    private void Start()
    {
        if (this._tapButton != null)
            this._tapButton.onClick.AddListener(() => this._0x1ba36383());
        if (this._pauseButton != null)
            this._pauseButton.onClick.AddListener(() => this._0x973dea09());
        if (this._backButton != null)
            this._backButton.onClick.AddListener(() => this._0x31fd1b51());
        if (this._pops != null)
            this._pops._0x0eac465d();
        this._0x3c4844dd();
    }

    private void _0x973dea09()
    {
        if (this._0x4807b167 == StateOver)
            return;
        if (_0x59a642a8.Instance != null)
            _0x59a642a8.Instance._0xf550d936(false);
        this._0x9b177d93();
    }

    private int _0x05ce7282;
    [SerializeField]
    private TMP_Text _hint;
    private void _0x79779060(int glass)
    {
        this._0x05ce7282 += glass;
    }

    private void _0x1ba36383()
    {
        if (this._0x4807b167 != StateIdle)
            return;
        if (_0x59a642a8.Instance == null || !_0x59a642a8.Instance._0xdb5e484e)
            return;
        if (!this._board._0xe2b80b43())
            return;
        this._0x4807b167 = StateResolving;
        this._0xd316e6d8++;
        if (this._0xd316e6d8 == 3 && this._hud != null)
            this._hud._0xb9753797();
    }

    /// <summary>Back to the City Hub: scene 0 by INDEX, never by name (C.1).</summary>
    private void _0x31fd1b51()
    {
        if (_0x59a642a8.Instance != null)
            _0x59a642a8.Instance._0x50418091(_0x5a9a28e3._0x52964cd5.SCENE_0);
    }

    private void _0x17e6ee3c(int _0x1d34c7e0)
    {
        _0xea666a49 _0x677278a1 = this._0x5782657f();
        if (_0x677278a1._0x5e5b5a33())
            return;
        switch (_0x677278a1.Kind)
        {
            case _0x38a6c9ac.KindPerfectRow:
                _0x677278a1.Progress = this._0x23d3b705;
                break;
            case _0x38a6c9ac.KindWideAt:
                _0x677278a1.Progress = this._board._0xa81a27fb._0xd4e7e9a1 >= 0.6f ? _0x1d34c7e0 : 0;
                break;
            case _0x38a6c9ac.KindNoSupport:
                _0x677278a1.Progress = this._0x8d54cfe6 == 0 ? _0x1d34c7e0 : 0;
                break;
            case _0x38a6c9ac.KindGlass:
                _0x677278a1.Progress = this._0x05ce7282;
                break;
            case _0x38a6c9ac.KindCleanFloors:
                _0x677278a1.Progress = this._0xead2ee6c;
                break;
            default:
                _0x677278a1.Progress = _0x1d34c7e0;
                break;
        }

        if (this._hud != null)
            this._hud._0x52bb6fc3(_0x677278a1.Label, _0x677278a1._0x2d174cec());
        if (!_0x677278a1._0x5e5b5a33())
            return;
        this._0x79779060(_0x677278a1.Reward);
        if (this._hud != null)
            this._hud._0x1c851d34(this._0x05ce7282);
        _0x226c8314 _0x85e13abc = _0xae21ba7c.Selected();
        if (this._pops != null)
            this._pops._0x2e2dfcb7(_0x677278a1.Label, _0x677278a1.Reward, _0x85e13abc.Title);
        this._0x6843d405++;
        if (this._0x6843d405 < this._0xef8a029d.Missions.Count && this._hud != null)
            this._hud._0x52bb6fc3(this._0x5782657f().Label, 0f);
    }

    private int _0x9dab0d2a;
    public void _0xdb7c907c(float _0x9f11cd1a, float _0xab8be7bd)
    {
        if (this._sky != null)
            this._sky._0x5be63dbd(_0x9f11cd1a, _0xab8be7bd);
    }

    public void _0x9b177d93()
    {
        if (this._pops == null)
            return;
        int _0xb7135cee = this._board._0xa81a27fb == null ? 0 : this._board._0xa81a27fb._0x44f62d10 - this._0xef8a029d.StubFloors;
        if (_0xb7135cee < 0)
            _0xb7135cee = 0;
        this._pops._0xa3c83eba(_0xb7135cee, this._0x23d3b705, this._0x05ce7282);
    }

    [SerializeField]
    private Button _backButton;
    [SerializeField]
    private _0xacf544f2 _hud;
    private void _0x9000e9d3(int _0x86f1c676)
    {
        if (_0x59a642a8.Instance != null)
            _0x59a642a8.Instance._0xf550d936(false);
        if (this._pops != null)
            this._pops._0x437a73bc(_0x86f1c676, _0x7815908a._0x042325e5, this._0x23d3b705, this._0x05ce7282);
    }

    [SerializeField]
    private Button _tapButton;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    private _0xea666a49 _0x5782657f()
    {
        if (this._0xef8a029d == null || this._0xef8a029d.Missions == null || this._0xef8a029d.Missions.Count == 0)
            return new _0xea666a49()._0x5f088b3f(_0x38a6c9ac.KindHeight, 12, _0x43a0c9ce._0x78200f1b(new byte[10] { 31, 8, 12, 14, 5, 109, 124, 127, 109, 11 }, 77), 200);
        int _0x865f661f = this._0x6843d405 < this._0xef8a029d.Missions.Count ? this._0x6843d405 : this._0xef8a029d.Missions.Count - 1;
        return this._0xef8a029d.Missions[_0x865f661f];
    }

    private int _0x6843d405;
    [SerializeField]
    private Image _overlay;
    [SerializeField]
    private _0xbd869a46 _pops;
    public const int StateOver = 2;
    private void _0x76719c31()
    {
        if (this._0x4807b167 == StateOver)
            return;
        this._0x4807b167 = StateOver;
        this._board._0x1affc1f3();
        int _0xc1451ae6 = this._board._0xa81a27fb._0x44f62d10 - this._0xef8a029d.StubFloors;
        if (_0xc1451ae6 < 0)
            _0xc1451ae6 = 0;
        _0x7815908a._0x03a2c387 = _0x7815908a._0x03a2c387 + 1;
        _0x7815908a._0x2bf2c764 = _0x7815908a._0x2bf2c764 + _0xc1451ae6;
        _0x5a9a28e3._0xbe8fc6df._0x878e04e0 = _0x5a9a28e3._0xbe8fc6df._0x878e04e0 + this._0x05ce7282;
        {
#if B_LOGS
            {
                Debug.Log($"[run] over floors={_0xc1451ae6} glass={this._0x05ce7282} streak={this._0x23d3b705}");
            }
#endif
        }

        if (this._overlay != null)
        {
            this._overlay.gameObject.SetActive(true);
            this._overlay.color = _0x5219e5ac.With(_0x5219e5ac.Deepest, 0f);
            this._overlay.DOFade(0.45f, _0x002cd05a.Duration(0.35f)).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        }

        float _0x4a3d3e4a = _0x002cd05a.Duration(0.6f);
        DOVirtual.DelayedCall(_0x4a3d3e4a, () => this._0x9000e9d3(_0xc1451ae6)).SetLink(this.gameObject);
    }

    private int _0xead2ee6c;
    private int _0x23d3b705;
    public void _0xae7b8023()
    {
        this._0x76719c31();
    }

    private void _0x4d349590()
    {
        this._0x9dab0d2a--;
        this._0x8d54cfe6++;
        if (this._0x9dab0d2a >= 0)
            return;
        this._0x76719c31();
    }

    private float _0x0cf13a4e()
    {
        int _0x72d6a34b = this._0xf6ef8940 > 8 ? 8 : this._0xf6ef8940;
        float _0x71485e4a = _0xae21ba7c.Selected().Multiplier;
        return (1f + 0.25f * _0x72d6a34b) * _0x71485e4a;
    }

    private void _0xa1fce9e6(int _0x93d66867)
    {
        if (_0x93d66867 > _0x7815908a._0x042325e5)
        {
            if (_0x93d66867 - _0x7815908a._0x042325e5 >= 3)
                _0x7815908a._0x6f9aefc8 = _0x7815908a._0x6f9aefc8 + 1;
            _0x7815908a._0x042325e5 = _0x93d66867;
        }

        if (this._0x23d3b705 > _0x7815908a._0x4cbdf272)
            _0x7815908a._0x4cbdf272 = this._0x23d3b705;
    }

    [SerializeField]
    private _0x2f62563f _sky;
    private void _0x3c4844dd()
    {
        this._board._0x6cec4211();
        int _0x660ddaa3 = _0x7815908a._0x03a2c387 + 1;
        this._0xef8a029d = new _0x0fa94b78()._0xb7dfcb8d(this._board._0x5155c1fd, _0x660ddaa3)._0xffa8b7d0();
        this._0x4807b167 = StateIdle;
        this._0x9dab0d2a = 3;
        this._0x8d54cfe6 = 0;
        this._0xf6ef8940 = 0;
        this._0x23d3b705 = 0;
        this._0x05ce7282 = 0;
        this._0xd316e6d8 = 0;
        this._0x6843d405 = 0;
        this._0xead2ee6c = 0;
        this._board._0x079e0bd9(this._0xef8a029d);
        if (this._sky != null)
            this._sky._0x4458f821(this._0xef8a029d, this._board._0x5155c1fd.FieldW);
        if (this._hud != null)
        {
            this._hud._0x8ce34f00(0);
            this._hud._0x1c851d34(0);
            this._hud._0x842c76cf(0);
            this._hud._0x30a82902(this._0x9dab0d2a);
            this._hud._0x52bb6fc3(this._0x5782657f().Label, 0f);
        }
    }

    private int _0x4807b167;
    private _0xacc286a4 _0xef8a029d;
    public const int StateResolving = 1;
    private int _0xf6ef8940;
    private int _0x8d54cfe6;
}

internal static class _0x43a0c9ce
{
    internal static string _0x78200f1b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}