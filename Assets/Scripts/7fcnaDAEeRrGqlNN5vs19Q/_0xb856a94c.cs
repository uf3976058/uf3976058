/// The result of one spin, as plain data. No constructor (C.59): build with
/// new SpinOutcome().Init(...).
public sealed class _0xb856a94c
{
    public _0xb856a94c _0x5b0ff397(int[] _0x9cf993b8)
    {
        this.Grid = _0x9cf993b8;
        this.LineSymbol = new int[_0xafff65e6.Lines];
        this.LineMatches = new int[_0xafff65e6.Lines];
        this.LineCoins = new int[_0xafff65e6.Lines];
        for (int _0x83999bfd = 0; _0x83999bfd < _0xafff65e6.Lines; _0x83999bfd++)
        {
            this.LineSymbol[_0x83999bfd] = -1;
        }

        return this;
    }

    public int TopSymbol = -1; // the symbol of the best paying line, for album credit
    public int _0x970c7bd2(int _0x1d13478a, int _0xe7e0d981)
    {
        return this.Grid[(_0x1d13478a * _0xafff65e6.Rows) + _0xe7e0d981];
    }

    public int BetMultiple; // TotalCoins / bet, floored - drives the big-win pop
    public int[] LineSymbol; // per payline, -1 when the line paid nothing
    public int[] LineMatches; // per payline, 0 when the line paid nothing
    public int[] LineCoins; // per payline
    public int CourtesySpins;
    public int[] Grid; // Cols * Rows, indexed col * Rows + row
    public int TotalCoins;
    public int Lanterns;
    public bool _0x81b3e2b7
    {
        get
        {
            return this.TotalCoins > 0;
        }
    }
}