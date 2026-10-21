using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The cabinet. One SPIN button, five reels that stop themselves left to right, five fixed
/// paylines. There is no timer, no draining meter and no per-round defeat: an untouched
/// session keeps showing the board for as long as it is left alone (C.5), and the cabinet
/// spins itself as a house demo after a while so a capture that lands between taps still has
/// something to photograph.
public sealed class _0xcb733c21 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _betPlusLabel;
    private void _0x8d410223()
    {
        this._0xb070bae3 = StateIdle;
        this._0xb08d092b = 0f;
        this._0xcdc07d56 = false;
        if (_0xc3f86607._0x94c37df7 < _0xafff65e6.BetSteps[0] && _0xc3f86607._0x395d8c11 <= 0)
        {
            this._0x11922092();
        }
    }

    [SerializeField]
    private Image[] _lineChips;
    private void _0xd36e7422()
    {
        _0xf44d047f.Instance._0xfa79fc65(_0x1d80aee2._0x6bf6c866.SCENE_0);
    }

    [SerializeField]
    private TMP_Text _compliance;
    private int[] _0xae906571;
    // --- art ---
    [SerializeField]
    private Sprite[] _gemArt;
    // --- HUD ---
    [SerializeField]
    private Button _backButton;
    [SerializeField]
    private Image _betPlate;
    private void _0xe52672f7(_0xb856a94c _0x5a46c2ee)
    {
        bool _0xcca0181e = _0xc3f86607._0xfc99299a;
        for (int _0xea5a0592 = 0; _0xea5a0592 < _0xafff65e6.Lines; _0xea5a0592++)
        {
            bool _0xd79a5299 = _0x5a46c2ee.LineCoins[_0xea5a0592] > 0;
            if (this._lineChips != null && _0xea5a0592 < this._lineChips.Length && this._lineChips[_0xea5a0592] != null)
            {
                this._lineChips[_0xea5a0592].color = _0xd79a5299 ? _0x21179992.Fade(_0x21179992.Mint, 0.9f) : _0x21179992.Fade(_0x21179992.BgPanelHi, 0.8f);
            }

            if (!_0xd79a5299)
            {
                continue;
            }

            int[] _0x5bfad35c = _0x6671a4c4.RowsOfLine(_0xea5a0592);
            for (int _0x71bb2faf = 0; _0x71bb2faf < _0x5a46c2ee.LineMatches[_0xea5a0592]; _0x71bb2faf++)
            {
                _0x584aa2cd _0xef277f0a = this._0xab1f3c23(_0x71bb2faf, _0x5bfad35c[_0x71bb2faf]);
                if (_0xef277f0a != null)
                {
                    _0xef277f0a._0xdc01e924(_0x21179992.Gold, _0xcca0181e);
                }
            }
        }
    }

    [SerializeField]
    private TMP_Text _betCaption;
    private void _0xcaa50e58()
    {
        if (this._0xf88618e5 != null && this._0xaac66b6a != null)
        {
            this._0xf88618e5._0xed68928c(this._0xaac66b6a.TotalCoins, this._0xaac66b6a.BetMultiple, _0xc3f86607._0x94c37df7);
        }
    }

    // --- readouts ------------------------------------------------------------
    private void _0xb381ac9e()
    {
        if (this._0x54ce7c23 != null)
        {
            for (int _0xbbde5ef6 = 0; _0xbbde5ef6 < _0xafff65e6.Cols; _0xbbde5ef6++)
            {
                if (this._0x54ce7c23[_0xbbde5ef6] == null)
                {
                    continue;
                }

                for (int _0x2b8ba8f8 = 0; _0x2b8ba8f8 < this._0x54ce7c23[_0xbbde5ef6].Length; _0x2b8ba8f8++)
                {
                    if (this._0x54ce7c23[_0xbbde5ef6][_0x2b8ba8f8] != null)
                    {
                        this._0x54ce7c23[_0xbbde5ef6][_0x2b8ba8f8]._0xb0a27e36();
                    }
                }
            }
        }

        if (this._lineChips == null)
        {
            return;
        }

        for (int _0x5a5dd261 = 0; _0x5a5dd261 < this._lineChips.Length; _0x5a5dd261++)
        {
            if (this._lineChips[_0x5a5dd261] != null)
            {
                this._lineChips[_0x5a5dd261].color = _0x21179992.Fade(_0x21179992.BgPanelHi, 0.8f);
            }
        }
    }

    private int _0x55e533fa;
    private System.Random _0x43973a1a;
    [SerializeField]
    private Image _balanceIcon;
    private void _0x7680f67c()
    {
        if (this._reelWindow != null && this._reelWindow.GetComponent<RectMask2D>() == null)
        {
            this._reelWindow.gameObject.AddComponent<RectMask2D>();
        }

        this._0x54ce7c23 = new _0x584aa2cd[_0xafff65e6.Cols][];
        for (int _0x1272662d = 0; _0x1272662d < _0xafff65e6.Cols; _0x1272662d++)
        {
            this._0x54ce7c23[_0x1272662d] = new _0x584aa2cd[StripCells];
            RectTransform _0x4bca758a = this._strips != null && _0x1272662d < this._strips.Length ? this._strips[_0x1272662d] : null;
            if (_0x4bca758a == null || this._cellPrefab == null)
            {
                continue;
            }

            for (int _0xade07c34 = 0; _0xade07c34 < StripCells; _0xade07c34++)
            {
                GameObject _0xdfcf6d40 = Instantiate(this._cellPrefab, _0x4bca758a, false);
                _0x584aa2cd _0x7d37a7c6 = _0xdfcf6d40.GetComponent<_0x584aa2cd>();
                if (_0x7d37a7c6 == null)
                {
                    continue;
                }

                _0x7d37a7c6._0x13d972e2(-(CellHead + (_0xade07c34 * CellPitch)));
                this._0x54ce7c23[_0x1272662d][_0xade07c34] = _0x7d37a7c6;
            }
        }
    }

    private void _0x6360acc0(int _0x5f9cbf24, int _0x92814567)
    {
        if (this._winReadout == null)
        {
            return;
        }

        if (_0x5f9cbf24 <= 0)
        {
            _0x32e32309.Apply(this._winReadout, "", 72f, 44f, _0x21179992.Mint);
            return;
        }

        _0x32e32309.Apply(this._winReadout, _0x411284df._0x9b30431f(new byte[4] { 126, 96, 103, 9 }, 41) + _0x32e32309.Coins(_0x5f9cbf24), 72f, 44f, _0x21179992.Mint);
        TMP_Text _0xf82eb10e = this._winReadout;
        int _0xb2290c3b = _0x5f9cbf24;
        DOVirtual.Float(0f, _0xb2290c3b, _0xafff65e6.WinCountUp, (_0x8d3e0638) => _0x32e32309.SetText(_0xf82eb10e, _0x411284df._0x9b30431f(new byte[4] { 104, 118, 113, 31 }, 63) + _0x32e32309.Coins((int)_0x8d3e0638))).SetLink(this.gameObject);
    }

    [SerializeField]
    private Button _spinButton;
    [SerializeField]
    private RectTransform[] _strips;
    [SerializeField]
    private Image _spinShadow;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
        if (this._betPlate != null)
        {
            DOTween.Kill(this._betPlate.transform);
        }

        if (this._strips == null)
        {
            return;
        }

        for (int _0xd1c1c119 = 0; _0xd1c1c119 < this._strips.Length; _0xd1c1c119++)
        {
            if (this._strips[_0xd1c1c119] != null)
            {
                DOTween.Kill(this._strips[_0xd1c1c119]);
            }
        }
    }

    private void _0xebcfa2c5(int _0xdb184639, int _0x7ea40517)
    {
        this._0x7e2ec317[_0xdb184639] = false;
        this._0xae906571[_0xdb184639] = _0x7ea40517;
        this._0x867549c3(_0xdb184639);
        RectTransform _0x5611f25e = this._strips != null && _0xdb184639 < this._strips.Length ? this._strips[_0xdb184639] : null;
        if (_0x5611f25e == null)
        {
            return;
        }

        _0x5611f25e.anchoredPosition = new Vector2(0f, CellPitch);
        _0x5611f25e.DOAnchorPosY(0f, _0xafff65e6.ReelSettle).SetEase(Ease.OutBack, 1.15f).SetLink(_0x5611f25e.gameObject);
    }

    [SerializeField]
    private TMP_Text _courtesyLabel;
    private void _0x78fb20ff()
    {
        int _0x9ed13c1f = _0xcf78378c.CurrentHall();
        if (this._reelFrame != null)
        {
            this._reelFrame.color = _0xcf78378c.HallTrim(_0x9ed13c1f);
        }

        if (this._boardBackdrop != null)
        {
            Color _0x15c3ba9c = _0xcf78378c.HallTint(_0x9ed13c1f);
            this._boardBackdrop.color = new Color(Mathf.Lerp(_0x21179992.BgDeep.r, _0x15c3ba9c.r, _0x15c3ba9c.a), Mathf.Lerp(_0x21179992.BgDeep.g, _0x15c3ba9c.g, _0x15c3ba9c.a), Mathf.Lerp(_0x21179992.BgDeep.b, _0x15c3ba9c.b, _0x15c3ba9c.a), 0.94f);
        }

        _0x32e32309.Apply(this._hallBanner, _0xcf78378c.HallName(_0x9ed13c1f), 44f, 34f, _0x21179992.Gold);
    }

    private int _0x9319ee91(_0xb856a94c _0x2946296e, int _0x0caa0ea8)
    {
        int _0x0d058d3e = 0;
        for (int _0x7fe2bbd6 = 0; _0x7fe2bbd6 < _0xafff65e6.Cols; _0x7fe2bbd6++)
        {
            for (int _0x657d8af5 = 0; _0x657d8af5 < _0xafff65e6.Rows; _0x657d8af5++)
            {
                if (_0x2946296e._0x970c7bd2(_0x7fe2bbd6, _0x657d8af5) == _0x0caa0ea8)
                {
                    _0x0d058d3e++;
                }
            }
        }

        return _0x0d058d3e;
    }

    private _0x6671a4c4 _0x8214c6b9;
    [SerializeField]
    private TMP_Text _spinLabel;
    [SerializeField]
    private TMP_Text _hallBanner;
    private _0x584aa2cd[][] _0x54ce7c23;
    private const int StateResolving = 2;
    // --- readouts ---
    [SerializeField]
    private TMP_Text _winReadout;
    [SerializeField]
    private TMP_Text _betMinusLabel;
    [SerializeField]
    private Image _spinFill;
    // --- spin ----------------------------------------------------------------
    private void _0x8803f2e4()
    {
        if (this._0xb070bae3 != StateIdle)
        {
            return;
        }

        int _0x0dfa9c46 = _0xc3f86607._0x6c9a9ff3;
        bool _0x32611cc6 = _0xc3f86607._0x395d8c11 > 0;
        if (!this._0xcdc07d56)
        {
            if (!_0x32611cc6 && _0xc3f86607._0x94c37df7 < _0x0dfa9c46)
            {
                this._0x11922092();
                return;
            }

            if (_0x32611cc6)
            {
                _0xc3f86607._0x395d8c11 = _0xc3f86607._0x395d8c11 - 1;
            }
            else
            {
                _0xc3f86607._0x94c37df7 = _0xc3f86607._0x94c37df7 - _0x0dfa9c46;
            }

            _0xc3f86607._0xe0fb96be = _0xc3f86607._0xe0fb96be + 1;
        }

        this._0x1abf0319(_0x0dfa9c46);
        this._0xaac66b6a = this._0x8214c6b9._0xb0e31425(this._0xebcdc7c1, _0x0dfa9c46);
        {
#if B_LOGS
            {
                Debug.Log($"[spin] seed={this._0x55e533fa} spin={_0xc3f86607._0xe0fb96be} bet={_0x0dfa9c46} demo={this._0xcdc07d56} win={this._0xaac66b6a.TotalCoins} lanterns={this._0xaac66b6a.Lanterns}");
            }
#endif
        }

        this._0xb070bae3 = StateSpinning;
        this._0xb381ac9e();
        this._0x6360acc0(0, 0);
        this._0xa39b92db();
        float _0x174854d9 = _0xc3f86607._0x9379774e ? _0xafff65e6.FastSpinScale : 1f;
        for (int _0xf99e6ab5 = 0; _0xf99e6ab5 < _0xafff65e6.Cols; _0xf99e6ab5++)
        {
            this._0x7e2ec317[_0xf99e6ab5] = true;
            this._0xb0de7d1e[_0xf99e6ab5] = 0f;
            int _0xfc62d126 = _0xf99e6ab5;
            int _0xbccab9c5 = this._0xebcdc7c1[_0xf99e6ab5];
            float _0x63c18f86 = (_0xafff65e6.BaseSpinTime + (_0xf99e6ab5 * _0xafff65e6.ReelStagger)) * _0x174854d9;
            DOVirtual.DelayedCall(_0x63c18f86, () => this._0xebcfa2c5(_0xfc62d126, _0xbccab9c5)).SetLink(this.gameObject);
        }

        float _0xaf59e0a3 = ((_0xafff65e6.BaseSpinTime + ((_0xafff65e6.Cols - 1) * _0xafff65e6.ReelStagger)) * _0x174854d9) + _0xafff65e6.ReelSettle;
        DOVirtual.DelayedCall(_0xaf59e0a3, () => this._0xb0489a8d()).SetLink(this.gameObject);
    }

    [SerializeField]
    private TMP_Text[] _lineChipLabels;
    [SerializeField]
    private TMP_Text _balanceValue;
    private void _0x1f4e9ef0(_0xb856a94c _0x7c32592e)
    {
        _0xaf17bb5a[] _0x7f589c70 = _0x64c39bc0.Active(new System.Random(_0xc3f86607._0xd3a73b97 * 7919));
        int _0xb7ebd816 = 0;
        _0xc3f86607._0xb81020ac = _0x7c32592e._0x81b3e2b7 ? 0 : _0xc3f86607._0xb81020ac + 1;
        if (_0x7c32592e.TotalCoins > 0)
        {
            _0xc3f86607._0x94c37df7 = _0xc3f86607._0x94c37df7 + _0x7c32592e.TotalCoins;
            if (_0x7c32592e.TotalCoins > _0xc3f86607._0x08d47a64)
            {
                _0xc3f86607._0x08d47a64 = _0x7c32592e.TotalCoins;
            }

            if (_0xc3f86607._0xa59a79ae && _0x7c32592e.BetMultiple >= 5)
            {
                Handheld.Vibrate();
            }
        }

        if (_0x7c32592e.CourtesySpins > 0)
        {
            _0xc3f86607._0x395d8c11 = _0xc3f86607._0x395d8c11 + _0x7c32592e.CourtesySpins;
        }

        int _0x8279eff9 = _0x7c32592e.TopSymbol >= 0 ? _0xcf78378c.Credit(_0x7c32592e.TopSymbol) : -1;
        if (_0x8279eff9 >= 0)
        {
            this._0x78fb20ff();
        }

        for (int _0x548d3ec8 = 0; _0x548d3ec8 < _0x7f589c70.Length; _0x548d3ec8++)
        {
            _0xb7ebd816 += this._0x613a633d(_0x7f589c70[_0x548d3ec8], _0x7c32592e, _0x8279eff9);
        }

        if (_0xb7ebd816 > 0)
        {
            _0xc3f86607._0x94c37df7 = _0xc3f86607._0x94c37df7 + _0xb7ebd816;
            {
#if B_LOGS
                {
                    Debug.Log($"[missions] bonus={_0xb7ebd816}");
                }
#endif
            }
        }
    }

    private const int StateSpinning = 1;
    [SerializeField]
    private Button _betPlusButton;
    private int _0x613a633d(_0xaf17bb5a _0x1ecb9eb8, _0xb856a94c _0x474cc3a1, int _0xa6efd367)
    {
        if (_0x1ecb9eb8 == null)
        {
            return 0;
        }

        int _0x5df7d19d = 0;
        if (_0x1ecb9eb8.Kind == _0x64c39bc0.KindRubies)
        {
            _0x5df7d19d = this._0x9319ee91(_0x474cc3a1, (int)_0x1e7d2097.Ruby);
        }
        else if (_0x1ecb9eb8.Kind == _0x64c39bc0.KindLanterns)
        {
            _0x5df7d19d = _0x474cc3a1.Lanterns;
        }
        else if (_0x1ecb9eb8.Kind == _0x64c39bc0.KindSpins)
        {
            _0x5df7d19d = 1;
        }
        else if (_0x1ecb9eb8.Kind == _0x64c39bc0.KindWildSubs)
        {
            _0x5df7d19d = this._0x1c0c0985(_0x474cc3a1) ? 1 : 0;
        }
        else if (_0x1ecb9eb8.Kind == _0x64c39bc0.KindWins)
        {
            _0x5df7d19d = _0x474cc3a1._0x81b3e2b7 ? 1 : 0;
        }
        else if (_0x1ecb9eb8.Kind == _0x64c39bc0.KindBottomWins)
        {
            _0x5df7d19d = _0x474cc3a1.LineCoins[2] > 0 ? 1 : 0;
        }
        else if (_0x1ecb9eb8.Kind == _0x64c39bc0.KindAlbumSlots)
        {
            _0x5df7d19d = _0x474cc3a1.TopSymbol >= 0 ? 1 : 0;
        }
        else if (_0x1ecb9eb8.Kind == _0x64c39bc0.KindSessionCoins)
        {
            _0x5df7d19d = _0x474cc3a1.TotalCoins;
        }
        else if (_0x1ecb9eb8.Kind == _0x64c39bc0.KindBigMultiple)
        {
            _0x5df7d19d = _0x474cc3a1.BetMultiple >= _0xafff65e6.BigWinBetMultiple ? 1 : 0;
        }

        return _0x64c39bc0.Advance(_0x1ecb9eb8, _0x5df7d19d);
    }

    [SerializeField]
    private Image _pauseIcon;
    [SerializeField]
    private TMP_Text _balanceLabel;
    [SerializeField]
    private RectTransform _reelWindow;
    [SerializeField]
    private Image _courtesyPlate;
    /// Two scripted, bounded outcomes, both disclosed in the log: the showcase spin of a fresh
    /// install, so a review run always holds a win frame, and a soft pity after a long dry run.
    /// Everything else is drawn straight from the session generator.
    private void _0x1abf0319(int _0xd7631e70)
    {
        bool _0x6e0c736a = !this._0xcdc07d56 && _0xc3f86607._0xe0fb96be == _0xafff65e6.ShowcaseSpin;
        bool _0xea296335 = !this._0xcdc07d56 && _0xc3f86607._0xb81020ac >= _0xafff65e6.SoftPitySpins;
        if (_0x6e0c736a)
        {
            int[] _0xb33b77fe =
            {
                (int)_0x1e7d2097.Ruby,
                (int)_0x1e7d2097.Crown
            };
            int _0xceeb2fd6 = _0xb33b77fe[this._0x43973a1a.Next(_0xb33b77fe.Length)];
            if (this._0x8214c6b9._0x0fa1acdf(_0xceeb2fd6, _0xafff65e6.ShowcaseMatches, this._0x43973a1a, this._0xebcdc7c1))
            {
                {
#if B_LOGS
                    {
                        Debug.Log($"[spin] scripted showcase symbol={_0xceeb2fd6} matches={_0xafff65e6.ShowcaseMatches}");
                    }
#endif
                }

                return;
            }
        }

        if (_0xea296335)
        {
            if (this._0x8214c6b9._0x0fa1acdf((int)_0x1e7d2097.Amethyst, 3, this._0x43973a1a, this._0xebcdc7c1))
            {
                {
#if B_LOGS
                    {
                        Debug.Log($"[spin] soft pity after {_0xc3f86607._0xb81020ac} dry spins");
                    }
#endif
                }

                return;
            }
        }

        for (int _0x1dea9857 = 0; _0x1dea9857 < _0xafff65e6.Cols; _0x1dea9857++)
        {
            this._0xebcdc7c1[_0x1dea9857] = this._0x43973a1a.Next(_0xafff65e6.StripStops);
        }
    }

    private void _0x95863704()
    {
        this._0xb08d092b = 0f;
        if (this._0xf88618e5 != null)
        {
            this._0xf88618e5._0x584b4d51(_0xc3f86607._0x94c37df7, _0xc3f86607._0x6c9a9ff3, _0xc3f86607._0xe0fb96be);
        }
    }

    [SerializeField]
    private Image _boardBackdrop;
    private int[][] _0xc0778dba;
    private void _0x8e9aadf9(int _0x09f33407)
    {
        this._0xb08d092b = 0f;
        if (this._0xb070bae3 != StateIdle)
        {
            return;
        }

        _0xc3f86607._0x973ef7b9 = _0xc3f86607._0x973ef7b9 + _0x09f33407;
        this._0xa39b92db();
        if (this._betPlate != null)
        {
            Transform _0x7547cc30 = this._betPlate.transform;
            _0x7547cc30.localScale = Vector3.one;
            _0x7547cc30.DOPunchScale(Vector3.one * 0.08f, 0.18f, 8, 0.6f).SetLink(this._betPlate.gameObject);
        }
    }

    public const float CellPitch = 216f;
    [SerializeField]
    private GameObject _cellPrefab;
    // --- input ---------------------------------------------------------------
    private void _0xd6cc63a6()
    {
        this._0xb08d092b = 0f;
        this._0xcdc07d56 = false;
        this._0x8803f2e4();
    }

    private void _0x96c388ec()
    {
        if (this._spinButton != null)
        {
            this._spinButton.onClick.AddListener(() => this._0xd6cc63a6());
        }

        if (this._betMinusButton != null)
        {
            this._betMinusButton.onClick.AddListener(() => this._0x8e9aadf9(-1));
        }

        if (this._betPlusButton != null)
        {
            this._betPlusButton.onClick.AddListener(() => this._0x8e9aadf9(1));
        }

        if (this._backButton != null)
        {
            this._backButton.onClick.AddListener(() => this._0xd36e7422());
        }

        if (this._pauseButton != null)
        {
            this._pauseButton.onClick.AddListener(() => this._0x95863704());
        }
    }

    [SerializeField]
    private Button _pauseButton;
    private const int StripCells = 5;
    private void Start()
    {
        _0xc3f86607.EnsureReady();
        int _0xd3a76325 = _0xc3f86607.NextSession();
        this._0x55e533fa = (_0xd3a76325 * 7919) ^ (_0xc3f86607._0xe0fb96be * 104729);
        this._0x43973a1a = new System.Random(this._0x55e533fa);
        this._0xc0778dba = new _0x2bbd6fac()._0xa71264bd(this._0x43973a1a)._0x2a2562a8();
        this._0x8214c6b9 = new _0x6671a4c4()._0x6b01e7a7(this._0xc0778dba);
        _0x2bbd6fac.Report(this._0x55e533fa, this._0xc0778dba);
        this._0xebcdc7c1 = new int[_0xafff65e6.Cols];
        this._0xae906571 = new int[_0xafff65e6.Cols];
        this._0x7e2ec317 = new bool[_0xafff65e6.Cols];
        this._0xb0de7d1e = new float[_0xafff65e6.Cols];
        this._0x9fcf4e6d();
        this._0x7680f67c();
        this._0x78fb20ff();
        this._0x96c388ec();
        for (int _0xa0735c63 = 0; _0xa0735c63 < _0xafff65e6.Cols; _0xa0735c63++)
        {
            this._0xebcdc7c1[_0xa0735c63] = this._0x43973a1a.Next(_0xafff65e6.StripStops);
            this._0xae906571[_0xa0735c63] = this._0xebcdc7c1[_0xa0735c63];
            this._0x867549c3(_0xa0735c63);
        }

        this._0xa39b92db();
        this._0x6360acc0(0, 0);
    }

    /// Explicit initialisation: this view lives in a prefab, so a scene-level presenter
    /// cannot be serialised into it.
    public void _0x35011e1c(_0xe1c471bb _0xbfbab703)
    {
        this._0xf88618e5 = _0xbfbab703;
    }

    [SerializeField]
    private TMP_Text[] _payLabels;
    private float[] _0xb0de7d1e;
    private int[] _0xebcdc7c1;
    private const int StateIdle = 0;
    private Sprite _0x8630b302(int _0xd3e21fe2)
    {
        if (this._gemArt == null || _0xd3e21fe2 < 0 || _0xd3e21fe2 >= this._gemArt.Length)
        {
            return null;
        }

        return this._gemArt[_0xd3e21fe2];
    }

    private void _0xa39b92db()
    {
        _0x32e32309.Apply(this._balanceValue, _0x32e32309.Coins(_0xc3f86607._0x94c37df7), 48f, 40f, _0x21179992.Gold);
        _0x32e32309.Apply(this._betValue, _0x32e32309.Coins(_0xc3f86607._0x6c9a9ff3), 44f, 34f, _0x21179992.Cream);
        bool _0x79ac38dd = this._0xb070bae3 == StateSpinning;
        if (this._spinButton != null)
        {
            this._spinButton.interactable = !_0x79ac38dd;
        }

        if (this._spinFill != null)
        {
            this._spinFill.color = _0x79ac38dd ? _0x21179992.Fade(_0x21179992.VioletDeep, 0.55f) : _0x21179992.VioletDeep;
        }

        _0x32e32309.Apply(this._spinLabel, _0x79ac38dd ? _0x411284df._0x9b30431f(new byte[8] { 76, 79, 86, 81, 81, 86, 81, 88 }, 31) : (_0xc3f86607._0x08d47a64 > 0 ? _0x411284df._0x9b30431f(new byte[10] { 25, 26, 3, 4, 106, 11, 13, 11, 3, 4 }, 74) : _0x411284df._0x9b30431f(new byte[4] { 187, 184, 161, 166 }, 232)), 62f, 44f, _0x21179992.Cream);
        bool _0x86b263e7 = _0xc3f86607._0x395d8c11 > 0;
        if (this._courtesyPlate != null)
        {
            this._courtesyPlate.gameObject.SetActive(_0x86b263e7);
        }

        if (_0x86b263e7)
        {
            _0x32e32309.Apply(this._courtesyLabel, _0x411284df._0x9b30431f(new byte[15] { 97, 109, 119, 112, 118, 103, 113, 123, 2, 113, 114, 107, 108, 113, 2 }, 34) + _0xc3f86607._0x395d8c11, 38f, 34f, _0x21179992.Cream);
        }

        if (this._betMinusButton != null)
        {
            this._betMinusButton.interactable = !_0x79ac38dd && _0xc3f86607._0x973ef7b9 > 0;
        }

        if (this._betPlusButton != null)
        {
            this._betPlusButton.interactable = !_0x79ac38dd && _0xc3f86607._0x973ef7b9 < _0xafff65e6.BetSteps.Length - 1;
        }
    }

    private void _0x11922092()
    {
        _0xc3f86607.GrantCourtesyCoins();
        this._0xa39b92db();
        if (this._0xf88618e5 != null)
        {
            this._0xf88618e5._0xb8a39f0b(_0xafff65e6.CourtesyGrant, _0xc3f86607._0x94c37df7);
        }
    }

    // --- controls ---
    [SerializeField]
    private Button _betMinusButton;
    private bool _0x1c0c0985(_0xb856a94c _0x22286d3e)
    {
        for (int _0xf19c5dbf = 0; _0xf19c5dbf < _0xafff65e6.Lines; _0xf19c5dbf++)
        {
            if (_0x22286d3e.LineCoins[_0xf19c5dbf] <= 0 || _0x22286d3e.LineSymbol[_0xf19c5dbf] == _0x1745229a.WildIndex)
            {
                continue;
            }

            int[] _0x7ee406a0 = _0x6671a4c4.RowsOfLine(_0xf19c5dbf);
            for (int _0x95e57168 = 0; _0x95e57168 < _0x22286d3e.LineMatches[_0xf19c5dbf]; _0x95e57168++)
            {
                if (_0x1745229a.Wild(_0x22286d3e._0x970c7bd2(_0x95e57168, _0x7ee406a0[_0x95e57168])))
                {
                    return true;
                }
            }
        }

        return false;
    }

    // --- cabinet ---
    [SerializeField]
    private Image _cabinetShadow;
    private int _0xb070bae3 = StateIdle;
    private _0xb856a94c _0xaac66b6a;
    [SerializeField]
    private TMP_Text _betValue;
    private void _0x5efab54a()
    {
        if (this._payIcons == null || this._payLabels == null)
        {
            return;
        }

        for (int _0xc40b0809 = 0; _0xc40b0809 < this._payIcons.Length && _0xc40b0809 < _0x1745229a.Count; _0xc40b0809++)
        {
            if (this._payIcons[_0xc40b0809] != null)
            {
                this._payIcons[_0xc40b0809].sprite = this._0x8630b302(_0xc40b0809);
                this._payIcons[_0xc40b0809].color = Color.white;
            }

            if (_0xc40b0809 >= this._payLabels.Length)
            {
                continue;
            }

            int _0x21a65a9a = _0x1745229a.LineMultiplier(_0xc40b0809, 3);
            _0x32e32309.Apply(this._payLabels[_0xc40b0809], _0x21a65a9a > 0 ? _0x411284df._0x9b30431f(new byte[1] { 159 }, 231) + _0x21a65a9a : _0x411284df._0x9b30431f(new byte[4] { 173, 185, 174, 174 }, 235), 32f, 34f, _0x21a65a9a > 0 ? _0x21179992.Gold : _0x21179992.Mint);
        }
    }

    [SerializeField]
    private TMP_Text _hint;
    private float _0xb08d092b;
    [SerializeField]
    private Image _spinPlate;
    private void _0x867549c3(int _0xa16080b4)
    {
        if (this._0x54ce7c23 == null || this._0x54ce7c23[_0xa16080b4] == null)
        {
            return;
        }

        for (int _0x5ec67a11 = 0; _0x5ec67a11 < this._0x54ce7c23[_0xa16080b4].Length; _0x5ec67a11++)
        {
            _0x584aa2cd _0x3f4da5f5 = this._0x54ce7c23[_0xa16080b4][_0x5ec67a11];
            if (_0x3f4da5f5 == null)
            {
                continue;
            }

            int _0x0e9887d7 = this._0xc0778dba[_0xa16080b4][(this._0xae906571[_0xa16080b4] + _0x5ec67a11) % _0xafff65e6.StripStops];
            _0x3f4da5f5.Show(_0x0e9887d7, this._0x8630b302(_0x0e9887d7));
        }
    }

    private const float SpinSpeed = 2600f;
    [SerializeField]
    private Image _reelFrame;
    private bool[] _0x7e2ec317;
    public const float CellHead = 102f;
    // --- paytable strip ---
    [SerializeField]
    private Image[] _payIcons;
    // --- result --------------------------------------------------------------
    private void _0xb0489a8d()
    {
        _0xb856a94c _0x465c09f7 = this._0xaac66b6a;
        this._0xb070bae3 = StateResolving;
        if (_0x465c09f7 == null)
        {
            this._0xb070bae3 = StateIdle;
            return;
        }

        if (!this._0xcdc07d56)
        {
            this._0x1f4e9ef0(_0x465c09f7);
        }

        this._0xe52672f7(_0x465c09f7);
        this._0x6360acc0(_0x465c09f7.TotalCoins, _0x465c09f7.BetMultiple);
        this._0xa39b92db();
        if (this._0xcdc07d56)
        {
            _0x32e32309.Apply(this._hint, _0x411284df._0x9b30431f(new byte[29] { 217, 222, 196, 194, 212, 177, 213, 212, 220, 222, 177, 188, 177, 197, 208, 193, 177, 194, 193, 216, 223, 177, 197, 222, 177, 193, 221, 208, 200 }, 145), 38f, 34f, _0x21179992.Gold);
        }
        else
        {
            _0x32e32309.Apply(this._hint, _0x411284df._0x9b30431f(new byte[28] { 222, 203, 218, 170, 217, 218, 195, 196, 170, 167, 170, 191, 170, 216, 207, 207, 198, 217, 170, 167, 170, 191, 170, 198, 195, 196, 207, 217 }, 138), 38f, 34f, _0x21179992.TextMuted);
        }

        bool _0xd0bff73d = !this._0xcdc07d56 && _0x465c09f7.BetMultiple >= _0xafff65e6.BigWinBetMultiple;
        if (_0xd0bff73d && this._0xf88618e5 != null)
        {
            DOVirtual.DelayedCall(_0xafff65e6.ResultBeat, () => this._0xcaa50e58()).SetLink(this.gameObject);
        }

        DOVirtual.DelayedCall(_0xafff65e6.ResultBeat, () => this._0x8d410223()).SetLink(this.gameObject);
    }

    private bool _0xcdc07d56;
    [SerializeField]
    private Image _backIcon;
    private _0xe1c471bb _0xf88618e5;
    private _0x584aa2cd _0xab1f3c23(int _0xea5f2094, int _0xd3e937a8)
    {
        if (this._0x54ce7c23 == null || _0xea5f2094 < 0 || _0xea5f2094 >= this._0x54ce7c23.Length || this._0x54ce7c23[_0xea5f2094] == null)
        {
            return null;
        }

        return _0xd3e937a8 >= 0 && _0xd3e937a8 < this._0x54ce7c23[_0xea5f2094].Length ? this._0x54ce7c23[_0xea5f2094][_0xd3e937a8] : null;
    }

    // --- set-up --------------------------------------------------------------
    private void _0x9fcf4e6d()
    {
        if (this._cabinetShadow != null)
        {
            this._cabinetShadow.color = _0x21179992.Fade(_0x21179992.Shadow, 0.45f);
        }

        if (this._balancePlate != null)
        {
            this._balancePlate.color = _0x21179992.Fade(_0x21179992.BgPanelHi, 0.92f);
        }

        if (this._betPlate != null)
        {
            this._betPlate.color = _0x21179992.Fade(_0x21179992.BgPanelHi, 0.92f);
        }

        if (this._courtesyPlate != null)
        {
            this._courtesyPlate.color = _0x21179992.Fade(_0x21179992.Mint, 0.35f);
        }

        if (this._spinShadow != null)
        {
            this._spinShadow.color = _0x21179992.Fade(_0x21179992.GoldDeep, 0.55f);
        }

        if (this._spinPlate != null)
        {
            this._spinPlate.color = _0x21179992.Gold;
        }

        if (this._backIcon != null)
        {
            this._backIcon.color = _0x21179992.Gold;
        }

        if (this._pauseIcon != null)
        {
            this._pauseIcon.color = _0x21179992.Gold;
        }

        if (this._balanceIcon != null)
        {
            this._balanceIcon.color = Color.white;
        }

        _0x32e32309.Apply(this._balanceLabel, _0x411284df._0x9b30431f(new byte[7] { 240, 243, 254, 243, 252, 241, 247 }, 178), 30f, 34f, _0x21179992.TextMuted);
        _0x32e32309.Apply(this._hint, _0x411284df._0x9b30431f(new byte[28] { 53, 32, 49, 65, 50, 49, 40, 47, 65, 76, 65, 84, 65, 51, 36, 36, 45, 50, 65, 76, 65, 84, 65, 45, 40, 47, 36, 50 }, 97), 38f, 34f, _0x21179992.TextMuted);
        _0x32e32309.Apply(this._betCaption, _0x411284df._0x9b30431f(new byte[3] { 158, 153, 136 }, 220), 32f, 34f, _0x21179992.TextMuted);
        _0x32e32309.Apply(this._betMinusLabel, _0x411284df._0x9b30431f(new byte[1] { 89 }, 116), 56f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._betPlusLabel, _0x411284df._0x9b30431f(new byte[1] { 190 }, 149), 56f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._compliance, _0x411284df._0x9b30431f(new byte[55] { 38, 57, 34, 36, 37, 49, 60, 80, 51, 63, 57, 62, 35, 80, 63, 62, 60, 41, 80, 93, 80, 62, 63, 80, 34, 53, 49, 60, 80, 61, 63, 62, 53, 41, 80, 93, 80, 62, 63, 80, 32, 37, 34, 51, 56, 49, 35, 53, 35, 80, 93, 80, 65, 72, 91 }, 112), 34f, 34f, _0x21179992.TextMuted);
        for (int _0x80e6888d = 0; _0x80e6888d < _0xafff65e6.Lines; _0x80e6888d++)
        {
            if (this._lineChipLabels != null && _0x80e6888d < this._lineChipLabels.Length)
            {
                _0x32e32309.Apply(this._lineChipLabels[_0x80e6888d], _0x411284df._0x9b30431f(new byte[1] { 177 }, 253) + (_0x80e6888d + 1), 32f, 34f, _0x21179992.Cream);
            }
        }

        this._0x5efab54a();
    }

    [SerializeField]
    private Image _balancePlate;
    // --- loop ----------------------------------------------------------------
    private void Update()
    {
        if (_0xf44d047f.Instance == null || !_0xf44d047f.Instance._0x892b5715)
        {
            return;
        }

        float dt = Time.deltaTime;
        if (this._0xb070bae3 == StateSpinning)
        {
            for (int _0xba279380 = 0; _0xba279380 < _0xafff65e6.Cols; _0xba279380++)
            {
                if (!this._0x7e2ec317[_0xba279380])
                {
                    continue;
                }

                this._0xb0de7d1e[_0xba279380] += SpinSpeed * dt;
                while (this._0xb0de7d1e[_0xba279380] >= CellPitch)
                {
                    this._0xb0de7d1e[_0xba279380] -= CellPitch;
                    this._0xae906571[_0xba279380] = ((this._0xae906571[_0xba279380] - 1) + _0xafff65e6.StripStops) % _0xafff65e6.StripStops;
                    this._0x867549c3(_0xba279380);
                }

                RectTransform _0x8e8724c7 = this._strips[_0xba279380];
                if (_0x8e8724c7 != null)
                {
                    // Down, never up: the wrap above moves the strip content one cell DOWN
                    // (the index steps back), so the sweep in between has to travel the same
                    // way or every wrap reads as a jump back. The settle in StopColumn drops
                    // the strip in from above for the same reason.
                    _0x8e8724c7.anchoredPosition = new Vector2(0f, -this._0xb0de7d1e[_0xba279380]);
                }
            }

            return;
        }

        if (this._0xb070bae3 != StateIdle)
        {
            return;
        }

        this._0xb08d092b += dt;
        if (this._0xb08d092b >= _0xafff65e6.IdleDemoDelay)
        {
            this._0xb08d092b = 0f;
            this._0xcdc07d56 = true;
            this._0x8803f2e4();
        }
    }
}

internal static class _0x411284df
{
    internal static string _0x9b30431f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}