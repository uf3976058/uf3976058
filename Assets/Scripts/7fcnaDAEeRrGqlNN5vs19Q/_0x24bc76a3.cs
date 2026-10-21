using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Four rows, every one of which changes something the player can see at once.
///
/// The brief asked for audio settings. These games ship with no sound at all (C.20), so a
/// volume slider or a music toggle would be a control that confirms nothing - the row is
/// replaced by REDUCE SPARKLE / HAPTICS / FAST SPIN, which are real and testable. The rest of
/// the brief's settings scope (resetting local progress) is implemented as the fourth row.
public sealed class _0x24bc76a3 : MonoBehaviour
{
    private void _0xf5ec9a18()
    {
        _0xc3f86607._0xfc99299a = !_0xc3f86607._0xfc99299a;
        this._0x86827a86();
    }

    [SerializeField]
    private Image _resetPlate;
    private bool _0x2ab84536;
    private void _0x86827a86()
    {
        if (this._rowHost != null && this._rowPrefab != null)
        {
            for (int _0xfed45405 = this._rowHost.childCount - 1; _0xfed45405 >= 0; _0xfed45405--)
            {
                Destroy(this._rowHost.GetChild(_0xfed45405).gameObject);
            }

            this._0x5472ef9e(0, _0x352c9122._0x39088121(new byte[14] { 116, 99, 98, 115, 101, 99, 6, 117, 118, 103, 116, 109, 106, 99 }, 38), _0xc3f86607._0xfc99299a, () => this._0xf5ec9a18());
            this._0x5472ef9e(1, _0x352c9122._0x39088121(new byte[7] { 42, 35, 50, 54, 43, 33, 49 }, 98), _0xc3f86607._0xa59a79ae, () => this._0xf8547736());
            this._0x5472ef9e(2, _0x352c9122._0x39088121(new byte[9] { 251, 252, 238, 233, 157, 238, 237, 244, 243 }, 189), _0xc3f86607._0x9379774e, () => this._0x799dcbba());
            this._0x5472ef9e(3, _0x352c9122._0x39088121(new byte[17] { 190, 189, 164, 163, 190, 205, 185, 165, 164, 190, 205, 169, 168, 187, 164, 174, 168 }, 237), true, () => this._0x0717a077());
        }

        this._0x8762a37f();
    }

    private void _0x1b1e5ace()
    {
        if (!this._0x2ab84536)
        {
            this._0x2ab84536 = true;
            this._0x8762a37f();
            return;
        }

        this._0x2ab84536 = false;
        _0xc3f86607.ResetProgress();
        _0x64c39bc0.Reshuffle();
        this._0x86827a86();
        if (this._lobby != null)
        {
            this._lobby._0xe21bb561();
            this._lobby._0x586aa695();
        }
    }

    [SerializeField]
    private TMP_Text _heading;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    [SerializeField]
    private Button _resetButton;
    private void _0x8762a37f()
    {
        if (this._resetPlate != null)
        {
            this._resetPlate.color = this._0x2ab84536 ? _0x21179992.Fade(_0x21179992.GoldDeep, 0.95f) : _0x21179992.VioletDeep;
        }

        _0x32e32309.Apply(this._resetLabel, this._0x2ab84536 ? _0x352c9122._0x39088121(new byte[26] { 243, 230, 247, 135, 230, 224, 230, 238, 233, 135, 243, 232, 135, 240, 238, 247, 226, 135, 247, 245, 232, 224, 245, 226, 244, 244 }, 167) : _0x352c9122._0x39088121(new byte[20] { 33, 54, 32, 54, 39, 83, 63, 60, 48, 50, 63, 83, 35, 33, 60, 52, 33, 54, 32, 32 }, 115), 44f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._hint, this._0x2ab84536 ? _0x352c9122._0x39088121(new byte[44] { 36, 56, 57, 35, 80, 51, 60, 53, 49, 34, 35, 80, 49, 60, 50, 37, 61, 35, 92, 80, 61, 57, 35, 35, 57, 63, 62, 35, 80, 49, 62, 52, 80, 36, 56, 53, 80, 50, 49, 60, 49, 62, 51, 53 }, 112) : _0x352c9122._0x39088121(new byte[45] { 245, 230, 245, 226, 233, 228, 248, 249, 254, 247, 144, 248, 245, 226, 245, 144, 249, 227, 144, 227, 228, 255, 226, 245, 244, 144, 255, 254, 144, 228, 248, 249, 227, 144, 244, 245, 230, 249, 243, 245, 144, 255, 254, 252, 233 }, 176), 38f, 34f, this._0x2ab84536 ? _0x21179992.Gold : _0x21179992.TextMuted);
    }

    /// A read-only row still has to answer a tap, so it punches its own card.
    private void _0x0717a077()
    {
        if (this._rowHost == null || this._rowHost.childCount < 4)
        {
            return;
        }

        Transform _0x9b63c5e8 = this._rowHost.GetChild(3);
        _0x9b63c5e8.localScale = Vector3.one;
        _0x9b63c5e8.DOPunchScale(Vector3.one * 0.04f, 0.18f, 6, 0.6f).SetLink(_0x9b63c5e8.gameObject);
    }

    private void _0xf8547736()
    {
        _0xc3f86607._0xa59a79ae = !_0xc3f86607._0xa59a79ae;
        if (_0xc3f86607._0xa59a79ae)
        {
            Handheld.Vibrate();
        }

        this._0x86827a86();
    }

    [SerializeField]
    private TMP_Text _hint;
    [SerializeField]
    private TMP_Text _compliance;
    private void _0x799dcbba()
    {
        _0xc3f86607._0x9379774e = !_0xc3f86607._0x9379774e;
        this._0x86827a86();
    }

    [SerializeField]
    private Image _cardPlate;
    private const float FirstRowY = 234f;
    private const float RowPitch = 156f;
    [SerializeField]
    private GameObject _rowPrefab;
    [SerializeField]
    private _0x708fc31f _lobby;
    private void _0x33182201()
    {
        if (this._0xe4c1fc6e)
        {
            return;
        }

        this._0xe4c1fc6e = true;
        if (this._cardPlate != null)
        {
            this._cardPlate.color = _0x21179992.Fade(_0x21179992.BgPanel, 0.98f);
        }

        _0x32e32309.Apply(this._heading, _0x352c9122._0x39088121(new byte[8] { 186, 172, 189, 189, 160, 167, 174, 186 }, 233), 72f, 48f, _0x21179992.Cream);
        _0x32e32309.Apply(this._compliance, _0x352c9122._0x39088121(new byte[34] { 67, 92, 71, 65, 64, 84, 89, 53, 86, 90, 92, 91, 70, 53, 90, 91, 89, 76, 53, 56, 53, 91, 90, 53, 71, 80, 84, 89, 53, 88, 90, 91, 80, 76 }, 21) + _0x352c9122._0x39088121(new byte[1] { 20 }, 30) + _0x352c9122._0x39088121(new byte[46] { 21, 20, 123, 11, 14, 9, 24, 19, 26, 8, 30, 8, 123, 118, 123, 21, 20, 123, 12, 18, 15, 19, 31, 9, 26, 12, 26, 23, 8, 123, 118, 123, 21, 20, 123, 24, 26, 8, 19, 123, 11, 9, 18, 1, 30, 8 }, 91) + _0x352c9122._0x39088121(new byte[1] { 12 }, 6) + _0x352c9122._0x39088121(new byte[37] { 175, 166, 187, 201, 168, 173, 188, 165, 189, 186, 201, 196, 201, 216, 209, 194, 201, 196, 201, 172, 167, 189, 172, 187, 189, 168, 160, 167, 164, 172, 167, 189, 201, 166, 167, 165, 176 }, 233), 34f, 34f, _0x21179992.TextMuted);
        _0x32e32309.Apply(this._backLabel, _0x352c9122._0x39088121(new byte[12] { 0, 3, 1, 9, 98, 22, 13, 98, 10, 3, 14, 14 }, 66), 44f, 34f, _0x21179992.Cream);
        if (this._resetButton != null)
        {
            this._resetButton.onClick.AddListener(() => this._0x1b1e5ace());
        }

        if (this._backButton != null)
        {
            this._backButton.onClick.AddListener(() => this._0x4e5c2488());
        }
    }

    private void _0x5472ef9e(int _0x9caaaf49, string _0xe3da7251, bool _0x6b8e9da9, System.Action _0xc5e848d2)
    {
        GameObject _0x65249759 = Instantiate(this._rowPrefab, this._rowHost, false);
        RectTransform _0x2d0cf08e = _0x65249759.transform as RectTransform;
        if (_0x2d0cf08e != null)
        {
            _0x2d0cf08e.anchoredPosition = new Vector2(0f, FirstRowY - (_0x9caaaf49 * RowPitch));
        }

        _0x9fd35ab1 _0x805c05d5 = _0x65249759.GetComponent<_0x9fd35ab1>();
        if (_0x805c05d5 == null)
        {
            return;
        }

        string _0xcb7dc5ff = _0x9caaaf49 == 3 ? _0xc3f86607._0xe0fb96be.ToString() : (_0x6b8e9da9 ? _0x352c9122._0x39088121(new byte[2] { 6, 7 }, 73) : _0x352c9122._0x39088121(new byte[3] { 186, 179, 179 }, 245));
        _0x805c05d5._0xfccc87ae(_0xe3da7251, _0xcb7dc5ff, _0x9caaaf49 == 3 ? false : _0x6b8e9da9, _0xc5e848d2);
    }

    [SerializeField]
    private TMP_Text _backLabel;
    public void _0x147d1e85()
    {
        this._0x33182201();
        this._0x2ab84536 = false;
        this._0x86827a86();
    }

    private void _0x4e5c2488()
    {
        if (this._lobby != null)
        {
            this._lobby._0x586aa695();
        }
    }

    private bool _0xe4c1fc6e;
    [SerializeField]
    private RectTransform _rowHost;
    [SerializeField]
    private TMP_Text _resetLabel;
    [SerializeField]
    private Button _backButton;
}

internal static class _0x352c9122
{
    internal static string _0x39088121(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}