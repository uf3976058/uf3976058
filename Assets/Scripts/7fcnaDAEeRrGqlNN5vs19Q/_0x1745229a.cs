/// Paytable and symbol rules. A multiplier here applies to the TOTAL bet, per line.
///
/// The numbers are NOT the ones sketched in the design doc: with those, the exact return of
/// this grid is 1.51, and no reel weighting that still shows every symbol brings it inside
/// the mandatory 0.88 - 0.94 band (a 3-of-a-kind paying twice the whole stake is simply too
/// generous at a 26 % hit rate). The doc's own instruction is that the economy is tuned until
/// the measured figure lands, so the curve was kept and the whole table scaled by ~0.6.
/// Exact return with the reel compositions in ReelStripBuilder: 0.9212.
public static class _0x1745229a
{
    public const int ScatterIndex = 7;
    // [symbol][matches-3] -> multiplier of the TOTAL bet, for 3 / 4 / 5 of a kind.
    private static readonly int[][] _0x4a3b73e3 =
    {
        new[]
        {
            1,
            4,
            12
        }, // Amethyst
        new[]
        {
            1,
            5,
            15
        }, // Topaz
        new[]
        {
            2,
            7,
            20
        }, // Emerald
        new[]
        {
            2,
            9,
            30
        }, // Sapphire
        new[]
        {
            3,
            13,
            45
        }, // Ruby
        new[]
        {
            6,
            25,
            95
        }, // Crown
        new[]
        {
            10,
            45,
            160
        }, // Prism (wild)
        new[]
        {
            0,
            0,
            0
        }, // Lantern (scatter pays spins, not coins)
    };
    public static int LineMultiplier(int _0xf61ced70, int _0x13e01ef1)
    {
        if (_0xf61ced70 < 0 || _0xf61ced70 >= Count)
        {
            return 0;
        }

        if (_0x13e01ef1 < 3 || _0x13e01ef1 > 5)
        {
            return 0;
        }

        return _0x4a3b73e3[_0xf61ced70][_0x13e01ef1 - 3];
    }

    public static bool Wild(int _0x6f1b9335)
    {
        return _0x6f1b9335 == WildIndex;
    }

    /// Courtesy spins awarded by 3 / 4 / 5 lanterns anywhere on the grid.
    public static int ScatterSpins(int _0x22af505e)
    {
        if (_0x22af505e >= 5)
        {
            return 12;
        }

        if (_0x22af505e == 4)
        {
            return 8;
        }

        if (_0x22af505e == 3)
        {
            return 5;
        }

        return 0;
    }

    public const int Count = 8;
    public static string Name(int _0x8da2a248)
    {
        if (_0x8da2a248 < 0 || _0x8da2a248 >= Count)
        {
            return "";
        }

        return _0xbf44c400[_0x8da2a248];
    }

    public const int WildIndex = 6;
    public static bool Scatter(int _0xb2563093)
    {
        return _0xb2563093 == ScatterIndex;
    }

    private static readonly string[] _0xbf44c400 =
    {
        _0x9d127287._0xf8a6ecbb(new byte[8] { 145, 157, 149, 132, 152, 137, 131, 132 }, 208),
        _0x9d127287._0xf8a6ecbb(new byte[5] { 24, 3, 28, 13, 22 }, 76),
        _0x9d127287._0xf8a6ecbb(new byte[7] { 112, 120, 112, 103, 116, 121, 113 }, 53),
        _0x9d127287._0xf8a6ecbb(new byte[8] { 148, 134, 151, 151, 143, 142, 149, 130 }, 199),
        _0x9d127287._0xf8a6ecbb(new byte[4] { 234, 237, 250, 225 }, 184),
        _0x9d127287._0xf8a6ecbb(new byte[5] { 211, 194, 223, 199, 222 }, 144),
        _0x9d127287._0xf8a6ecbb(new byte[11] { 223, 221, 198, 220, 194, 175, 220, 199, 206, 221, 203 }, 143),
        _0x9d127287._0xf8a6ecbb(new byte[11] { 35, 33, 41, 68, 40, 37, 42, 48, 33, 54, 42 }, 100),
    };
}

internal static class _0x9d127287
{
    internal static string _0xf8a6ecbb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}