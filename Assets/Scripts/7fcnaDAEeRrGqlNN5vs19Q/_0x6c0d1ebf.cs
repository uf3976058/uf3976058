using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Three albums of six slots. Filling one unlocks a hall, and that is visible beyond this
/// sheet: the cabinet's banner, trim colour and backdrop tint all follow it (C.7).
public sealed class _0x6c0d1ebf : MonoBehaviour
{
    private void _0xd66ee909()
    {
        if (this._lobby != null)
        {
            this._lobby._0x586aa695();
        }
    }

    private void _0x8ae9e30f()
    {
        _0xf44d047f.Instance._0xfa79fc65(_0x1d80aee2._0x6bf6c866.SCENE_1);
    }

    [SerializeField]
    private Button _playButton;
    [SerializeField]
    private TMP_Text[] _blockCounters;
    [SerializeField]
    private GameObject _slotPrefab;
    [SerializeField]
    private _0x708fc31f _lobby;
    private void _0x016948f5()
    {
        if (this._0x2575b951)
        {
            return;
        }

        this._0x2575b951 = true;
        if (this._cardPlate != null)
        {
            this._cardPlate.color = _0x21179992.Fade(_0x21179992.BgPanel, 0.98f);
        }

        if (this._playPlate != null)
        {
            this._playPlate.color = _0x21179992.Violet;
        }

        _0x32e32309.Apply(this._heading, _0xb3180a15._0x57282fa3(new byte[9] { 66, 64, 72, 37, 68, 73, 71, 80, 72 }, 5), 72f, 48f, _0x21179992.Cream);
        _0x32e32309.Apply(this._playLabel, _0xb3180a15._0x57282fa3(new byte[8] { 71, 91, 86, 78, 55, 89, 88, 64 }, 23), 48f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._backLabel, _0xb3180a15._0x57282fa3(new byte[12] { 125, 126, 124, 116, 31, 107, 112, 31, 119, 126, 115, 115 }, 63), 44f, 34f, _0x21179992.Cream);
        if (this._playButton != null)
        {
            this._playButton.onClick.AddListener(() => this._0x8ae9e30f());
        }

        if (this._backButton != null)
        {
            this._backButton.onClick.AddListener(() => this._0xd66ee909());
        }
    }

    [SerializeField]
    private Button _backButton;
    private Sprite _0xcd975582(int _0xb3a4f80d)
    {
        if (this._gemArt == null || _0xb3a4f80d < 0 || _0xb3a4f80d >= this._gemArt.Length)
        {
            return null;
        }

        return this._gemArt[_0xb3a4f80d];
    }

    [SerializeField]
    private TMP_Text _hint;
    [SerializeField]
    private TMP_Text _heading;
    [SerializeField]
    private Sprite[] _gemArt;
    [SerializeField]
    private Image _cardPlate;
    private void _0x23fa9c4b()
    {
        bool _0xcb6dc02f = _0xcf78378c.TotalFilled() > 0;
        if (this._hint != null)
        {
            _0x32e32309.Apply(this._hint, _0xcb6dc02f ? _0xb3180a15._0x57282fa3(new byte[43] { 19, 114, 21, 23, 31, 114, 27, 1, 114, 1, 23, 6, 114, 5, 26, 23, 28, 114, 27, 6, 114, 17, 19, 0, 0, 27, 23, 1, 114, 19, 114, 5, 27, 28, 28, 27, 28, 21, 114, 30, 27, 28, 23 }, 82) : _0xb3180a15._0x57282fa3(new byte[15] { 14, 15, 20, 8, 9, 14, 7, 96, 19, 5, 20, 96, 25, 5, 20 }, 64) + _0xb3180a15._0x57282fa3(new byte[1] { 179 }, 185) + _0xb3180a15._0x57282fa3(new byte[34] { 201, 215, 208, 190, 223, 190, 210, 215, 208, 219, 190, 202, 209, 190, 206, 210, 223, 221, 219, 190, 199, 209, 203, 204, 190, 216, 215, 204, 205, 202, 190, 217, 219, 211 }, 158), 38f, 34f, _0x21179992.TextMuted);
        }

        if (this._blockSlots == null || this._slotPrefab == null)
        {
            return;
        }

        for (int _0xa8a6d95f = 0; _0xa8a6d95f < this._blockSlots.Length; _0xa8a6d95f++)
        {
            RectTransform _0x3f956797 = this._blockSlots[_0xa8a6d95f];
            if (_0x3f956797 == null)
            {
                continue;
            }

            _0x3f956797.gameObject.SetActive(_0xcb6dc02f);
            if (this._blockTitles != null && _0xa8a6d95f < this._blockTitles.Length)
            {
                bool _0x64677bfb = _0xcf78378c.Complete(_0xa8a6d95f);
                _0x32e32309.Apply(this._blockTitles[_0xa8a6d95f], _0x64677bfb ? _0xcf78378c.HallName(_0xa8a6d95f) + _0xb3180a15._0x57282fa3(new byte[11] { 20, 25, 20, 119, 123, 121, 100, 120, 113, 96, 113 }, 52) : _0xcf78378c.HallName(_0xa8a6d95f), 44f, 34f, _0x64677bfb ? _0x21179992.Mint : _0x21179992.Cream);
                this._blockTitles[_0xa8a6d95f].gameObject.SetActive(_0xcb6dc02f);
            }

            if (this._blockCounters != null && _0xa8a6d95f < this._blockCounters.Length)
            {
                _0x32e32309.Apply(this._blockCounters[_0xa8a6d95f], _0xcf78378c.Counter(_0xa8a6d95f), 40f, 34f, _0x21179992.Gold);
                this._blockCounters[_0xa8a6d95f].gameObject.SetActive(_0xcb6dc02f);
            }

            for (int _0x118e381a = _0x3f956797.childCount - 1; _0x118e381a >= 0; _0x118e381a--)
            {
                Destroy(_0x3f956797.GetChild(_0x118e381a).gameObject);
            }

            if (!_0xcb6dc02f)
            {
                continue;
            }

            for (int _0x90968212 = 0; _0x90968212 < _0xafff65e6.AlbumSlots; _0x90968212++)
            {
                GameObject _0x8a04e9fd = Instantiate(this._slotPrefab, _0x3f956797, false);
                RectTransform _0xc9223528 = _0x8a04e9fd.transform as RectTransform;
                if (_0xc9223528 != null)
                {
                    _0xc9223528.anchoredPosition = new Vector2((_0x90968212 - ((_0xafff65e6.AlbumSlots - 1) * 0.5f)) * SlotPitch, 0f);
                }

                bool _0x29f7b254 = _0xcf78378c.Filled(_0xa8a6d95f, _0x90968212);
                _0x65ed7b11 _0x795f8e8e = _0x8a04e9fd.GetComponent<_0x65ed7b11>();
                if (_0x795f8e8e != null)
                {
                    _0x795f8e8e._0xd7a737df(_0x29f7b254 ? this._0xcd975582(_0xcf78378c.SymbolOf(_0xa8a6d95f, _0x90968212)) : this._emptyArt, _0x29f7b254);
                }
            }
        }
    }

    [SerializeField]
    private RectTransform[] _blockSlots;
    [SerializeField]
    private Sprite _emptyArt;
    private bool _0x2575b951;
    private const float SlotPitch = 154f;
    [SerializeField]
    private TMP_Text _backLabel;
    [SerializeField]
    private TMP_Text[] _blockTitles;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    public void _0xdc2affe3()
    {
        this._0x016948f5();
        this._0x23fa9c4b();
    }

    [SerializeField]
    private TMP_Text _playLabel;
    [SerializeField]
    private Image _playPlate;
}

internal static class _0xb3180a15
{
    internal static string _0x57282fa3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}