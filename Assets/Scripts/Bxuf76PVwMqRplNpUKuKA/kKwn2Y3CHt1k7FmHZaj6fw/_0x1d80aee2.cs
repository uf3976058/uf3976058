using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x1d80aee2
{
    public static class _0xb61edb9b
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

    public class _0xe22f035d
    {
        private static readonly _0xe22f035d _0x53afa00c = new();
        public static readonly _0xe22f035d[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x53afa00c,
            _0x53afa00c,
            _0x53afa00c,
        };
        private int _0x428357ed => 0;
        private int _0x87ac4419 => 10;
        private string _0xaaa680d9 => _0xc07c52a7._0xd392e235(new byte[4] { 228, 204, 199, 220 }, 169);
        private string _0x4285700f => _0xc07c52a7._0xd392e235(new byte[8] { 160, 169, 186, 169, 160, 151, 220, 145 }, 236);

        private int _0xeb1f4ecb
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xc07c52a7._0xd392e235(new byte[25] { 84, 98, 101, 101, 114, 121, 99, 80, 123, 120, 117, 118, 123, 84, 127, 118, 103, 99, 114, 101, 94, 121, 115, 114, 111 }, 23)))
                    PlayerPrefs.SetInt(_0xc07c52a7._0xd392e235(new byte[25] { 52, 2, 5, 5, 18, 25, 3, 48, 27, 24, 21, 22, 27, 52, 31, 22, 7, 3, 18, 5, 62, 25, 19, 18, 15 }, 119), 0);
                return PlayerPrefs.GetInt(_0xc07c52a7._0xd392e235(new byte[25] { 18, 36, 35, 35, 52, 63, 37, 22, 61, 62, 51, 48, 61, 18, 57, 48, 33, 37, 52, 35, 24, 63, 53, 52, 41 }, 81));
            }

            set => PlayerPrefs.SetInt(_0xc07c52a7._0xd392e235(new byte[25] { 40, 30, 25, 25, 14, 5, 31, 44, 7, 4, 9, 10, 7, 40, 3, 10, 27, 31, 14, 25, 34, 5, 15, 14, 19 }, 107), value);
        }

        public int _0xe64019cd
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xaaa680d9}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xaaa680d9}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xaaa680d9}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xaaa680d9}CurrentLevelIndex", value);
        }

        public int _0x968f49ad
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xaaa680d9}BestScore"))
                    this._0x968f49ad = 0;
                return PlayerPrefs.GetInt($"{this._0xaaa680d9}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xaaa680d9}BestScore", value);
        }

        public bool _0xd99c9211
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xaaa680d9}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xaaa680d9}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xaaa680d9}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xaaa680d9}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xd6db5f57
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0xeef67835
    {
        public static int _0x81680469
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xc07c52a7._0xd392e235(new byte[5] { 78, 98, 100, 99, 126 }, 13)))
                    PlayerPrefs.SetInt(_0xc07c52a7._0xd392e235(new byte[5] { 165, 137, 143, 136, 149 }, 230), 0);
                return PlayerPrefs.GetInt(_0xc07c52a7._0xd392e235(new byte[5] { 71, 107, 109, 106, 119 }, 4));
            }

            set
            {
                PlayerPrefs.SetInt(_0xc07c52a7._0xd392e235(new byte[5] { 135, 171, 173, 170, 183 }, 196), value);
                _0xf44d047f.Instance._0xa1c5329d();
            }
        }
    }

    public static class _0x6bf6c866
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0xc07c52a7
{
    internal static string _0xd392e235(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}