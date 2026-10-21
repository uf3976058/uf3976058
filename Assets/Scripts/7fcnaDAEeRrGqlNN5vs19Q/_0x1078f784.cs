using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The seven day ladder of fictional coins. Keyed on the local calendar date - no network,
/// no server time, nothing bought and nothing redeemable.
public sealed class _0x1078f784 : MonoBehaviour
{
    [SerializeField]
    private GameObject _tilePrefab;
    private void _0x2de4aaa2()
    {
        if (this._0x20b06b80)
        {
            return;
        }

        this._0x20b06b80 = true;
        if (this._cardPlate != null)
        {
            this._cardPlate.color = _0x21179992.Fade(_0x21179992.BgPanel, 0.98f);
        }

        _0x32e32309.Apply(this._heading, _0x98a2229b._0x2fcd0503(new byte[11] { 253, 248, 240, 245, 224, 153, 234, 237, 248, 250, 242 }, 185), 72f, 48f, _0x21179992.Cream);
        _0x32e32309.Apply(this._note, _0x98a2229b._0x2fcd0503(new byte[15] { 65, 64, 75, 46, 93, 90, 79, 77, 69, 46, 79, 46, 74, 79, 87 }, 14) + _0x98a2229b._0x2fcd0503(new byte[1] { 70 }, 76) + _0x98a2229b._0x2fcd0503(new byte[37] { 13, 9, 19, 19, 96, 1, 96, 4, 1, 25, 96, 1, 14, 4, 96, 20, 8, 5, 96, 12, 1, 4, 4, 5, 18, 96, 19, 20, 1, 18, 20, 19, 96, 15, 22, 5, 18 }, 64), 38f, 34f, _0x21179992.TextMuted);
        _0x32e32309.Apply(this._backLabel, _0x98a2229b._0x2fcd0503(new byte[12] { 18, 17, 19, 27, 112, 4, 31, 112, 24, 17, 28, 28 }, 80), 44f, 34f, _0x21179992.Cream);
        if (this._claimButton != null)
        {
            this._claimButton.onClick.AddListener(() => this._0xaf472f5d());
        }

        if (this._backButton != null)
        {
            this._backButton.onClick.AddListener(() => this._0xba7c8b90());
        }
    }

    [SerializeField]
    private TMP_Text _claimLabel;
    private bool _0x20b06b80;
    private void _0x5ea42be0()
    {
        bool _0x91a4d71f = _0xc3f86607._0x94b00b40;
        if (this._claimButton != null)
        {
            this._claimButton.interactable = !_0x91a4d71f;
        }

        if (this._claimPlate != null)
        {
            this._claimPlate.color = _0x91a4d71f ? _0x21179992.Fade(_0x21179992.BgPanelHi, 0.70f) : _0x21179992.Violet;
        }

        _0x32e32309.Apply(this._claimLabel, _0x91a4d71f ? _0x98a2229b._0x2fcd0503(new byte[18] { 154, 150, 148, 156, 249, 155, 152, 154, 146, 249, 141, 150, 148, 150, 139, 139, 150, 142 }, 217) : _0x98a2229b._0x2fcd0503(new byte[6] { 27, 20, 25, 17, 21, 120 }, 88) + _0x32e32309.Coins(_0xc3f86607._0x8e3bb66f) + _0x98a2229b._0x2fcd0503(new byte[6] { 128, 227, 239, 233, 238, 243 }, 160), 48f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._hint, _0x91a4d71f ? _0x98a2229b._0x2fcd0503(new byte[18] { 138, 145, 154, 159, 135, 254, 151, 141, 254, 157, 145, 146, 146, 155, 157, 138, 155, 154 }, 222) + _0x98a2229b._0x2fcd0503(new byte[1] { 171 }, 161) + _0x98a2229b._0x2fcd0503(new byte[28] { 108, 112, 125, 24, 118, 125, 96, 108, 24, 108, 113, 116, 125, 24, 119, 104, 125, 118, 107, 24, 108, 119, 117, 119, 106, 106, 119, 111 }, 56) : _0x98a2229b._0x2fcd0503(new byte[30] { 60, 41, 56, 72, 43, 36, 41, 33, 37, 72, 60, 39, 72, 41, 44, 44, 72, 60, 39, 44, 41, 49, 79, 59, 72, 59, 60, 41, 43, 35 }, 104), 38f, 34f, _0x21179992.TextMuted);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    [SerializeField]
    private TMP_Text _backLabel;
    private void _0xaf472f5d()
    {
        if (_0xc3f86607._0x94b00b40)
        {
            return;
        }

        _0xc3f86607.ClaimDaily();
        this._0xb344b55e();
        this._0xb58266b7();
        if (this._lobby != null)
        {
            this._lobby._0xe21bb561();
        }
    }

    [SerializeField]
    private _0x708fc31f _lobby;
    private const float TilePitchX = 248f;
    [SerializeField]
    private GameObject _burstPrefab;
    /// Eight tokens thrown outward from the ladder, so the claim is visible on a still frame.
    private void _0xb344b55e()
    {
        if (this._burstPrefab == null || this._grid == null || _0xc3f86607._0xfc99299a)
        {
            return;
        }

        for (int _0xe6ac6e89 = 0; _0xe6ac6e89 < 8; _0xe6ac6e89++)
        {
            GameObject _0x1f176e14 = Instantiate(this._burstPrefab, this._grid, false);
            _0x1f176e14.SetActive(true);
            RectTransform _0x7973e700 = _0x1f176e14.transform as RectTransform;
            Image _0x263903fe = _0x1f176e14.GetComponent<Image>();
            if (_0x7973e700 == null)
            {
                continue;
            }

            _0x7973e700.anchoredPosition = Vector2.zero;
            float _0x66017d37 = _0xe6ac6e89 * 45f * Mathf.Deg2Rad;
            Vector2 _0x15fc7818 = new Vector2(Mathf.Cos(_0x66017d37), Mathf.Sin(_0x66017d37)) * 300f;
            _0x7973e700.DOAnchorPos(_0x15fc7818, 0.6f).SetEase(Ease.OutCubic).SetLink(_0x1f176e14);
            if (_0x263903fe != null)
            {
                _0x263903fe.DOFade(0f, 0.6f).SetLink(_0x1f176e14);
            }

            Destroy(_0x1f176e14, 0.8f);
        }
    }

    [SerializeField]
    private Button _backButton;
    [SerializeField]
    private TMP_Text _heading;
    [SerializeField]
    private Image _cardPlate;
    public void _0xd8933b94()
    {
        this._0x2de4aaa2();
        this._0xb58266b7();
    }

    [SerializeField]
    private TMP_Text _note;
    private void _0xb58266b7()
    {
        if (this._grid != null && this._tilePrefab != null)
        {
            for (int _0x2bfcaf95 = this._grid.childCount - 1; _0x2bfcaf95 >= 0; _0x2bfcaf95--)
            {
                Destroy(this._grid.GetChild(_0x2bfcaf95).gameObject);
            }

            int _0x090cd98f = _0xc3f86607._0x35605d49;
            bool _0x04cbe481 = _0xc3f86607._0x94b00b40;
            for (int _0xfd639081 = 1; _0xfd639081 <= _0xafff65e6.DailyLadder.Length; _0xfd639081++)
            {
                GameObject _0x6cb1563e = Instantiate(this._tilePrefab, this._grid, false);
                RectTransform _0xd1db38eb = _0x6cb1563e.transform as RectTransform;
                if (_0xd1db38eb != null)
                {
                    bool _0x72bb3a47 = _0xfd639081 <= 4;
                    int _0xc8752f6a = _0x72bb3a47 ? _0xfd639081 - 1 : _0xfd639081 - 5;
                    int _0xa9fc8034 = _0x72bb3a47 ? 4 : 3;
                    float _0xb8660671 = (_0xc8752f6a - ((_0xa9fc8034 - 1) * 0.5f)) * TilePitchX;
                    _0xd1db38eb.anchoredPosition = new Vector2(_0xb8660671, _0x72bb3a47 ? RowY : -RowY);
                }

                int _0xa560d676 = _0xfd639081 < _0x090cd98f || (_0xfd639081 == _0x090cd98f && _0x04cbe481) ? 2 : (_0xfd639081 == _0x090cd98f ? 1 : 0);
                _0x04493928 _0x2df79849 = _0x6cb1563e.GetComponent<_0x04493928>();
                if (_0x2df79849 != null)
                {
                    _0x2df79849._0xaeb96a72(_0xfd639081, _0xafff65e6.DailyLadder[_0xfd639081 - 1], _0xa560d676);
                }
            }
        }

        this._0x5ea42be0();
    }

    [SerializeField]
    private Button _claimButton;
    [SerializeField]
    private Image _claimPlate;
    [SerializeField]
    private RectTransform _grid;
    [SerializeField]
    private TMP_Text _hint;
    private const float RowY = 135f;
    private void _0xba7c8b90()
    {
        if (this._lobby != null)
        {
            this._lobby._0x586aa695();
        }
    }
}

internal static class _0x98a2229b
{
    internal static string _0x2fcd0503(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}