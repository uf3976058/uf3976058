using UnityEngine;

/// Fictional, non-purchasable, non-redeemable coins and the local flags that go with them.
/// The balance itself lives in the template's own PlayerSYSTEM.Coins so the template money
/// readouts stay in step; everything else is a plain PlayerPrefs key. There is no shop, no
/// purchase, no network and no account behind any of this.
public static class _0xc3f86607
{
    public static int _0x8e3bb66f
    {
        get
        {
            return _0xafff65e6.DailyLadder[_0x35605d49 - 1];
        }
    }

    private static readonly string HapticsKey = _0x2c45ad42._0x27fb5d40(new byte[10] { 212, 213, 193, 251, 210, 195, 199, 218, 208, 192 }, 179);
    private static readonly string SessionKey = _0x2c45ad42._0x27fb5d40(new byte[10] { 119, 118, 98, 67, 117, 99, 99, 121, 127, 126 }, 16);
    /// Called once per launch before anything reads the balance.
    public static void EnsureReady()
    {
        if (PlayerPrefs.GetInt(SeedKey, 0) == 1)
        {
            return;
        }

        PlayerPrefs.SetInt(SeedKey, 1);
        PlayerPrefs.SetInt(BetKey, _0xafff65e6.DefaultBetIndex);
        _0x1d80aee2._0xeef67835._0x81680469 = _0xafff65e6.StartingBalance;
        PlayerPrefs.Save();
    }

    public static bool _0xfc99299a
    {
        get
        {
            return PlayerPrefs.GetInt(SparkleKey, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(SparkleKey, value ? 1 : 0);
        }
    }

    private static readonly string SpinsKey = _0x2c45ad42._0x27fb5d40(new byte[8] { 196, 197, 209, 240, 211, 202, 205, 208 }, 163);
    private static readonly string DayStampKey = _0x2c45ad42._0x27fb5d40(new byte[13] { 239, 238, 250, 204, 233, 225, 228, 241, 219, 252, 233, 229, 248 }, 136);
    private static readonly string CourtesyKey = _0x2c45ad42._0x27fb5d40(new byte[11] { 95, 94, 74, 123, 87, 77, 74, 76, 93, 75, 65 }, 56);
    public static int _0xe0fb96be
    {
        get
        {
            return PlayerPrefs.GetInt(SpinsKey, 0);
        }

        set
        {
            PlayerPrefs.SetInt(SpinsKey, value);
        }
    }

    public static string Today()
    {
        System.DateTime _0xd0921fcf = System.DateTime.Now.Date;
        return _0xd0921fcf.Year.ToString() + _0x2c45ad42._0x27fb5d40(new byte[1] { 145 }, 188) + _0xd0921fcf.Month.ToString() + _0x2c45ad42._0x27fb5d40(new byte[1] { 197 }, 232) + _0xd0921fcf.Day.ToString();
    }

    private static readonly string BetKey = _0x2c45ad42._0x27fb5d40(new byte[11] { 111, 110, 122, 74, 109, 124, 65, 102, 108, 109, 112 }, 8);
    public static int _0x08d47a64
    {
        get
        {
            return PlayerPrefs.GetInt(BestWinKey, 0);
        }

        set
        {
            PlayerPrefs.SetInt(BestWinKey, value);
        }
    }

    public static void ResetProgress()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        EnsureReady();
    }

    public static int _0x395d8c11
    {
        get
        {
            return PlayerPrefs.GetInt(CourtesyKey, 0);
        }

        set
        {
            PlayerPrefs.SetInt(CourtesyKey, value < 0 ? 0 : value);
        }
    }

    /// Rolls the ladder forward (or back to day 1) exactly once per calendar day.
    public static void RollDaily()
    {
        string _0x2749ab66 = PlayerPrefs.GetString(DayStampKey, "");
        if (_0x2749ab66 == "" || _0x2749ab66 == Today())
        {
            return;
        }

        int _0xbcfec648 = _0x2749ab66 == Yesterday() ? _0x35605d49 + 1 : 1;
        if (_0xbcfec648 > _0xafff65e6.DailyLadder.Length)
        {
            _0xbcfec648 = 1;
        }

        PlayerPrefs.SetInt(DayKey, _0xbcfec648);
        PlayerPrefs.SetString(DayStampKey, "");
    }

    public static string Yesterday()
    {
        System.DateTime _0x3d466dc5 = System.DateTime.Now.Date.AddDays(-1);
        return _0x3d466dc5.Year.ToString() + _0x2c45ad42._0x27fb5d40(new byte[1] { 159 }, 178) + _0x3d466dc5.Month.ToString() + _0x2c45ad42._0x27fb5d40(new byte[1] { 46 }, 3) + _0x3d466dc5.Day.ToString();
    }

    public static int NextSession()
    {
        int _0xa2d92382 = PlayerPrefs.GetInt(SessionKey, 0) + 1;
        PlayerPrefs.SetInt(SessionKey, _0xa2d92382);
        PlayerPrefs.Save();
        return _0xa2d92382;
    }

    public static int _0x973ef7b9
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(BetKey, _0xafff65e6.DefaultBetIndex), 0, _0xafff65e6.BetSteps.Length - 1);
        }

        set
        {
            PlayerPrefs.SetInt(BetKey, Mathf.Clamp(value, 0, _0xafff65e6.BetSteps.Length - 1));
        }
    }

    private static readonly string DayKey = _0x2c45ad42._0x27fb5d40(new byte[11] { 119, 118, 98, 84, 113, 121, 124, 105, 84, 113, 105 }, 16);
    private static readonly string BestWinKey = _0x2c45ad42._0x27fb5d40(new byte[10] { 10, 11, 31, 47, 8, 30, 25, 58, 4, 3 }, 109);
    private static readonly string SeedKey = _0x2c45ad42._0x27fb5d40(new byte[9] { 35, 34, 54, 23, 33, 33, 32, 33, 32 }, 68);
    /// The only use of the lose pop: the vault ran dry and the hall tops it back up.
    public static void GrantCourtesyCoins()
    {
        _0x94c37df7 = _0x94c37df7 + _0xafff65e6.CourtesyGrant;
        PlayerPrefs.Save();
    }

    public static bool _0x94b00b40
    {
        get
        {
            return PlayerPrefs.GetString(DayStampKey, "") == Today();
        }
    }

    public static int _0xb81020ac
    {
        get
        {
            return PlayerPrefs.GetInt(DryKey, 0);
        }

        set
        {
            PlayerPrefs.SetInt(DryKey, value);
        }
    }

    public static bool _0x9379774e
    {
        get
        {
            return PlayerPrefs.GetInt(FastKey, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(FastKey, value ? 1 : 0);
        }
    }

    public static bool _0xa59a79ae
    {
        get
        {
            return PlayerPrefs.GetInt(HapticsKey, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(HapticsKey, value ? 1 : 0);
        }
    }

    private static readonly string SparkleKey = _0x2c45ad42._0x27fb5d40(new byte[16] { 162, 163, 183, 151, 160, 161, 176, 166, 160, 150, 181, 164, 183, 174, 169, 160 }, 197);
    // --- daily stack ---------------------------------------------------------
    /// Day 1..7 of the ladder. A missed day resets to day 1; no network, no server time.
    public static int _0x35605d49
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(DayKey, 1), 1, _0xafff65e6.DailyLadder.Length);
        }
    }

    private static readonly string FastKey = _0x2c45ad42._0x27fb5d40(new byte[11] { 205, 204, 216, 236, 203, 217, 222, 249, 218, 195, 196 }, 170);
    private static readonly string DryKey = _0x2c45ad42._0x27fb5d40(new byte[11] { 117, 116, 96, 86, 96, 107, 65, 98, 123, 124, 97 }, 18);
    public static void ClaimDaily()
    {
        if (_0x94b00b40)
        {
            return;
        }

        _0x94c37df7 = _0x94c37df7 + _0x8e3bb66f;
        PlayerPrefs.SetString(DayStampKey, Today());
        PlayerPrefs.Save();
    }

    /// A new index every launch, so the strips and the mission triplet differ between runs.
    public static int _0xd3a73b97
    {
        get
        {
            return PlayerPrefs.GetInt(SessionKey, 0);
        }
    }

    public static int _0x94c37df7
    {
        get
        {
            return _0x1d80aee2._0xeef67835._0x81680469;
        }

        set
        {
            _0x1d80aee2._0xeef67835._0x81680469 = value < 0 ? 0 : value;
        }
    }

    public static int _0x6c9a9ff3
    {
        get
        {
            return _0xafff65e6.BetAt(_0x973ef7b9);
        }
    }
}

internal static class _0x2c45ad42
{
    internal static string _0x27fb5d40(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}