using UnityEngine;

/// Builds the five 24-stop reel strips for one session (C.11).
///
/// The COMPOSITION of each reel is fixed - that is what keeps the measured return inside
/// the published band whichever session the player lands in - while the ORDER is shuffled
/// from the session seed, so two sessions never line the same symbols up in the same places
/// and near-misses fall differently. A shuffle that happens to stack four identical stops in
/// a row reads as a broken reel, so every candidate is checked and re-rolled; after 20 failed
/// attempts the hardcoded fallback ships instead (a guarantee, not the game).
public sealed class _0x2bbd6fac
{
    private const int MaxAttempts = 20;
    /// Where on the strip the given symbol sits with the given row offset, or -1.
    public static int FindStopFor(int[] _0x501744f9, int _0x06c30828, int _0x779ad739, System.Random _0x12f06ebf)
    {
        int _0x72f3d0ca = _0x12f06ebf == null ? 0 : _0x12f06ebf.Next(_0x501744f9.Length);
        for (int _0xc53eb770 = 0; _0xc53eb770 < _0x501744f9.Length; _0xc53eb770++)
        {
            int _0x96223157 = (_0x72f3d0ca + _0xc53eb770) % _0x501744f9.Length;
            if (_0x501744f9[(_0x96223157 + _0x779ad739) % _0x501744f9.Length] == _0x06c30828)
            {
                return _0x96223157;
            }
        }

        return -1;
    }

    private int[] _0x2383d0a9(int[] _0xcb16c71e)
    {
        int[] _0xcca5ee13 = new int[_0xcb16c71e.Length];
        System.Array.Copy(_0xcb16c71e, _0xcca5ee13, _0xcb16c71e.Length);
        for (int _0x29995eb7 = _0xcca5ee13.Length - 1; _0x29995eb7 > 0; _0x29995eb7--)
        {
            int _0x61ca895a = this._0x69ec7c1b.Next(_0x29995eb7 + 1);
            int _0x1cd24a08 = _0xcca5ee13[_0x29995eb7];
            _0xcca5ee13[_0x29995eb7] = _0xcca5ee13[_0x61ca895a];
            _0xcca5ee13[_0x61ca895a] = _0x1cd24a08;
        }

        return _0xcca5ee13;
    }

    private static int[] Spread(int[] _0x95c2ed4a)
    {
        int[] _0x5f2457bf = new int[_0xafff65e6.StripStops];
        int _0x8594462a = 0;
        for (int _0x11b13b62 = 0; _0x11b13b62 < _0x95c2ed4a.Length; _0x11b13b62++)
        {
            for (int _0x56c8ea81 = 0; _0x56c8ea81 < _0x95c2ed4a[_0x11b13b62]; _0x56c8ea81++)
            {
                _0x5f2457bf[_0x8594462a] = _0x11b13b62;
                _0x8594462a++;
            }
        }

        return _0x5f2457bf;
    }

    /// Used only when 20 shuffles in a row failed the adjacency check.
    private static readonly int[][] _0xfceb7436 =
    {
        new[]
        {
            0,
            1,
            2,
            0,
            3,
            1,
            4,
            0,
            2,
            6,
            1,
            0,
            5,
            3,
            1,
            2,
            4,
            0,
            7,
            1,
            3,
            2,
            4,
            0
        },
        new[]
        {
            1,
            0,
            3,
            2,
            0,
            4,
            1,
            5,
            0,
            2,
            1,
            6,
            3,
            0,
            4,
            2,
            1,
            0,
            3,
            7,
            2,
            4,
            1,
            0
        },
        new[]
        {
            2,
            0,
            1,
            3,
            0,
            2,
            4,
            1,
            6,
            0,
            2,
            5,
            1,
            0,
            3,
            2,
            0,
            4,
            1,
            2,
            7,
            0,
            3,
            1
        },
        new[]
        {
            0,
            1,
            0,
            2,
            3,
            1,
            0,
            4,
            1,
            5,
            0,
            2,
            1,
            3,
            0,
            1,
            2,
            0,
            7,
            4,
            1,
            0,
            3,
            2
        },
        new[]
        {
            1,
            0,
            2,
            1,
            0,
            3,
            1,
            0,
            4,
            2,
            1,
            5,
            0,
            1,
            3,
            0,
            2,
            1,
            0,
            7,
            4,
            1,
            0,
            2
        },
    };
    private System.Random _0x69ec7c1b;
    private int[] _0xac3e73a5(int _0x51657d01)
    {
        int[] _0x72e8591e = Spread(_0x8c6a6d64[_0x51657d01]);
        for (int _0x4e7c303b = 0; _0x4e7c303b < MaxAttempts; _0x4e7c303b++)
        {
            int[] _0x6c4397b5 = this._0x2383d0a9(_0x72e8591e);
            if (Valid(_0x6c4397b5))
            {
                return _0x6c4397b5;
            }
        }

        int[] _0x7e0f1b1b = new int[_0xafff65e6.StripStops];
        System.Array.Copy(_0xfceb7436[_0x51657d01], _0x7e0f1b1b, _0xafff65e6.StripStops);
        return _0x7e0f1b1b;
    }

    /// Logged once per session so a reported layout can be reproduced from its seed.
    public static void Report(int _0x6266ab4e, int[][] _0x202db98a)
    {
        {
#if B_LOGS
            {
                Debug.Log($"[strips] seed={_0x6266ab4e} {Describe(_0x202db98a)}");
            }
#endif
        }
    }

    /// The window the player sees on one reel: three consecutive stops, wrapping.
    public static void Window(int[] _0xe7738131, int _0x8f2ba5e6, int[] _0x5159ae0d)
    {
        for (int _0xd140031a = 0; _0xd140031a < _0xafff65e6.Rows; _0xd140031a++)
        {
            _0x5159ae0d[_0xd140031a] = _0xe7738131[(_0x8f2ba5e6 + _0xd140031a) % _0xe7738131.Length];
        }
    }

    // Stops per symbol, per reel. Index order follows GemSymbol.
    // Amethyst, Topaz, Emerald, Sapphire, Ruby, Crown, Prism, Lantern  -> 24 each.
    // The prism substitutes, so it rides only the first three reels - that is what keeps a
    // five-of-a-kind rare while still letting the player see a substitution most sessions.
    // Exact return of this table with the paytable in GemPaytable: 0.9212, any-line hit 25.7 %.
    private static readonly int[][] _0x8c6a6d64 =
    {
        new[]
        {
            6,
            5,
            4,
            3,
            2,
            2,
            1,
            1
        },
        new[]
        {
            6,
            5,
            4,
            3,
            2,
            2,
            1,
            1
        },
        new[]
        {
            6,
            5,
            4,
            3,
            2,
            2,
            1,
            1
        },
        new[]
        {
            7,
            6,
            4,
            3,
            2,
            1,
            0,
            1
        },
        new[]
        {
            7,
            6,
            4,
            3,
            2,
            1,
            0,
            1
        },
    };
    public static string Describe(int[][] _0x71fbf8ec)
    {
        string _0x57582841 = "";
        for (int _0x5973df74 = 0; _0x5973df74 < _0x71fbf8ec.Length; _0x5973df74++)
        {
            _0x57582841 += _0x5973df74 > 0 ? _0x172b5934._0x8f8986de(new byte[3] { 70, 26, 70 }, 102) : "";
            for (int _0x58194250 = 0; _0x58194250 < _0x71fbf8ec[_0x5973df74].Length; _0x58194250++)
            {
                _0x57582841 += _0x71fbf8ec[_0x5973df74][_0x58194250].ToString();
            }
        }

        return _0x57582841;
    }

    public int[][] _0x2a2562a8()
    {
        int[][] _0xd79b7d7f = new int[_0xafff65e6.Cols][];
        for (int _0x0fe9a0ef = 0; _0x0fe9a0ef < _0xafff65e6.Cols; _0x0fe9a0ef++)
        {
            _0xd79b7d7f[_0x0fe9a0ef] = this._0xac3e73a5(_0x0fe9a0ef);
        }

        return _0xd79b7d7f;
    }

    /// The strip wraps, so adjacency is checked round the loop, not just inside the array.
    private static bool Valid(int[] _0xd95b9edd)
    {
        int _0xcdad1ad9 = 1;
        for (int _0x939441de = 1; _0x939441de < _0xd95b9edd.Length + 3; _0x939441de++)
        {
            int _0x0aea8892 = _0xd95b9edd[_0x939441de % _0xd95b9edd.Length];
            int _0x3b451973 = _0xd95b9edd[(_0x939441de - 1) % _0xd95b9edd.Length];
            _0xcdad1ad9 = _0x0aea8892 == _0x3b451973 ? _0xcdad1ad9 + 1 : 1;
            if (_0xcdad1ad9 >= 4)
            {
                return false;
            }
        }

        return true;
    }

    /// No constructor anywhere in generated code (C.59) - build with new X().Init(...).
    public _0x2bbd6fac _0xa71264bd(System.Random _0x222d2703)
    {
        this._0x69ec7c1b = _0x222d2703;
        return this;
    }
}

internal static class _0x172b5934
{
    internal static string _0x8f8986de(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}