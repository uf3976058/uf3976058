/// Every tunable number of the game in one place. No value here is eyeballed on a screen:
/// the board geometry is derived in section 6.1 of the design doc from the 1242 x 2688
/// reference canvas and is authored into the prefab, so the code only needs the counts.
public static class _0xafff65e6
{
    /// A result pop releases itself, so a capture step that lands on it still moves on.
    public const float PopAutoRelease = 6f;
    public const int CourtesyGrant = 500;
    public static readonly int[] BetSteps =
    {
        25,
        50,
        100,
        250
    };
    public const int Lines = 5;
    public const float ResultBeat = 0.70f;
    // --- meta ----------------------------------------------------------------
    public const int Albums = 3;
    /// No input for this long and the cabinet spins itself as a house demo, so the capture
    /// window never photographs a dead screen (C.5). Any tap cancels it.
    public const float IdleDemoDelay = 12f;
    // --- economy -------------------------------------------------------------
    public const int StartingBalance = 5000;
    public const float WinCountUp = 0.60f;
    /// The spin of a fresh install that is scripted to a win on the centre line, so a review
    /// run always has one. Four of a kind of a high gem clears BigWinBetMultiple on this
    /// paytable (ruby 13x, crown 25x); three of a kind would not, and the pop would never show.
    public const int ShowcaseSpin = 2;
    public const float FastSpinScale = 0.5f;
    /// After this many paying-nothing spins the next one is nudged to the smallest line win.
    public const int SoftPitySpins = 12;
    public const int ShowcaseMatches = 4;
    public const int AlbumSlots = 6;
    public const int DefaultBetIndex = 1;
    public const int MissionPool = 9;
    // --- rules ---------------------------------------------------------------
    /// A win of at least this many times the total bet raises the WIN pop.
    public const int BigWinBetMultiple = 10;
    public const int StripStops = 24;
    // --- pacing (seconds) ----------------------------------------------------
    public const float SpinUp = 0.30f;
    public const int ActiveMissions = 3;
    public const float ReelSettle = 0.34f;
    public const float BaseSpinTime = 1.80f;
    public static int BetAt(int _0xa6511bd9)
    {
        if (_0xa6511bd9 < 0)
        {
            _0xa6511bd9 = 0;
        }

        if (_0xa6511bd9 >= BetSteps.Length)
        {
            _0xa6511bd9 = BetSteps.Length - 1;
        }

        return BetSteps[_0xa6511bd9];
    }

    public const float ReelStagger = 0.14f;
    public static readonly int[] DailyLadder =
    {
        250,
        300,
        400,
        500,
        650,
        800,
        1200
    };
    // --- board ---------------------------------------------------------------
    public const int Cols = 5;
    public const int Rows = 3;
}