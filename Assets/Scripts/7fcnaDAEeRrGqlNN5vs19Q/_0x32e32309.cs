using TMPro;
using UnityEngine;

/// Every TMP label this app touches goes through here (C.10 / C.12 / C.14):
/// word wrapping OFF, line breaks only where the string itself carries one,
/// autosize ON with a floor that never drops below the readability threshold,
/// and its own material instance whose outline contrasts with the face colour.
public static class _0x32e32309
{
    /// A readable thousands form without Hermes-style locale surprises: 1234567 -> 1,234,567.
    public static string Coins(int _0x992d81ab)
    {
        bool _0xb96bf5b7 = _0x992d81ab < 0;
        int _0x62e255b3 = _0xb96bf5b7 ? -_0x992d81ab : _0x992d81ab;
        string _0x5371761e = _0x62e255b3.ToString();
        string _0x2758d2c0 = "";
        int _0xdd0bbea4 = 0;
        for (int _0x0b97d51d = _0x5371761e.Length - 1; _0x0b97d51d >= 0; _0x0b97d51d--)
        {
            _0x2758d2c0 = _0x5371761e[_0x0b97d51d] + _0x2758d2c0;
            _0xdd0bbea4++;
            if (_0xdd0bbea4 % 3 == 0 && _0x0b97d51d > 0)
            {
                _0x2758d2c0 = _0xe7cf7413._0x1f1434b5(new byte[1] { 176 }, 156) + _0x2758d2c0;
            }
        }

        return _0xb96bf5b7 ? _0xe7cf7413._0x1f1434b5(new byte[1] { 10 }, 39) + _0x2758d2c0 : _0x2758d2c0;
    }

    public static void Apply(TMP_Text _0x6e8d7a6b, string _0x82ddb7de, float _0x6613f92b, Color _0xecc9d749)
    {
        Apply(_0x6e8d7a6b, _0x82ddb7de, _0x6613f92b, UiFloor, _0xecc9d749);
    }

    public static void Apply(TMP_Text _0xa0b2aa1c, string _0xc20c4234, float _0xfd12474d, float _0xa1523bfd, Color _0xa5e5a0f7)
    {
        if (_0xa0b2aa1c == null)
        {
            return;
        }

        _0xa0b2aa1c.text = _0xc20c4234;
        _0xa0b2aa1c.color = _0xa5e5a0f7;
        _0xa0b2aa1c.textWrappingMode = TextWrappingModes.NoWrap;
        _0xa0b2aa1c.overflowMode = TextOverflowModes.Overflow;
        _0xa0b2aa1c.enableAutoSizing = true;
        _0xa0b2aa1c.fontSizeMin = _0xa1523bfd < UiFloor ? UiFloor : _0xa1523bfd;
        _0xa0b2aa1c.fontSizeMax = _0xfd12474d < _0xa0b2aa1c.fontSizeMin ? _0xa0b2aa1c.fontSizeMin : _0xfd12474d;
        _0xa0b2aa1c.fontSize = _0xa0b2aa1c.fontSizeMax;
        ApplyOutline(_0xa0b2aa1c, _0xa5e5a0f7);
    }

    /// Readability floor for UGUI text. The reference canvas here is 1242 wide, so the
    /// 24 of C.12 (measured on 1080) is ~27.6 - 34 keeps real margin above it.
    public const float UiFloor = 34f;
    /// Give the label its OWN material instance with an outline that contrasts with its face.
    /// Reading fontMaterial instantiates the material; the shared asset is left untouched.
    public static void ApplyOutline(TMP_Text _0x84618009, Color _0x433b7acc)
    {
        if (_0x84618009 == null || _0x84618009.font == null)
        {
            return;
        }

        Material _0x0a9e8626 = _0x84618009.fontMaterial;
        if (_0x0a9e8626 == null)
        {
            return;
        }

        float _0x57a5876b = (0.299f * _0x433b7acc.r) + (0.587f * _0x433b7acc.g) + (0.114f * _0x433b7acc.b);
        _0x0a9e8626.SetColor(ShaderUtilities.ID_OutlineColor, _0x57a5876b < 0.5f ? _0x21179992.Cream : _0x21179992.Ink);
        _0x0a9e8626.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
    }

    /// Change only the string of a label that was already set up.
    public static void SetText(TMP_Text _0x7df1b7d0, string _0xf185f1dc)
    {
        if (_0x7df1b7d0 == null)
        {
            return;
        }

        _0x7df1b7d0.text = _0xf185f1dc;
    }
}

internal static class _0xe7cf7413
{
    internal static string _0x1f1434b5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}