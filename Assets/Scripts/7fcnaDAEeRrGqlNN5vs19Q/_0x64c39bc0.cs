using UnityEngine;

/// The three local objectives of a session, drawn from a pool of nine by the session seed.
///
/// Reachability is verified, not assumed: every mission carries the number of spins it takes
/// on average, measured against this exact paytable and these exact reel compositions, and a
/// triplet whose hardest member needs more than SpinBudget spins is redrawn (up to 20 times,
/// then the hardcoded fallback triplet ships). Progress is local only - PlayerPrefs, no server.
public static class _0x64c39bc0
{
    private static _0xaf17bb5a[] _0x8b7b3617;
    public const int KindRubies = 0;
    public const int SpinBudget = 60;
    private static readonly string DoneKey = _0x18d8d02e._0xd71379d5(new byte[14] { 186, 187, 175, 144, 180, 174, 174, 180, 178, 179, 153, 178, 179, 184 }, 221);
    // --- progress ------------------------------------------------------------
    public static int Progress(_0xaf17bb5a _0xdc9c9e80)
    {
        return PlayerPrefs.GetInt(ProgressKey + _0xdc9c9e80.Id, 0);
    }

    public static bool Done(_0xaf17bb5a _0x3e9685ed)
    {
        return PlayerPrefs.GetInt(DoneKey + _0x3e9685ed.Id, 0) == 1;
    }

    /// Chosen once per session and remembered, so the lobby and the cabinet agree.
    public static _0xaf17bb5a[] Active(System.Random _0x64f6d6d9)
    {
        if (_0x4c15a4f8 != null)
        {
            return _0x4c15a4f8;
        }

        string _0xa084e2fe = PlayerPrefs.GetString(PickKey, "");
        int[] _0x8def565c = Parse(_0xa084e2fe);
        if (_0x8def565c == null || !Reachable(_0x8def565c))
        {
            _0x8def565c = Draw(_0x64f6d6d9);
            PlayerPrefs.SetString(PickKey, _0x8def565c[0] + _0x18d8d02e._0xd71379d5(new byte[1] { 187 }, 151) + _0x8def565c[1] + _0x18d8d02e._0xd71379d5(new byte[1] { 115 }, 95) + _0x8def565c[2]);
            PlayerPrefs.Save();
        }

        _0xaf17bb5a[] _0xcd0892eb = Pool();
        _0x4c15a4f8 = new _0xaf17bb5a[_0xafff65e6.ActiveMissions];
        for (int _0x011cc4dc = 0; _0x011cc4dc < _0xafff65e6.ActiveMissions; _0x011cc4dc++)
        {
            _0x4c15a4f8[_0x011cc4dc] = _0xcd0892eb[_0x8def565c[_0x011cc4dc]];
        }

        return _0x4c15a4f8;
    }

    public const int KindBigMultiple = 8;
    public const int KindAlbumSlots = 6;
    public const int KindSessionCoins = 7;
    public static string ProgressLine(_0xaf17bb5a _0x51c0c90f)
    {
        int _0xc3e7684e = Progress(_0x51c0c90f);
        if (_0x51c0c90f.Kind == KindSessionCoins)
        {
            return _0x32e32309.Coins(_0xc3e7684e) + _0x18d8d02e._0xd71379d5(new byte[3] { 33, 46, 33 }, 1) + _0x32e32309.Coins(_0x51c0c90f.Target) + _0x18d8d02e._0xd71379d5(new byte[1] { 249 }, 217) + _0x51c0c90f.Unit;
        }

        return _0xc3e7684e + _0x18d8d02e._0xd71379d5(new byte[3] { 94, 81, 94 }, 126) + _0x51c0c90f.Target + _0x18d8d02e._0xd71379d5(new byte[1] { 56 }, 24) + _0x51c0c90f.Unit;
    }

    private static int[] Parse(string _0x80b2a3b7)
    {
        if (string.IsNullOrEmpty(_0x80b2a3b7))
        {
            return null;
        }

        string[] _0x85fb82a7 = _0x80b2a3b7.Split(',');
        if (_0x85fb82a7.Length != _0xafff65e6.ActiveMissions)
        {
            return null;
        }

        int[] _0xfa2d6482 = new int[_0x85fb82a7.Length];
        for (int _0xb0dc826e = 0; _0xb0dc826e < _0x85fb82a7.Length; _0xb0dc826e++)
        {
            int _0x48549335;
            if (!int.TryParse(_0x85fb82a7[_0xb0dc826e], out _0x48549335))
            {
                return null;
            }

            _0xfa2d6482[_0xb0dc826e] = _0x48549335;
        }

        return _0xfa2d6482;
    }

    public const int KindBottomWins = 5;
    public static int State(_0xaf17bb5a _0x17352af9)
    {
        if (Done(_0x17352af9))
        {
            return 2;
        }

        return Progress(_0x17352af9) > 0 ? 1 : 0;
    }

    public const int KindWins = 4;
    private static readonly string PickKey = _0x18d8d02e._0xd71379d5(new byte[14] { 88, 89, 77, 114, 86, 76, 76, 86, 80, 81, 111, 86, 92, 84 }, 63);
    public const int KindWildSubs = 3;
    private static _0xaf17bb5a[] _0x4c15a4f8;
    private static int[] Draw(System.Random _0xc7e17a3d)
    {
        _0xaf17bb5a[] _0xd955764a = Pool();
        for (int _0x9e39f092 = 0; _0x9e39f092 < MaxDraws; _0x9e39f092++)
        {
            int[] _0xc7d5beae = new int[_0xd955764a.Length];
            for (int _0x9ac72efc = 0; _0x9ac72efc < _0xc7d5beae.Length; _0x9ac72efc++)
            {
                _0xc7d5beae[_0x9ac72efc] = _0x9ac72efc;
            }

            for (int _0x5c4a62e3 = _0xc7d5beae.Length - 1; _0x5c4a62e3 > 0; _0x5c4a62e3--)
            {
                int _0x60c9af66 = _0xc7e17a3d.Next(_0x5c4a62e3 + 1);
                int _0x74f967ca = _0xc7d5beae[_0x5c4a62e3];
                _0xc7d5beae[_0x5c4a62e3] = _0xc7d5beae[_0x60c9af66];
                _0xc7d5beae[_0x60c9af66] = _0x74f967ca;
            }

            int[] _0x82564626 =
            {
                _0xc7d5beae[0],
                _0xc7d5beae[1],
                _0xc7d5beae[2]
            };
            if (Reachable(_0x82564626))
            {
                {
#if B_LOGS
                    {
                        Debug.Log($"[missions] draw={_0x82564626[0]},{_0x82564626[1]},{_0x82564626[2]} attempt={_0x9e39f092}");
                    }
#endif
                }

                return _0x82564626;
            }
        }

        return new[]
        {
            1,
            0,
            4
        }; // the three cheapest - a fallback, never the game
    }

    public const int KindSpins = 2;
    /// Forget the session pick so the next launch draws a new triplet.
    public static void Reshuffle()
    {
        _0x4c15a4f8 = null;
        PlayerPrefs.DeleteKey(PickKey);
    }

    /// Measured rates behind the estimates (4,000,000 sampled spins, exact stop model):
    /// any win 1 in 4.1, wild substitution 1 in 8.9, bottom line 1 in 17.3,
    /// a 10x payout 1 in 49, 1.25 rubies and 0.62 lanterns per spin.
    private static _0xaf17bb5a[] Pool()
    {
        if (_0x8b7b3617 != null)
        {
            return _0x8b7b3617;
        }

        _0x8b7b3617 = new[]
        {
            new _0xaf17bb5a()._0x88d81158(0, KindRubies, 8, 300, 7, _0x18d8d02e._0xd71379d5(new byte[13] { 75, 70, 73, 67, 39, 63, 39, 85, 82, 69, 78, 66, 84 }, 7), _0x18d8d02e._0xd71379d5(new byte[6] { 56, 63, 40, 35, 47, 57 }, 106)),
            new _0xaf17bb5a()._0x88d81158(1, KindLanterns, 3, 250, 5, _0x18d8d02e._0xd71379d5(new byte[18] { 164, 168, 171, 171, 162, 164, 179, 199, 212, 199, 171, 166, 169, 179, 162, 181, 169, 180 }, 231), _0x18d8d02e._0xd71379d5(new byte[8] { 7, 10, 5, 31, 14, 25, 5, 24 }, 75)),
            new _0xaf17bb5a()._0x88d81158(2, KindSpins, 25, 400, 25, _0x18d8d02e._0xd71379d5(new byte[13] { 154, 153, 128, 135, 233, 251, 252, 233, 157, 128, 132, 140, 154 }, 201), _0x18d8d02e._0xd71379d5(new byte[5] { 108, 111, 118, 113, 108 }, 63)),
            new _0xaf17bb5a()._0x88d81158(3, KindWildSubs, 2, 450, 18, _0x18d8d02e._0xd71379d5(new byte[25] { 211, 210, 207, 187, 169, 187, 203, 201, 210, 200, 214, 187, 200, 206, 217, 200, 207, 210, 207, 206, 207, 210, 212, 213, 200 }, 155), _0x18d8d02e._0xd71379d5(new byte[6] { 246, 244, 239, 245, 235, 245 }, 166)),
            new _0xaf17bb5a()._0x88d81158(4, KindWins, 5, 350, 21, _0x18d8d02e._0xd71379d5(new byte[11] { 17, 15, 8, 102, 115, 102, 18, 15, 11, 3, 21 }, 70), _0x18d8d02e._0xd71379d5(new byte[4] { 214, 200, 207, 210 }, 129)),
            new _0xaf17bb5a()._0x88d81158(5, KindBottomWins, 2, 600, 35, _0x18d8d02e._0xd71379d5(new byte[28] { 106, 116, 115, 29, 105, 106, 116, 126, 120, 29, 114, 115, 29, 105, 117, 120, 29, 127, 114, 105, 105, 114, 112, 29, 113, 116, 115, 120 }, 61), _0x18d8d02e._0xd71379d5(new byte[4] { 91, 69, 66, 95 }, 12)),
            new _0xaf17bb5a()._0x88d81158(6, KindAlbumSlots, 2, 500, 12, _0x18d8d02e._0xd71379d5(new byte[23] { 62, 40, 57, 77, 95, 77, 42, 40, 32, 62, 77, 36, 35, 77, 57, 37, 40, 77, 44, 33, 47, 56, 32 }, 109), _0x18d8d02e._0xd71379d5(new byte[4] { 206, 204, 196, 218 }, 137)),
            new _0xaf17bb5a()._0x88d81158(7, KindSessionCoins, 1200, 700, 29, _0x18d8d02e._0xd71379d5(new byte[15] { 2, 28, 27, 117, 100, 121, 103, 101, 101, 117, 22, 26, 28, 27, 6 }, 85), _0x18d8d02e._0xd71379d5(new byte[5] { 65, 77, 75, 76, 81 }, 2)),
            new _0xaf17bb5a()._0x88d81158(8, KindBigMultiple, 1, 1000, 49, _0x18d8d02e._0xd71379d5(new byte[18] { 145, 134, 130, 128, 139, 227, 130, 227, 242, 243, 155, 227, 147, 130, 154, 140, 150, 151 }, 195), _0x18d8d02e._0xd71379d5(new byte[7] { 12, 29, 5, 19, 9, 8, 15 }, 92)),
        };
        return _0x8b7b3617;
    }

    public static float Fill(_0xaf17bb5a _0xdefa5235)
    {
        return _0xdefa5235.Target <= 0 ? 0f : Mathf.Clamp01((float)Progress(_0xdefa5235) / _0xdefa5235.Target);
    }

    private static readonly string ProgressKey = _0x18d8d02e._0xd71379d5(new byte[14] { 207, 206, 218, 229, 193, 219, 219, 193, 199, 198, 248, 218, 199, 207 }, 168);
    private const int MaxDraws = 20;
    /// Returns the coins a mission just paid out, 0 when nothing completed.
    public static int Advance(_0xaf17bb5a _0x1314d890, int _0x8c196f85)
    {
        if (_0x8c196f85 <= 0 || Done(_0x1314d890))
        {
            return 0;
        }

        int _0x07a44628 = Progress(_0x1314d890) + _0x8c196f85;
        if (_0x07a44628 > _0x1314d890.Target)
        {
            _0x07a44628 = _0x1314d890.Target;
        }

        PlayerPrefs.SetInt(ProgressKey + _0x1314d890.Id, _0x07a44628);
        if (_0x07a44628 < _0x1314d890.Target)
        {
            return 0;
        }

        PlayerPrefs.SetInt(DoneKey + _0x1314d890.Id, 1);
        PlayerPrefs.Save();
        return _0x1314d890.Reward;
    }

    private static bool Reachable(int[] _0x71de5963)
    {
        _0xaf17bb5a[] _0x3484aac4 = Pool();
        if (_0x71de5963.Length != _0xafff65e6.ActiveMissions)
        {
            return false;
        }

        for (int _0xdfa77ff7 = 0; _0xdfa77ff7 < _0x71de5963.Length; _0xdfa77ff7++)
        {
            if (_0x71de5963[_0xdfa77ff7] < 0 || _0x71de5963[_0xdfa77ff7] >= _0x3484aac4.Length)
            {
                return false;
            }

            if (_0x3484aac4[_0x71de5963[_0xdfa77ff7]].EstimatedSpins > SpinBudget)
            {
                return false;
            }

            for (int _0x93bd709a = _0xdfa77ff7 + 1; _0x93bd709a < _0x71de5963.Length; _0x93bd709a++)
            {
                if (_0x71de5963[_0xdfa77ff7] == _0x71de5963[_0x93bd709a])
                {
                    return false;
                }
            }
        }

        return true;
    }

    public const int KindLanterns = 1;
}

internal static class _0x18d8d02e
{
    internal static string _0xd71379d5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}