using UnityEngine;
using UnityEngine.UI;

/// Scene root of 1_MenuScene. It owns nothing the template owns: it instantiates this game's
/// two screens into the panel bodies the template already manages, by INDEX, and retints the
/// splash loading bar.
///
/// Why instantiate rather than build a canvas of our own: the template holds the splash for
/// as long as its services take, and anything on a separate canvas shows underneath it for
/// that whole time, which reads as one screen. Panel.Content is what the splash scales away.
public sealed class _0x5c5d40a6 : MonoBehaviour
{
    /// Rule G: the fill takes the palette accent and the track a dark palette colour with a
    /// real alpha. The template ships white on white at alpha 0.004, i.e. invisible, and the
    /// bar is the only thing on the splash that moves.
    private void _0x0475944f()
    {
        _0x96c5878b _0xca4f5d2e = _0x96c5878b.Instance;
        if (_0xca4f5d2e == null || _0xca4f5d2e.AnimationSlider == null)
        {
            return;
        }

        Slider _0xe222e1f1 = _0xca4f5d2e.AnimationSlider;
        RectTransform _0x0e3284ab = _0xe222e1f1.fillRect;
        if (_0x0e3284ab == null)
        {
            return;
        }

        Image _0x362cee2e = _0x0e3284ab.GetComponent<Image>();
        if (_0x362cee2e != null)
        {
            _0x362cee2e.color = _0x21179992.Gold;
        }

        Transform _0xa0fe6fd5 = _0x0e3284ab.parent;
        Image _0xeac3f488 = _0xa0fe6fd5 == null ? null : _0xa0fe6fd5.GetComponent<Image>();
        if (_0xeac3f488 != null)
        {
            _0xeac3f488.color = _0x21179992.Fade(_0x21179992.BgPanelHi, 0.85f);
        }

        Transform _0xd0f5ab11 = _0xa0fe6fd5 == null ? null : _0xa0fe6fd5.parent;
        Image _0x9359609a = _0xd0f5ab11 == null ? null : _0xd0f5ab11.GetComponent<Image>();
        if (_0x9359609a != null)
        {
            _0x9359609a.color = _0x21179992.Fade(_0x21179992.GoldDeep, 0.9f);
        }
    }

    private void Start()
    {
        _0xc3f86607.EnsureReady();
        this._0x3ec24ed1(_0x1d80aee2._0xb61edb9b.DEFAULT, this._lobbyPrefab, false);
        this._0x3ec24ed1(_0x1d80aee2._0xb61edb9b.SPLASH, this._splashBrandPrefab, true);
        this._0x0475944f();
    }

    [SerializeField]
    private GameObject _splashBrandPrefab;
    private void _0x3ec24ed1(int _0xbfe56eda, GameObject _0x2ec4b3cf, bool _0xfeb0e993)
    {
        if (_0x2ec4b3cf == null)
        {
            return;
        }

        _0x0b32188d _0x8bd4fcbc = _0x0b32188d.Instance;
        if (_0x8bd4fcbc == null || _0x8bd4fcbc.Panels == null || _0xbfe56eda < 0 || _0xbfe56eda >= _0x8bd4fcbc.Panels.Count)
        {
            return;
        }

        _0xe96ae584 _0x96786b92 = _0x8bd4fcbc.Panels[_0xbfe56eda];
        if (_0x96786b92 == null || _0x96786b92.Content == null)
        {
            return;
        }

        GameObject _0x7561d04a = Instantiate(_0x2ec4b3cf, _0x96786b92.Content.transform, false);
        RectTransform _0xa6e0c8eb = _0x7561d04a.transform as RectTransform;
        if (_0xa6e0c8eb != null)
        {
            _0xa6e0c8eb.anchorMin = Vector2.zero;
            _0xa6e0c8eb.anchorMax = Vector2.one;
            _0xa6e0c8eb.offsetMin = Vector2.zero;
            _0xa6e0c8eb.offsetMax = Vector2.zero;
        }

        if (_0xfeb0e993)
        {
            // The loading bar is a sibling here; first place keeps it drawn on top.
            _0x7561d04a.transform.SetAsFirstSibling();
        }
    }

    [SerializeField]
    private GameObject _lobbyPrefab;
}