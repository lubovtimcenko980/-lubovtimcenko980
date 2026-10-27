using System.Collections.Generic;

/// <summary>A mission drawn for a run or for the day. Kind decides how progress is measured.</summary>
public sealed class _0xea666a49
{
    public int Target;
    public _0xea666a49 _0x5f088b3f(int _0xef9d1422, int _0xd90262ae, string _0xbcc78d5b, int _0xd5121bf8)
    {
        this.Kind = _0xef9d1422;
        this.Target = _0xd90262ae;
        this.Label = _0xbcc78d5b;
        this.Reward = _0xd5121bf8;
        this.Progress = 0;
        return this;
    }

    public int Reward;
    public float _0x2d174cec()
    {
        if (this.Target <= 0)
            return 0f;
        float _0xfe659609 = (float)this.Progress / this.Target;
        return _0xfe659609 < 0f ? 0f : (_0xfe659609 > 1f ? 1f : _0xfe659609);
    }

    public bool _0x5e5b5a33()
    {
        return this.Progress >= this.Target;
    }

    public string Label;
    public int Kind;
    public int Progress;
}

/// <summary>Six templates; the targets and the reward are drawn from the run seed, never typed.</summary>
public static class _0x38a6c9ac
{
    public const int KindGlass = 4;
    /// <summary>Two different templates per run, drawn — not written out.</summary>
    public static List<_0xea666a49> DrawPair(System.Random _0xc6f23d67)
    {
        int _0x97321228 = _0xc6f23d67.Next(0, 6);
        int _0x45fb2371 = _0xc6f23d67.Next(0, 6);
        if (_0x45fb2371 == _0x97321228)
            _0x45fb2371 = (_0x97321228 + 1 + _0xc6f23d67.Next(0, 5)) % 6;
        List<_0xea666a49> _0x0f327d9a = new List<_0xea666a49>();
        _0x0f327d9a.Add(Draw(_0xc6f23d67, _0x97321228));
        _0x0f327d9a.Add(Draw(_0xc6f23d67, _0x45fb2371));
        return _0x0f327d9a;
    }

    public const int KindPerfectRow = 1;
    public static _0xea666a49 Draw(System.Random _0x3263781a, int _0x32f3770b)
    {
        switch (_0x32f3770b)
        {
            case KindPerfectRow:
            {
                int _0x1fedd499 = _0x3263781a.Next(3, 7);
                return new _0xea666a49()._0x5f088b3f(_0x32f3770b, _0x1fedd499, _0x39e4ce66._0xb3c71471(new byte[5] { 221, 208, 223, 213, 177 }, 145) + _0x1fedd499 + _0x39e4ce66._0xb3c71471(new byte[17] { 156, 236, 249, 238, 250, 249, 255, 232, 156, 245, 242, 156, 253, 156, 238, 243, 235 }, 188), 120 + _0x1fedd499 * 20);
            }

            case KindWideAt:
            {
                int _0x6616a702 = _0x3263781a.Next(8, 13);
                return new _0xea666a49()._0x5f088b3f(_0x32f3770b, _0x6616a702, _0x39e4ce66._0xb3c71471(new byte[23] { 191, 177, 177, 164, 212, 163, 189, 176, 160, 188, 212, 187, 162, 177, 166, 212, 194, 196, 209, 212, 181, 160, 212 }, 244) + _0x6616a702 + _0x39e4ce66._0xb3c71471(new byte[2] { 38, 64 }, 6), 150 + _0x6616a702 * 10);
            }

            case KindNoSupport:
            {
                int _0xdddcf4f0 = _0x3263781a.Next(14, 21);
                return new _0xea666a49()._0x5f088b3f(_0x32f3770b, _0xdddcf4f0, _0x39e4ce66._0xb3c71471(new byte[6] { 192, 199, 210, 208, 216, 179 }, 147) + _0xdddcf4f0 + _0x39e4ce66._0xb3c71471(new byte[24] { 161, 199, 161, 214, 200, 213, 201, 161, 207, 206, 161, 210, 212, 209, 209, 206, 211, 213, 161, 210, 209, 196, 207, 213 }, 129), 160 + _0xdddcf4f0 * 6);
            }

            case KindGlass:
            {
                int _0x56c007b6 = _0x3263781a.Next(180, 321);
                return new _0xea666a49()._0x5f088b3f(_0x32f3770b, _0x56c007b6, _0x39e4ce66._0xb3c71471(new byte[5] { 102, 98, 113, 109, 3 }, 35) + _0x56c007b6 + _0x39e4ce66._0xb3c71471(new byte[17] { 126, 25, 18, 31, 13, 13, 126, 23, 16, 126, 17, 16, 27, 126, 12, 11, 16 }, 94), 140 + _0x56c007b6 / 4);
            }

            case KindCleanFloors:
            {
                int _0x18d75678 = _0x3263781a.Next(6, 10);
                return new _0xea666a49()._0x5f088b3f(_0x32f3770b, _0x18d75678, _0x39e4ce66._0xb3c71471(new byte[6] { 33, 46, 39, 35, 48, 66 }, 98) + _0x18d75678 + _0x39e4ce66._0xb3c71471(new byte[19] { 90, 60, 90, 45, 51, 46, 50, 90, 52, 53, 90, 56, 51, 61, 90, 46, 40, 51, 55 }, 122), 130 + _0x18d75678 * 18);
            }

            default:
            {
                int _0x277a15a5 = _0x3263781a.Next(10, 17);
                return new _0xea666a49()._0x5f088b3f(_0x32f3770b, _0x277a15a5, _0x39e4ce66._0xb3c71471(new byte[6] { 28, 11, 15, 13, 6, 110 }, 78) + _0x277a15a5 + _0x39e4ce66._0xb3c71471(new byte[2] { 128, 230 }, 160), 120 + _0x277a15a5 * 12);
            }
        }
    }

    public const int KindHeight = 0;
    public const int KindCleanFloors = 5;
    public const int KindNoSupport = 3;
    /// <summary>Three challenges for the day, stable for that day because the seed is the day.</summary>
    public static List<_0xea666a49> DrawDaily(int _0x60d413ee)
    {
        System.Random _0xc178ef1a = new System.Random(_0x60d413ee * 31337 + 911);
        List<_0xea666a49> _0xd8f508e2 = new List<_0xea666a49>();
        int _0x97be5e95 = -1;
        for (int _0x726bd80b = 0; _0x726bd80b < 3; _0x726bd80b++)
        {
            int _0x1b8a58db = _0xc178ef1a.Next(0, 6);
            if (_0x1b8a58db == _0x97be5e95)
                _0x1b8a58db = (_0x1b8a58db + 1) % 6;
            _0x97be5e95 = _0x1b8a58db;
            _0xd8f508e2.Add(Draw(_0xc178ef1a, _0x1b8a58db));
        }

        return _0xd8f508e2;
    }

    public const int KindWideAt = 2;
}

internal static class _0x39e4ce66
{
    internal static string _0xb3c71471(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}