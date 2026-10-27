using UnityEngine;

/// <summary>PlayerPrefs access. Keys are literals RETURNED FROM METHODS: a const string is
/// turned into a runtime-initialised field by string encryption (C.52), and nameof would be
/// renamed outright.</summary>
public static class _0x7815908a
{
    private static string KeyRuns()
    {
        return _0xb7be131e._0xf91b77d4(new byte[8] { 146, 131, 147, 207, 147, 148, 143, 146 }, 225);
    }

    /// <summary>Count of buildings earned for the collection grid.</summary>
    public static int _0x6f9aefc8
    {
        get
        {
            return PlayerPrefs.GetInt(KeyCollection(), 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyCollection(), value);
        }
    }

    private static string KeyFloors()
    {
        return _0xb7be131e._0xf91b77d4(new byte[10] { 86, 71, 87, 11, 67, 73, 74, 74, 87, 86 }, 37);
    }

    private static string KeyStreak()
    {
        return _0xb7be131e._0xf91b77d4(new byte[10] { 195, 210, 194, 158, 195, 196, 194, 213, 209, 219 }, 176);
    }

    /// <summary>Day index the daily challenges were rolled for.</summary>
    public static int _0x4a9049f9
    {
        get
        {
            return PlayerPrefs.GetInt(KeyMissionDay(), -1);
        }

        set
        {
            PlayerPrefs.SetInt(KeyMissionDay(), value);
        }
    }

    private static string KeyFlags()
    {
        return _0xb7be131e._0xf91b77d4(new byte[9] { 170, 187, 171, 247, 191, 181, 184, 190, 170 }, 217);
    }

    public static int _0x042325e5
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBest(), 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBest(), value);
        }
    }

    public static int _0xe3f42192
    {
        get
        {
            return PlayerPrefs.GetInt(KeyPerfect(), 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyPerfect(), value);
        }
    }

    private static string KeyBest()
    {
        return _0xb7be131e._0xf91b77d4(new byte[8] { 83, 66, 82, 14, 66, 69, 83, 84 }, 32);
    }

    public static int _0x4cbdf272
    {
        get
        {
            return PlayerPrefs.GetInt(KeyStreak(), 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyStreak(), value);
        }
    }

    public static string Thousands(int _0x84b14090)
    {
        string _0x0f552cc4 = Mathf.Abs(_0x84b14090).ToString();
        string _0x36493ec9 = string.Empty;
        int _0x27eb3a52 = 0;
        for (int _0xa7435c7e = _0x0f552cc4.Length - 1; _0xa7435c7e >= 0; _0xa7435c7e--)
        {
            _0x36493ec9 = _0x0f552cc4[_0xa7435c7e] + _0x36493ec9;
            _0x27eb3a52++;
            if (_0x27eb3a52 % 3 == 0 && _0xa7435c7e > 0)
                _0x36493ec9 = _0xb7be131e._0xf91b77d4(new byte[1] { 197 }, 233) + _0x36493ec9;
        }

        return _0x84b14090 < 0 ? _0xb7be131e._0xf91b77d4(new byte[1] { 163 }, 142) + _0x36493ec9 : _0x36493ec9;
    }

    public static void ResetEverything()
    {
        PlayerPrefs.DeleteKey(KeyBest());
        PlayerPrefs.DeleteKey(KeyFloors());
        PlayerPrefs.DeleteKey(KeyPerfect());
        PlayerPrefs.DeleteKey(KeyStreak());
        PlayerPrefs.DeleteKey(KeyRuns());
        PlayerPrefs.DeleteKey(KeyDistrict());
        PlayerPrefs.DeleteKey(KeyCollection());
        PlayerPrefs.DeleteKey(KeyMissionDay());
        _0x5a9a28e3._0xbe8fc6df._0x878e04e0 = 0;
        PlayerPrefs.Save();
    }

    public static int _0x96d1c0ce
    {
        get
        {
            return PlayerPrefs.GetInt(KeyDistrict(), 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyDistrict(), value);
        }
    }

    public static int _0x03a2c387
    {
        get
        {
            return PlayerPrefs.GetInt(KeyRuns(), 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyRuns(), value);
        }
    }

    private static string KeyMissionDay()
    {
        return _0xb7be131e._0xf91b77d4(new byte[12] { 117, 100, 116, 40, 107, 111, 117, 117, 111, 105, 104, 117 }, 6);
    }

    private static string KeyPerfect()
    {
        return _0xb7be131e._0xf91b77d4(new byte[11] { 215, 198, 214, 138, 212, 193, 214, 194, 193, 199, 208 }, 164);
    }

    /// <summary>Bit field: 1 haptics, 2 reduced motion, 4 high contrast.</summary>
    public static int _0xe6c37e23
    {
        get
        {
            return PlayerPrefs.GetInt(KeyFlags(), 1);
        }

        set
        {
            PlayerPrefs.SetInt(KeyFlags(), value);
        }
    }

    public static int _0x2bf2c764
    {
        get
        {
            return PlayerPrefs.GetInt(KeyFloors(), 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyFloors(), value);
        }
    }

    private static string KeyDistrict()
    {
        return _0xb7be131e._0xf91b77d4(new byte[13] { 67, 82, 66, 30, 84, 89, 67, 68, 66, 89, 83, 68, 67 }, 48);
    }

    private static string KeyCollection()
    {
        return _0xb7be131e._0xf91b77d4(new byte[14] { 145, 128, 144, 204, 129, 141, 142, 142, 135, 129, 150, 139, 141, 140 }, 226);
    }
}

internal static class _0xb7be131e
{
    internal static string _0xf91b77d4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}