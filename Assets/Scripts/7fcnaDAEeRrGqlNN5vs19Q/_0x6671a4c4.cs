/// Reads a set of reel stops into a grid and pays it out.
///
/// Five fixed paylines on the 5x3 grid, row 0 = top. A line pays on 3, 4 or 5 matching
/// symbols counted FROM THE LEFTMOST REEL; the prism shard substitutes for any gem but not
/// for the lantern; only the best-paying reading of a line counts and line wins sum.
/// Multipliers apply to the TOTAL bet (GemPaytable), so one paying line already returns the
/// stake or better and the five lines are five independent draws of the same distribution.
public sealed class _0x6671a4c4
{
    public _0x6671a4c4 _0x6b01e7a7(int[][] _0x8725c1db)
    {
        this._0xb8d066fa = _0x8725c1db;
        return this;
    }

    /// How many reels from the left read as <candidate>. The prism substitutes for a gem;
    /// a pure prism run is scored as the prism itself, and the lantern substitutes for nothing.
    private static int MatchRun(_0xb856a94c _0xd29dfc7b, int[] _0x6e6498ac, int _0xd6b9151d)
    {
        int _0xcdf4e882 = 0;
        for (int _0xf08bceec = 0; _0xf08bceec < _0xafff65e6.Cols; _0xf08bceec++)
        {
            int _0x375c2c98 = _0xd29dfc7b._0x970c7bd2(_0xf08bceec, _0x6e6498ac[_0xf08bceec]);
            bool _0xbaf834a2 = _0x375c2c98 == _0xd6b9151d;
            if (!_0xbaf834a2 && _0xd6b9151d != _0x1745229a.WildIndex && _0x1745229a.Wild(_0x375c2c98))
            {
                _0xbaf834a2 = true;
            }

            if (!_0xbaf834a2)
            {
                break;
            }

            _0xcdf4e882++;
        }

        return _0xcdf4e882;
    }

    /// Stops that put <symbol> on the centre line across the first <reels> reels, used by the
    /// two scripted outcomes of the design doc. Returns false when the strips cannot do it.
    public bool _0x0fa1acdf(int _0xa88f808b, int _0xbef4d026, System.Random _0x9e6f44ed, int[] _0xd3e491b0)
    {
        for (int _0x4a3bf0b7 = 0; _0x4a3bf0b7 < _0xafff65e6.Cols; _0x4a3bf0b7++)
        {
            if (_0x4a3bf0b7 < _0xbef4d026)
            {
                int _0x31bf4d19 = _0x2bbd6fac.FindStopFor(this._0xb8d066fa[_0x4a3bf0b7], _0xa88f808b, 1, _0x9e6f44ed);
                if (_0x31bf4d19 < 0)
                {
                    return false;
                }

                _0xd3e491b0[_0x4a3bf0b7] = _0x31bf4d19;
            }
            else
            {
                _0xd3e491b0[_0x4a3bf0b7] = _0x9e6f44ed.Next(this._0xb8d066fa[_0x4a3bf0b7].Length);
            }
        }

        // The tail reels must NOT extend the run, or a scripted 3-of-a-kind silently
        // becomes a 4 or 5 and the showcase stops being the small win it was meant to be.
        for (int _0x7e27f85f = _0xbef4d026; _0x7e27f85f < _0xafff65e6.Cols; _0x7e27f85f++)
        {
            int[] _0x44adeeb3 = this._0xb8d066fa[_0x7e27f85f];
            for (int _0xc89e7002 = 0; _0xc89e7002 < _0x44adeeb3.Length; _0xc89e7002++)
            {
                int _0xb96c2839 = (_0xd3e491b0[_0x7e27f85f] + _0xc89e7002) % _0x44adeeb3.Length;
                int _0xce758ea5 = _0x44adeeb3[(_0xb96c2839 + 1) % _0x44adeeb3.Length];
                if (_0xce758ea5 != _0xa88f808b && !_0x1745229a.Wild(_0xce758ea5))
                {
                    _0xd3e491b0[_0x7e27f85f] = _0xb96c2839;
                    break;
                }
            }
        }

        return true;
    }

    public static int[] RowsOfLine(int _0x486b89a9)
    {
        return _0x5a4f61a1[_0x486b89a9];
    }

    private int[][] _0xb8d066fa;
    /// row index per reel, one row per payline: centre, top, bottom, V, inverted V.
    private static readonly int[][] _0x5a4f61a1 =
    {
        new[]
        {
            1,
            1,
            1,
            1,
            1
        },
        new[]
        {
            0,
            0,
            0,
            0,
            0
        },
        new[]
        {
            2,
            2,
            2,
            2,
            2
        },
        new[]
        {
            0,
            1,
            2,
            1,
            0
        },
        new[]
        {
            2,
            1,
            0,
            1,
            2
        },
    };
    public _0xb856a94c _0xb0e31425(int[] _0x3a22908a, int _0xaa1b8288)
    {
        _0xb856a94c _0x50954956 = new _0xb856a94c()._0x5b0ff397(this._0x98fbd616(_0x3a22908a));
        int _0xc3a17e01 = 0;
        for (int _0x77610bba = 0; _0x77610bba < _0xafff65e6.Lines; _0x77610bba++)
        {
            int[] _0x72f3d3d3 = _0x5a4f61a1[_0x77610bba];
            int _0x2f7a47a4 = -1;
            int _0xd60000e7 = 0;
            int bestPay = 0;
            for (int _0xd97c3c13 = 0; _0xd97c3c13 <= _0x1745229a.WildIndex; _0xd97c3c13++)
            {
                int _0xd092ff79 = MatchRun(_0x50954956, _0x72f3d3d3, _0xd97c3c13);
                int _0x6bc35541 = _0x1745229a.LineMultiplier(_0xd97c3c13, _0xd092ff79) * _0xaa1b8288;
                if (_0x6bc35541 > bestPay)
                {
                    bestPay = _0x6bc35541;
                    _0x2f7a47a4 = _0xd97c3c13;
                    _0xd60000e7 = _0xd092ff79;
                }
            }

            if (bestPay > 0)
            {
                _0x50954956.LineSymbol[_0x77610bba] = _0x2f7a47a4;
                _0x50954956.LineMatches[_0x77610bba] = _0xd60000e7;
                _0x50954956.LineCoins[_0x77610bba] = bestPay;
                _0x50954956.TotalCoins += bestPay;
                if (bestPay > _0xc3a17e01)
                {
                    _0xc3a17e01 = bestPay;
                    _0x50954956.TopSymbol = _0x2f7a47a4;
                }
            }
        }

        _0x50954956.Lanterns = CountLanterns(_0x50954956);
        _0x50954956.CourtesySpins = _0x1745229a.ScatterSpins(_0x50954956.Lanterns);
        _0x50954956.BetMultiple = _0xaa1b8288 > 0 ? _0x50954956.TotalCoins / _0xaa1b8288 : 0;
        return _0x50954956;
    }

    private static int CountLanterns(_0xb856a94c _0xa4cb7e77)
    {
        int _0xded3999b = 0;
        for (int _0x3903ad59 = 0; _0x3903ad59 < _0xafff65e6.Cols; _0x3903ad59++)
        {
            for (int _0xd13e3a85 = 0; _0xd13e3a85 < _0xafff65e6.Rows; _0xd13e3a85++)
            {
                if (_0x1745229a.Scatter(_0xa4cb7e77._0x970c7bd2(_0x3903ad59, _0xd13e3a85)))
                {
                    _0xded3999b++;
                }
            }
        }

        return _0xded3999b;
    }

    public int[] _0x98fbd616(int[] _0xb672117f)
    {
        int[] _0x7f101eff = new int[_0xafff65e6.Cols * _0xafff65e6.Rows];
        for (int _0x266b8a67 = 0; _0x266b8a67 < _0xafff65e6.Cols; _0x266b8a67++)
        {
            int[] _0xb02f193b = this._0xb8d066fa[_0x266b8a67];
            for (int _0x0530354e = 0; _0x0530354e < _0xafff65e6.Rows; _0x0530354e++)
            {
                _0x7f101eff[(_0x266b8a67 * _0xafff65e6.Rows) + _0x0530354e] = _0xb02f193b[(_0xb672117f[_0x266b8a67] + _0x0530354e) % _0xb02f193b.Length];
            }
        }

        return _0x7f101eff;
    }
}