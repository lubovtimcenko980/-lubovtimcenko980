using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x5a9a28e3
{
    public static class _0x379e6670
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public class _0x68154f29
    {
        private static readonly _0x68154f29 _0x6b8af0b7 = new();
        public static readonly _0x68154f29[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x6b8af0b7,
            _0x6b8af0b7,
            _0x6b8af0b7,
        };
        private int _0x0a19c985 => 0;
        private int _0x48d3bd88 => 10;
        private string _0x3b0399b7 => _0x087bfa2f._0x522793f0(new byte[4] { 38, 14, 5, 30 }, 107);
        private string _0xcb90a6b7 => _0x087bfa2f._0x522793f0(new byte[8] { 137, 128, 147, 128, 137, 190, 245, 184 }, 197);

        private int _0x4761b27f
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x087bfa2f._0x522793f0(new byte[25] { 206, 248, 255, 255, 232, 227, 249, 202, 225, 226, 239, 236, 225, 206, 229, 236, 253, 249, 232, 255, 196, 227, 233, 232, 245 }, 141)))
                    PlayerPrefs.SetInt(_0x087bfa2f._0x522793f0(new byte[25] { 191, 137, 142, 142, 153, 146, 136, 187, 144, 147, 158, 157, 144, 191, 148, 157, 140, 136, 153, 142, 181, 146, 152, 153, 132 }, 252), 0);
                return PlayerPrefs.GetInt(_0x087bfa2f._0x522793f0(new byte[25] { 40, 30, 25, 25, 14, 5, 31, 44, 7, 4, 9, 10, 7, 40, 3, 10, 27, 31, 14, 25, 34, 5, 15, 14, 19 }, 107));
            }

            set => PlayerPrefs.SetInt(_0x087bfa2f._0x522793f0(new byte[25] { 228, 210, 213, 213, 194, 201, 211, 224, 203, 200, 197, 198, 203, 228, 207, 198, 215, 211, 194, 213, 238, 201, 195, 194, 223 }, 167), value);
        }

        public int _0x75fec8b3
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x3b0399b7}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x3b0399b7}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x3b0399b7}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x3b0399b7}CurrentLevelIndex", value);
        }

        public int _0x9a4de410
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x3b0399b7}BestScore"))
                    this._0x9a4de410 = 0;
                return PlayerPrefs.GetInt($"{this._0x3b0399b7}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x3b0399b7}BestScore", value);
        }

        public bool _0x846ba247
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x3b0399b7}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x3b0399b7}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x3b0399b7}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x3b0399b7}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xbe8fc6df
    {
        public static int _0x878e04e0
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x087bfa2f._0x522793f0(new byte[5] { 189, 145, 151, 144, 141 }, 254)))
                    PlayerPrefs.SetInt(_0x087bfa2f._0x522793f0(new byte[5] { 135, 171, 173, 170, 183 }, 196), 0);
                return PlayerPrefs.GetInt(_0x087bfa2f._0x522793f0(new byte[5] { 138, 166, 160, 167, 186 }, 201));
            }

            set
            {
                PlayerPrefs.SetInt(_0x087bfa2f._0x522793f0(new byte[5] { 104, 68, 66, 69, 88 }, 43), value);
                _0x59a642a8.Instance._0x04683bb5();
            }
        }
    }

    public static class _0xe57848ce
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x52964cd5
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0x087bfa2f
{
    internal static string _0x522793f0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}