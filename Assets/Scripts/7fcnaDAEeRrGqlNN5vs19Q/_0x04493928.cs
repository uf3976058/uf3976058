using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// One tile of the seven day ladder. State 0 = still to come, 1 = today, 2 = claimed.
public sealed class _0x04493928 : MonoBehaviour
{
    [SerializeField]
    private Image _plate;
    [SerializeField]
    private TMP_Text _day;
    public void _0xaeb96a72(int _0xf9c11e23, int _0xf5705ef4, int _0x7abc43e2)
    {
        if (this._plate != null)
        {
            if (_0x7abc43e2 >= 2)
            {
                this._plate.color = _0x21179992.Fade(_0x21179992.Mint, 0.30f);
            }
            else if (_0x7abc43e2 == 1)
            {
                this._plate.color = _0x21179992.Fade(_0x21179992.Violet, 0.45f);
            }
            else
            {
                this._plate.color = _0x21179992.Fade(_0x21179992.BgDeep, 0.80f);
            }
        }

        if (this._icon != null)
        {
            this._icon.color = _0x7abc43e2 == 0 ? _0x21179992.Fade(Color.white, 0.5f) : Color.white;
        }

        _0x32e32309.Apply(this._day, _0xb0d0b29f._0x43f6b121(new byte[4] { 118, 115, 107, 18 }, 50) + _0xf9c11e23, 34f, 34f, _0x7abc43e2 == 1 ? _0x21179992.Gold : _0x21179992.TextMuted);
        _0x32e32309.Apply(this._value, _0x7abc43e2 >= 2 ? _0xb0d0b29f._0x43f6b121(new byte[7] { 133, 138, 135, 143, 139, 131, 130 }, 198) : _0x32e32309.Coins(_0xf5705ef4), 40f, 34f, _0x7abc43e2 >= 2 ? _0x21179992.Mint : _0x21179992.Gold);
    }

    [SerializeField]
    private Image _icon;
    [SerializeField]
    private TMP_Text _value;
}

internal static class _0xb0d0b29f
{
    internal static string _0x43f6b121(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}