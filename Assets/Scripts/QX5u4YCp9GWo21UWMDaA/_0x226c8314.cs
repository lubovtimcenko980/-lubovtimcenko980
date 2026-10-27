using UnityEngine;

/// <summary>One district: accent, score multiplier, unlock threshold, thumbnail slot.
/// Built with Init(...) — no constructors anywhere in generated code (C.59).</summary>
public sealed class _0x226c8314
{
    public Color Accent;
    public _0x226c8314 _0xbaf9154e(string _0x7744313f, string _0xf8b6d4ac, Color _0x0a34f56f, float _0xcf452651, int _0x05cc1dfb, int _0x907a1500)
    {
        this.Title = _0x7744313f;
        this.Blurb = _0xf8b6d4ac;
        this.Accent = _0x0a34f56f;
        this.Multiplier = _0xcf452651;
        this.UnlockAt = _0x05cc1dfb;
        this.ThumbIndex = _0x907a1500;
        return this;
    }

    public float Multiplier;
    public int ThumbIndex;
    public string Blurb;
    public int UnlockAt;
    public string Title;
}

public static class _0xae21ba7c
{
    public static _0x226c8314 Selected()
    {
        _0x226c8314[] _0x52588671 = All();
        int _0x9d5fdd00 = Mathf.Clamp(_0x7815908a._0x96d1c0ce, 0, _0x52588671.Length - 1);
        if (!IsUnlocked(_0x9d5fdd00))
            _0x9d5fdd00 = 0;
        return _0x52588671[_0x9d5fdd00];
    }

    public static bool IsUnlocked(int _0xbf1e7862)
    {
        _0x226c8314[] _0xc3f2174c = All();
        if (_0xbf1e7862 < 0 || _0xbf1e7862 >= _0xc3f2174c.Length)
            return false;
        return _0x7815908a._0x042325e5 >= _0xc3f2174c[_0xbf1e7862].UnlockAt;
    }

    public static int SelectedIndex()
    {
        int _0x7abc6bdb = Mathf.Clamp(_0x7815908a._0x96d1c0ce, 0, Count() - 1);
        return IsUnlocked(_0x7abc6bdb) ? _0x7abc6bdb : 0;
    }

    public static _0x226c8314[] All()
    {
        return new _0x226c8314[]
        {
            new _0x226c8314()._0xbaf9154e(_0x46115b36._0x02cb09b7(new byte[12] { 112, 121, 106, 122, 119, 106, 24, 127, 116, 121, 107, 107 }, 56), _0x46115b36._0x02cb09b7(new byte[20] { 130, 128, 141, 140, 225, 150, 128, 149, 132, 147, 237, 225, 141, 142, 150, 225, 150, 136, 143, 133 }, 193), _0x5219e5ac.Secondary, 1.0f, 0, 0),
            new _0x226c8314()._0xbaf9154e(_0x46115b36._0x02cb09b7(new byte[11] { 201, 195, 220, 195, 201, 170, 217, 218, 195, 196, 207 }, 138), _0x46115b36._0x02cb09b7(new byte[23] { 85, 72, 70, 73, 85, 33, 81, 77, 78, 85, 82, 45, 33, 71, 64, 82, 85, 33, 66, 83, 64, 79, 68 }, 1), _0x5219e5ac.Accent, 1.15f, 20, 1),
            new _0x226c8314()._0xbaf9154e(_0x46115b36._0x02cb09b7(new byte[12] { 45, 38, 44, 45, 67, 55, 38, 49, 49, 34, 32, 38 }, 99), _0x46115b36._0x02cb09b7(new byte[25] { 53, 50, 60, 51, 47, 91, 40, 51, 50, 61, 47, 87, 91, 53, 58, 41, 41, 52, 44, 91, 63, 62, 56, 48, 40 }, 123), _0x5219e5ac.Primary, 1.3f, 34, 2)
        };
    }

    public static int Count()
    {
        return 3;
    }
}

internal static class _0x46115b36
{
    internal static string _0x02cb09b7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}