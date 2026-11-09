using UnityEngine;

/// Three gem albums of six slots each, and the hall each one unlocks.
///
/// A slot fills when its gem is the top symbol of a winning line. Completing an album is
/// visible beyond a label (C.7): the hall banner in the cabinet changes, and the reel trim
/// and backdrop tint move to that hall's colour on the next visit.
public static class _0xcf78378c
{
    /// The highest album the player has completed, or -1 while none is done.
    public static int UnlockedHall()
    {
        int _0xb7a1c99a = -1;
        for (int _0xc30b2488 = 0; _0xc30b2488 < _0xafff65e6.Albums; _0xc30b2488++)
        {
            if (Complete(_0xc30b2488))
            {
                _0xb7a1c99a = _0xc30b2488;
            }
        }

        return _0xb7a1c99a;
    }

    public static bool Filled(int _0xe658993a, int _0x8a6c5b35)
    {
        return PlayerPrefs.GetInt(SlotKey + _0xe658993a + _0xcae1a659._0x3c58e92e(new byte[1] { 244 }, 171) + _0x8a6c5b35, 0) == 1;
    }

    public static string Counter(int _0x5690e273)
    {
        return FilledCount(_0x5690e273) + _0xcae1a659._0x3c58e92e(new byte[3] { 28, 19, 28 }, 60) + _0xafff65e6.AlbumSlots;
    }

    public static int FilledCount(int _0x8fb96cec)
    {
        int _0xa6052098 = 0;
        for (int _0xbd9357e1 = 0; _0xbd9357e1 < _0xafff65e6.AlbumSlots; _0xbd9357e1++)
        {
            if (Filled(_0x8fb96cec, _0xbd9357e1))
            {
                _0xa6052098++;
            }
        }

        return _0xa6052098;
    }

    private static readonly string[] _0x1322bc8d =
    {
        _0xcae1a659._0x3c58e92e(new byte[13] { 182, 186, 178, 163, 191, 174, 164, 163, 215, 191, 182, 187, 187 }, 247),
        _0xcae1a659._0x3c58e92e(new byte[9] { 109, 106, 125, 102, 31, 119, 126, 115, 115 }, 63),
        _0xcae1a659._0x3c58e92e(new byte[10] { 250, 248, 227, 249, 231, 138, 226, 235, 230, 230 }, 170)
    };
    // Which gem each of the six slots of each album wants.
    private static readonly int[][] _0x0862a4f1 =
    {
        new[]
        {
            0,
            0,
            0,
            1,
            1,
            1
        }, // amethyst x3, topaz x3
        new[]
        {
            2,
            2,
            3,
            3,
            4,
            4
        }, // emerald x2, sapphire x2, ruby x2
        new[]
        {
            5,
            5,
            5,
            6,
            6,
            6
        }, // crown x3, prism x3
    };
    public static int SymbolOf(int _0x0b5239da, int _0x17d1c6c7)
    {
        return _0x0862a4f1[_0x0b5239da][_0x17d1c6c7];
    }

    public static bool Complete(int _0x2442ecf0)
    {
        return FilledCount(_0x2442ecf0) >= _0xafff65e6.AlbumSlots;
    }

    public static int TotalFilled()
    {
        int _0xd3374eab = 0;
        for (int _0x227c2722 = 0; _0x227c2722 < _0xafff65e6.Albums; _0x227c2722++)
        {
            _0xd3374eab += FilledCount(_0x227c2722);
        }

        return _0xd3374eab;
    }

    public static Color HallTint(int _0xcb10b7ed)
    {
        if (_0xcb10b7ed >= 2)
        {
            return _0x21179992.Fade(_0x21179992.Mint, 0.16f);
        }

        if (_0xcb10b7ed == 1)
        {
            return _0x21179992.Fade(_0x21179992.GoldDeep, 0.18f);
        }

        return _0x21179992.Fade(_0x21179992.VioletDeep, 0.20f);
    }

    public static string HallName(int _0x4dbcf16c)
    {
        if (_0x4dbcf16c < 0 || _0x4dbcf16c >= _0x1322bc8d.Length)
        {
            return _0x1322bc8d[0];
        }

        return _0x1322bc8d[_0x4dbcf16c];
    }

    /// The hall the cabinet currently wears: the unlocked one, or the first hall by default.
    public static int CurrentHall()
    {
        int _0x1a197cd8 = UnlockedHall();
        return _0x1a197cd8 < 0 ? 0 : _0x1a197cd8;
    }

    /// Credits the first empty slot that wants this gem. Returns the album that just
    /// COMPLETED, or -1 when nothing completed.
    public static int Credit(int _0x325a6838)
    {
        if (_0x325a6838 < 0)
        {
            return -1;
        }

        for (int _0x49520259 = 0; _0x49520259 < _0xafff65e6.Albums; _0x49520259++)
        {
            for (int _0x3ced97ab = 0; _0x3ced97ab < _0xafff65e6.AlbumSlots; _0x3ced97ab++)
            {
                if (_0x0862a4f1[_0x49520259][_0x3ced97ab] != _0x325a6838 || Filled(_0x49520259, _0x3ced97ab))
                {
                    continue;
                }

                PlayerPrefs.SetInt(SlotKey + _0x49520259 + _0xcae1a659._0x3c58e92e(new byte[1] { 97 }, 62) + _0x3ced97ab, 1);
                PlayerPrefs.Save();
                return Complete(_0x49520259) ? _0x49520259 : -1;
            }
        }

        return -1;
    }

    /// All three trims are LIGHT on a dark board, so the cabinet always reads; they differ
    /// enough from each other that completing an album is obvious on a screenshot (C.7).
    public static Color HallTrim(int _0xd7ac9a84)
    {
        if (_0xd7ac9a84 >= 2)
        {
            return _0x21179992.Mint;
        }

        if (_0xd7ac9a84 == 1)
        {
            return _0x21179992.Cream;
        }

        return _0x21179992.Gold;
    }

    private static readonly string SlotKey = _0xcae1a659._0x3c58e92e(new byte[12] { 44, 45, 57, 10, 39, 41, 62, 38, 24, 39, 36, 63 }, 75);
}

internal static class _0xcae1a659
{
    internal static string _0x3c58e92e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}