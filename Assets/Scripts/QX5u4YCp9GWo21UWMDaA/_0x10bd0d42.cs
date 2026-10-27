using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>The seven hub sheets — onboarding, districts, collection, skyline, challenges,
/// statistics and settings. Exactly one is open at a time, every one of them can be empty and
/// says so, and every control changes something the player can see (C.7, empty-state rule).</summary>
public sealed class _0x10bd0d42 : MonoBehaviour
{
    [SerializeField]
    private _0xaf898f26[] _sheets;
    [SerializeField]
    private RectTransform[] _sheetBodies;
    public const int SheetSettings = 6;
    [SerializeField]
    private TMP_Text[] _sheetTitles;
    [SerializeField]
    private Sprite _stepTrimSprite;
    public void _0x855245b3(int _0x9c36fb95)
    {
        if (this._sheets == null || _0x9c36fb95 < 0 || _0x9c36fb95 >= this._sheets.Length)
            return;
        this._0xa1a7ec20();
        this._0xf097dfdb = _0x9c36fb95;
        this._0x7103ed40(_0x9c36fb95);
        if (this._scrim != null)
        {
            this._scrim.SetActive(true);
            if (this._scrimImage != null)
            {
                this._scrimImage.color = _0x5219e5ac.With(_0x5219e5ac.Deepest, 0f);
                this._scrimImage.DOFade(0.66f, _0x002cd05a.Duration(0.18f)).SetLink(this._scrim);
            }
        }

        this._sheets[_0x9c36fb95].Show();
        RectTransform _0x37cf3f90 = this._sheetRects != null && _0x9c36fb95 < this._sheetRects.Length ? this._sheetRects[_0x9c36fb95] : null;
        if (_0x37cf3f90 != null)
        {
            _0x37cf3f90.localScale = Vector3.one * 0.94f;
            _0x37cf3f90.DOScale(1f, _0x002cd05a.Duration(0.22f)).SetEase(Ease.OutBack).SetLink(_0x37cf3f90.gameObject);
        }
    }

    public const int SheetHowTo = 0;
    [SerializeField]
    private Image _chipHowToBorder;
    [SerializeField]
    private Sprite _stepTapSprite;
    private void _0x7103ed40(int _0x752a2ffa)
    {
        this._0x6947de48();
        this._0x1df854e4(_0x752a2ffa, string.Empty);
        switch (_0x752a2ffa)
        {
            case SheetHowTo:
                this._0x347f199f();
                break;
            case SheetDistricts:
                this._0xeb344a26();
                break;
            case SheetCollection:
                this._0x22138b27();
                break;
            case SheetSkyline:
                this._0xf82d93eb();
                break;
            case SheetMissions:
                this._0x543fd418();
                break;
            case SheetStats:
                this._0x5bcd3922();
                break;
            default:
                this._0x58cc4826();
                break;
        }
    }

    private void _0x5bcd3922()
    {
        if (_0x7815908a._0x03a2c387 <= 0)
        {
            this._0x1df854e4(SheetStats, _0x83a1d515._0x27fa8c33(new byte[36] { 196, 197, 170, 216, 223, 196, 217, 170, 211, 207, 222, 170, 167, 170, 200, 223, 195, 198, 206, 170, 211, 197, 223, 216, 170, 204, 195, 216, 217, 222, 170, 222, 197, 221, 207, 216 }, 138));
            return;
        }

        string[] _0x258d0866 =
        {
            _0x83a1d515._0x27fa8c33(new byte[11] { 16, 23, 1, 6, 114, 26, 23, 27, 21, 26, 6 }, 82),
            _0x83a1d515._0x27fa8c33(new byte[12] { 239, 244, 239, 250, 247, 155, 253, 247, 244, 244, 233, 232 }, 187),
            _0x83a1d515._0x27fa8c33(new byte[13] { 130, 151, 128, 148, 151, 145, 134, 242, 150, 128, 157, 130, 129 }, 210),
            _0x83a1d515._0x27fa8c33(new byte[11] { 234, 237, 251, 252, 136, 251, 252, 250, 237, 233, 227 }, 168),
            _0x83a1d515._0x27fa8c33(new byte[4] { 54, 49, 42, 55 }, 100),
            _0x83a1d515._0x27fa8c33(new byte[12] { 189, 182, 187, 169, 169, 218, 191, 187, 168, 180, 191, 190 }, 250)
        };
        string[] _0x5d94462e =
        {
            _0x7815908a._0x042325e5 + _0x83a1d515._0x27fa8c33(new byte[2] { 198, 160 }, 230),
            _0x7815908a.Thousands(_0x7815908a._0x2bf2c764),
            _0x7815908a.Thousands(_0x7815908a._0xe3f42192),
            _0x83a1d515._0x27fa8c33(new byte[1] { 14 }, 118) + _0x7815908a._0x4cbdf272,
            _0x7815908a.Thousands(_0x7815908a._0x03a2c387),
            _0x7815908a.Thousands(_0x5a9a28e3._0xbe8fc6df._0x878e04e0)
        };
        Color[] _0x5dc215aa =
        {
            _0x5219e5ac.Accent,
            _0x5219e5ac.Secondary,
            _0x5219e5ac.Accent,
            _0x5219e5ac.Secondary,
            _0x5219e5ac.TextPrimary,
            _0x5219e5ac.Accent
        };
        for (int _0xbde8e9c4 = 0; _0xbde8e9c4 < 6; _0xbde8e9c4++)
        {
            int _0xcc4eb912 = _0xbde8e9c4 % 2;
            int _0xbbf28e68 = _0xbde8e9c4 / 2;
            _0x084c8230 _0x392d69a6 = this._0xf841c103(SheetStats, new Vector2(470f, 220f), new Vector2(-250f + _0xcc4eb912 * 500f, 400f - _0xbbf28e68 * 250f));
            if (_0x392d69a6 == null)
                continue;
            _0x392d69a6._0x76db2939(null, _0x5219e5ac.TextPrimary);
            _0x392d69a6._0x0894e786(string.Empty, _0x5219e5ac.TextPrimary, 32f);
            _0x392d69a6._0x1d43a85b(_0x5d94462e[_0xbde8e9c4], _0x5dc215aa[_0xbde8e9c4], 56f);
            _0x392d69a6._0x24e258ad(_0x258d0866[_0xbde8e9c4], _0x5219e5ac.TextSecondary, 28f);
            _0x392d69a6._0x76ae1526(-1f, _0x5219e5ac.Secondary);
            _0x392d69a6._0x6077426a();
            _0x392d69a6._0x58f51a2a(_0x5219e5ac.With(_0x5219e5ac.Surface, 0.62f), _0x5dc215aa[_0xbde8e9c4]);
        }
    }

    [SerializeField]
    private Button[] _sheetCloses;
    [SerializeField]
    private TMP_Text[] _sheetEmpty;
    [SerializeField]
    private GameObject _scrim;
    [SerializeField]
    private Button _chipMissions;
    [SerializeField]
    private GameObject _cardPrefab;
    public const int SheetDistricts = 1;
    [SerializeField]
    private Button _chipSkyline;
    [SerializeField]
    private Image _scrimImage;
    [SerializeField]
    private Sprite _buildingSprite;
    private _0x084c8230 _0xf841c103(int _0x5f2c5e07, Vector2 _0x4e9f0b0f, Vector2 _0xce55fa50)
    {
        if (this._cardPrefab == null || this._sheetBodies == null || _0x5f2c5e07 >= this._sheetBodies.Length)
            return null;
        RectTransform _0x782d2add = this._sheetBodies[_0x5f2c5e07];
        if (_0x782d2add == null)
            return null;
        GameObject _0x3ac952cf = Instantiate(this._cardPrefab, _0x782d2add, false);
        this._0xff6ec615.Add(_0x3ac952cf);
        _0x084c8230 _0x1cf15d5d = _0x3ac952cf.GetComponent<_0x084c8230>();
        if (_0x1cf15d5d == null)
            return null;
        _0x1cf15d5d._0xf1eb017c();
        _0x1cf15d5d._0xa6f10735(_0x782d2add, _0x4e9f0b0f, _0xce55fa50);
        _0x1cf15d5d._0x58f51a2a(_0x5219e5ac.With(_0x5219e5ac.Surface, 0.62f), _0x5219e5ac.With(_0x5219e5ac.Secondary, 0.5f));
        return _0x1cf15d5d;
    }

    private void _0x44923a6d(Button _0x4429cd09, int _0xed4efd79)
    {
        if (_0x4429cd09 != null)
            _0x4429cd09.onClick.AddListener(() => this._0x855245b3(_0xed4efd79));
    }

    [SerializeField]
    private Button _chipDistricts;
    [SerializeField]
    private Button _glyphStats;
    [SerializeField]
    private RectTransform[] _sheetRects;
    private void _0x7400f1b8(int _0x1fdd077c, string _0xc72e7f8e, bool _0x23036f5f, string _0x760c231e)
    {
        _0x084c8230 _0x6d4d3dfd = this._0xf841c103(SheetSettings, new Vector2(980f, 220f), new Vector2(0f, 430f - _0x1fdd077c * 250f));
        if (_0x6d4d3dfd == null)
            return;
        _0x6d4d3dfd._0x76db2939(null, _0x5219e5ac.TextPrimary);
        _0x6d4d3dfd._0x0894e786(_0xc72e7f8e, _0x5219e5ac.TextPrimary, 42f);
        _0x6d4d3dfd._0x1d43a85b(string.Empty, _0x5219e5ac.TextPrimary, 40f);
        _0x6d4d3dfd._0x24e258ad(_0x760c231e, _0x5219e5ac.TextSecondary, 28f);
        _0x6d4d3dfd._0x76ae1526(-1f, _0x5219e5ac.Secondary);
        _0x6d4d3dfd._0xd7a8bc2b(_0x23036f5f, _0xae21ba7c.Selected().Accent);
        if (_0x6d4d3dfd._0xb3ae4394 != null)
            _0x6d4d3dfd._0xb3ae4394.onClick.AddListener(() => this._0x2ddf6882(_0x1fdd077c, _0x6d4d3dfd));
    }

    public void _0xa1a7ec20()
    {
        if (this._0xf097dfdb < 0)
            return;
        this._sheets[this._0xf097dfdb]._0x77a3fb66();
        this._0xf097dfdb = -1;
        if (this._scrim != null)
            this._scrim.SetActive(false);
        this._0x6947de48();
    }

    private readonly List<GameObject> _0xff6ec615 = new List<GameObject>();
    private void _0x58cc4826()
    {
        this._0x7400f1b8(0, _0x83a1d515._0x27fa8c33(new byte[7] { 87, 94, 79, 75, 86, 92, 76 }, 31), _0x002cd05a._0x00a98ad2, _0x83a1d515._0x27fa8c33(new byte[26] { 134, 135, 140, 233, 139, 156, 147, 147, 233, 134, 135, 233, 136, 233, 153, 140, 155, 143, 140, 138, 157, 233, 141, 155, 134, 153 }, 201));
        this._0x7400f1b8(1, _0x83a1d515._0x27fa8c33(new byte[14] { 30, 9, 8, 25, 15, 9, 8, 108, 1, 3, 24, 5, 3, 2 }, 76), _0x002cd05a._0xa31c7051, _0x83a1d515._0x27fa8c33(new byte[24] { 53, 46, 41, 52, 50, 35, 52, 70, 50, 49, 35, 35, 40, 53, 74, 70, 40, 41, 70, 34, 52, 47, 32, 50 }, 102));
        this._0x7400f1b8(2, _0x83a1d515._0x27fa8c33(new byte[21] { 82, 83, 93, 82, 55, 89, 85, 84, 78, 72, 91, 73, 78, 58, 74, 95, 72, 92, 95, 89, 78 }, 26), _0x002cd05a._0xc0e0e5e0, _0x83a1d515._0x27fa8c33(new byte[24] { 0, 26, 2, 13, 99, 5, 15, 2, 16, 11, 99, 19, 15, 22, 16, 99, 2, 99, 14, 2, 17, 8, 6, 17 }, 67));
        _0x084c8230 _0xcf11cdb6 = this._0xf841c103(SheetSettings, new Vector2(980f, 220f), new Vector2(0f, -140f));
        if (_0xcf11cdb6 == null)
            return;
        _0xcf11cdb6._0x76db2939(null, _0x5219e5ac.TextPrimary);
        _0xcf11cdb6._0x0894e786(_0x83a1d515._0x27fa8c33(new byte[14] { 89, 78, 88, 78, 95, 43, 91, 89, 68, 76, 89, 78, 88, 88 }, 11), _0x5219e5ac.Accent, 42f);
        _0xcf11cdb6._0x1d43a85b(string.Empty, _0x5219e5ac.TextPrimary, 40f);
        _0xcf11cdb6._0x24e258ad(_0x83a1d515._0x27fa8c33(new byte[33] { 205, 218, 201, 219, 205, 219, 168, 205, 222, 205, 218, 209, 168, 220, 199, 223, 205, 218, 168, 209, 199, 221, 168, 192, 201, 222, 205, 168, 202, 221, 193, 196, 220 }, 136), _0x5219e5ac.TextSecondary, 28f);
        _0xcf11cdb6._0x76ae1526(-1f, _0x5219e5ac.Secondary);
        _0xcf11cdb6._0x6077426a();
        if (_0xcf11cdb6._0xb3ae4394 != null)
            _0xcf11cdb6._0xb3ae4394.onClick.AddListener(() => this._0xff03444d(_0xcf11cdb6));
    }

    private void _0xf82d93eb()
    {
        string[] _0xeaf3538a =
        {
            _0x83a1d515._0x27fa8c33(new byte[3] { 1, 25, 11 }, 82),
            _0x83a1d515._0x27fa8c33(new byte[10] { 198, 205, 192, 210, 210, 161, 213, 200, 207, 213 }, 129),
            _0x83a1d515._0x27fa8c33(new byte[5] { 146, 131, 144, 159, 148 }, 209)
        };
        for (int _0x9d3aa1cb = 0; _0x9d3aa1cb < _0xeaf3538a.Length; _0x9d3aa1cb++)
        {
            int _0xb394f64d = _0x9d3aa1cb;
            _0x084c8230 _0xaecfe000 = this._0xf841c103(SheetSkyline, new Vector2(980f, 260f), new Vector2(0f, 420f - _0x9d3aa1cb * 290f));
            if (_0xaecfe000 == null)
                continue;
            _0xaecfe000._0x76db2939(null, _0x5219e5ac.TextPrimary);
            _0xaecfe000._0x0894e786(_0xeaf3538a[_0x9d3aa1cb], _0x5219e5ac.TextPrimary, 44f);
            _0xaecfe000._0x1d43a85b(this._0xf90f387f(this._0x7d88a361), _0xae21ba7c.Selected().Accent, 40f);
            _0xaecfe000._0x24e258ad(_0x83a1d515._0x27fa8c33(new byte[22] { 159, 138, 155, 235, 159, 132, 235, 136, 146, 136, 135, 142, 235, 159, 131, 142, 235, 152, 131, 138, 143, 142 }, 203), _0x5219e5ac.TextSecondary, 28f);
            _0xaecfe000._0x76ae1526(-1f, _0x5219e5ac.Secondary);
            _0xaecfe000._0x6077426a();
            if (_0xaecfe000._0xb3ae4394 != null)
                _0xaecfe000._0xb3ae4394.onClick.AddListener(() => this._0x50c03361(_0xb394f64d, _0xaecfe000));
        }
    }

    [SerializeField]
    private _0xea655647 _header;
    private void _0x1df854e4(int _0x3bd75bd3, string _0x946f8144)
    {
        if (this._sheetEmpty == null || _0x3bd75bd3 >= this._sheetEmpty.Length)
            return;
        TMP_Text _0xb0ee5d53 = this._sheetEmpty[_0x3bd75bd3];
        if (_0xb0ee5d53 == null)
            return;
        bool _0xcd6d5f38 = !string.IsNullOrEmpty(_0x946f8144);
        _0xb0ee5d53.gameObject.SetActive(_0xcd6d5f38);
        if (_0xcd6d5f38)
            _0xeea80888.Apply(_0xb0ee5d53, _0x946f8144, 36f, _0x5219e5ac.TextSecondary);
    }

    [SerializeField]
    private Button _chipCollection;
    private int _0xf097dfdb = -1;
    private void _0x543fd418()
    {
        int _0x7d37da76 = (int)(System.DateTime.UtcNow.Date.Ticks / System.TimeSpan.TicksPerDay);
        List<_0xea666a49> _0xe992ff91 = _0x38a6c9ac.DrawDaily(_0x7d37da76);
        for (int _0xc9b20f68 = 0; _0xc9b20f68 < _0xe992ff91.Count; _0xc9b20f68++)
        {
            _0xea666a49 _0x8949a0e5 = _0xe992ff91[_0xc9b20f68];
            _0x084c8230 _0x344c99d7 = this._0xf841c103(SheetMissions, new Vector2(980f, 240f), new Vector2(0f, 430f - _0xc9b20f68 * 270f));
            if (_0x344c99d7 == null)
                continue;
            _0x344c99d7._0x76db2939(null, _0x5219e5ac.TextPrimary);
            _0x344c99d7._0x0894e786(_0x83a1d515._0x27fa8c33(new byte[5] { 125, 102, 109, 104, 112 }, 41), _0x5219e5ac.Secondary, 30f);
            _0x344c99d7._0x1d43a85b(_0x8949a0e5.Label, _0x5219e5ac.TextPrimary, 38f);
            _0x344c99d7._0x24e258ad(_0x83a1d515._0x27fa8c33(new byte[1] { 115 }, 88) + _0x8949a0e5.Reward + _0x83a1d515._0x27fa8c33(new byte[6] { 145, 246, 253, 240, 226, 226 }, 177), _0x5219e5ac.Accent, 28f);
            _0x344c99d7._0x76ae1526(0f, _0x5219e5ac.Secondary);
            _0x344c99d7._0x6077426a();
        }

        _0x084c8230 _0x087b7870 = this._0xf841c103(SheetMissions, new Vector2(980f, 180f), new Vector2(0f, -500f));
        if (_0x087b7870 != null)
        {
            _0x087b7870._0x76db2939(null, _0x5219e5ac.TextPrimary);
            _0x087b7870._0x0894e786(_0x83a1d515._0x27fa8c33(new byte[8] { 184, 164, 165, 191, 204, 190, 185, 162 }, 236), _0x5219e5ac.Secondary, 30f);
            _0x087b7870._0x1d43a85b(_0x83a1d515._0x27fa8c33(new byte[36] { 58, 57, 33, 78, 35, 39, 61, 61, 39, 33, 32, 61, 78, 47, 60, 43, 78, 42, 60, 47, 57, 32, 78, 57, 38, 43, 32, 78, 55, 33, 59, 78, 62, 34, 47, 55 }, 110), _0x5219e5ac.TextPrimary, 32f);
            _0x087b7870._0x24e258ad(_0x83a1d515._0x27fa8c33(new byte[25] { 85, 73, 68, 88, 33, 66, 73, 64, 79, 70, 68, 33, 68, 87, 68, 83, 88, 33, 64, 85, 85, 68, 76, 81, 85 }, 1), _0x5219e5ac.TextSecondary, 26f);
            _0x087b7870._0x76ae1526(-1f, _0x5219e5ac.Secondary);
            _0x087b7870._0x6077426a();
        }
    }

    private void _0x2ddf6882(int _0x5e85b2cc, _0x084c8230 _0x49041532)
    {
        if (_0x5e85b2cc == 0)
        {
            _0x002cd05a._0x00a98ad2 = !_0x002cd05a._0x00a98ad2;
            _0x002cd05a.Buzz();
            _0x49041532._0xd7a8bc2b(_0x002cd05a._0x00a98ad2, _0xae21ba7c.Selected().Accent);
        }
        else if (_0x5e85b2cc == 1)
        {
            _0x002cd05a._0xa31c7051 = !_0x002cd05a._0xa31c7051;
            _0x49041532._0xd7a8bc2b(_0x002cd05a._0xa31c7051, _0xae21ba7c.Selected().Accent);
            if (this._header != null)
                this._header._0xa5f1a700();
        }
        else
        {
            _0x002cd05a._0xc0e0e5e0 = !_0x002cd05a._0xc0e0e5e0;
            _0x49041532._0xd7a8bc2b(_0x002cd05a._0xc0e0e5e0, _0xae21ba7c.Selected().Accent);
            _0x49041532._0x24e258ad(_0x002cd05a._0xc0e0e5e0 ? _0x83a1d515._0x27fa8c33(new byte[24] { 248, 226, 250, 245, 155, 253, 247, 250, 232, 243, 155, 235, 247, 238, 232, 155, 250, 155, 246, 250, 233, 240, 254, 233 }, 187) : _0x83a1d515._0x27fa8c33(new byte[10] { 109, 101, 102, 110, 10, 108, 102, 107, 121, 98 }, 42), _0x002cd05a._0x3e16228f, 28f);
        }
    }

    [SerializeField]
    private Button _chipHowTo;
    private static readonly string[] _0x47533bcf =
    {
        _0x83a1d515._0x27fa8c33(new byte[12] { 161, 166, 190, 201, 189, 166, 201, 171, 188, 160, 165, 173 }, 233),
        _0x83a1d515._0x27fa8c33(new byte[9] { 2, 15, 21, 18, 20, 15, 5, 18, 21 }, 70),
        _0x83a1d515._0x27fa8c33(new byte[10] { 60, 48, 51, 51, 58, 60, 43, 54, 48, 49 }, 127),
        _0x83a1d515._0x27fa8c33(new byte[9] { 120, 114, 111, 98, 27, 111, 114, 117, 111 }, 59),
        _0x83a1d515._0x27fa8c33(new byte[10] { 21, 30, 23, 26, 26, 19, 24, 17, 19, 5 }, 86),
        _0x83a1d515._0x27fa8c33(new byte[10] { 76, 75, 94, 75, 86, 76, 75, 86, 92, 76 }, 31),
        _0x83a1d515._0x27fa8c33(new byte[8] { 190, 168, 185, 185, 164, 163, 170, 190 }, 237)
    };
    private void _0x22138b27()
    {
        int _0x019a50bb = _0x7815908a._0x6f9aefc8;
        if (_0x019a50bb <= 0)
        {
            this._0x1df854e4(SheetCollection, _0x83a1d515._0x27fa8c33(new byte[54] { 95, 94, 69, 89, 88, 95, 86, 49, 68, 95, 93, 94, 82, 90, 84, 85, 49, 72, 84, 69, 49, 60, 49, 87, 88, 95, 88, 66, 89, 49, 80, 49, 67, 68, 95, 49, 69, 94, 49, 84, 80, 67, 95, 49, 80, 49, 83, 68, 88, 93, 85, 88, 95, 86 }, 17));
            return;
        }

        int _0x54423bc3 = _0x019a50bb > 9 ? 9 : _0x019a50bb;
        for (int _0xa4c93de8 = 0; _0xa4c93de8 < _0x54423bc3; _0xa4c93de8++)
        {
            int _0x4b41e55f = _0xa4c93de8 % 3;
            int _0x93b40923 = _0xa4c93de8 / 3;
            _0x084c8230 _0x9991d0b0 = this._0xf841c103(SheetCollection, new Vector2(300f, 380f), new Vector2(-320f + _0x4b41e55f * 320f, 420f - _0x93b40923 * 410f));
            if (_0x9991d0b0 == null)
                continue;
            _0x9991d0b0._0x76db2939(this._buildingSprite, _0x5219e5ac.With(_0xae21ba7c.All()[_0xa4c93de8 % 3].Accent, 1f));
            _0x9991d0b0._0x0894e786(_0x83a1d515._0x27fa8c33(new byte[6] { 45, 54, 46, 60, 43, 89 }, 121) + (_0xa4c93de8 + 1), _0x5219e5ac.TextPrimary, 32f);
            _0x9991d0b0._0x1d43a85b(string.Empty, _0x5219e5ac.TextPrimary, 32f);
            _0x9991d0b0._0x24e258ad(_0x83a1d515._0x27fa8c33(new byte[6] { 255, 251, 232, 244, 255, 254 }, 186), _0x5219e5ac.TextSecondary, 26f);
            _0x9991d0b0._0x76ae1526(-1f, _0x5219e5ac.Secondary);
            _0x9991d0b0._0x6077426a();
        }
    }

    private void _0x6947de48()
    {
        for (int _0x3899544c = 0; _0x3899544c < this._0xff6ec615.Count; _0x3899544c++)
            if (this._0xff6ec615[_0x3899544c] != null)
                Destroy(this._0xff6ec615[_0x3899544c]);
        this._0xff6ec615.Clear();
    }

    private void _0xeb344a26()
    {
        _0x226c8314[] _0x5732f6b8 = _0xae21ba7c.All();
        for (int _0x048988c3 = 0; _0x048988c3 < _0x5732f6b8.Length; _0x048988c3++)
        {
            int _0x62b75fa9 = _0x048988c3;
            _0x226c8314 _0x6c6036e1 = _0x5732f6b8[_0x048988c3];
            bool _0x2066322b = _0xae21ba7c.IsUnlocked(_0x048988c3);
            _0x084c8230 _0x6adbaa3d = this._0xf841c103(SheetDistricts, new Vector2(980f, 300f), new Vector2(0f, 420f - _0x048988c3 * 330f));
            if (_0x6adbaa3d == null)
                continue;
            Sprite _0x9a8b95af = this._districtSprites != null && _0x6c6036e1.ThumbIndex < this._districtSprites.Length ? this._districtSprites[_0x6c6036e1.ThumbIndex] : null;
            _0x6adbaa3d._0x76db2939(_0x9a8b95af, _0x2066322b ? Color.white : _0x5219e5ac.With(_0x5219e5ac.Surface, 1f));
            _0x6adbaa3d._0x0894e786(_0x6c6036e1.Title, _0x2066322b ? _0x6c6036e1.Accent : _0x5219e5ac.TextSecondary, 46f);
            _0x6adbaa3d._0x1d43a85b(_0x2066322b ? _0x83a1d515._0x27fa8c33(new byte[5] { 196, 195, 213, 210, 166 }, 134) + _0x7815908a._0x042325e5 + _0x83a1d515._0x27fa8c33(new byte[2] { 189, 219 }, 157) : _0x83a1d515._0x27fa8c33(new byte[6] { 108, 111, 99, 107, 101, 100 }, 32), _0x5219e5ac.TextPrimary, 40f);
            _0x6adbaa3d._0x24e258ad(_0x2066322b ? _0x6c6036e1.Blurb : _0x83a1d515._0x27fa8c33(new byte[10] { 83, 72, 74, 73, 69, 77, 38, 71, 82, 38 }, 6) + _0x6c6036e1.UnlockAt + _0x83a1d515._0x27fa8c33(new byte[2] { 8, 110 }, 40), _0x5219e5ac.TextSecondary, 30f);
            _0x6adbaa3d._0x76ae1526(-1f, _0x6c6036e1.Accent);
            _0x6adbaa3d._0x6077426a();
            if (_0x6adbaa3d._0xb3ae4394 != null)
                _0x6adbaa3d._0xb3ae4394.onClick.AddListener(() => this._0x736c94d3(_0x62b75fa9, _0x6adbaa3d));
        }
    }

    private int _0x7d88a361;
    private void Start()
    {
        for (int _0x6fc6abdc = 0; _0x6fc6abdc < this._sheets.Length; _0x6fc6abdc++)
        {
            if (this._sheets[_0x6fc6abdc] != null)
                this._sheets[_0x6fc6abdc]._0x77a3fb66();
            if (this._sheetTitles != null && _0x6fc6abdc < this._sheetTitles.Length)
                _0xeea80888.Apply(this._sheetTitles[_0x6fc6abdc], _0x47533bcf[_0x6fc6abdc], 48f, _0x5219e5ac.TextPrimary);
        }

        if (this._scrim != null)
            this._scrim.SetActive(false);
        this._0x44923a6d(this._chipDistricts, SheetDistricts);
        this._0x44923a6d(this._chipMissions, SheetMissions);
        this._0x44923a6d(this._chipSkyline, SheetSkyline);
        this._0x44923a6d(this._chipHowTo, SheetHowTo);
        this._0x44923a6d(this._chipCollection, SheetCollection);
        this._0x44923a6d(this._glyphStats, SheetStats);
        this._0x44923a6d(this._glyphSettings, SheetSettings);
        if (this._sheetCloses != null)
            for (int _0x511eb708 = 0; _0x511eb708 < this._sheetCloses.Length; _0x511eb708++)
                if (this._sheetCloses[_0x511eb708] != null)
                    this._sheetCloses[_0x511eb708].onClick.AddListener(() => this._0xa1a7ec20());
        if (_0x7815908a._0x03a2c387 == 0 && this._chipHowToBorder != null && !_0x002cd05a._0xa31c7051)
            this._chipHowToBorder.DOFade(0.9f, 1.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._chipHowToBorder.gameObject);
    }

    public const int SheetMissions = 4;
    private void _0x50c03361(int _0x0b320362, _0x084c8230 _0x7e4aa71c)
    {
        this._0x7d88a361 = (this._0x7d88a361 + 1) % 3;
        if (_0x7e4aa71c != null)
            _0x7e4aa71c._0x1d43a85b(this._0xf90f387f(this._0x7d88a361), _0xae21ba7c.Selected().Accent, 40f);
        if (this._header != null)
            this._header._0xce575453(this._0x7d88a361);
    }

    [SerializeField]
    private Sprite _stepSweepSprite;
    private string _0xf90f387f(int _0xa9296b07)
    {
        switch (_0xa9296b07 % 3)
        {
            case 1:
                return _0x83a1d515._0x27fa8c33(new byte[5] { 171, 167, 168, 175, 184 }, 234);
            case 2:
                return _0x83a1d515._0x27fa8c33(new byte[3] { 110, 100, 98 }, 39);
            default:
                return _0x83a1d515._0x27fa8c33(new byte[6] { 26, 19, 0, 16, 29, 0 }, 82);
        }
    }

    [SerializeField]
    private Sprite[] _districtSprites;
    private void _0x736c94d3(int _0x1101cf9e, _0x084c8230 _0x9ab5b895)
    {
        if (!_0xae21ba7c.IsUnlocked(_0x1101cf9e))
        {
            if (_0x9ab5b895 != null)
                _0x9ab5b895.transform.DOShakePosition(_0x002cd05a.Duration(0.24f), new Vector3(8f, 0f, 0f), 12, 0f).SetLink(_0x9ab5b895.gameObject);
            return;
        }

        _0x7815908a._0x96d1c0ce = _0x1101cf9e;
        if (this._header != null)
            this._header._0xa33d6b57();
        this._0xa1a7ec20();
    }

    private void _0x347f199f()
    {
        Sprite[] _0x0541d973 =
        {
            this._stepSweepSprite,
            this._stepTapSprite,
            this._stepTrimSprite
        };
        string[] _0xb720ab06 =
        {
            _0x83a1d515._0x27fa8c33(new byte[5] { 61, 57, 39, 32, 41 }, 110),
            _0x83a1d515._0x27fa8c33(new byte[3] { 199, 210, 195 }, 147),
            _0x83a1d515._0x27fa8c33(new byte[4] { 30, 24, 3, 7 }, 74)
        };
        string[] _0x57f964a7 =
        {
            _0x83a1d515._0x27fa8c33(new byte[29] { 56, 89, 63, 53, 54, 54, 43, 89, 42, 46, 48, 55, 62, 42, 89, 54, 47, 60, 43, 89, 45, 49, 60, 89, 45, 54, 46, 60, 43 }, 121),
            _0x83a1d515._0x27fa8c33(new byte[23] { 200, 221, 204, 188, 221, 210, 197, 203, 212, 217, 206, 217, 188, 200, 211, 188, 216, 206, 211, 204, 188, 213, 200 }, 156),
            _0x83a1d515._0x27fa8c33(new byte[27] { 242, 237, 228, 241, 133, 237, 228, 235, 226, 246, 133, 234, 243, 224, 247, 133, 236, 246, 133, 230, 240, 241, 133, 228, 242, 228, 252 }, 165)
        };
        for (int _0x864a2e17 = 0; _0x864a2e17 < 3; _0x864a2e17++)
        {
            _0x084c8230 _0x1bc13cb7 = this._0xf841c103(SheetHowTo, new Vector2(980f, 300f), new Vector2(0f, 420f - _0x864a2e17 * 330f));
            if (_0x1bc13cb7 == null)
                continue;
            _0x1bc13cb7._0x76db2939(_0x0541d973[_0x864a2e17], _0x5219e5ac.TextPrimary);
            _0x1bc13cb7._0x0894e786(_0xb720ab06[_0x864a2e17], _0x5219e5ac.Accent, 46f);
            _0x1bc13cb7._0x1d43a85b(string.Empty, _0x5219e5ac.TextPrimary, 40f);
            _0x1bc13cb7._0x24e258ad(_0x57f964a7[_0x864a2e17], _0x5219e5ac.TextSecondary, 32f);
            _0x1bc13cb7._0x76ae1526(-1f, _0x5219e5ac.Secondary);
            _0x1bc13cb7._0x6077426a();
        }

        _0x084c8230 _0x888469a2 = this._0xf841c103(SheetHowTo, new Vector2(980f, 160f), new Vector2(0f, -600f));
        if (_0x888469a2 != null)
        {
            _0x888469a2._0x76db2939(null, _0x5219e5ac.TextPrimary);
            _0x888469a2._0x0894e786(_0x83a1d515._0x27fa8c33(new byte[34] { 145, 141, 151, 128, 128, 229, 134, 137, 128, 132, 139, 229, 129, 151, 138, 149, 150, 229, 146, 140, 129, 128, 139, 229, 145, 141, 128, 229, 146, 140, 139, 129, 138, 146 }, 197), _0x5219e5ac.Accent, 36f);
            _0x888469a2._0x1d43a85b(string.Empty, _0x5219e5ac.TextPrimary, 36f);
            _0x888469a2._0x24e258ad(_0x83a1d515._0x27fa8c33(new byte[21] { 136, 134, 134, 147, 227, 151, 139, 134, 227, 144, 151, 130, 128, 136, 227, 139, 140, 141, 134, 144, 151 }, 195), _0x5219e5ac.TextSecondary, 30f);
            _0x888469a2._0x76ae1526(-1f, _0x5219e5ac.Secondary);
            _0x888469a2._0x6077426a();
        }
    }

    public const int SheetStats = 5;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
        if (this._chipHowToBorder != null)
            DOTween.Kill(this._chipHowToBorder);
    }

    public const int SheetCollection = 2;
    private void _0xff03444d(_0x084c8230 _0xeba1af39)
    {
        _0x7815908a.ResetEverything();
        if (this._header != null)
            this._header._0xe6d63068();
        if (_0xeba1af39 != null)
        {
            _0xeba1af39._0x24e258ad(_0x83a1d515._0x27fa8c33(new byte[15] { 49, 51, 46, 38, 51, 36, 50, 50, 65, 36, 51, 32, 50, 36, 37 }, 97), _0x5219e5ac.Accent, 28f);
            _0xeba1af39.transform.localScale = Vector3.one;
            _0xeba1af39.transform.DOPunchScale(Vector3.one * 0.04f, _0x002cd05a.Duration(0.3f), 6, 0.6f).SetLink(_0xeba1af39.gameObject);
        }
    }

    [SerializeField]
    private Button _glyphSettings;
    public const int SheetSkyline = 3;
}

internal static class _0x83a1d515
{
    internal static string _0x27fa8c33(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}