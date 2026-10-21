using UnityEngine;

/// Colour constants for this app. Preset CASINO_GOLD, values overridden with the brief hexes.
/// EVERY colour that ever becomes a TEXT face is light: there is one TMP material for the whole
/// app and its outline is Ink, so a dark face on a dark outline is an unreadable blot (C.14).
/// Violet / VioletDeep / BgPanel / BgDeep / Ink are SURFACE colours only - never a text face.
public static class _0x21179992
{
    public static readonly Color VioletDeep = new Color(0.305882f, 0.105882f, 0.478431f, 1f); // #4E1B7A
    // --- trim and text --------------------------------------------------------
    public static readonly Color Gold = new Color(0.956863f, 0.788235f, 0.364706f, 1f); // #F4C95D
    public static readonly Color PanelFill = new Color(0.141176f, 0.101961f, 0.235294f, 1f); // #241A3C
    public static readonly Color Mint = new Color(0.180392f, 0.768627f, 0.713725f, 1f); // #2EC4B6
    /// Same hue, different alpha. Kept as a helper so no call site invents a second shade.
    public static Color Fade(Color _0x732994fc, float _0xeb3a3b2c)
    {
        return new Color(_0x732994fc.r, _0x732994fc.g, _0x732994fc.b, _0xeb3a3b2c);
    }

    public static readonly Color Violet = new Color(0.482353f, 0.172549f, 0.749020f, 1f); // #7B2CBF
    public static readonly Color Ink = new Color(0.078431f, 0.047059f, 0.125490f, 1f); // #140C20 outline only
    /// The accent a mission / album row uses for its state bar.
    public static Color StateAccent(int _0x7081897e)
    {
        if (_0x7081897e >= 2)
        {
            return Mint;
        }

        if (_0x7081897e == 1)
        {
            return Gold;
        }

        return TextMuted;
    }

    public static readonly Color Shadow = new Color(0.043137f, 0.023529f, 0.070588f, 1f); // #0B0612
    public static readonly Color BgPanel = new Color(0.117647f, 0.082353f, 0.196078f, 1f); // #1E1532
    public static readonly Color BgPanelHi = new Color(0.164706f, 0.109804f, 0.278431f, 1f); // #2A1C47
    // --- surfaces -------------------------------------------------------------
    public static readonly Color BgDeep = new Color(0.086275f, 0.058824f, 0.141176f, 1f); // #160F24
    public static readonly Color GoldDeep = new Color(0.780392f, 0.603922f, 0.180392f, 1f); // #C79A2E
    public static readonly Color TextMuted = new Color(0.776471f, 0.713725f, 0.847059f, 1f); // #C6B6D8
    public static readonly Color Cream = new Color(1f, 0.972549f, 0.905882f, 1f); // #FFF8E7
}