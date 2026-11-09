using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xdcb197cd : MonoBehaviour
{
    private void _0xacf3e880()
    {
        if (this._0x880601eb == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x924d5ec9 = Screen.safeArea;
        Vector2 _0x034ca1d9 = _0x924d5ec9.position;
        Vector2 _0xb6a2352d = _0x924d5ec9.position + _0x924d5ec9.size;
        _0x034ca1d9.x /= screenWidth;
        _0x034ca1d9.y /= screenHeight;
        _0xb6a2352d.x /= screenWidth;
        _0xb6a2352d.y /= screenHeight;
        this._0x880601eb.anchorMin = _0x034ca1d9;
        this._0x880601eb.anchorMax = _0xb6a2352d;
        this._0x880601eb.offsetMin = Vector2.zero;
        this._0x880601eb.offsetMax = Vector2.zero;
        if (this._0x2f188231 == null)
            return;
        Vector2 _0x926b6c0a = _0xb6a2352d - _0x034ca1d9;
        float _0xd944d45d = 2f - _0x926b6c0a.x;
        float _0xd1f5fa2c = 2f - _0x926b6c0a.y;
        this._0x2f188231.referenceResolution = this._0xc2aefd07 * new Vector2(_0xd944d45d, _0xd1f5fa2c);
    }

    private static bool _0x189b9893;
    private static void ApplySafeAreaToAll()
    {
        for (int _0x3c8b9d6e = 0; _0x3c8b9d6e < _0x9d7c9ff6.Count; _0x3c8b9d6e++)
            _0x9d7c9ff6[_0x3c8b9d6e]._0xacf3e880();
    }

    private static void SafeAreaChanged()
    {
        _0xfe427a24 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static Vector2 _0x128ff9f5 = Vector2.zero;
    private RectTransform _0x2db5b63a;
    private static void ResolutionChanged()
    {
        _0x128ff9f5.x = Screen.width;
        _0x128ff9f5.y = Screen.height;
        _0xfe427a24 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xca3a10ff.Invoke();
    }

    private Canvas _0xdb4bdc9a;
    private static UnityEvent _0xca3a10ff = new();
    private static readonly List<_0xdcb197cd> _0x9d7c9ff6 = new();
    private static void OrientationChanged()
    {
        _0xaaa91678 = Screen.orientation;
        _0x128ff9f5.x = Screen.width;
        _0x128ff9f5.y = Screen.height;
        _0xfe427a24 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xca3a10ff.Invoke();
    }

    private void OnDestroy()
    {
        if (_0x9d7c9ff6 != null && _0x9d7c9ff6.Contains(this))
            _0x9d7c9ff6.Remove(this);
    }

    private CanvasScaler _0x2f188231;
    private Vector2 _0xc2aefd07;
    private void Update()
    {
        if (_0x9d7c9ff6.Count == 0 || _0x9d7c9ff6[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xaaa91678)
            OrientationChanged();
        if (Screen.safeArea != _0xfe427a24)
            SafeAreaChanged();
        if (Screen.width != _0x128ff9f5.x || Screen.height != _0x128ff9f5.y)
            ResolutionChanged();
    }

    private static ScreenOrientation _0xaaa91678 = ScreenOrientation.LandscapeLeft;
    private void Awake()
    {
        if (!_0x9d7c9ff6.Contains(this))
            _0x9d7c9ff6.Add(this);
        this._0xdb4bdc9a = this.GetComponent<Canvas>();
        this._0x2f188231 = this.GetComponent<CanvasScaler>();
        if (this._0x2f188231 != null)
            this._0xc2aefd07 = this._0x2f188231.referenceResolution;
        this._0x2db5b63a = this.GetComponent<RectTransform>();
        this._0x880601eb = this.transform.Find(_0xfc9cf294._0x11b69474(new byte[8] { 79, 125, 122, 121, 93, 110, 121, 125 }, 28)) as RectTransform;
        if (!_0x189b9893)
        {
            _0xaaa91678 = Screen.orientation;
            _0x128ff9f5.x = Screen.width;
            _0x128ff9f5.y = Screen.height;
            _0xfe427a24 = Screen.safeArea;
            _0x189b9893 = true;
        }

        this._0xacf3e880();
    }

    private RectTransform _0x880601eb;
    private static Rect _0xfe427a24 = Rect.zero;
    private void Start()
    {
    }
}

internal static class _0xfc9cf294
{
    internal static string _0x11b69474(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}