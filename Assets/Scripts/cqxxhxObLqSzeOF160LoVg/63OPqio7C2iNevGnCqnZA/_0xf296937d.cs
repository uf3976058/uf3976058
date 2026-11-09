using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xf296937d : MonoBehaviour
{
    private static Vector2 _0x43ae26b1 = Vector2.zero;
    private void Awake()
    {
        if (!_0xb20722ae.Contains(this))
            _0xb20722ae.Add(this);
        this._0x44b7cad6 = this.GetComponent<Canvas>();
        this._0x2a8a911f = this.GetComponent<RectTransform>();
        this._0xde5ad947 = this.transform.Find(_0x4b5287b4._0x2ef3260e(new byte[8] { 147, 161, 166, 165, 129, 178, 165, 161 }, 192)) as RectTransform;
        if (!_0x3b1c8d90)
        {
            _0x81336b6c = Screen.orientation;
            _0x43ae26b1.x = Screen.width;
            _0x43ae26b1.y = Screen.height;
            _0xc87e2a94 = Screen.safeArea;
            _0x3b1c8d90 = true;
        }

        this._0xeb3ddc51();
    }

    private static void OrientationChanged()
    {
        _0x81336b6c = Screen.orientation;
        _0x43ae26b1.x = Screen.width;
        _0x43ae26b1.y = Screen.height;
        _0x1bff3fce.Invoke();
    }

    private static ScreenOrientation _0x81336b6c = ScreenOrientation.LandscapeLeft;
    private static Rect _0xc87e2a94 = Rect.zero;
    private static UnityEvent _0x1bff3fce = new();
    private Canvas _0x44b7cad6;
    private static void SafeAreaChanged()
    {
        _0xc87e2a94 = Screen.safeArea;
        for (int _0x8ae2aa18 = 0; _0x8ae2aa18 < _0xb20722ae.Count; _0x8ae2aa18++)
            _0xb20722ae[_0x8ae2aa18]._0xeb3ddc51();
    }

    private void _0xeb3ddc51()
    {
        if (this._0xde5ad947 == null)
            return;
        Rect _0x85f9aa27 = Screen.safeArea;
        Vector2 _0x0008064c = _0x85f9aa27.position;
        Vector2 _0x7275d0a1 = _0x85f9aa27.position + _0x85f9aa27.size;
        _0x0008064c.x /= this._0x44b7cad6.pixelRect.width;
        _0x0008064c.y /= this._0x44b7cad6.pixelRect.height;
        _0x7275d0a1.x /= this._0x44b7cad6.pixelRect.width;
        _0x7275d0a1.y /= this._0x44b7cad6.pixelRect.height;
        this._0xde5ad947.anchorMin = _0x0008064c;
        this._0xde5ad947.anchorMax = _0x7275d0a1;
    }

    private static bool _0x3b1c8d90;
    private RectTransform _0xde5ad947;
    private RectTransform _0x2a8a911f;
    private static void ResolutionChanged()
    {
        _0x43ae26b1.x = Screen.width;
        _0x43ae26b1.y = Screen.height;
        _0x1bff3fce.Invoke();
    }

    private void OnDestroy()
    {
        if (_0xb20722ae != null && _0xb20722ae.Contains(this))
            _0xb20722ae.Remove(this);
    }

    private void Update()
    {
        if (_0xb20722ae[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x81336b6c)
            OrientationChanged();
        if (Screen.safeArea != _0xc87e2a94)
            SafeAreaChanged();
        if (Screen.width != _0x43ae26b1.x || Screen.height != _0x43ae26b1.y)
            ResolutionChanged();
    }

    private static readonly List<_0xf296937d> _0xb20722ae = new();
}

internal static class _0x4b5287b4
{
    internal static string _0x2ef3260e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}