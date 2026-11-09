using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The Gem Hall lobby. Everything here is this game's own object: the balance readout, the
/// mission strip, the album teaser and the four sheets. The PLAY slot underneath is the
/// template's own button (it carries the scene driver); this view only draws its face, with
/// every face graphic raycast-transparent so the tap reaches the button below.
public sealed class _0x708fc31f : MonoBehaviour
{
    [SerializeField]
    private Button _dailyButton;
    [SerializeField]
    private _0x1078f784 _dailySheet;
    [SerializeField]
    private TMP_Text _balanceValue;
    private void _0x28e0c313()
    {
        if (this._balancePlate != null)
        {
            this._balancePlate.color = _0x21179992.Fade(_0x21179992.BgPanelHi, 0.92f);
        }

        if (this._albumPlate != null)
        {
            this._albumPlate.color = _0x21179992.Fade(_0x21179992.BgPanel, 0.92f);
        }

        if (this._sheetBackdrop != null)
        {
            this._sheetBackdrop.color = _0x21179992.Fade(_0x21179992.BgDeep, 0.80f);
        }

        if (this._blobs == null)
        {
            return;
        }

        for (int _0x6a5f2aa1 = 0; _0x6a5f2aa1 < this._blobs.Length; _0x6a5f2aa1++)
        {
            Image _0xbbc10fd1 = this._blobs[_0x6a5f2aa1] == null ? null : this._blobs[_0x6a5f2aa1].GetComponent<Image>();
            if (_0xbbc10fd1 != null)
            {
                _0xbbc10fd1.color = _0x21179992.Fade(_0x6a5f2aa1 == 1 ? _0x21179992.Mint : _0x21179992.Violet, 0.10f);
            }
        }
    }

    [SerializeField]
    private TMP_Text _missionsHeading;
    private void _0x9060d735(GameObject _0x592b5c3a)
    {
        this._0x1c722a01 = _0x592b5c3a;
        if (this._sheetBackdrop != null)
        {
            this._sheetBackdrop.gameObject.SetActive(true);
            this._sheetBackdrop.color = _0x21179992.Fade(_0x21179992.BgDeep, 0f);
            this._sheetBackdrop.DOFade(0.80f, 0.22f).SetLink(this._sheetBackdrop.gameObject);
        }

        _0x592b5c3a.SetActive(true);
        _0x592b5c3a.transform.localScale = Vector3.one * 0.92f;
        _0x592b5c3a.transform.DOScale(1f, 0.30f).SetEase(Ease.OutBack).SetLink(_0x592b5c3a);
    }

    private void Start()
    {
        _0xc3f86607.EnsureReady();
        _0xc3f86607.RollDaily();
        if (this._crest != null)
        {
            this._crest.color = Color.white;
        }

        _0x32e32309.Apply(this._heading, _0xbab275a7._0x0b7a353d(new byte[12] { 152, 132, 137, 236, 139, 137, 129, 236, 132, 141, 128, 128 }, 204), 72f, 48f, _0x21179992.Cream);
        _0x32e32309.Apply(this._balanceLabel, _0xbab275a7._0x0b7a353d(new byte[7] { 109, 110, 99, 110, 97, 108, 106 }, 47), 34f, 34f, _0x21179992.TextMuted);
        _0x32e32309.Apply(this._missionsHeading, _0xbab275a7._0x0b7a353d(new byte[8] { 10, 14, 20, 20, 14, 8, 9, 20 }, 71), 44f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._albumTitle, _0xbab275a7._0x0b7a353d(new byte[9] { 178, 176, 184, 213, 180, 185, 183, 160, 184 }, 245), 44f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._hint, _0xbab275a7._0x0b7a353d(new byte[27] { 145, 132, 246, 225, 225, 232, 247, 132, 137, 132, 145, 132, 232, 237, 234, 225, 247, 132, 137, 132, 235, 234, 225, 132, 240, 229, 244 }, 164), 38f, 34f, _0x21179992.TextMuted);
        _0x32e32309.Apply(this._playLabel, _0xbab275a7._0x0b7a353d(new byte[4] { 105, 117, 120, 96 }, 57), 62f, 44f, _0x21179992.Cream);
        _0x32e32309.Apply(this._compliance, _0xbab275a7._0x0b7a353d(new byte[55] { 63, 32, 59, 61, 60, 40, 37, 73, 42, 38, 32, 39, 58, 73, 38, 39, 37, 48, 73, 68, 73, 39, 38, 73, 59, 44, 40, 37, 73, 36, 38, 39, 44, 48, 73, 68, 73, 39, 38, 73, 57, 60, 59, 42, 33, 40, 58, 44, 58, 73, 68, 73, 88, 81, 66 }, 105), 34f, 34f, _0x21179992.TextMuted);
        _0x32e32309.Apply(this._dailyLabel, _0xbab275a7._0x0b7a353d(new byte[11] { 10, 15, 7, 2, 23, 110, 29, 26, 15, 13, 5 }, 78), 40f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._albumLabel, _0xbab275a7._0x0b7a353d(new byte[9] { 126, 124, 116, 25, 120, 117, 123, 108, 116 }, 57), 40f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._settingsLabel, _0xbab275a7._0x0b7a353d(new byte[8] { 159, 137, 152, 152, 133, 130, 139, 159 }, 204), 40f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._howToLabel, _0xbab275a7._0x0b7a353d(new byte[11] { 24, 31, 7, 112, 4, 31, 112, 0, 28, 17, 9 }, 80), 38f, 34f, _0x21179992.Gold);
        this._0xfdcaf2df();
        this._0x28e0c313();
        this._0x1bc50239();
        this._0xe21bb561();
        this._0x16e2f0b0();
        this._0xc1eb69bd();
        this._0x586aa695();
        this._0x009e44bb();
    }

    [SerializeField]
    private TMP_Text _compliance;
    [SerializeField]
    private Button _howToButton;
    [SerializeField]
    private RectTransform[] _missionSlots;
    [SerializeField]
    private Image _playPlate;
    private void _0x16e2f0b0()
    {
        if (this._albumCounters == null)
        {
            return;
        }

        for (int _0xce30d612 = 0; _0xce30d612 < this._albumCounters.Length; _0xce30d612++)
        {
            bool _0xcd82456c = _0xcf78378c.Complete(_0xce30d612);
            _0x32e32309.Apply(this._albumCounters[_0xce30d612], _0xcf78378c.Counter(_0xce30d612), 36f, 34f, _0xcd82456c ? _0x21179992.Mint : _0x21179992.Gold);
            if (this._albumCrests != null && _0xce30d612 < this._albumCrests.Length && this._albumCrests[_0xce30d612] != null)
            {
                this._albumCrests[_0xce30d612].color = _0xcd82456c ? Color.white : _0x21179992.Fade(Color.white, 0.55f);
            }
        }
    }

    [SerializeField]
    private TMP_Text _heading;
    [SerializeField]
    private Image _sheetBackdrop;
    private void OnDestroy()
    {
        if (this._blobs != null)
        {
            for (int _0xfde9ea76 = 0; _0xfde9ea76 < this._blobs.Length; _0xfde9ea76++)
            {
                if (this._blobs[_0xfde9ea76] != null)
                {
                    DOTween.Kill(this._blobs[_0xfde9ea76]);
                }
            }
        }

        if (this._crest != null)
        {
            DOTween.Kill(this._crest.transform);
        }

        if (this._playPlate != null)
        {
            DOTween.Kill(this._playPlate.transform);
        }

        if (this._sheetBackdrop != null)
        {
            DOTween.Kill(this._sheetBackdrop);
        }
    }

    [SerializeField]
    private Image _crest;
    /// Fewer than two live rows and the strip is replaced by one themed line - a single
    /// orphaned card reads as a bug, and an empty band reads as a missing feature.
    private void _0x1bc50239()
    {
        if (this._missionSlots == null || this._missionCardPrefab == null)
        {
            return;
        }

        _0xaf17bb5a[] _0xcb489b5f = _0x64c39bc0.Active(new System.Random(_0xc3f86607._0xd3a73b97 * 7919));
        int _0x6086e301 = 0;
        for (int _0xb9876d75 = 0; _0xb9876d75 < this._missionSlots.Length; _0xb9876d75++)
        {
            RectTransform _0xaaaedfa3 = this._missionSlots[_0xb9876d75];
            if (_0xaaaedfa3 == null)
            {
                continue;
            }

            for (int _0x43eec33b = _0xaaaedfa3.childCount - 1; _0x43eec33b >= 0; _0x43eec33b--)
            {
                Destroy(_0xaaaedfa3.GetChild(_0x43eec33b).gameObject);
            }

            bool _0x335d7a98 = _0xb9876d75 < _0xcb489b5f.Length && _0xcb489b5f[_0xb9876d75] != null;
            _0xaaaedfa3.gameObject.SetActive(_0x335d7a98);
            if (!_0x335d7a98)
            {
                continue;
            }

            GameObject _0x454036c7 = Instantiate(this._missionCardPrefab, _0xaaaedfa3, false);
            RectTransform _0xe888a1b1 = _0x454036c7.transform as RectTransform;
            if (_0xe888a1b1 != null)
            {
                _0xe888a1b1.anchoredPosition = Vector2.zero;
            }

            _0xa2c1fd78 _0xffb4fed1 = _0x454036c7.GetComponent<_0xa2c1fd78>();
            if (_0xffb4fed1 != null)
            {
                _0xffb4fed1._0x71dfe221(_0xcb489b5f[_0xb9876d75]);
            }

            _0x6086e301++;
        }

        bool _0x07de3389 = _0x6086e301 >= 2;
        if (this._missionsEmpty != null)
        {
            this._missionsEmpty.gameObject.SetActive(!_0x07de3389);
            _0x32e32309.Apply(this._missionsEmpty, _0xbab275a7._0x0b7a353d(new byte[15] { 35, 34, 77, 32, 36, 62, 62, 36, 34, 35, 62, 77, 52, 40, 57 }, 109) + _0xbab275a7._0x0b7a353d(new byte[1] { 102 }, 108) + _0xbab275a7._0x0b7a353d(new byte[26] { 218, 217, 192, 199, 169, 221, 198, 169, 198, 217, 204, 199, 169, 221, 193, 204, 169, 207, 192, 219, 218, 221, 169, 198, 199, 204 }, 137), 38f, 34f, _0x21179992.TextMuted);
        }

        if (!_0x07de3389)
        {
            for (int _0xbc335497 = 0; _0xbc335497 < this._missionSlots.Length; _0xbc335497++)
            {
                if (this._missionSlots[_0xbc335497] != null)
                {
                    this._missionSlots[_0xbc335497].gameObject.SetActive(false);
                }
            }
        }
    }

    [SerializeField]
    private Image _playFill;
    [SerializeField]
    private _0x24bc76a3 _settingsSheet;
    // --- content -------------------------------------------------------------
    public void _0xe21bb561()
    {
        _0x32e32309.Apply(this._balanceValue, _0x32e32309.Coins(_0xc3f86607._0x94c37df7), 56f, 40f, _0x21179992.Gold);
    }

    /// Called by every sheet's BACK bar, and once at start-up to put the lobby in a known state.
    public void _0x586aa695()
    {
        if (this._dailySheet != null)
        {
            this._dailySheet.gameObject.SetActive(false);
        }

        if (this._gemAlbumSheet != null)
        {
            this._gemAlbumSheet.gameObject.SetActive(false);
        }

        if (this._settingsSheet != null)
        {
            this._settingsSheet.gameObject.SetActive(false);
        }

        if (this._howToSheet != null)
        {
            this._howToSheet.gameObject.SetActive(false);
        }

        if (this._sheetBackdrop != null)
        {
            this._sheetBackdrop.gameObject.SetActive(false);
        }

        this._0x1c722a01 = null;
        this._0xe21bb561();
        this._0x16e2f0b0();
        this._0x1bc50239();
    }

    private void _0xc1eb69bd()
    {
        if (this._dailyButton != null)
        {
            this._dailyButton.onClick.AddListener(() => this._0x3c5c70fe());
        }

        if (this._albumButton != null)
        {
            this._albumButton.onClick.AddListener(() => this._0x8d3c8b6f());
        }

        if (this._settingsButton != null)
        {
            this._settingsButton.onClick.AddListener(() => this._0xd59df78e());
        }

        if (this._howToButton != null)
        {
            this._howToButton.onClick.AddListener(() => this._0x45d40066());
        }
    }

    [SerializeField]
    private TMP_Text _hint;
    [SerializeField]
    private Button _settingsButton;
    [SerializeField]
    private TMP_Text _albumLabel;
    [SerializeField]
    private RectTransform[] _blobs;
    private GameObject _0x1c722a01;
    [SerializeField]
    private TMP_Text _missionsEmpty;
    [SerializeField]
    private Image _playShadow;
    // --- motion --------------------------------------------------------------
    private void _0x009e44bb()
    {
        if (this._crest != null)
        {
            this._crest.transform.localScale = Vector3.one * 0.9f;
            this._crest.transform.DOScale(1f, 0.45f).SetEase(Ease.OutBack).SetLink(this._crest.gameObject);
        }

        if (this._playPlate != null)
        {
            this._playPlate.transform.localScale = Vector3.one * 0.9f;
            this._playPlate.transform.DOScale(1f, 0.45f).SetEase(Ease.OutBack).SetDelay(0.25f).SetLink(this._playPlate.gameObject);
        }

        if (this._blobs == null)
        {
            return;
        }

        for (int _0x2d818f20 = 0; _0x2d818f20 < this._blobs.Length; _0x2d818f20++)
        {
            RectTransform _0x0c9629d4 = this._blobs[_0x2d818f20];
            if (_0x0c9629d4 == null)
            {
                continue;
            }

            Vector2 _0xa8777255 = _0x0c9629d4.anchoredPosition;
            _0x0c9629d4.DOAnchorPos(_0xa8777255 + new Vector2(_0x2d818f20 % 2 == 0 ? 70f : -70f, 50f), 9f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0x0c9629d4.gameObject);
        }
    }

    [SerializeField]
    private Image[] _albumCrests;
    [SerializeField]
    private TMP_Text _dailyLabel;
    private void _0x8d3c8b6f()
    {
        if (this._gemAlbumSheet != null)
        {
            this._gemAlbumSheet._0xdc2affe3();
            this._0x9060d735(this._gemAlbumSheet.gameObject);
        }
    }

    // --- sheets --------------------------------------------------------------
    private void _0x3c5c70fe()
    {
        if (this._dailySheet != null)
        {
            this._dailySheet._0xd8933b94();
            this._0x9060d735(this._dailySheet.gameObject);
        }
    }

    [SerializeField]
    private _0x6c0d1ebf _gemAlbumSheet;
    [SerializeField]
    private Button _albumButton;
    [SerializeField]
    private TMP_Text _howToLabel;
    private void _0x45d40066()
    {
        if (this._howToSheet != null)
        {
            this._howToSheet._0x1ad2b4b5();
            this._0x9060d735(this._howToSheet.gameObject);
        }
    }

    private void _0xd59df78e()
    {
        if (this._settingsSheet != null)
        {
            this._settingsSheet._0x147d1e85();
            this._0x9060d735(this._settingsSheet.gameObject);
        }
    }

    public bool _0x3789e992
    {
        get
        {
            return this._0x1c722a01 != null;
        }
    }

    [SerializeField]
    private Image _balancePlate;
    private void _0xfdcaf2df()
    {
        if (this._playShadow != null)
        {
            this._playShadow.color = _0x21179992.Fade(_0x21179992.GoldDeep, 0.55f);
        }

        if (this._playPlate != null)
        {
            this._playPlate.color = _0x21179992.Gold;
        }

        if (this._playFill != null)
        {
            this._playFill.color = _0x21179992.VioletDeep;
        }
    }

    [SerializeField]
    private Image _albumPlate;
    [SerializeField]
    private TMP_Text _balanceLabel;
    [SerializeField]
    private GameObject _missionCardPrefab;
    [SerializeField]
    private TMP_Text[] _albumCounters;
    [SerializeField]
    private TMP_Text _settingsLabel;
    [SerializeField]
    private _0xfdab11f6 _howToSheet;
    [SerializeField]
    private TMP_Text _playLabel;
    [SerializeField]
    private TMP_Text _albumTitle;
}

internal static class _0xbab275a7
{
    internal static string _0x0b7a353d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}