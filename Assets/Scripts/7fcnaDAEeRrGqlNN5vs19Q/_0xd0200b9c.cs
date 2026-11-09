using UnityEngine;
using UnityEngine.UI;

/// Scene root of 2_GameScene. Same shape as the menu root: fill the template's own panel
/// bodies by index, then hand the cabinet the pop presenter it cannot serialise (the cabinet
/// lives in a prefab, the presenter is a scene object).
public sealed class _0xd0200b9c : MonoBehaviour
{
    private void _0x33a54ffb()
    {
        _0x96c5878b _0x7911a8da = _0x96c5878b.Instance;
        if (_0x7911a8da == null || _0x7911a8da.AnimationSlider == null)
        {
            return;
        }

        Slider _0x9dd40604 = _0x7911a8da.AnimationSlider;
        RectTransform _0x8561c5de = _0x9dd40604.fillRect;
        if (_0x8561c5de == null)
        {
            return;
        }

        Image _0xf827d67c = _0x8561c5de.GetComponent<Image>();
        if (_0xf827d67c != null)
        {
            _0xf827d67c.color = _0x21179992.Gold;
        }

        Transform _0x87e107d8 = _0x8561c5de.parent;
        Image _0xc522a246 = _0x87e107d8 == null ? null : _0x87e107d8.GetComponent<Image>();
        if (_0xc522a246 != null)
        {
            _0xc522a246.color = _0x21179992.Fade(_0x21179992.BgPanelHi, 0.85f);
        }
    }

    private GameObject _0xf7ca92ba(int _0xf003958e, GameObject _0x9baa9aa5, bool _0xf1567d77)
    {
        if (_0x9baa9aa5 == null)
        {
            return null;
        }

        _0x0b32188d _0x2ea288eb = _0x0b32188d.Instance;
        if (_0x2ea288eb == null || _0x2ea288eb.Panels == null || _0xf003958e < 0 || _0xf003958e >= _0x2ea288eb.Panels.Count)
        {
            return null;
        }

        _0xe96ae584 _0x229c0d21 = _0x2ea288eb.Panels[_0xf003958e];
        if (_0x229c0d21 == null || _0x229c0d21.Content == null)
        {
            return null;
        }

        GameObject _0x1e8a07df = Instantiate(_0x9baa9aa5, _0x229c0d21.Content.transform, false);
        RectTransform _0x61516fcb = _0x1e8a07df.transform as RectTransform;
        if (_0x61516fcb != null)
        {
            _0x61516fcb.anchorMin = Vector2.zero;
            _0x61516fcb.anchorMax = Vector2.one;
            _0x61516fcb.offsetMin = Vector2.zero;
            _0x61516fcb.offsetMax = Vector2.zero;
        }

        if (_0xf1567d77)
        {
            _0x1e8a07df.transform.SetAsFirstSibling();
        }

        return _0x1e8a07df;
    }

    [SerializeField]
    private GameObject _reelsPrefab;
    private void Start()
    {
        _0xc3f86607.EnsureReady();
        this._0xf7ca92ba(_0x1d80aee2._0xb61edb9b.SPLASH, this._splashBrandPrefab, true);
        GameObject _0x342f3771 = this._0xf7ca92ba(_0x1d80aee2._0xb61edb9b.DEFAULT, this._reelsPrefab, false);
        if (_0x342f3771 == null)
        {
            return;
        }

        _0xcb733c21 _0xc017c07d = _0x342f3771.GetComponent<_0xcb733c21>();
        if (_0xc017c07d != null)
        {
            _0xc017c07d._0x35011e1c(this._pops);
        }

        this._0x33a54ffb();
    }

    [SerializeField]
    private GameObject _splashBrandPrefab;
    [SerializeField]
    private _0xe1c471bb _pops;
}