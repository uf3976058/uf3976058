using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xe27b2536 : MonoBehaviour
{
    private bool _0xb6db5f94 = false;
    private bool _0x112bdda1 = false;
    private async Task _0x51f88b48()
    {
        if (await _0xffc8e00d())
            return;
        if (await _0x567b0234())
            return;
        if (await _0x12b3ca31())
            return;
        _0x4b577a04();
        await _0x02e74567(_0x4124d8e8());
        _0x20656dda = await _0x52d0aa63();
        await _0x2aec6867();
    }

    internal string _0xa05e59c0(string _0x2b0673dd)
    {
        int _0x3d2699f4 = _0x2b0673dd.IndexOf(_0x339c0fec._0x5bb166a0(new byte[3] { 109, 96, 57 }, 4), StringComparison.OrdinalIgnoreCase);
        if (_0x3d2699f4 < 0)
            return null;
        string _0xded6caf8 = _0x2b0673dd.Substring(_0x3d2699f4 + 3);
        int _0x102d2ab4 = _0xded6caf8.IndexOf('&');
        return _0x102d2ab4 >= 0 ? _0xded6caf8.Substring(0, _0x102d2ab4) : _0xded6caf8;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x96ccb026)
    {
        if (_0x96ccb026 == null || _0x96ccb026.Extra == null)
            return null;
        object _0xd9549b6f;
        if (!_0x96ccb026.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xd9549b6f))
            return null;
        return _0xd9549b6f as string;
    }

    private void _0x26edc79f(string _0xae18c334)
    {
        if (string.IsNullOrEmpty(_0xae18c334))
            return;
        if (TryOpenExternalLikeChrome(_0xae18c334))
            return;
        OpenUrlExternally(_0xae18c334);
    }

    private async Task _0x2aec6867()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xd906b057 = _0x339c0fec._0x5bb166a0(new byte[5] { 33, 38, 43, 52, 34 }, 71);
        _0x47abb397 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x60d60753 = DateTime.UtcNow.Ticks.ToString();
        _0xb2e76a7d = "";
        JObject _0x1461ac78 = _0x75af0f1a(_0xc4a227d6, _0x1b9159de, _0xba0b1bf4, _0x0fef61ea, _0xa4af0607, _0x6e0656ed, _0xccb21664, _0x899d8f9c, _0x20656dda, _0x65518d6e, _0xd906b057, _0xb2e76a7d, _0x28ecd9f9, _0x07d6c554, _0x80e30291.ToString(), _0x476dd3b5, _0x60d60753, _0x47abb397, _0xf2712e3c, _0xc5efbc01, _0x22178190, _0x8cdd5489, _0x1fe15d05());
        var _0x589a7e75 = _0x551bbdfb(_0x1461ac78.ToString(), _0xf2712e3c);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x1461ac78}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x339c0fec._0x5bb166a0(new byte[7] { 43, 58, 34, 55, 52, 58, 63 }, 91) + _0xf2712e3c, _0x589a7e75 } });
            await Task.Delay(500);
            string _0xc3ad9462 = "";
            for (int _0x0cc02672 = 0; _0x0cc02672 < 20; _0x0cc02672++)
            {
                if (await _0x3d5df30f(1, 1))
                {
                    await _0x032ffccf(_0x339c0fec._0x5bb166a0(new byte[7] { 67, 77, 78, 66, 74, 68, 69 }, 33));
                    _0x0abf0ad2();
                    return;
                }

                _0xc3ad9462 = await _0x1d899328(1, 500);
                if (!string.IsNullOrEmpty(_0xc3ad9462))
                    break;
            }

            _0xa13d420a(_0xc3ad9462);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[22] { 200, 199, 214, 192, 199, 206, 179, 212, 246, 253, 246, 225, 242, 255, 179, 246, 225, 225, 252, 225, 169, 179 }, 147) + e.Message);
#endif
            }

            _0x0abf0ad2();
        }
    }

    private IEnumerator _0xe53f0b8e(float _0x71f9e5dc)
    {
        yield return new WaitForSeconds(_0x71f9e5dc);
        if (!_0x3ec822e7)
        {
            _0x3ec822e7 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xa4af0607}");
                }
#endif
            }
        }
    }

    private bool _0x204a4901(string _0xca25d2dd, string _0xb5511aff)
    {
        string _0x9bbe5235 = _0xa05e59c0(_0xca25d2dd);
        if (string.IsNullOrEmpty(_0x9bbe5235))
            _0x9bbe5235 = _0xb5511aff;
        if (_0xedda1aa0(_0x9bbe5235))
            return true;
        string _0x3da55677 = string.IsNullOrEmpty(_0x9bbe5235) ? _0x339c0fec._0x5bb166a0(new byte[29] { 81, 77, 77, 73, 74, 3, 22, 22, 73, 85, 88, 64, 23, 94, 86, 86, 94, 85, 92, 23, 90, 86, 84, 22, 74, 77, 86, 75, 92 }, 57) : _0x339c0fec._0x5bb166a0(new byte[46] { 115, 111, 111, 107, 104, 33, 52, 52, 107, 119, 122, 98, 53, 124, 116, 116, 124, 119, 126, 53, 120, 116, 118, 52, 104, 111, 116, 105, 126, 52, 122, 107, 107, 104, 52, 127, 126, 111, 122, 114, 119, 104, 36, 114, 127, 38 }, 27) + _0x9bbe5235;
        WLog(_0x339c0fec._0x5bb166a0(new byte[35] { 202, 225, 251, 230, 228, 236, 197, 224, 226, 236, 169, 228, 232, 251, 226, 236, 253, 169, 239, 232, 229, 229, 235, 232, 234, 226, 169, 232, 250, 169, 254, 236, 235, 179, 169 }, 137) + _0x3da55677);
        return _0x23405d9a(_0x3da55677);
    }

    private string _0x60d60753 = "";
    private bool _0x977bd4c2 = false;
    private GameObject _0x7720ce94;
    private string _0x47abb397 = "";
    private void _0x8368aef1(bool _0xc5e25030)
    {
        _0x74f0133e();
        _0x7720ce94.SetActive(_0xc5e25030);
        _0x035cf02a = _0xc5e25030;
        if (_0xc5e25030)
        {
            _0x7720ce94.transform.SetAsLastSibling();
            if (_0xe4a22691 != null)
                _0xe4a22691.localRotation = Quaternion.identity;
        }
    }

    private void _0x28c33063()
    {
        using (var _0xecbfaade = new AndroidJavaClass(_0x339c0fec._0x5bb166a0(new byte[30] { 69, 73, 75, 8, 83, 72, 79, 82, 95, 21, 66, 8, 86, 74, 71, 95, 67, 84, 8, 115, 72, 79, 82, 95, 118, 74, 71, 95, 67, 84 }, 38)))
        using (var _0xf3b84a92 = _0xecbfaade.GetStatic<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[15] { 166, 176, 183, 183, 160, 171, 177, 132, 166, 177, 172, 179, 172, 177, 188 }, 197)))
        using (var _0x015fbcfc = _0xf3b84a92.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[9] { 22, 20, 5, 56, 31, 5, 20, 31, 5 }, 113)))
        {
            if (_0x015fbcfc == null)
                return;
            using (var _0x78342aeb = _0x015fbcfc.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[9] { 218, 216, 201, 248, 197, 201, 207, 220, 206 }, 189)))
            {
                if (_0x78342aeb == null)
                    return;
                using (var _0xb9a8d8c5 = new AndroidJavaObject(_0x339c0fec._0x5bb166a0(new byte[19] { 217, 196, 209, 152, 220, 197, 217, 216, 152, 252, 229, 249, 248, 249, 212, 220, 211, 213, 194 }, 182)))
                using (var _0xcc2f95d1 = _0x78342aeb.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[6] { 239, 225, 253, 215, 225, 240 }, 132)))
                using (var _0x84cc502a = _0xcc2f95d1.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[8] { 3, 30, 15, 24, 11, 30, 5, 24 }, 106)))
                {
                    while (_0x84cc502a.Call<bool>(_0x339c0fec._0x5bb166a0(new byte[7] { 12, 5, 23, 42, 1, 28, 16 }, 100)))
                    {
                        string _0x682b144d = _0x84cc502a.Call<string>(_0x339c0fec._0x5bb166a0(new byte[4] { 136, 131, 158, 146 }, 230));
                        using (var _0x0a659ae2 = _0x78342aeb.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[3] { 95, 93, 76 }, 56), _0x682b144d))
                        {
                            _0xb9a8d8c5.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[3] { 27, 30, 31 }, 107), _0x682b144d, _0x0a659ae2);
                        }
                    }

                    string _0xd9c84aeb = _0xb9a8d8c5.Call<string>(_0x339c0fec._0x5bb166a0(new byte[8] { 29, 6, 58, 29, 27, 0, 7, 14 }, 105));
                    if (!string.IsNullOrEmpty(_0xd9c84aeb))
                    {
                        _0xf26effb6(_0xd9c84aeb);
                        _0xd11f11b4(_0xd9c84aeb);
                    }
                }
            }
        }
    }

    private bool _0x346a1813(int _0x2d93e13b, string _0x66c78345, string _0x0b36d279)
    {
        if (string.IsNullOrEmpty(_0x0b36d279))
            return false;
        if (!IsHttpUrl(_0x0b36d279))
            return true;
        if (string.IsNullOrEmpty(_0x66c78345))
            return false;
        return _0x66c78345.IndexOf(_0x339c0fec._0x5bb166a0(new byte[20] { 245, 226, 226, 239, 243, 255, 254, 254, 245, 243, 228, 249, 255, 254, 239, 226, 245, 227, 245, 228 }, 176), StringComparison.OrdinalIgnoreCase) >= 0 || _0x66c78345.IndexOf(_0x339c0fec._0x5bb166a0(new byte[22] { 14, 25, 25, 20, 8, 4, 5, 5, 14, 8, 31, 2, 4, 5, 20, 25, 14, 13, 30, 24, 14, 15 }, 75), StringComparison.OrdinalIgnoreCase) >= 0 || _0x66c78345.IndexOf(_0x339c0fec._0x5bb166a0(new byte[21] { 31, 8, 8, 5, 25, 21, 20, 20, 31, 25, 14, 19, 21, 20, 5, 25, 22, 21, 9, 31, 30 }, 90), StringComparison.OrdinalIgnoreCase) >= 0 || _0x66c78345.IndexOf(_0x339c0fec._0x5bb166a0(new byte[22] { 112, 103, 103, 106, 96, 123, 126, 123, 122, 98, 123, 106, 96, 103, 121, 106, 102, 118, 125, 112, 120, 112 }, 53), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x1b9159de = "";
    private bool _0x5a65c5ba = false;
    private IEnumerator _0x4124d8e8()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[26] { 98, 109, 92, 74, 77, 100, 25, 112, 87, 80, 77, 80, 88, 85, 80, 67, 92, 107, 92, 95, 95, 92, 75, 92, 75, 25 }, 57));
            }
#endif
        }

        bool _0x1fef6f93 = false;
        InstallReferrer.GetReferrer((_0x1867ff77) =>
        {
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[24] { 190, 177, 128, 150, 145, 197, 183, 128, 131, 128, 151, 151, 128, 151, 184, 197, 130, 128, 145, 197, 7, 99, 119, 197 }, 229) + _0xa4af0607);
            if (_0x1867ff77.IsSuccess)
            {
                _0xa4af0607 = _0x1867ff77.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x339c0fec._0x5bb166a0(new byte[28] { 51, 60, 13, 27, 28, 72, 58, 13, 14, 13, 26, 26, 13, 26, 53, 72, 59, 29, 11, 11, 13, 27, 27, 72, 138, 238, 250, 72 }, 104) + _0xa4af0607);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x339c0fec._0x5bb166a0(new byte[27] { 230, 233, 216, 206, 201, 157, 239, 216, 219, 216, 207, 207, 216, 207, 224, 157, 251, 220, 212, 209, 216, 217, 157, 95, 59, 47, 157 }, 189) + _0x1867ff77);
#endif
                }

                _0xa4af0607 = "";
            }

            _0x3ec822e7 = true;
        });
        StartCoroutine(_0xe53f0b8e(2f));
        yield return new WaitUntil(() => _0x3ec822e7);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xa4af0607}");
#endif
        }

        bool _0xc7585212 = _0xa4af0607.Contains(_0x339c0fec._0x5bb166a0(new byte[6] { 98, 102, 105, 108, 97, 56 }, 5));
        _0x1fef6f93 = _0xc7585212 || _0xa4af0607.Contains(_0x339c0fec._0x5bb166a0(new byte[18] { 71, 86, 86, 85, 8, 79, 72, 85, 82, 71, 65, 84, 71, 75, 8, 69, 73, 75 }, 38)) || _0xa4af0607.Contains(_0x339c0fec._0x5bb166a0(new byte[17] { 132, 149, 149, 150, 203, 131, 132, 134, 128, 135, 138, 138, 142, 203, 134, 138, 136 }, 229));
        _0x6e0656ed = _0xc7585212 ? "" : (_0x1fef6f93 ? "" : _0x6e0656ed);
        _0x6e0656ed = _0x6e0656ed ?? "";
        _0xccb21664 = _0xccb21664 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x6e0656ed}");
#endif
        }
    }

    private string _0xde23239d()
    {
        try
        {
            using (var _0x8b198536 = new AndroidJavaClass(_0x339c0fec._0x5bb166a0(new byte[30] { 233, 229, 231, 164, 255, 228, 227, 254, 243, 185, 238, 164, 250, 230, 235, 243, 239, 248, 164, 223, 228, 227, 254, 243, 218, 230, 235, 243, 239, 248 }, 138)))
            {
                var _0x676c3e5b = _0x8b198536.GetStatic<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[15] { 85, 67, 68, 68, 83, 88, 66, 119, 85, 66, 95, 64, 95, 66, 79 }, 54));
                var _0x5fc4bb46 = _0x676c3e5b.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[21] { 174, 172, 189, 136, 185, 185, 165, 160, 170, 168, 189, 160, 166, 167, 138, 166, 167, 189, 172, 177, 189 }, 201));
                using (var _0x9b746428 = new AndroidJavaClass(_0x339c0fec._0x5bb166a0(new byte[26] { 20, 27, 17, 7, 26, 28, 17, 91, 2, 16, 23, 30, 28, 1, 91, 34, 16, 23, 38, 16, 1, 1, 28, 27, 18, 6 }, 117)))
                {
                    return _0x9b746428.CallStatic<string>(_0x339c0fec._0x5bb166a0(new byte[19] { 32, 34, 51, 3, 34, 33, 38, 50, 43, 51, 18, 52, 34, 53, 6, 32, 34, 41, 51 }, 71), _0x5fc4bb46);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private int _0x921f1190 = 0;
    private RectTransform _0xe4a22691;
    private Task _0x02e74567(IEnumerator _0xbf616d13)
    {
        var _0x9991ee55 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x152a384d(_0xbf616d13, _0x9991ee55));
        return _0x9991ee55.Task;
    }

    private bool _0xedda1aa0(string _0x71e6bf51)
    {
        if (string.IsNullOrEmpty(_0x71e6bf51))
            return false;
        try
        {
            using (var _0xafb27c64 = new AndroidJavaClass(_0x339c0fec._0x5bb166a0(new byte[30] { 30, 18, 16, 83, 8, 19, 20, 9, 4, 78, 25, 83, 13, 17, 28, 4, 24, 15, 83, 40, 19, 20, 9, 4, 45, 17, 28, 4, 24, 15 }, 125)))
            using (var _0x16ca132d = _0xafb27c64.GetStatic<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[15] { 175, 185, 190, 190, 169, 162, 184, 141, 175, 184, 165, 186, 165, 184, 181 }, 204)))
            using (var _0x78de6d88 = _0x16ca132d.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[17] { 96, 98, 115, 87, 102, 100, 108, 102, 96, 98, 74, 102, 105, 102, 96, 98, 117 }, 7)))
            using (var _0xb50ed64e = _0x78de6d88.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[25] { 5, 7, 22, 46, 3, 23, 12, 1, 10, 43, 12, 22, 7, 12, 22, 36, 13, 16, 50, 3, 1, 9, 3, 5, 7 }, 98), _0x71e6bf51))
            {
                if (_0xb50ed64e == null)
                    return false;
                WLog(_0x339c0fec._0x5bb166a0(new byte[37] { 54, 29, 7, 26, 24, 16, 57, 28, 30, 16, 85, 25, 20, 0, 27, 22, 29, 85, 28, 27, 6, 1, 20, 25, 25, 16, 17, 85, 5, 20, 22, 30, 20, 18, 16, 79, 85 }, 117) + _0x71e6bf51);
                _0xb50ed64e.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[8] { 17, 20, 20, 54, 28, 17, 23, 3 }, 112), 0x10000000);
                _0x16ca132d.Call(_0x339c0fec._0x5bb166a0(new byte[13] { 137, 142, 155, 136, 142, 187, 153, 142, 147, 140, 147, 142, 131 }, 250), _0xb50ed64e);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    internal void _0x67bf5d2d()
    {
        Rect _0xb7091e27 = Screen.safeArea;
        Vector2 _0xf538a915 = new Vector2(Screen.width, Screen.height);
        if (_0xb7091e27 == lastSafe && _0xf538a915 == lastSize)
            return;
        // Apply manual padding
        _0xb7091e27.xMin += _0x873e7f24;
        _0xb7091e27.xMax -= _0x07265c96;
        _0xb7091e27.yMin += _0x7a4de469;
        _0xb7091e27.yMax -= _0x63048eb5;
        // Convert Unity safe area -> native WebView frame
        Rect _0xa4840f36 = new Rect(_0xb7091e27.x, _0xf538a915.y - _0xb7091e27.y - _0xb7091e27.height, // Y flip for native coordinate system
 _0xb7091e27.width, _0xb7091e27.height);
        _0x9620eb46.Frame = _0xa4840f36;
        lastSafe = Screen.safeArea;
        lastSize = _0xf538a915;
    }

    private string _0xc747da4e()
    {
        return _0x339c0fec._0x5bb166a0(new byte[12] { 180, 250, 233, 242, 255, 232, 245, 243, 242, 180, 181, 231 }, 156) + _0x339c0fec._0x5bb166a0(new byte[8] { 159, 136, 155, 201, 156, 136, 212, 206 }, 233) + WindowsDesktopUserAgent + _0x339c0fec._0x5bb166a0(new byte[2] { 94, 66 }, 121) + _0x339c0fec._0x5bb166a0(new byte[30] { 7, 16, 3, 81, 1, 3, 30, 5, 30, 76, 63, 16, 7, 24, 22, 16, 5, 30, 3, 95, 1, 3, 30, 5, 30, 5, 8, 1, 20, 74 }, 113) + _0x339c0fec._0x5bb166a0(new byte[121] { 84, 71, 92, 81, 70, 91, 93, 92, 18, 86, 87, 84, 26, 93, 80, 88, 30, 89, 87, 75, 30, 68, 83, 94, 27, 73, 70, 64, 75, 73, 125, 80, 88, 87, 81, 70, 28, 86, 87, 84, 91, 92, 87, 98, 64, 93, 66, 87, 64, 70, 75, 26, 93, 80, 88, 30, 89, 87, 75, 30, 73, 85, 87, 70, 8, 84, 71, 92, 81, 70, 91, 93, 92, 26, 27, 73, 64, 87, 70, 71, 64, 92, 18, 68, 83, 94, 9, 79, 30, 81, 93, 92, 84, 91, 85, 71, 64, 83, 80, 94, 87, 8, 70, 64, 71, 87, 79, 27, 9, 79, 81, 83, 70, 81, 90, 26, 87, 27, 73, 79, 79 }, 50) + _0x339c0fec._0x5bb166a0(new byte[26] { 201, 200, 203, 133, 221, 223, 194, 217, 194, 129, 138, 216, 222, 200, 223, 236, 202, 200, 195, 217, 138, 129, 216, 204, 132, 150 }, 173) + _0x339c0fec._0x5bb166a0(new byte[130] { 207, 206, 205, 131, 219, 217, 196, 223, 196, 135, 140, 202, 219, 219, 253, 206, 217, 216, 194, 196, 197, 140, 135, 140, 158, 133, 155, 139, 131, 252, 194, 197, 207, 196, 220, 216, 139, 229, 255, 139, 154, 155, 133, 155, 144, 139, 252, 194, 197, 157, 159, 144, 139, 211, 157, 159, 130, 139, 234, 219, 219, 199, 206, 252, 206, 201, 224, 194, 223, 132, 158, 152, 156, 133, 152, 157, 139, 131, 224, 227, 255, 230, 231, 135, 139, 199, 194, 192, 206, 139, 236, 206, 200, 192, 196, 130, 139, 232, 195, 217, 196, 198, 206, 132, 154, 153, 155, 133, 155, 133, 155, 133, 155, 139, 248, 202, 205, 202, 217, 194, 132, 158, 152, 156, 133, 152, 157, 140, 130, 144 }, 171) + _0x339c0fec._0x5bb166a0(new byte[30] { 234, 235, 232, 166, 254, 252, 225, 250, 225, 162, 169, 254, 226, 239, 250, 232, 225, 252, 227, 169, 162, 169, 217, 231, 224, 189, 188, 169, 167, 181 }, 142) + _0x339c0fec._0x5bb166a0(new byte[34] { 232, 233, 234, 164, 252, 254, 227, 248, 227, 160, 171, 250, 233, 226, 232, 227, 254, 171, 160, 171, 203, 227, 227, 235, 224, 233, 172, 197, 226, 239, 162, 171, 165, 183 }, 140) + _0x339c0fec._0x5bb166a0(new byte[30] { 63, 62, 61, 115, 43, 41, 52, 47, 52, 119, 124, 54, 58, 35, 15, 52, 46, 56, 51, 11, 52, 50, 53, 47, 40, 124, 119, 107, 114, 96 }, 91) + _0x339c0fec._0x5bb166a0(new byte[449] { 208, 214, 221, 223, 210, 197, 214, 132, 209, 197, 192, 153, 223, 198, 214, 197, 202, 192, 215, 158, 255, 223, 198, 214, 197, 202, 192, 158, 131, 231, 204, 214, 203, 201, 205, 209, 201, 131, 136, 210, 193, 214, 215, 205, 203, 202, 158, 131, 149, 150, 148, 131, 217, 136, 223, 198, 214, 197, 202, 192, 158, 131, 227, 203, 203, 195, 200, 193, 132, 231, 204, 214, 203, 201, 193, 131, 136, 210, 193, 214, 215, 205, 203, 202, 158, 131, 149, 150, 148, 131, 217, 136, 223, 198, 214, 197, 202, 192, 158, 131, 234, 203, 208, 153, 229, 155, 230, 214, 197, 202, 192, 131, 136, 210, 193, 214, 215, 205, 203, 202, 158, 131, 150, 144, 131, 217, 249, 136, 201, 203, 198, 205, 200, 193, 158, 194, 197, 200, 215, 193, 136, 212, 200, 197, 208, 194, 203, 214, 201, 158, 131, 243, 205, 202, 192, 203, 211, 215, 131, 136, 195, 193, 208, 236, 205, 195, 204, 225, 202, 208, 214, 203, 212, 221, 242, 197, 200, 209, 193, 215, 158, 194, 209, 202, 199, 208, 205, 203, 202, 140, 141, 223, 214, 193, 208, 209, 214, 202, 132, 244, 214, 203, 201, 205, 215, 193, 138, 214, 193, 215, 203, 200, 210, 193, 140, 223, 197, 214, 199, 204, 205, 208, 193, 199, 208, 209, 214, 193, 158, 131, 220, 156, 146, 131, 136, 198, 205, 208, 202, 193, 215, 215, 158, 131, 146, 144, 131, 136, 201, 203, 198, 205, 200, 193, 158, 194, 197, 200, 215, 193, 136, 201, 203, 192, 193, 200, 158, 131, 131, 136, 212, 200, 197, 208, 194, 203, 214, 201, 158, 131, 243, 205, 202, 192, 203, 211, 215, 131, 136, 212, 200, 197, 208, 194, 203, 214, 201, 242, 193, 214, 215, 205, 203, 202, 158, 131, 149, 145, 138, 148, 138, 148, 131, 136, 209, 197, 226, 209, 200, 200, 242, 193, 214, 215, 205, 203, 202, 158, 131, 149, 150, 148, 138, 148, 138, 148, 138, 148, 131, 217, 141, 159, 217, 217, 159, 235, 198, 206, 193, 199, 208, 138, 192, 193, 194, 205, 202, 193, 244, 214, 203, 212, 193, 214, 208, 221, 140, 212, 214, 203, 208, 203, 136, 131, 209, 215, 193, 214, 229, 195, 193, 202, 208, 224, 197, 208, 197, 131, 136, 223, 195, 193, 208, 158, 194, 209, 202, 199, 208, 205, 203, 202, 140, 141, 223, 214, 193, 208, 209, 214, 202, 132, 209, 197, 192, 159, 217, 136, 199, 203, 202, 194, 205, 195, 209, 214, 197, 198, 200, 193, 158, 208, 214, 209, 193, 217, 141, 159, 217, 199, 197, 208, 199, 204, 140, 193, 141, 223, 217 }, 164) + _0x339c0fec._0x5bb166a0(new byte[112] { 216, 217, 218, 148, 207, 223, 206, 217, 217, 210, 144, 155, 203, 213, 216, 200, 212, 155, 144, 141, 133, 142, 140, 149, 135, 216, 217, 218, 148, 207, 223, 206, 217, 217, 210, 144, 155, 212, 217, 213, 219, 212, 200, 155, 144, 141, 140, 132, 140, 149, 135, 216, 217, 218, 148, 207, 223, 206, 217, 217, 210, 144, 155, 221, 202, 221, 213, 208, 235, 213, 216, 200, 212, 155, 144, 141, 133, 142, 140, 149, 135, 216, 217, 218, 148, 207, 223, 206, 217, 217, 210, 144, 155, 221, 202, 221, 213, 208, 244, 217, 213, 219, 212, 200, 155, 144, 141, 140, 136, 140, 149, 135 }, 188) + _0x339c0fec._0x5bb166a0(new byte[45] { 195, 197, 206, 204, 192, 222, 217, 211, 216, 192, 153, 216, 217, 195, 216, 194, 212, 223, 196, 195, 214, 197, 195, 138, 194, 217, 211, 210, 209, 222, 217, 210, 211, 140, 202, 212, 214, 195, 212, 223, 159, 210, 158, 204, 202 }, 183) + _0x339c0fec._0x5bb166a0(new byte[721] { 152, 158, 149, 151, 154, 141, 158, 204, 131, 158, 133, 139, 209, 155, 133, 130, 136, 131, 155, 194, 129, 141, 152, 143, 132, 161, 137, 136, 133, 141, 194, 142, 133, 130, 136, 196, 155, 133, 130, 136, 131, 155, 197, 215, 155, 133, 130, 136, 131, 155, 194, 129, 141, 152, 143, 132, 161, 137, 136, 133, 141, 209, 138, 153, 130, 143, 152, 133, 131, 130, 196, 157, 197, 151, 154, 141, 158, 204, 159, 209, 191, 152, 158, 133, 130, 139, 196, 157, 197, 194, 152, 131, 160, 131, 155, 137, 158, 175, 141, 159, 137, 196, 197, 215, 133, 138, 196, 159, 194, 133, 130, 136, 137, 148, 163, 138, 196, 203, 156, 131, 133, 130, 152, 137, 158, 214, 204, 143, 131, 141, 158, 159, 137, 203, 197, 210, 209, 220, 144, 144, 159, 194, 133, 130, 136, 137, 148, 163, 138, 196, 203, 132, 131, 154, 137, 158, 214, 204, 130, 131, 130, 137, 203, 197, 210, 209, 220, 144, 144, 159, 194, 133, 130, 136, 137, 148, 163, 138, 196, 203, 129, 141, 148, 193, 155, 133, 136, 152, 132, 203, 197, 210, 209, 220, 144, 144, 159, 194, 133, 130, 136, 137, 148, 163, 138, 196, 203, 129, 141, 148, 193, 136, 137, 154, 133, 143, 137, 193, 155, 133, 136, 152, 132, 203, 197, 210, 209, 220, 197, 158, 137, 152, 153, 158, 130, 204, 151, 129, 141, 152, 143, 132, 137, 159, 214, 138, 141, 128, 159, 137, 192, 129, 137, 136, 133, 141, 214, 157, 192, 131, 130, 143, 132, 141, 130, 139, 137, 214, 130, 153, 128, 128, 192, 141, 136, 136, 160, 133, 159, 152, 137, 130, 137, 158, 214, 138, 153, 130, 143, 152, 133, 131, 130, 196, 197, 151, 145, 192, 158, 137, 129, 131, 154, 137, 160, 133, 159, 152, 137, 130, 137, 158, 214, 138, 153, 130, 143, 152, 133, 131, 130, 196, 197, 151, 145, 192, 141, 136, 136, 169, 154, 137, 130, 152, 160, 133, 159, 152, 137, 130, 137, 158, 214, 138, 153, 130, 143, 152, 133, 131, 130, 196, 197, 151, 145, 192, 158, 137, 129, 131, 154, 137, 169, 154, 137, 130, 152, 160, 133, 159, 152, 137, 130, 137, 158, 214, 138, 153, 130, 143, 152, 133, 131, 130, 196, 197, 151, 145, 192, 136, 133, 159, 156, 141, 152, 143, 132, 169, 154, 137, 130, 152, 214, 138, 153, 130, 143, 152, 133, 131, 130, 196, 197, 151, 158, 137, 152, 153, 158, 130, 204, 138, 141, 128, 159, 137, 215, 145, 145, 215, 133, 138, 196, 159, 194, 133, 130, 136, 137, 148, 163, 138, 196, 203, 156, 131, 133, 130, 152, 137, 158, 214, 204, 138, 133, 130, 137, 203, 197, 210, 209, 220, 144, 144, 159, 194, 133, 130, 136, 137, 148, 163, 138, 196, 203, 132, 131, 154, 137, 158, 214, 204, 132, 131, 154, 137, 158, 203, 197, 210, 209, 220, 197, 158, 137, 152, 153, 158, 130, 204, 151, 129, 141, 152, 143, 132, 137, 159, 214, 152, 158, 153, 137, 192, 129, 137, 136, 133, 141, 214, 157, 192, 131, 130, 143, 132, 141, 130, 139, 137, 214, 130, 153, 128, 128, 192, 141, 136, 136, 160, 133, 159, 152, 137, 130, 137, 158, 214, 138, 153, 130, 143, 152, 133, 131, 130, 196, 197, 151, 145, 192, 158, 137, 129, 131, 154, 137, 160, 133, 159, 152, 137, 130, 137, 158, 214, 138, 153, 130, 143, 152, 133, 131, 130, 196, 197, 151, 145, 192, 141, 136, 136, 169, 154, 137, 130, 152, 160, 133, 159, 152, 137, 130, 137, 158, 214, 138, 153, 130, 143, 152, 133, 131, 130, 196, 197, 151, 145, 192, 158, 137, 129, 131, 154, 137, 169, 154, 137, 130, 152, 160, 133, 159, 152, 137, 130, 137, 158, 214, 138, 153, 130, 143, 152, 133, 131, 130, 196, 197, 151, 145, 192, 136, 133, 159, 156, 141, 152, 143, 132, 169, 154, 137, 130, 152, 214, 138, 153, 130, 143, 152, 133, 131, 130, 196, 197, 151, 158, 137, 152, 153, 158, 130, 204, 138, 141, 128, 159, 137, 215, 145, 145, 215, 158, 137, 152, 153, 158, 130, 204, 131, 158, 133, 139, 196, 157, 197, 215, 145, 215, 145, 143, 141, 152, 143, 132, 196, 137, 197, 151, 145 }, 236) + _0x339c0fec._0x5bb166a0(new byte[5] { 90, 14, 15, 14, 28 }, 39);
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x9620eb46 = null;
    private string _0x20656dda = "";
    private void _0xd33456d3(UniWebView _0x770d8b42)
    {
        _0x770d8b42.BackgroundColor = Color.clear;
        _0x770d8b42.SetSupportMultipleWindows(true, true);
        _0x770d8b42.SetBackButtonEnabled(false);
        _0x9620eb46.SetUserAgent(_0x0d40ff50());
    }

    private AndroidJavaObject _0xddcf6cf9 { get; set; }

    private void _0xa13d420a(string _0x156e642d)
    {
        bool _0x67da6558 = !string.IsNullOrEmpty(_0x156e642d);
        if (_0x67da6558)
        {
            {
#if B_LOGS
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[13] { 189, 178, 131, 149, 146, 187, 198, 181, 142, 137, 145, 220, 198 }, 230) + _0x156e642d);
#endif
            }

            _0x788267e8(_0x156e642d);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[39] { 246, 249, 200, 222, 217, 240, 141, 235, 204, 193, 193, 207, 204, 206, 198, 141, 79, 43, 63, 141, 234, 204, 192, 200, 141, 133, 195, 194, 141, 203, 196, 195, 204, 193, 141, 248, 255, 225, 132 }, 173));
#endif
            }

            _0x0abf0ad2();
            return;
        }
    }

    internal bool isDestroyedForce = false;
    private string _0x476dd3b5 = "";
    private bool _0x23405d9a(string _0x13348a8e)
    {
        try
        {
            using (var _0x998cb255 = new AndroidJavaClass(_0x339c0fec._0x5bb166a0(new byte[30] { 179, 191, 189, 254, 165, 190, 185, 164, 169, 227, 180, 254, 160, 188, 177, 169, 181, 162, 254, 133, 190, 185, 164, 169, 128, 188, 177, 169, 181, 162 }, 208)))
            using (var _0x1e1c6304 = _0x998cb255.GetStatic<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[15] { 62, 40, 47, 47, 56, 51, 41, 28, 62, 41, 52, 43, 52, 41, 36 }, 93)))
            using (var _0xc8189b33 = new AndroidJavaClass(_0x339c0fec._0x5bb166a0(new byte[15] { 229, 234, 224, 246, 235, 237, 224, 170, 234, 225, 240, 170, 209, 246, 237 }, 132)))
            using (var _0x9e5c5e9a = _0xc8189b33.CallStatic<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[5] { 113, 96, 115, 114, 100 }, 1), _0x13348a8e))
            using (var _0x6cdf71ca = new AndroidJavaObject(_0x339c0fec._0x5bb166a0(new byte[22] { 190, 177, 187, 173, 176, 182, 187, 241, 188, 176, 177, 171, 186, 177, 171, 241, 150, 177, 171, 186, 177, 171 }, 223), _0x339c0fec._0x5bb166a0(new byte[26] { 135, 136, 130, 148, 137, 143, 130, 200, 143, 136, 146, 131, 136, 146, 200, 135, 133, 146, 143, 137, 136, 200, 176, 175, 163, 177 }, 230), _0x9e5c5e9a))
            {
                WLog(_0x339c0fec._0x5bb166a0(new byte[26] { 203, 224, 250, 231, 229, 237, 196, 225, 227, 237, 168, 231, 248, 237, 230, 168, 237, 240, 252, 237, 250, 230, 233, 228, 178, 168 }, 136) + _0x13348a8e);
                _0x6cdf71ca.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[11] { 138, 143, 143, 168, 138, 159, 142, 140, 132, 153, 146 }, 235), _0x339c0fec._0x5bb166a0(new byte[33] { 113, 126, 116, 98, 127, 121, 116, 62, 121, 126, 100, 117, 126, 100, 62, 115, 113, 100, 117, 119, 127, 98, 105, 62, 82, 66, 95, 71, 67, 81, 82, 92, 85 }, 16));
                _0x6cdf71ca.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[8] { 69, 64, 64, 98, 72, 69, 67, 87 }, 36), 0x10000000);
                _0x1e1c6304.Call(_0x339c0fec._0x5bb166a0(new byte[13] { 150, 145, 132, 151, 145, 164, 134, 145, 140, 147, 140, 145, 156 }, 229), _0x6cdf71ca);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x339c0fec._0x5bb166a0(new byte[28] { 89, 114, 104, 117, 119, 127, 86, 115, 113, 127, 58, 127, 98, 110, 127, 104, 116, 123, 118, 58, 124, 123, 115, 118, 127, 126, 32, 58 }, 26) + e.Message);
            Application.OpenURL(_0x13348a8e);
            return true;
        }
    }

    private void _0x788267e8(string _0xe82a3ad7)
    {
        _0x28c33063();
        StartCoroutine(_0xffe762ae(_0xe82a3ad7));
    }

    internal Rect lastSafe = Rect.zero;
    private bool _0x96f863f8()
    {
        var _0x8cccf307 = Keyboard.current;
        return _0x8cccf307 != null && _0x8cccf307.escapeKey.wasPressedThisFrame;
    }

    internal bool firstLoadShown = false;
    private void OnApplicationPause(bool _0x7092dddf)
    {
        isApplicationPause = _0x7092dddf;
    }

    internal bool _0x36ab2056(string _0x9f9869d6)
    {
        return _0x9f9869d6.StartsWith(_0x339c0fec._0x5bb166a0(new byte[9] { 92, 80, 67, 90, 84, 69, 11, 30, 30 }, 49), StringComparison.OrdinalIgnoreCase) || _0x9f9869d6.StartsWith(_0x339c0fec._0x5bb166a0(new byte[24] { 97, 125, 125, 121, 122, 51, 38, 38, 121, 101, 104, 112, 39, 110, 102, 102, 110, 101, 108, 39, 106, 102, 100, 38 }, 9), StringComparison.OrdinalIgnoreCase) || _0x9f9869d6.StartsWith(_0x339c0fec._0x5bb166a0(new byte[23] { 155, 135, 135, 131, 201, 220, 220, 131, 159, 146, 138, 221, 148, 156, 156, 148, 159, 150, 221, 144, 156, 158, 220 }, 243), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0x035cf02a = false;
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x0abf0ad2();
    }

    // PART 3
    private string _0x14256a71()
    {
        try
        {
            var _0xbb8d5c75 = new AndroidJavaClass(_0x339c0fec._0x5bb166a0(new byte[30] { 35, 47, 45, 110, 53, 46, 41, 52, 57, 115, 36, 110, 48, 44, 33, 57, 37, 50, 110, 21, 46, 41, 52, 57, 16, 44, 33, 57, 37, 50 }, 64));
            var _0xcbefae60 = _0xbb8d5c75.GetStatic<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[15] { 44, 58, 61, 61, 42, 33, 59, 14, 44, 59, 38, 57, 38, 59, 54 }, 79));
            var _0xe7bb8dda = new AndroidJavaClass(_0x339c0fec._0x5bb166a0(new byte[57] { 223, 211, 209, 146, 219, 211, 211, 219, 208, 217, 146, 221, 210, 216, 206, 211, 213, 216, 146, 219, 209, 207, 146, 221, 216, 207, 146, 213, 216, 217, 210, 200, 213, 218, 213, 217, 206, 146, 253, 216, 202, 217, 206, 200, 213, 207, 213, 210, 219, 245, 216, 255, 208, 213, 217, 210, 200 }, 188));
            var _0x2223ab08 = _0xe7bb8dda.CallStatic<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[20] { 45, 47, 62, 11, 46, 60, 47, 56, 62, 35, 57, 35, 36, 45, 3, 46, 3, 36, 44, 37 }, 74), _0xcbefae60);
            var _0xcfb46179 = _0x2223ab08.Call<string>(_0x339c0fec._0x5bb166a0(new byte[5] { 216, 218, 203, 246, 219 }, 191));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xcfb46179}");
#endif
            }

            return string.IsNullOrEmpty(_0xcfb46179) ? "" : _0xcfb46179;
        }
        catch
        {
            return "";
        }
    }

    private string _0x0d40ff50()
    {
        if (string.IsNullOrEmpty(_0x899d8f9c) && _0x9620eb46 != null)
            _0x899d8f9c = _0x9620eb46.GetUserAgent();
        if (string.IsNullOrEmpty(_0x899d8f9c))
            return string.Empty;
        string _0x2205ca85 = Regex.Replace(_0x899d8f9c, _0x339c0fec._0x5bb166a0(new byte[11] { 41, 6, 95, 78, 41, 6, 95, 2, 3, 41, 23 }, 117), string.Empty);
        _0x2205ca85 = Regex.Replace(_0x2205ca85, _0x339c0fec._0x5bb166a0(new byte[15] { 106, 69, 29, 116, 67, 95, 90, 82, 25, 109, 104, 13, 31, 107, 29 }, 54), string.Empty);
        _0x2205ca85 = Regex.Replace(_0x2205ca85, _0x339c0fec._0x5bb166a0(new byte[15] { 70, 117, 98, 99, 121, 127, 126, 63, 36, 76, 62, 32, 76, 99, 58 }, 16), string.Empty);
        return Regex.Replace(_0x2205ca85, _0x339c0fec._0x5bb166a0(new byte[6] { 4, 43, 35, 106, 116, 37 }, 88), _0x339c0fec._0x5bb166a0(new byte[1] { 183 }, 151)).Trim();
    }

    private static string ReadPushField(Dictionary<string, object> _0x87e75e10, string _0x5a11be25)
    {
        if (_0x87e75e10 == null || string.IsNullOrEmpty(_0x5a11be25))
            return string.Empty;
        if (_0x87e75e10.TryGetValue(_0x339c0fec._0x5bb166a0(new byte[16] { 55, 54, 45, 48, 63, 48, 58, 56, 45, 48, 54, 55, 29, 56, 45, 56 }, 89), out var raw))
        {
            try
            {
                var _0x21582089 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x21582089 != null && _0x21582089.TryGetValue(_0x5a11be25, out var nestedVal))
                {
                    var _0x312201b3 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x312201b3))
                        return _0x312201b3;
                }
            }
            catch
            {
            }
        }

        if (_0x87e75e10.TryGetValue(_0x5a11be25, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private IEnumerator _0x3e5840a0()
    {
        yield return _0x6f7954fa(Permission.Camera);
    }

    private string _0x4154cfd1;
    private string _0x899d8f9c = "";
    private async Task<bool> _0xffc8e00d()
    {
        {
#if B_LOGS
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[37] { 116, 123, 74, 92, 91, 114, 15, 124, 70, 72, 65, 102, 65, 122, 65, 70, 91, 86, 124, 74, 93, 89, 70, 76, 74, 92, 110, 65, 64, 65, 86, 66, 64, 90, 92, 67, 86 }, 47));
#endif
        }

        try
        {
            var _0x7f101927 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x7f101927);
            {
#if B_LOGS
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[32] { 203, 196, 245, 227, 228, 205, 176, 197, 254, 249, 228, 233, 195, 245, 226, 230, 249, 243, 245, 227, 176, 217, 254, 249, 228, 249, 241, 252, 249, 234, 245, 244 }, 144));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[20] { 90, 75, 93, 90, 46, 91, 96, 103, 122, 119, 93, 107, 124, 120, 103, 109, 107, 125, 52, 46 }, 14) + ex.Message);
#endif
            }

            _0x25d86ebb?._0x0abf0ad2();
            return true;
        }

        bool _0x55d3f217 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x55d3f217 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x339c0fec._0x5bb166a0(new byte[37] { 230, 233, 216, 206, 201, 224, 157, 238, 212, 218, 211, 144, 212, 211, 157, 252, 211, 210, 211, 196, 208, 210, 200, 206, 147, 157, 237, 209, 220, 196, 216, 207, 157, 244, 249, 135, 157 }, 189) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xf2712e3c = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x339c0fec._0x5bb166a0(new byte[25] { 14, 31, 9, 14, 122, 9, 51, 61, 52, 119, 51, 52, 122, 27, 47, 46, 50, 122, 31, 8, 8, 21, 8, 96, 122 }, 90) + ex.Message);
#endif
                }

                _0x25d86ebb?._0x0abf0ad2();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x339c0fec._0x5bb166a0(new byte[28] { 3, 18, 4, 3, 119, 4, 62, 48, 57, 122, 62, 57, 119, 5, 50, 38, 34, 50, 36, 35, 119, 18, 5, 5, 24, 5, 109, 119 }, 87) + ex.Message);
#endif
                }

                _0x25d86ebb?._0x0abf0ad2();
                return true;
            }
        }
        while (!_0x55d3f217);
        return false;
    }

    private bool OpenUrlExternally(string _0x4d41b97c)
    {
        return _0x23405d9a(_0x4d41b97c);
    }

    private void _0xb5e2027c()
    {
        if (_0x9620eb46 == null)
            return;
        if (_0xb766c454)
            _0x9620eb46.SetUserAgent(_0x0d40ff50());
        else
            _0x9620eb46.SetUserAgent("");
    }

    private async Task _0x032ffccf(string _0x268c9b0d)
    {
        if (_0x977bd4c2 || string.IsNullOrEmpty(_0xf2712e3c) || string.IsNullOrEmpty(_0x268c9b0d) || _0x5a65c5ba)
            return;
        _0x977bd4c2 = true;
        try
        {
            JObject _0xc1ac7276 = _0x75af0f1a(_0x268c9b0d, _0xf2712e3c, _0x1fe15d05());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x268c9b0d} payload: {_0xc1ac7276}");
                }
#endif
            }

            var _0x7da89109 = _0x551bbdfb(_0xc1ac7276.ToString(), _0xf2712e3c);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x339c0fec._0x5bb166a0(new byte[4] { 136, 139, 133, 128 }, 228) + _0xf2712e3c, _0x7da89109 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[24] { 2, 13, 28, 10, 13, 4, 121, 21, 54, 56, 61, 121, 41, 56, 42, 42, 121, 60, 43, 43, 54, 43, 99, 121 }, 89) + e.Message);
#endif
            }
        }
    }

    private async Task<bool> _0x3d5df30f(int _0x248b8201 = 5, int _0x252f806d = 500)
    {
        List<EntityData> _0x4520edc8 = new List<EntityData>();
        int _0x756244d7 = 0;
        do
        {
            try
            {
                _0x4520edc8 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x339c0fec._0x5bb166a0(new byte[8] { 224, 252, 241, 233, 245, 226, 217, 244 }, 144), _0xf2712e3c, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x339c0fec._0x5bb166a0(new byte[9] { 112, 106, 73, 107, 112, 111, 120, 122, 96 }, 25) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x339c0fec._0x5bb166a0(new byte[32] { 177, 190, 143, 153, 158, 183, 202, 155, 159, 143, 152, 147, 171, 153, 147, 132, 137, 184, 143, 153, 159, 134, 158, 153, 202, 143, 152, 152, 133, 152, 208, 202 }, 234) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x252f806d);
        }
        while (_0x4520edc8.Count == 0 && _0x756244d7++ < _0x248b8201);
        {
#if B_LOGS
            {
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[32] { 161, 174, 159, 137, 142, 167, 218, 179, 137, 170, 136, 147, 140, 155, 153, 131, 218, 171, 143, 159, 136, 131, 218, 136, 159, 137, 143, 150, 142, 137, 192, 218 }, 250) + JsonConvert.SerializeObject(_0x4520edc8, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[38] { 231, 232, 217, 207, 200, 225, 156, 245, 207, 236, 206, 213, 202, 221, 223, 197, 156, 237, 201, 217, 206, 197, 156, 206, 217, 207, 201, 208, 200, 207, 156, 223, 211, 201, 210, 200, 134, 156 }, 188) + _0x4520edc8.Count);
            }
#endif
        }

        bool _0x21f40593 = true;
        if (_0x4520edc8.Count == 0)
        {
            _0x21f40593 = false;
        }
        else
        {
            _0x21f40593 = _0x4520edc8.Any(_0x3f493835 => _0x3f493835.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[25] { 95, 80, 97, 119, 112, 89, 36, 77, 119, 84, 118, 109, 114, 101, 103, 125, 36, 118, 97, 119, 113, 104, 112, 62, 36 }, 4) + _0x21f40593);
            }
#endif
        }

        return _0x21f40593;
    }

    private string _0xba0b1bf4 = "";
    private string _0xf2712e3c = "";
    private Text _0x26db4e48;
    private void _0x2b783e2e()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    internal Button _0xd5474f64(string _0x64ac0f64, Transform _0xcb1864c8)
    {
        var _0x279dab3b = new GameObject(_0x64ac0f64 + _0x339c0fec._0x5bb166a0(new byte[3] { 178, 132, 158 }, 240), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x21473423 = _0x279dab3b.GetComponent<RectTransform>();
        _0x21473423.SetParent(_0xcb1864c8, false);
        var _0x6ccfeea7 = _0x279dab3b.GetComponent<Image>();
        _0x6ccfeea7.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x82f49443 = _0x279dab3b.GetComponent<Button>();
        var _0x36f7f134 = _0x82f49443.colors;
        _0x36f7f134.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x36f7f134.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x82f49443.colors = _0x36f7f134;
        var _0xb94948a2 = new GameObject(_0x339c0fec._0x5bb166a0(new byte[4] { 208, 225, 252, 240 }, 132), typeof(RectTransform), typeof(Text));
        var _0x27b3264d = _0xb94948a2.GetComponent<RectTransform>();
        _0x27b3264d.SetParent(_0x279dab3b.transform, false);
        _0x27b3264d.anchorMin = Vector2.zero;
        _0x27b3264d.anchorMax = Vector2.one;
        _0x27b3264d.offsetMin = _0x27b3264d.offsetMax = Vector2.zero;
        var _0x7cf158b7 = _0xb94948a2.GetComponent<Text>();
        _0x7cf158b7.text = _0x64ac0f64;
        _0x7cf158b7.alignment = TextAnchor.MiddleCenter;
        _0x7cf158b7.color = Color.black;
        _0x7cf158b7.font = Resources.GetBuiltinResource<Font>(_0x339c0fec._0x5bb166a0(new byte[9] { 99, 80, 75, 67, 78, 12, 86, 86, 68 }, 34));
        _0x7cf158b7.fontSize = 28;
        WLog(_0x339c0fec._0x5bb166a0(new byte[14] { 201, 248, 239, 235, 254, 239, 200, 255, 254, 254, 229, 228, 170, 173 }, 138) + _0x64ac0f64 + _0x339c0fec._0x5bb166a0(new byte[1] { 226 }, 197));
        return _0x82f49443;
    }

    private readonly string[] _0x9b8ca76d = new string[]
    {
        _0x339c0fec._0x5bb166a0(new byte[60] { 132, 235, 250, 196, 84, 32, 28, 17, 84, 6, 17, 17, 24, 7, 84, 21, 6, 17, 84, 28, 27, 0, 84, 6, 29, 19, 28, 0, 84, 26, 27, 3, 84, 150, 244, 231, 84, 16, 27, 26, 150, 244, 237, 0, 84, 25, 29, 7, 7, 84, 13, 27, 1, 6, 84, 7, 4, 29, 26, 85 }, 116),
        _0x339c0fec._0x5bb166a0(new byte[52] { 171, 196, 214, 219, 123, 18, 47, 123, 56, 52, 46, 55, 63, 123, 57, 62, 123, 34, 52, 46, 41, 123, 55, 46, 56, 48, 34, 123, 54, 52, 54, 62, 53, 47, 123, 185, 219, 200, 123, 44, 51, 34, 123, 40, 47, 52, 43, 123, 53, 52, 44, 100 }, 91),
        _0x339c0fec._0x5bb166a0(new byte[66] { 176, 200, 243, 189, 234, 221, 114, 16, 59, 53, 114, 37, 59, 60, 33, 114, 51, 32, 55, 114, 58, 59, 38, 38, 59, 60, 53, 114, 63, 61, 32, 55, 114, 61, 52, 38, 55, 60, 114, 38, 61, 54, 51, 43, 114, 176, 210, 193, 114, 33, 38, 51, 43, 114, 59, 60, 114, 38, 58, 55, 114, 53, 51, 63, 55, 124 }, 82),
        _0x339c0fec._0x5bb166a0(new byte[54] { 64, 47, 37, 34, 144, 228, 216, 217, 195, 144, 217, 195, 144, 192, 194, 217, 221, 213, 144, 196, 217, 221, 213, 144, 82, 48, 35, 144, 196, 216, 213, 144, 210, 213, 195, 196, 144, 192, 220, 209, 201, 213, 194, 195, 144, 192, 220, 209, 201, 144, 222, 223, 199, 158 }, 176),
        _0x339c0fec._0x5bb166a0(new byte[48] { 140, 227, 232, 217, 92, 37, 19, 9, 14, 92, 11, 21, 18, 18, 21, 18, 27, 92, 15, 8, 14, 25, 29, 23, 92, 31, 19, 9, 16, 24, 92, 30, 25, 92, 19, 18, 25, 92, 15, 12, 21, 18, 92, 29, 11, 29, 5, 82 }, 124),
        _0x339c0fec._0x5bb166a0(new byte[65] { 152, 247, 242, 232, 72, 34, 9, 11, 3, 24, 7, 28, 27, 72, 9, 26, 13, 72, 5, 7, 26, 13, 72, 9, 11, 28, 1, 30, 13, 72, 28, 7, 6, 1, 15, 0, 28, 72, 138, 232, 251, 72, 27, 28, 9, 17, 72, 9, 6, 12, 72, 28, 26, 17, 72, 17, 7, 29, 26, 72, 4, 29, 11, 3, 70 }, 104),
        _0x339c0fec._0x5bb166a0(new byte[55] { 193, 174, 191, 131, 17, 116, 71, 84, 67, 72, 17, 66, 65, 88, 95, 17, 82, 94, 68, 95, 69, 66, 17, 211, 177, 162, 17, 69, 89, 84, 17, 95, 84, 73, 69, 17, 94, 95, 84, 17, 82, 94, 68, 93, 85, 17, 83, 84, 17, 72, 94, 68, 67, 66, 31 }, 49),
        _0x339c0fec._0x5bb166a0(new byte[63] { 57, 118, 75, 52, 99, 84, 251, 139, 183, 186, 162, 190, 169, 168, 251, 169, 178, 188, 179, 175, 251, 181, 180, 172, 251, 186, 169, 190, 251, 172, 178, 181, 181, 178, 181, 188, 251, 57, 91, 72, 251, 191, 180, 181, 57, 91, 66, 175, 251, 172, 186, 183, 176, 251, 186, 172, 186, 162, 251, 162, 190, 175, 245 }, 219),
        _0x339c0fec._0x5bb166a0(new byte[51] { 216, 183, 167, 174, 8, 103, 70, 68, 81, 8, 92, 64, 71, 91, 77, 8, 95, 64, 71, 8, 91, 92, 73, 81, 8, 65, 70, 8, 92, 64, 77, 8, 79, 73, 69, 77, 8, 95, 65, 70, 8, 92, 64, 77, 8, 88, 90, 65, 82, 77, 6 }, 40),
        _0x339c0fec._0x5bb166a0(new byte[64] { 218, 162, 153, 215, 128, 183, 24, 117, 87, 85, 93, 86, 76, 77, 85, 24, 81, 75, 24, 93, 78, 93, 74, 65, 76, 80, 81, 86, 95, 24, 218, 184, 171, 24, 83, 93, 93, 72, 24, 75, 72, 81, 86, 86, 81, 86, 95, 24, 94, 87, 74, 24, 65, 87, 77, 74, 24, 91, 80, 89, 86, 91, 93, 22 }, 56)
    };
    private readonly List<UniWebViewPopup> _0xf33d6a44 = new List<UniWebViewPopup>();
    internal bool isApplicationPause = false;
    private void _0xb7e233a3()
    {
        _0xb766c454 = true;
        if (_0x9620eb46 != null)
            _0x9620eb46.SetUserAgent(_0x0d40ff50());
    }

    internal void Update()
    {
        if (_0x9620eb46 == null)
            return;
        if (_0x96f863f8())
            _0x983b0ed6();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x67bf5d2d();
        if (_0x035cf02a && _0xe4a22691 != null)
            _0xe4a22691.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private string _0x65518d6e = "";
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x551bbdfb(string _0x08b21b44, string _0xb94b64ae)
    {
        try
        {
            using var _0x55cbc0cf = Aes.Create();
            _0x55cbc0cf.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xb94b64ae));
            _0x55cbc0cf.GenerateIV();
            using var _0x5539af9e = new MemoryStream();
            _0x5539af9e.Write(_0x55cbc0cf.IV, 0, _0x55cbc0cf.IV.Length);
            using (var _0x04772a74 = new CryptoStream(_0x5539af9e, _0x55cbc0cf.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xe496a3bb = Encoding.UTF8.GetBytes(_0x08b21b44);
                _0x04772a74.Write(_0xe496a3bb, 0, _0xe496a3bb.Length);
                _0x04772a74.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x5539af9e.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private float _0xb0df8ebd = 0f;
    private bool _0xb766c454 = false;
    private ApplicationInstallMode _0x80e30291 = ApplicationInstallMode.Unknown;
    private void _0x983b0ed6()
    {
        WLog(_0x339c0fec._0x5bb166a0(new byte[21] { 211, 250, 233, 255, 236, 250, 233, 254, 187, 249, 250, 248, 240, 187, 235, 233, 254, 232, 232, 254, 255 }, 155));
        if (Time.frameCount == _0x7bd60033)
            return;
        _0x7bd60033 = Time.frameCount;
        if (_0x6522221f())
            return;
        _0x77e63d48();
    }

    // WEB VIEW LOGIC
    public bool _0x2061dc30 { get; set; }

    private async Task<bool> _0x567b0234()
    {
        _0x96c5878b.Instance?._0xe238b6b8();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x17d3e671) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x339c0fec._0x5bb166a0(new byte[32] { 22, 25, 40, 62, 57, 16, 109, 24, 35, 36, 57, 52, 109, 29, 56, 62, 37, 109, 3, 34, 57, 36, 43, 36, 46, 44, 57, 36, 34, 35, 119, 109 }, 77) + string.Join(_0x339c0fec._0x5bb166a0(new byte[1] { 36 }, 45), _0x17d3e671));
                }
#endif
            }
        };
        try
        {
            _0x0fef61ea = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x339c0fec._0x5bb166a0(new byte[31] { 51, 60, 13, 27, 28, 53, 72, 46, 9, 1, 4, 13, 12, 72, 28, 7, 72, 15, 13, 28, 72, 24, 29, 27, 0, 72, 28, 7, 3, 13, 6 }, 104));
                }
#endif
            }

            _0x0fef61ea = "";
        }

        _0x9594de1b = !string.IsNullOrEmpty(_0x0fef61ea);
        _0x8cdd5489 = _0x1fe15d05();
        {
#if B_LOGS
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[25] { 220, 211, 226, 244, 243, 218, 167, 210, 233, 238, 243, 254, 167, 215, 242, 244, 239, 167, 211, 232, 236, 226, 233, 189, 167 }, 135) + _0x0fef61ea);
#endif
        }

        _0x96c5878b.Instance?._0x8f5ba30c();
        return false;
    }

    private static bool IsPrivacyItemTrue(Item _0x0e09ab3c)
    {
        if (_0x0e09ab3c.Key != _0x339c0fec._0x5bb166a0(new byte[9] { 222, 196, 231, 197, 222, 193, 214, 212, 206 }, 183))
            return false;
        try
        {
            var _0x1044a9be = _0x0e09ab3c.Value.GetAs<object>();
            return _0x1044a9be switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    internal bool IsHttpUrl(string _0x21dd3aca)
    {
        if (string.IsNullOrEmpty(_0x21dd3aca))
            return false;
        return _0x21dd3aca.StartsWith(_0x339c0fec._0x5bb166a0(new byte[7] { 158, 130, 130, 134, 204, 217, 217 }, 246), StringComparison.OrdinalIgnoreCase) || _0x21dd3aca.StartsWith(_0x339c0fec._0x5bb166a0(new byte[8] { 182, 170, 170, 174, 173, 228, 241, 241 }, 222), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x3dac08f4(UniWebView _0x6036a69b)
    {
        if (_0xb6db5f94)
            return;
        _0xb6db5f94 = true;
        _0x6036a69b.AddUrlScheme(_0x339c0fec._0x5bb166a0(new byte[2] { 38, 53 }, 82));
        _0x6036a69b.AddUrlScheme(_0x339c0fec._0x5bb166a0(new byte[6] { 160, 167, 189, 172, 167, 189 }, 201));
        _0x6036a69b.AddUrlScheme(_0x339c0fec._0x5bb166a0(new byte[6] { 227, 239, 252, 229, 235, 250 }, 142));
        _0x6036a69b.OnMessageReceived += (_0xd0c174b6, _0xdbe3dd32) =>
        {
            if (TryOpenExternalLikeChrome(_0xdbe3dd32.RawMessage))
            {
                _0x8368aef1(false);
                return;
            }
        };
        _0x6036a69b.RegisterShouldHandleRequest(_0x88fbadc2 =>
        {
            string _0x1d764e50 = _0x88fbadc2 != null ? _0x88fbadc2.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x1d764e50))
                return true;
            WLog(_0x339c0fec._0x5bb166a0(new byte[21] { 102, 93, 90, 64, 89, 81, 125, 84, 91, 81, 89, 80, 103, 80, 68, 64, 80, 70, 65, 15, 21 }, 53) + _0x1d764e50);
            if (TryOpenExternalLikeChrome(_0x1d764e50))
            {
                _0x8368aef1(false);
                return false;
            }

            if (_0x88fbadc2 != null && _0x88fbadc2.IsMainFrame && IsGoogleAuthFlowUrl(_0x1d764e50) && !_0xb766c454)
            {
                WLog(_0x339c0fec._0x5bb166a0(new byte[62] { 154, 182, 190, 185, 247, 128, 178, 181, 129, 190, 178, 160, 247, 179, 178, 163, 178, 180, 163, 178, 179, 247, 144, 184, 184, 176, 187, 178, 247, 182, 162, 163, 191, 247, 130, 133, 155, 247, 250, 233, 247, 165, 178, 187, 184, 182, 179, 247, 160, 190, 163, 191, 247, 144, 184, 184, 176, 187, 178, 247, 130, 150 }, 215));
                _0xb766c454 = true;
                _0x8368aef1(true);
                _0x9620eb46.SetUserAgent(_0x0d40ff50());
                _0x9620eb46.Load(_0x1d764e50);
                return false;
            }

            return true;
        });
        _0x6036a69b.OnLoadingErrorReceived += (_0xd0c174b6, _0x73287ef8, _0xdbe3dd32, _0xee7d45f2) =>
        {
            WLog(_0x339c0fec._0x5bb166a0(new byte[25] { 58, 22, 30, 25, 87, 32, 18, 21, 33, 30, 18, 0, 87, 50, 5, 5, 24, 5, 77, 87, 20, 24, 19, 18, 74 }, 119) + _0x73287ef8 + _0x339c0fec._0x5bb166a0(new byte[9] { 250, 183, 191, 169, 169, 187, 189, 191, 231 }, 218) + _0xdbe3dd32);
            string _0x7a7b18a9 = GetFailingUrl(_0xee7d45f2);
            if (string.IsNullOrEmpty(_0x7a7b18a9) || IsAboutBlank(_0x7a7b18a9))
                return;
            _ = _0x032ffccf(_0x339c0fec._0x5bb166a0(new byte[8] { 34, 35, 10, 48, 39, 39, 58, 39 }, 85));
            WLog(_0x339c0fec._0x5bb166a0(new byte[45] { 25, 53, 61, 58, 116, 3, 49, 54, 2, 61, 49, 35, 116, 50, 53, 61, 56, 61, 58, 51, 116, 1, 6, 24, 116, 121, 106, 116, 59, 36, 49, 58, 116, 49, 44, 32, 49, 38, 58, 53, 56, 56, 45, 110, 116 }, 84) + _0x7a7b18a9);
            StopCurrentFailedLoad(_0xd0c174b6);
            _0x26edc79f(_0x7a7b18a9);
        };
        _0x6036a69b.OnPageStarted += (_0xd0c174b6, _0xd4a27dbb) =>
        {
            _0x921f1190 = 0;
            if (_0xae6c54fa && IsAboutBlank(_0xd4a27dbb))
            {
                WLog(_0x339c0fec._0x5bb166a0(new byte[27] { 81, 115, 100, 118, 96, 115, 108, 33, 96, 99, 110, 116, 117, 59, 99, 109, 96, 111, 106, 33, 114, 117, 96, 115, 117, 100, 101 }, 1));
                return;
            }

            WLog(_0x339c0fec._0x5bb166a0(new byte[29] { 10, 38, 46, 41, 103, 16, 34, 37, 17, 46, 34, 48, 103, 8, 41, 23, 38, 32, 34, 20, 51, 38, 53, 51, 34, 35, 125, 103, 108 }, 71) + (Time.realtimeSinceStartup - _0xb0df8ebd).ToString(_0x339c0fec._0x5bb166a0(new byte[5] { 254, 224, 254, 254, 254 }, 206)) + _0x339c0fec._0x5bb166a0(new byte[2] { 131, 208 }, 240) + _0xd4a27dbb);
            if (TryOpenExternalLikeChrome(_0xd4a27dbb))
            {
                StopCurrentFailedLoad(_0xd0c174b6);
                return;
            }

            if (ContainsIgnoreCase(_0xd4a27dbb, _0x339c0fec._0x5bb166a0(new byte[8] { 113, 124, 124, 116, 59, 116, 101, 101 }, 21)) || ContainsIgnoreCase(_0xd4a27dbb, _0x339c0fec._0x5bb166a0(new byte[15] { 245, 228, 252, 171, 242, 236, 225, 226, 224, 241, 171, 231, 233, 234, 226 }, 133)) || _0xd4a27dbb.StartsWith(_0x339c0fec._0x5bb166a0(new byte[25] { 250, 230, 230, 226, 225, 168, 189, 189, 240, 226, 245, 254, 253, 240, 243, 254, 244, 243, 228, 188, 254, 251, 228, 247, 189 }, 146), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xd0c174b6);
                OpenUrlExternally(_0xd4a27dbb);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xd4a27dbb))
            {
                _0x8368aef1(true);
                WLog(_0x339c0fec._0x5bb166a0(new byte[41] { 100, 76, 76, 68, 79, 70, 3, 66, 86, 87, 75, 3, 69, 79, 76, 84, 3, 71, 70, 87, 70, 64, 87, 70, 71, 3, 14, 29, 3, 72, 70, 70, 83, 3, 85, 74, 80, 74, 65, 79, 70 }, 35));
                return;
            }

            _0xb1f7b87d = true;
            _0x8368aef1(true);
            WLog(_0x339c0fec._0x5bb166a0(new byte[43] { 171, 153, 158, 170, 149, 153, 139, 220, 144, 147, 157, 152, 149, 146, 155, 211, 142, 153, 152, 149, 142, 153, 159, 136, 149, 146, 155, 220, 209, 194, 220, 151, 153, 153, 140, 220, 138, 149, 143, 149, 158, 144, 153 }, 252));
        };
        _0x6036a69b.OnPageCommitted += (_0xd0c174b6, _0xd4a27dbb) =>
        {
            if (_0xae6c54fa && IsAboutBlank(_0xd4a27dbb))
                return;
            WLog(_0x339c0fec._0x5bb166a0(new byte[31] { 150, 186, 178, 181, 251, 140, 190, 185, 141, 178, 190, 172, 251, 148, 181, 139, 186, 188, 190, 152, 180, 182, 182, 178, 175, 175, 190, 191, 225, 251, 240 }, 219) + (Time.realtimeSinceStartup - _0xb0df8ebd).ToString(_0x339c0fec._0x5bb166a0(new byte[5] { 239, 241, 239, 239, 239 }, 223)) + _0x339c0fec._0x5bb166a0(new byte[2] { 226, 177 }, 145) + _0xd4a27dbb);
            if (!firstLoadShown && IsHttpUrl(_0xd4a27dbb))
            {
                firstLoadShown = true;
                _0xb1f7b87d = false;
                _0x8368aef1(false);
                _0x2b783e2e();
                _0x67bf5d2d();
                _0xd0c174b6.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x032ffccf(_0x339c0fec._0x5bb166a0(new byte[9] { 34, 35, 10, 58, 37, 48, 59, 48, 49 }, 85));
                WLog(_0x339c0fec._0x5bb166a0(new byte[39] { 100, 72, 64, 71, 9, 126, 76, 75, 127, 64, 76, 94, 9, 90, 65, 70, 94, 71, 9, 70, 71, 9, 74, 70, 68, 68, 64, 93, 93, 76, 77, 9, 74, 70, 71, 93, 76, 71, 93 }, 41));
            }
        };
        _0x6036a69b.OnPageProgressChanged += (_0xd0c174b6, _0x07555445) =>
        {
            if (_0xae6c54fa)
                return;
            if (!firstLoadShown && _0x07555445 >= 0.65f)
            {
                firstLoadShown = true;
                _0xb1f7b87d = false;
                _0x8368aef1(false);
                _0x2b783e2e();
                _0x67bf5d2d();
                _0xd0c174b6.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x032ffccf(_0x339c0fec._0x5bb166a0(new byte[9] { 12, 13, 36, 20, 11, 30, 21, 30, 31 }, 123));
                WLog(_0x339c0fec._0x5bb166a0(new byte[32] { 240, 220, 212, 211, 157, 234, 216, 223, 235, 212, 216, 202, 157, 206, 213, 210, 202, 211, 157, 223, 196, 157, 205, 207, 210, 218, 207, 216, 206, 206, 135, 157 }, 189) + _0x07555445);
            }
        };
        _0x6036a69b.OnPageFinished += (_0xd0c174b6, _0x73287ef8, _0xd4a27dbb) =>
        {
            if (_0xae6c54fa && IsAboutBlank(_0xd4a27dbb))
            {
                _0xae6c54fa = false;
                WLog(_0x339c0fec._0x5bb166a0(new byte[28] { 113, 83, 68, 86, 64, 83, 76, 1, 64, 67, 78, 84, 85, 27, 67, 77, 64, 79, 74, 1, 71, 72, 79, 72, 82, 73, 68, 69 }, 33));
                return;
            }

            WLog(_0x339c0fec._0x5bb166a0(new byte[24] { 185, 149, 157, 154, 212, 163, 145, 150, 162, 157, 145, 131, 212, 178, 157, 154, 157, 135, 156, 145, 144, 206, 212, 223 }, 244) + (Time.realtimeSinceStartup - _0xb0df8ebd).ToString(_0x339c0fec._0x5bb166a0(new byte[5] { 250, 228, 250, 250, 250 }, 202)) + _0x339c0fec._0x5bb166a0(new byte[7] { 205, 158, 221, 209, 218, 219, 131 }, 190) + _0x73287ef8 + _0x339c0fec._0x5bb166a0(new byte[5] { 178, 231, 224, 254, 175 }, 146) + _0xd4a27dbb);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xb1f7b87d = false;
                _0x8368aef1(false);
                _0x2b783e2e();
                _0x67bf5d2d();
                _0xd0c174b6.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x032ffccf(_0x339c0fec._0x5bb166a0(new byte[9] { 66, 67, 106, 90, 69, 80, 91, 80, 81 }, 53));
                WLog(_0x339c0fec._0x5bb166a0(new byte[33] { 6, 42, 34, 37, 107, 28, 46, 41, 29, 34, 46, 60, 107, 45, 34, 57, 56, 63, 107, 39, 36, 42, 47, 107, 40, 36, 38, 59, 39, 46, 63, 46, 47 }, 75));
            }
            else if (_0xb1f7b87d)
            {
                _0xb1f7b87d = false;
                _0x8368aef1(false);
                _0xd0c174b6.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x339c0fec._0x5bb166a0(new byte[40] { 181, 153, 145, 150, 216, 175, 157, 154, 174, 145, 157, 143, 216, 171, 144, 151, 143, 216, 153, 158, 140, 157, 138, 216, 148, 151, 153, 156, 145, 150, 159, 216, 158, 145, 150, 145, 139, 144, 157, 156 }, 248));
            }
            else
            {
                _0x8368aef1(false);
            }

            if (_0xb766c454 && !IsGoogleAuthFlowUrl(_0xd4a27dbb) && !IsGoogleAuthFlowUrl(_0xd4a27dbb))
            {
                WLog(_0x339c0fec._0x5bb166a0(new byte[48] { 227, 203, 203, 195, 200, 193, 132, 197, 209, 208, 204, 132, 215, 193, 193, 201, 215, 132, 194, 205, 202, 205, 215, 204, 193, 192, 132, 137, 154, 132, 214, 193, 215, 208, 203, 214, 193, 132, 192, 193, 194, 197, 209, 200, 208, 132, 241, 229 }, 164));
                _0xb766c454 = false;
                _0x9620eb46.SetUserAgent("");
            }
        };
        _0x6036a69b.OnShouldClose += _0xd0c174b6 =>
        {
            WLog(_0x339c0fec._0x5bb166a0(new byte[41] { 148, 155, 170, 188, 187, 146, 239, 130, 174, 166, 161, 239, 152, 170, 173, 153, 166, 170, 184, 239, 128, 161, 156, 167, 160, 186, 163, 171, 140, 163, 160, 188, 170, 239, 166, 161, 185, 160, 164, 170, 171 }, 207));
            _0x983b0ed6();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x6036a69b.SetPopupPageEventEnabled(true);
        bool _0x30871785 = false;
        bool _0x9f94f489 = false;
        _0x6036a69b.OnMultipleWindowOpened += (_0xd0c174b6, _0x323ee6b8) =>
        {
            _0xd0c174b6.ScrollTo(0, 0, false);
            WLog(_0x339c0fec._0x5bb166a0(new byte[43] { 155, 148, 165, 179, 180, 157, 224, 141, 161, 169, 174, 224, 151, 165, 162, 150, 169, 165, 183, 224, 141, 181, 172, 180, 169, 176, 172, 165, 151, 169, 174, 164, 175, 183, 224, 143, 176, 165, 174, 165, 164, 250, 224 }, 192) + _0x323ee6b8);
            var _0xb686936c = _0x6036a69b.GetPopupWindow(_0x323ee6b8);
            if (_0xb686936c == null)
                return;
            _0xf33d6a44.Add(_0xb686936c);
            Debug.Log($"[Test] Popup ID: {_0xb686936c.Id}");
            _0xb686936c.OnPageStarted += (_0x0b1b9e20, _0xd4a27dbb) =>
            {
                WLog(_0x339c0fec._0x5bb166a0(new byte[36] { 108, 99, 82, 68, 67, 106, 23, 103, 88, 71, 66, 71, 23, 96, 82, 85, 97, 94, 82, 64, 23, 120, 89, 103, 86, 80, 82, 100, 67, 86, 69, 67, 82, 83, 13, 23 }, 55) + _0xd4a27dbb);
                _0x921f1190 = 0;
                if (string.IsNullOrEmpty(_0xd4a27dbb) || IsAboutBlank(_0xd4a27dbb))
                    return;
                if (IsGoogleAuthFlowUrl(_0xd4a27dbb))
                {
                    WLog(_0x339c0fec._0x5bb166a0(new byte[57] { 27, 20, 37, 51, 52, 29, 96, 16, 47, 48, 53, 48, 96, 7, 47, 47, 39, 44, 37, 96, 33, 53, 52, 40, 96, 38, 44, 47, 55, 96, 109, 126, 96, 51, 48, 47, 47, 38, 96, 7, 47, 47, 39, 44, 37, 96, 3, 40, 50, 47, 45, 37, 96, 21, 1, 122, 96 }, 64) + _0xd4a27dbb);
                    _0x30871785 = false;
                    _0xb7e233a3();
                    if (_0x0b1b9e20 != null && _0x0b1b9e20.IsAlive)
                        _0x0b1b9e20.EvaluateJavaScript(_0x38dc0c40());
                    return;
                }

                if (_0x9620eb46 == null)
                    return;
                if (!_0x30871785)
                {
                    _0x30871785 = true;
                    _0x9620eb46.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x339c0fec._0x5bb166a0(new byte[39] { 216, 215, 230, 240, 247, 222, 163, 211, 236, 243, 246, 243, 163, 226, 243, 243, 239, 250, 163, 212, 234, 237, 231, 236, 244, 240, 163, 231, 230, 240, 232, 247, 236, 243, 163, 214, 194, 185, 163 }, 131) + _0xd4a27dbb);
                }

                if (_0x0b1b9e20 != null && _0x0b1b9e20.IsAlive)
                    _0x0b1b9e20.EvaluateJavaScript(_0xc747da4e());
                if (!_0x9f94f489 && _0x0b1b9e20 != null && _0x0b1b9e20.IsAlive && IsHttpUrl(_0xd4a27dbb))
                {
                    _0x9f94f489 = true;
                }
            };
            _0xb686936c.OnPageFinished += (_0x0b1b9e20, _0xee7d45f2) =>
            {
                string _0x5d32f155 = _0xee7d45f2 != null ? _0xee7d45f2.data : string.Empty;
                WLog(_0x339c0fec._0x5bb166a0(new byte[35] { 130, 141, 188, 170, 173, 132, 249, 137, 182, 169, 172, 169, 249, 142, 188, 187, 143, 176, 188, 174, 249, 159, 176, 183, 176, 170, 177, 188, 189, 227, 249, 172, 171, 181, 228 }, 217) + _0x5d32f155);
                if (_0x0b1b9e20 == null || !_0x0b1b9e20.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x5d32f155))
                {
                    _0xb7e233a3();
                    _0x0b1b9e20.EvaluateJavaScript(_0x38dc0c40());
                    return;
                }

                if (!_0x30871785)
                    return;
                _0x0b1b9e20.EvaluateJavaScript(_0xc747da4e());
            };
        };
        _0x6036a69b.OnMultipleWindowClosed += (_0xd0c174b6, _0x323ee6b8) =>
        {
            _0xf33d6a44.RemoveAll(_0xff35f6d7 => _0xff35f6d7 == null || _0xff35f6d7.Id == _0x323ee6b8 || !_0xff35f6d7.IsAlive);
            _0x8368aef1(false);
            if (_0xf33d6a44.Count == 0 && _0x9620eb46 != null)
            {
                _0x30871785 = false;
                _0x9f94f489 = false;
                _0xb5e2027c();
            }

            WLog(_0x339c0fec._0x5bb166a0(new byte[43] { 143, 128, 177, 167, 160, 137, 244, 153, 181, 189, 186, 244, 131, 177, 182, 130, 189, 177, 163, 244, 153, 161, 184, 160, 189, 164, 184, 177, 131, 189, 186, 176, 187, 163, 244, 151, 184, 187, 167, 177, 176, 238, 244 }, 212) + _0x323ee6b8);
        };
        _0x6036a69b.RegisterOnRequestMediaCapturePermission(_0x88fbadc2 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private string Decrypt(string _0x4d0fce8a, string _0x65662535)
    {
        try
        {
            var _0xa14b7e44 = Convert.FromBase64String(_0x4d0fce8a);
            using var _0x81820ffc = Aes.Create();
            _0x81820ffc.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x65662535));
            var _0x32d693be = new byte[16];
            Buffer.BlockCopy(_0xa14b7e44, 0, _0x32d693be, 0, 16);
            _0x81820ffc.IV = _0x32d693be;
            using var _0x67b6eac1 = new MemoryStream(_0xa14b7e44, 16, _0xa14b7e44.Length - 16);
            using var _0xae638ae1 = new CryptoStream(_0x67b6eac1, _0x81820ffc.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x3504d030 = new StreamReader(_0xae638ae1, Encoding.UTF8);
            return _0x3504d030.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal bool IsAboutBlank(string _0x27bc3aa7)
    {
        if (string.IsNullOrEmpty(_0x27bc3aa7))
            return false;
        return _0x27bc3aa7.StartsWith(_0x339c0fec._0x5bb166a0(new byte[11] { 70, 69, 72, 82, 83, 29, 69, 75, 70, 73, 76 }, 39), StringComparison.OrdinalIgnoreCase);
    }

    private void OnApplicationFocus(bool _0x97965916)
    {
        isApplicationFocus = _0x97965916;
        if (_0x97965916 && _0x2061dc30)
        {
            _0x28c33063();
        }
    }

    public void _0x0abf0ad2()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[18] { 78, 65, 112, 102, 97, 72, 53, 89, 116, 96, 123, 118, 125, 53, 82, 116, 120, 112 }, 21));
#endif
        }

        _0x96c5878b.Instance?._0x08a08079();
        _0x0b32188d.Instance._0x1d843820(_0x1d80aee2._0xb61edb9b.DEFAULT);
    }

    private string _0x0fef61ea = "";
    private void _0xf26effb6(string _0x3800c5f7)
    {
        Dictionary<string, object> _0x8fe03f8f;
        try
        {
            _0x8fe03f8f = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x3800c5f7);
        }
        catch
        {
            return;
        }

        var _0x57844949 = ReadPushField(_0x8fe03f8f, _0x339c0fec._0x5bb166a0(new byte[3] { 68, 67, 93 }, 49));
        if (string.IsNullOrWhiteSpace(_0x57844949))
            return;
        _0x57844949 = _0x57844949.Trim();
        if (!IsHttpUrl(_0x57844949))
            return;
        if (string.Equals(_0x57844949, _0x4154cfd1, StringComparison.Ordinal))
            return;
        _0x4154cfd1 = _0x57844949;
        OpenUrlExternally(_0x57844949);
    }

    private string _0x07d6c554 = "";
    private Canvas _0xbdacaabf;
    private string _0xccb21664 { get; set; }

    private Canvas _0xeb12bcd6()
    {
        if (_0xbdacaabf != null)
            return _0xbdacaabf;
        var _0xf0fbf775 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xf0fbf775 == null)
        {
            var _0xd4d6c1a4 = new GameObject(_0x339c0fec._0x5bb166a0(new byte[6] { 215, 245, 250, 226, 245, 231 }, 148), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xf0fbf775 = _0xd4d6c1a4.GetComponent<Canvas>();
            _0xf0fbf775.transform.SetParent(transform, false);
            _0xf0fbf775.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xbdacaabf = _0xf0fbf775;
        return _0xbdacaabf;
    }

    private IEnumerator _0x6f7954fa(string _0x218e0dc7)
    {
        if (Permission.HasUserAuthorizedPermission(_0x218e0dc7))
            yield break;
        bool _0x159689ac = false;
        var _0xf73f270d = new PermissionCallbacks();
        _0xf73f270d.PermissionGranted += _0xd686e5ad => _0x159689ac = true;
        _0xf73f270d.PermissionDenied += _0xd686e5ad => _0x159689ac = true;
        Permission.RequestUserPermission(_0x218e0dc7, _0xf73f270d);
        yield return new WaitUntil(() => _0x159689ac);
    }

    private void StopCurrentFailedLoad(UniWebView _0x58083a03)
    {
        _0x8368aef1(false);
        if (_0x58083a03 == null)
            return;
        _0x58083a03.Stop();
        if (_0x58083a03.CanGoBack)
            _0x58083a03.GoBack();
    }

    private string _0xc4a227d6 = "";
    private string _0x22178190 = "";
    private string _0xb2e76a7d = "";
    internal Vector2 lastSize = Vector2.zero;
    private static readonly string WindowsDesktopUserAgent = _0x339c0fec._0x5bb166a0(new byte[111] { 20, 54, 35, 48, 53, 53, 56, 118, 108, 119, 105, 121, 113, 14, 48, 55, 61, 54, 46, 42, 121, 23, 13, 121, 104, 105, 119, 105, 98, 121, 14, 48, 55, 111, 109, 98, 121, 33, 111, 109, 112, 121, 24, 41, 41, 53, 60, 14, 60, 59, 18, 48, 45, 118, 108, 106, 110, 119, 106, 111, 121, 113, 18, 17, 13, 20, 21, 117, 121, 53, 48, 50, 60, 121, 30, 60, 58, 50, 54, 112, 121, 26, 49, 43, 54, 52, 60, 118, 104, 107, 105, 119, 105, 119, 105, 119, 105, 121, 10, 56, 63, 56, 43, 48, 118, 108, 106, 110, 119, 106, 111 }, 89);
    private Action _0x1ba1a954;
    private void _0x4b577a04()
    {
        {
#if B_LOGS
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[22] { 28, 19, 34, 52, 51, 26, 103, 20, 51, 40, 53, 34, 3, 34, 49, 46, 36, 34, 14, 41, 33, 40 }, 71));
#endif
        }

        _0x28ecd9f9 = SystemInfo.deviceModel;
        _0x07d6c554 = Application.version;
        _0x80e30291 = Application.installMode;
        _0x476dd3b5 = Application.installerName;
        _0xc4a227d6 = Application.identifier;
        _0xba0b1bf4 = _0x14256a71();
        _0x899d8f9c = _0xde23239d();
        _0x65518d6e = SystemInfo.deviceUniqueIdentifier;
        _0xc5efbc01 = SystemInfo.graphicsDeviceName;
        _0x22178190 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x07d6c554 = _0x339c0fec._0x5bb166a0(new byte[5] { 177, 168, 177, 168, 177 }, 134);
                _0x80e30291 = ApplicationInstallMode.Store;
                _0x476dd3b5 = _0x339c0fec._0x5bb166a0(new byte[19] { 164, 168, 170, 233, 166, 169, 163, 181, 168, 174, 163, 233, 177, 162, 169, 163, 174, 169, 160 }, 199);
                _0x899d8f9c = _0x339c0fec._0x5bb166a0(new byte[8] { 252, 244, 233, 237, 224, 185, 236, 248 }, 153);
                _0x65518d6e = Guid.NewGuid().ToString().Replace(_0x339c0fec._0x5bb166a0(new byte[1] { 107 }, 70), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[17] { 209, 222, 239, 249, 254, 215, 170, 238, 239, 252, 199, 229, 238, 239, 230, 176, 170 }, 138) + _0x28ecd9f9);
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[19] { 129, 142, 191, 169, 174, 135, 250, 187, 170, 170, 140, 191, 168, 169, 179, 181, 180, 224, 250 }, 218) + _0x07d6c554);
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[20] { 67, 76, 125, 107, 108, 69, 56, 113, 118, 107, 108, 121, 116, 116, 85, 119, 124, 125, 34, 56 }, 24) + _0x80e30291);
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[23] { 21, 26, 43, 61, 58, 19, 110, 39, 32, 61, 58, 47, 34, 34, 43, 60, 29, 58, 33, 60, 43, 116, 110 }, 78) + _0x476dd3b5);
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[14] { 160, 175, 158, 136, 143, 166, 219, 154, 139, 139, 178, 159, 193, 219 }, 251) + _0xc4a227d6);
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[14] { 251, 244, 197, 211, 212, 253, 128, 193, 196, 214, 233, 196, 154, 128 }, 160) + _0xba0b1bf4);
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[18] { 79, 64, 113, 103, 96, 73, 52, 97, 103, 113, 102, 85, 115, 113, 122, 96, 46, 52 }, 20) + _0x899d8f9c);
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[17] { 45, 34, 19, 5, 2, 43, 86, 5, 15, 5, 50, 19, 0, 63, 18, 76, 86 }, 118) + _0x65518d6e);
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[12] { 237, 226, 211, 197, 194, 235, 150, 209, 198, 195, 140, 150 }, 182) + _0xc5efbc01);
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[12] { 217, 214, 231, 241, 246, 223, 162, 225, 242, 247, 184, 162 }, 130) + _0x22178190);
#endif
        }
    }

    private IEnumerator _0xffe762ae(string _0xe0f4fa64)
    {
        if (_0x9620eb46 != null && _0x2061dc30)
            yield break;
        _0x9620eb46 = gameObject.AddComponent<UniWebView>();
        _0xd33456d3(_0x9620eb46);
        _0x3dac08f4(_0x9620eb46);
        _0x9620eb46.BackgroundColor = Color.clear;
        var _0x50abea6b = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x67bf5d2d();
        yield return new WaitForEndOfFrame();
        _0x2061dc30 = true;
        _0x74f0133e();
        _0x8368aef1(true);
        _0xae6c54fa = false;
        _0xb766c454 = false;
        _0xf33d6a44.Clear();
        _0x7bd60033 = -1;
        firstLoadShown = false;
        _0xb1f7b87d = false;
        _0x112bdda1 = false;
        _0x9620eb46.SetUserAgent("");
        _0xb0df8ebd = Time.realtimeSinceStartup;
        _0x9620eb46.Stop();
        _0x9620eb46.Load(_0xe0f4fa64);
        _0x9620eb46.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x339c0fec._0x5bb166a0(new byte[25] { 92, 112, 120, 127, 49, 70, 116, 115, 71, 120, 116, 102, 49, 88, 127, 120, 101, 120, 112, 125, 49, 66, 121, 126, 102 }, 17));
    }

    private UniWebViewPopup _0x85eb7c97()
    {
        for (int _0xebf3cca9 = _0xf33d6a44.Count - 1; _0xebf3cca9 >= 0; _0xebf3cca9--)
        {
            var _0x4d504a82 = _0xf33d6a44[_0xebf3cca9];
            if (_0x4d504a82 != null && _0x4d504a82.IsAlive)
                return _0x4d504a82;
            _0xf33d6a44.RemoveAt(_0xebf3cca9);
        }

        return null;
    }

    private string _0x84bf1ebc = "";
    private string _0x38dc0c40()
    {
        string _0xc593e6dd = _0x0d40ff50();
        if (string.IsNullOrEmpty(_0xc593e6dd))
            return _0x339c0fec._0x5bb166a0(new byte[7] { 227, 250, 252, 241, 181, 165, 174 }, 149);
        string _0xbd7019b7 = _0xc593e6dd.Replace(_0x339c0fec._0x5bb166a0(new byte[1] { 156 }, 192), _0x339c0fec._0x5bb166a0(new byte[2] { 150, 150 }, 202)).Replace(_0x339c0fec._0x5bb166a0(new byte[1] { 221 }, 250), _0x339c0fec._0x5bb166a0(new byte[2] { 136, 243 }, 212));
        var _0x33b80b12 = Regex.Match(_0xc593e6dd, _0x339c0fec._0x5bb166a0(new byte[12] { 15, 36, 62, 35, 33, 41, 99, 100, 16, 40, 103, 101 }, 76));
        string _0x0683ed95 = _0x33b80b12.Success ? _0x33b80b12.Groups[1].Value : _0x339c0fec._0x5bb166a0(new byte[3] { 117, 118, 116 }, 68);
        return _0x339c0fec._0x5bb166a0(new byte[12] { 236, 162, 177, 170, 167, 176, 173, 171, 170, 236, 237, 191 }, 196) + _0x339c0fec._0x5bb166a0(new byte[8] { 45, 58, 41, 123, 46, 58, 102, 124 }, 91) + _0xbd7019b7 + _0x339c0fec._0x5bb166a0(new byte[2] { 197, 217 }, 226) + _0x339c0fec._0x5bb166a0(new byte[30] { 12, 27, 8, 90, 10, 8, 21, 14, 21, 71, 52, 27, 12, 19, 29, 27, 14, 21, 8, 84, 10, 8, 21, 14, 21, 14, 3, 10, 31, 65 }, 122) + _0x339c0fec._0x5bb166a0(new byte[121] { 101, 118, 109, 96, 119, 106, 108, 109, 35, 103, 102, 101, 43, 108, 97, 105, 47, 104, 102, 122, 47, 117, 98, 111, 42, 120, 119, 113, 122, 120, 76, 97, 105, 102, 96, 119, 45, 103, 102, 101, 106, 109, 102, 83, 113, 108, 115, 102, 113, 119, 122, 43, 108, 97, 105, 47, 104, 102, 122, 47, 120, 100, 102, 119, 57, 101, 118, 109, 96, 119, 106, 108, 109, 43, 42, 120, 113, 102, 119, 118, 113, 109, 35, 117, 98, 111, 56, 126, 47, 96, 108, 109, 101, 106, 100, 118, 113, 98, 97, 111, 102, 57, 119, 113, 118, 102, 126, 42, 56, 126, 96, 98, 119, 96, 107, 43, 102, 42, 120, 126, 126 }, 3) + _0x339c0fec._0x5bb166a0(new byte[26] { 104, 105, 106, 36, 124, 126, 99, 120, 99, 32, 43, 121, 127, 105, 126, 77, 107, 105, 98, 120, 43, 32, 121, 109, 37, 55 }, 12) + _0x339c0fec._0x5bb166a0(new byte[52] { 14, 15, 12, 66, 26, 24, 5, 30, 5, 70, 77, 11, 26, 26, 60, 15, 24, 25, 3, 5, 4, 77, 70, 31, 11, 68, 24, 15, 26, 6, 11, 9, 15, 66, 69, 52, 39, 5, 16, 3, 6, 6, 11, 54, 69, 69, 70, 77, 77, 67, 67, 81 }, 106) + _0x339c0fec._0x5bb166a0(new byte[37] { 37, 36, 39, 105, 49, 51, 46, 53, 46, 109, 102, 49, 45, 32, 53, 39, 46, 51, 44, 102, 109, 102, 13, 40, 47, 52, 57, 97, 32, 51, 44, 55, 121, 45, 102, 104, 122 }, 65) + _0x339c0fec._0x5bb166a0(new byte[34] { 147, 146, 145, 223, 135, 133, 152, 131, 152, 219, 208, 129, 146, 153, 147, 152, 133, 208, 219, 208, 176, 152, 152, 144, 155, 146, 215, 190, 153, 148, 217, 208, 222, 204 }, 247) + _0x339c0fec._0x5bb166a0(new byte[30] { 130, 131, 128, 206, 150, 148, 137, 146, 137, 202, 193, 139, 135, 158, 178, 137, 147, 133, 142, 182, 137, 143, 136, 146, 149, 193, 202, 211, 207, 221 }, 230) + _0x339c0fec._0x5bb166a0(new byte[48] { 16, 22, 29, 31, 18, 5, 22, 68, 17, 5, 0, 89, 31, 6, 22, 5, 10, 0, 23, 94, 63, 31, 6, 22, 5, 10, 0, 94, 67, 39, 12, 22, 11, 9, 13, 17, 9, 67, 72, 18, 1, 22, 23, 13, 11, 10, 94, 67 }, 100) + _0x0683ed95 + _0x339c0fec._0x5bb166a0(new byte[35] { 254, 164, 245, 162, 187, 171, 184, 183, 189, 227, 254, 158, 182, 182, 190, 181, 188, 249, 154, 177, 171, 182, 180, 188, 254, 245, 175, 188, 171, 170, 176, 182, 183, 227, 254 }, 217) + _0x0683ed95 + _0x339c0fec._0x5bb166a0(new byte[238] { 73, 19, 66, 21, 12, 28, 15, 0, 10, 84, 73, 32, 1, 26, 83, 47, 81, 44, 28, 15, 0, 10, 73, 66, 24, 11, 28, 29, 7, 1, 0, 84, 73, 92, 90, 73, 19, 51, 66, 3, 1, 12, 7, 2, 11, 84, 26, 28, 27, 11, 66, 30, 2, 15, 26, 8, 1, 28, 3, 84, 73, 47, 0, 10, 28, 1, 7, 10, 73, 66, 9, 11, 26, 38, 7, 9, 6, 43, 0, 26, 28, 1, 30, 23, 56, 15, 2, 27, 11, 29, 84, 8, 27, 0, 13, 26, 7, 1, 0, 70, 71, 21, 28, 11, 26, 27, 28, 0, 78, 62, 28, 1, 3, 7, 29, 11, 64, 28, 11, 29, 1, 2, 24, 11, 70, 21, 15, 28, 13, 6, 7, 26, 11, 13, 26, 27, 28, 11, 84, 73, 15, 28, 3, 73, 66, 12, 7, 26, 0, 11, 29, 29, 84, 73, 88, 90, 73, 66, 3, 1, 12, 7, 2, 11, 84, 26, 28, 27, 11, 66, 3, 1, 10, 11, 2, 84, 73, 73, 66, 30, 2, 15, 26, 8, 1, 28, 3, 84, 73, 47, 0, 10, 28, 1, 7, 10, 73, 66, 30, 2, 15, 26, 8, 1, 28, 3, 56, 11, 28, 29, 7, 1, 0, 84, 73, 95, 90, 64, 94, 64, 94, 73, 66, 27, 15, 40, 27, 2, 2, 56, 11, 28, 29, 7, 1, 0, 84, 73 }, 110) + _0x0683ed95 + _0x339c0fec._0x5bb166a0(new byte[117] { 42, 52, 42, 52, 42, 52, 35, 121, 45, 63, 121, 121, 63, 75, 102, 110, 97, 103, 112, 42, 96, 97, 98, 109, 106, 97, 84, 118, 107, 116, 97, 118, 112, 125, 44, 116, 118, 107, 112, 107, 40, 35, 113, 119, 97, 118, 69, 99, 97, 106, 112, 64, 101, 112, 101, 35, 40, 127, 99, 97, 112, 62, 98, 113, 106, 103, 112, 109, 107, 106, 44, 45, 127, 118, 97, 112, 113, 118, 106, 36, 113, 101, 96, 63, 121, 40, 103, 107, 106, 98, 109, 99, 113, 118, 101, 102, 104, 97, 62, 112, 118, 113, 97, 121, 45, 63, 121, 103, 101, 112, 103, 108, 44, 97, 45, 127, 121 }, 4) + _0x339c0fec._0x5bb166a0(new byte[5] { 88, 12, 13, 12, 30 }, 37);
    }

    private void Awake()
    {
        if (_0x25d86ebb != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x25d86ebb = gameObject.GetComponent<_0xe27b2536>();
        DontDestroyOnLoad(gameObject);
        _0x0fef61ea = _0x6e0656ed = _0xccb21664 = "";
        _0x84bf1ebc = "";
        _0x2061dc30 = false;
    }

    private bool _0x9594de1b = false;
    private async void Start()
    {
        await _0x51f88b48();
    }

    internal bool ContainsIgnoreCase(string _0xbaaecc8c, string _0x76c35ee6)
    {
        if (string.IsNullOrEmpty(_0xbaaecc8c) || string.IsNullOrEmpty(_0x76c35ee6))
            return false;
        return _0xbaaecc8c.IndexOf(_0x76c35ee6, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    // WS_SOURCE MONO
    public static _0xe27b2536 _0x25d86ebb { get; private set; }

    private string _0xc5efbc01 = "";
    public void _0x272db0dc()
    {
        if (_0x2061dc30)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[33] { 22, 25, 40, 62, 57, 16, 109, 25, 36, 32, 40, 63, 109, 34, 56, 57, 109, 96, 115, 109, 32, 34, 59, 40, 109, 57, 34, 109, 62, 46, 40, 35, 40 }, 77));
            }
#endif
        }

        _0x0abf0ad2();
    }

    private void _0x74f0133e()
    {
        if (_0x7720ce94 != null)
            return;
        var _0xc7dc9e4d = _0xeb12bcd6();
        _0x7720ce94 = new GameObject(_0x339c0fec._0x5bb166a0(new byte[14] { 253, 207, 200, 252, 195, 207, 221, 249, 218, 195, 196, 196, 207, 216 }, 170), typeof(RectTransform), typeof(Text));
        _0xe4a22691 = _0x7720ce94.GetComponent<RectTransform>();
        _0xe4a22691.SetParent(_0xc7dc9e4d.transform, false);
        _0xe4a22691.anchorMin = new Vector2(0.5f, 0.5f);
        _0xe4a22691.anchorMax = new Vector2(0.5f, 0.5f);
        _0xe4a22691.pivot = new Vector2(0.5f, 0.5f);
        _0xe4a22691.sizeDelta = new Vector2(600f, 600f);
        _0xe4a22691.anchoredPosition = Vector2.zero;
        _0x26db4e48 = _0x7720ce94.GetComponent<Text>();
        _0x26db4e48.text = _0x339c0fec._0x5bb166a0(new byte[1] { 95 }, 112);
        _0x26db4e48.font = Resources.GetBuiltinResource<Font>(_0x339c0fec._0x5bb166a0(new byte[17] { 173, 132, 134, 128, 130, 152, 179, 148, 143, 149, 136, 140, 132, 207, 149, 149, 135 }, 225));
        _0x26db4e48.fontSize = 200;
        _0x26db4e48.alignment = TextAnchor.MiddleCenter;
        _0x26db4e48.color = Color.white;
        _0x26db4e48.raycastTarget = false;
        _0x7720ce94.SetActive(false);
    }

    private bool _0xb1f7b87d = false;
    private void WLog(string _0xdfd4016b)
    {
#if B_LOGS
        {
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[7] { 12, 3, 50, 36, 35, 10, 119 }, 87) + _0xdfd4016b);
        }
#endif
    }

    private void _0xd11f11b4(string _0x775271e2)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[34] { 136, 135, 182, 160, 167, 142, 243, 149, 182, 167, 176, 187, 243, 150, 171, 167, 161, 178, 243, 131, 166, 160, 187, 243, 151, 178, 167, 178, 243, 129, 178, 164, 233, 243 }, 211) + _0x775271e2);
#endif
            }
        }

        var _0xfebee601 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x775271e2);
        StartCoroutine(_0x8eee589d(_0xfebee601));
    }

    private string _0xb6248f5a(string _0x76642753, string _0x5c6cc0f4)
    {
        if (string.IsNullOrEmpty(_0x5c6cc0f4))
            return _0x76642753;
        if (_0x76642753.Contains(_0x339c0fec._0x5bb166a0(new byte[1] { 31 }, 32)))
            return _0x76642753 + _0x339c0fec._0x5bb166a0(new byte[8] { 2, 87, 65, 74, 64, 77, 64, 25 }, 36) + UnityWebRequest.EscapeURL(_0x5c6cc0f4);
        else
            return _0x76642753 + _0x339c0fec._0x5bb166a0(new byte[8] { 247, 187, 173, 166, 172, 161, 172, 245 }, 200) + UnityWebRequest.EscapeURL(_0x5c6cc0f4);
    }

    private string _0xd906b057 = "";
    private string _0x8cdd5489 = "";
    private string _0xa4af0607 = "";
    internal bool IsGoogleAuthFlowUrl(string _0x6be7d5ef)
    {
        if (string.IsNullOrEmpty(_0x6be7d5ef))
            return false;
        return _0x6be7d5ef.IndexOf(_0x339c0fec._0x5bb166a0(new byte[19] { 170, 168, 168, 164, 190, 165, 191, 184, 229, 172, 164, 164, 172, 167, 174, 229, 168, 164, 166 }, 203), StringComparison.OrdinalIgnoreCase) >= 0 || _0x6be7d5ef.IndexOf(_0x339c0fec._0x5bb166a0(new byte[16] { 57, 59, 59, 55, 45, 54, 44, 43, 118, 63, 55, 55, 63, 52, 61, 118 }, 88), StringComparison.OrdinalIgnoreCase) >= 0 || _0x6be7d5ef.IndexOf(_0x339c0fec._0x5bb166a0(new byte[21] { 164, 172, 172, 164, 175, 166, 182, 176, 166, 177, 160, 172, 173, 183, 166, 173, 183, 237, 160, 172, 174 }, 195), StringComparison.OrdinalIgnoreCase) >= 0 || _0x6be7d5ef.IndexOf(_0x339c0fec._0x5bb166a0(new byte[11] { 247, 227, 228, 241, 228, 249, 243, 190, 243, 255, 253 }, 144), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x28ecd9f9 = "";
    private bool _0x6522221f()
    {
        if (_0x7245e555())
            return true;
        if (_0x9620eb46 != null && _0x9620eb46.CanGoBack)
        {
            WLog(_0x339c0fec._0x5bb166a0(new byte[36] { 27, 50, 33, 55, 36, 50, 33, 54, 115, 49, 50, 48, 56, 115, 126, 109, 115, 62, 50, 58, 61, 115, 4, 54, 49, 5, 58, 54, 36, 115, 20, 60, 17, 50, 48, 56 }, 83));
            _0x9620eb46.GoBack();
            return true;
        }

        return false;
    }

    private async Task<string> _0x1d899328(int _0x1376e306 = 5, int _0x501f9600 = 500)
    {
        try
        {
            List<EntityData> _0x3bd987cd = new List<EntityData>();
            int _0x441fcdca = 0;
            do
            {
                _0x3bd987cd = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x339c0fec._0x5bb166a0(new byte[8] { 22, 10, 7, 31, 3, 20, 47, 2 }, 102), _0xf2712e3c, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xf2712e3c }), new QueryOptions())).ToList();
                await Task.Delay(_0x501f9600);
            }
            while (_0x3bd987cd.Count == 0 && _0x441fcdca++ < _0x1376e306);
            {
#if B_LOGS
                {
                    Debug.Log(_0x339c0fec._0x5bb166a0(new byte[33] { 195, 204, 253, 235, 236, 197, 184, 203, 249, 238, 253, 252, 184, 212, 241, 246, 243, 184, 201, 237, 253, 234, 225, 184, 234, 253, 235, 237, 244, 236, 235, 162, 184 }, 152) + JsonConvert.SerializeObject(_0x3bd987cd, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x339c0fec._0x5bb166a0(new byte[39] { 216, 215, 230, 240, 247, 222, 163, 208, 226, 245, 230, 231, 163, 207, 234, 237, 232, 163, 210, 246, 230, 241, 250, 163, 241, 230, 240, 246, 239, 247, 240, 163, 224, 236, 246, 237, 247, 185, 163 }, 131) + _0x3bd987cd.Count);
                }
#endif
            }

            var _0x370de317 = _0x3bd987cd.SelectMany(_0x3f493835 => _0x3f493835.Data).FirstOrDefault(_0x72f7f294 => _0x72f7f294.Key == _0xf2712e3c)?.Value.GetAs<string>() ?? string.Empty;
            _0x370de317 = Decrypt(_0x370de317, _0xf2712e3c);
            {
#if B_LOGS
                {
                    Debug.Log(_0x339c0fec._0x5bb166a0(new byte[24] { 162, 173, 156, 138, 141, 164, 217, 181, 150, 152, 157, 217, 138, 152, 143, 156, 157, 217, 149, 144, 151, 146, 195, 217 }, 249) + _0x370de317);
                }
#endif
            }

            return _0x370de317;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x339c0fec._0x5bb166a0(new byte[39] { 24, 23, 38, 48, 55, 30, 99, 4, 38, 55, 99, 44, 49, 99, 51, 34, 49, 48, 38, 99, 48, 34, 53, 38, 39, 99, 47, 42, 45, 40, 99, 37, 34, 42, 47, 38, 39, 121, 99 }, 67) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    internal bool isApplicationFocus = false;
    private IEnumerator _0x8eee589d(Dictionary<string, object> _0x87c45cdb)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[30] { 95, 80, 97, 119, 112, 89, 36, 66, 97, 112, 103, 108, 36, 65, 124, 112, 118, 101, 36, 84, 113, 119, 108, 36, 64, 101, 112, 101, 62, 36 }, 4) + string.Join(_0x339c0fec._0x5bb166a0(new byte[1] { 54 }, 63), _0x87c45cdb));
#endif
            }
        }

        string _0xfaa55fcc = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x87c45cdb != null && _0x87c45cdb.TryGetValue(_0x339c0fec._0x5bb166a0(new byte[16] { 13, 12, 23, 10, 5, 10, 0, 2, 23, 10, 12, 13, 39, 2, 23, 2 }, 99), out var raw))
        {
            try
            {
                var _0xd9eef802 = raw?.ToString();
                var _0xba0ee799 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xd9eef802);
                if (_0xba0ee799 != null && _0xba0ee799.TryGetValue(_0x339c0fec._0x5bb166a0(new byte[6] { 98, 116, 127, 117, 120, 117 }, 17), out var val))
                {
                    _0xfaa55fcc = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x339c0fec._0x5bb166a0(new byte[30] { 131, 140, 189, 171, 172, 248, 136, 173, 171, 176, 133, 248, 146, 139, 151, 150, 248, 168, 185, 170, 171, 189, 248, 189, 170, 170, 183, 170, 226, 248 }, 216) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xfaa55fcc) && _0x87c45cdb != null && _0x87c45cdb.TryGetValue(_0x339c0fec._0x5bb166a0(new byte[6] { 126, 104, 99, 105, 100, 105 }, 13), out var lab))
        {
            _0xfaa55fcc = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[38] { 185, 182, 135, 145, 150, 194, 178, 151, 145, 138, 191, 194, 164, 135, 150, 129, 138, 135, 134, 194, 145, 135, 140, 134, 139, 134, 194, 132, 144, 141, 143, 194, 136, 145, 141, 140, 216, 194 }, 226) + _0xfaa55fcc);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xfaa55fcc))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[38] { 224, 239, 222, 200, 207, 155, 235, 206, 200, 211, 230, 155, 236, 218, 210, 207, 155, 207, 212, 155, 212, 203, 222, 213, 155, 204, 210, 207, 211, 155, 200, 222, 213, 223, 210, 223, 129, 155 }, 187) + _0xfaa55fcc);
            }
#endif
        }

        _0xceb4b91b = _0xfaa55fcc;
        yield return new WaitUntil(() => _0x2061dc30);
        var _0x7039d27c = _0x1d899328(2, 100);
        yield return new WaitUntil(() => _0x7039d27c.IsCompleted);
        string _0x9a7c5463 = _0x7039d27c.Result;
        if (!string.IsNullOrEmpty(_0x9a7c5463))
        {
            string _0xbb95568a = _0xb6248f5a(_0x9a7c5463, _0xfaa55fcc);
            {
#if B_LOGS
                Debug.Log(_0x339c0fec._0x5bb166a0(new byte[33] { 243, 252, 205, 219, 220, 136, 248, 221, 219, 192, 245, 136, 250, 205, 196, 199, 201, 204, 136, 255, 205, 202, 254, 193, 205, 223, 136, 223, 193, 220, 192, 146, 136 }, 168) + _0xbb95568a);
#endif
            }

            _0x9620eb46.Load(_0xbb95568a);
        }
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x52d0aa63()
    {
        var _0xe8cf184f = _0x339c0fec._0x5bb166a0(new byte[40] { 68, 88, 88, 92, 95, 22, 3, 3, 91, 91, 91, 2, 79, 64, 67, 89, 72, 74, 64, 77, 94, 73, 2, 79, 67, 65, 3, 79, 72, 66, 1, 79, 75, 69, 3, 88, 94, 77, 79, 73 }, 44);
        using (UnityWebRequest _0xd7515719 = UnityWebRequest.Get(_0xe8cf184f))
        {
            await _0xd7515719.SendWebRequest();
            string[] _0x42e1b38e = _0xd7515719.downloadHandler.text.Split('\n');
            foreach (string _0x0a51420a in _0x42e1b38e)
            {
                if (_0x0a51420a.StartsWith(_0x339c0fec._0x5bb166a0(new byte[3] { 122, 99, 46 }, 19)))
                {
                    string _0x95d2f03c = _0x0a51420a.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x95d2f03c} from {_0xe8cf184f}");
                        }
#endif
                    }

                    return _0x95d2f03c;
                }
            }
        }

        return "";
    }

    private string _0x1fe15d05()
    {
        float _0xe2f78f64 = Time.realtimeSinceStartup;
        if (_0xe2f78f64 < 0f)
            _0xe2f78f64 = 0f;
        int _0x135551e9 = (int)(_0xe2f78f64 * 1000f);
        int _0x3851299c = _0x135551e9 / 60000;
        int _0x0d5d257a = (_0x135551e9 / 1000) % 60;
        int _0x01a4aa18 = _0x135551e9 % 1000;
        return string.Format(_0x339c0fec._0x5bb166a0(new byte[21] { 160, 235, 225, 235, 235, 166, 225, 160, 234, 225, 235, 235, 166, 225, 160, 233, 225, 235, 235, 235, 166 }, 219), _0x3851299c, _0x0d5d257a, _0x01a4aa18);
    }

    private string _0x6e0656ed { get; set; }

    private async Task<bool> _0x12b3ca31()
    {
        {
#if B_LOGS
            Debug.Log(_0x339c0fec._0x5bb166a0(new byte[29] { 79, 64, 113, 103, 96, 73, 52, 93, 103, 68, 102, 125, 98, 117, 119, 109, 85, 122, 112, 71, 117, 98, 113, 112, 87, 124, 113, 119, 127 }, 20));
#endif
        }

        string _0xe06c0cc9 = "";
        for (int _0x40f3ec56 = 0; _0x40f3ec56 < 2; _0x40f3ec56++)
        {
            if (await _0x3d5df30f(1, 100))
            {
                await _0x032ffccf(_0x339c0fec._0x5bb166a0(new byte[7] { 108, 98, 97, 109, 101, 107, 106 }, 14));
                _0x0abf0ad2();
                return true;
            }

            _0xe06c0cc9 = await _0x1d899328(1, 100);
            if (!string.IsNullOrEmpty(_0xe06c0cc9))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xe06c0cc9))
            {
                if (!string.IsNullOrEmpty(_0xceb4b91b))
                {
                    _0xe06c0cc9 = _0xb6248f5a(_0xe06c0cc9, _0xceb4b91b);
                    {
#if B_LOGS
                        Debug.Log(_0x339c0fec._0x5bb166a0(new byte[53] { 42, 37, 20, 2, 5, 44, 81, 50, 16, 18, 25, 20, 21, 81, 23, 24, 31, 16, 29, 36, 3, 29, 81, 6, 24, 5, 25, 81, 2, 20, 31, 21, 24, 21, 81, 147, 247, 227, 81, 2, 25, 30, 6, 81, 38, 20, 19, 39, 24, 20, 6, 75, 81 }, 113) + _0xe06c0cc9);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x339c0fec._0x5bb166a0(new byte[39] { 47, 32, 17, 7, 0, 41, 84, 55, 21, 23, 28, 17, 16, 84, 18, 29, 26, 21, 24, 33, 6, 24, 84, 150, 242, 230, 84, 7, 28, 27, 3, 84, 35, 17, 22, 34, 29, 17, 3 }, 116));
#endif
                    }
                }

                _0x5a65c5ba = true;
                _0x788267e8(_0xe06c0cc9);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x339c0fec._0x5bb166a0(new byte[44] { 123, 116, 69, 83, 84, 125, 0, 101, 88, 67, 69, 80, 84, 73, 79, 78, 0, 87, 72, 73, 76, 69, 0, 67, 72, 69, 67, 75, 73, 78, 71, 0, 83, 65, 86, 69, 68, 0, 76, 73, 78, 75, 26, 0 }, 32) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private bool TryOpenExternalLikeChrome(string _0xbc7e13b9)
    {
        if (string.IsNullOrEmpty(_0xbc7e13b9))
            return false;
        if (_0xbc7e13b9.StartsWith(_0x339c0fec._0x5bb166a0(new byte[9] { 226, 229, 255, 238, 229, 255, 177, 164, 164 }, 139), StringComparison.OrdinalIgnoreCase))
            return _0x36041ea9(_0xbc7e13b9);
        if (_0x36ab2056(_0xbc7e13b9))
            return _0x204a4901(_0xbc7e13b9, null);
        if (!_0xbc7e13b9.StartsWith(_0x339c0fec._0x5bb166a0(new byte[7] { 154, 134, 134, 130, 200, 221, 221 }, 242), StringComparison.OrdinalIgnoreCase) && !_0xbc7e13b9.StartsWith(_0x339c0fec._0x5bb166a0(new byte[8] { 155, 135, 135, 131, 128, 201, 220, 220 }, 243), StringComparison.OrdinalIgnoreCase) && !_0xbc7e13b9.StartsWith(_0x339c0fec._0x5bb166a0(new byte[11] { 14, 13, 0, 26, 27, 85, 13, 3, 14, 1, 4 }, 111), StringComparison.OrdinalIgnoreCase))
        {
            return _0x23405d9a(_0xbc7e13b9);
        }

        return false;
    }

    private void _0x77e63d48()
    {
        if (_0x112bdda1)
        {
            WLog(_0x339c0fec._0x5bb166a0(new byte[18] { 225, 220, 205, 208, 132, 197, 200, 214, 193, 197, 192, 221, 132, 215, 204, 203, 211, 202 }, 164));
            return;
        }

        _0x8368aef1(false);
        WLog(_0x339c0fec._0x5bb166a0(new byte[46] { 117, 89, 81, 86, 24, 111, 93, 90, 110, 81, 93, 79, 24, 104, 77, 75, 80, 24, 118, 87, 76, 81, 94, 81, 91, 89, 76, 81, 87, 86, 24, 16, 80, 89, 74, 92, 79, 89, 74, 93, 24, 90, 89, 91, 83, 17 }, 56));
        ++_0x921f1190;
        _0x34209990();
        if (_0x921f1190 <= 1)
            return;
        if (_0x2f3007e2())
        {
            WLog(_0x339c0fec._0x5bb166a0(new byte[37] { 95, 98, 115, 110, 58, 105, 113, 115, 106, 106, 127, 126, 58, 55, 36, 58, 106, 117, 106, 111, 106, 105, 58, 105, 110, 115, 118, 118, 58, 117, 106, 127, 116, 127, 126, 32, 58 }, 26) + _0xf33d6a44.Count);
            return;
        }

        Application.Quit();
    }

    // WEB VIEW LOGIC END
    internal void _0x34209990()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xa5d2016a = new AndroidNotificationChannel
        {
            Id = _0x339c0fec._0x5bb166a0(new byte[15] { 201, 200, 203, 204, 216, 193, 217, 242, 206, 197, 204, 195, 195, 200, 193 }, 173),
            Name = _0x339c0fec._0x5bb166a0(new byte[15] { 237, 204, 207, 200, 220, 197, 221, 137, 234, 193, 200, 199, 199, 204, 197 }, 169),
            Importance = Importance.High,
            Description = _0x339c0fec._0x5bb166a0(new byte[21] { 0, 34, 41, 34, 53, 38, 43, 103, 41, 40, 51, 46, 33, 46, 36, 38, 51, 46, 40, 41, 52 }, 71)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xa5d2016a);
        // Build notification
        var _0xab8150e2 = new AndroidNotification
        {
            Title = _0x9b8ca76d[UnityEngine.Random.Range(0, _0x9b8ca76d.Length)],
            Text = _0x339c0fec._0x5bb166a0(new byte[21] { 153, 170, 189, 248, 161, 183, 173, 248, 171, 173, 170, 189, 248, 172, 183, 248, 189, 160, 177, 172, 231 }, 216),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xab8150e2, _0x339c0fec._0x5bb166a0(new byte[15] { 136, 137, 138, 141, 153, 128, 152, 179, 143, 132, 141, 130, 130, 137, 128 }, 236));
    }

    private bool _0x2f3007e2()
    {
        _0xf33d6a44.RemoveAll(_0xff35f6d7 => _0xff35f6d7 == null || !_0xff35f6d7.IsAlive);
        return _0xf33d6a44.Count > 0;
    }

    private string _0xceb4b91b;
    private JObject _0x75af0f1a(params string[] _0xbd8628ee)
    {
        JObject _0x3e1342b5 = new JObject();
        foreach (var _0x55fe0382 in _0xbd8628ee)
        {
            string _0x1736845a = _0x04ca1750();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x1736845a} val={_0x55fe0382}");
#endif
            }

            _0x3e1342b5.Add(_0x1736845a, _0x55fe0382 == null ? "" : _0x55fe0382);
        }

        return _0x3e1342b5;
    }

    private int _0x7bd60033 = -1;
    private int _0x63048eb5 = 5, _0x7a4de469 = 5, _0x873e7f24 = 5, _0x07265c96 = 5;
    private IEnumerator _0x152a384d(IEnumerator _0x9ba20b24, TaskCompletionSource<bool> _0xe70f68d4)
    {
        yield return _0x9ba20b24;
        _0xe70f68d4.SetResult(true);
    }

    private bool _0x36041ea9(string _0xaa30d4f9)
    {
        try
        {
            using (var _0x0a896b96 = new AndroidJavaClass(_0x339c0fec._0x5bb166a0(new byte[30] { 241, 253, 255, 188, 231, 252, 251, 230, 235, 161, 246, 188, 226, 254, 243, 235, 247, 224, 188, 199, 252, 251, 230, 235, 194, 254, 243, 235, 247, 224 }, 146)))
            using (var _0x8abae5b0 = _0x0a896b96.GetStatic<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[15] { 45, 59, 60, 60, 43, 32, 58, 15, 45, 58, 39, 56, 39, 58, 55 }, 78)))
            using (var _0x49c2be11 = _0x8abae5b0.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[17] { 184, 186, 171, 143, 190, 188, 180, 190, 184, 186, 146, 190, 177, 190, 184, 186, 173 }, 223)))
            using (var _0xd50a017b = new AndroidJavaClass(_0x339c0fec._0x5bb166a0(new byte[22] { 190, 177, 187, 173, 176, 182, 187, 241, 188, 176, 177, 171, 186, 177, 171, 241, 150, 177, 171, 186, 177, 171 }, 223)))
            using (var _0x2113b071 = _0xd50a017b.CallStatic<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[8] { 91, 74, 89, 88, 78, 126, 89, 66 }, 43), _0xaa30d4f9, 1))
            {
                string _0x6451b96d = _0x2113b071.Call<string>(_0x339c0fec._0x5bb166a0(new byte[14] { 153, 155, 138, 173, 138, 140, 151, 144, 153, 187, 134, 138, 140, 159 }, 254), _0x339c0fec._0x5bb166a0(new byte[20] { 135, 151, 138, 146, 150, 128, 151, 186, 131, 132, 137, 137, 135, 132, 134, 142, 186, 144, 151, 137 }, 229));
                string _0x8c5f177e = _0x2113b071.Call<string>(_0x339c0fec._0x5bb166a0(new byte[10] { 142, 140, 157, 185, 136, 138, 130, 136, 142, 140 }, 233));
                _0x2113b071.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[11] { 251, 254, 254, 217, 251, 238, 255, 253, 245, 232, 227 }, 154), _0x339c0fec._0x5bb166a0(new byte[33] { 247, 248, 242, 228, 249, 255, 242, 184, 255, 248, 226, 243, 248, 226, 184, 245, 247, 226, 243, 241, 249, 228, 239, 184, 212, 196, 217, 193, 197, 215, 212, 218, 211 }, 150));
                _0x2113b071.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[11] { 167, 176, 184, 186, 163, 176, 144, 173, 161, 167, 180 }, 213), _0x339c0fec._0x5bb166a0(new byte[20] { 22, 6, 27, 3, 7, 17, 6, 43, 18, 21, 24, 24, 22, 21, 23, 31, 43, 1, 6, 24 }, 116));
                if (_0x2113b071.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[15] { 106, 125, 107, 119, 116, 110, 125, 89, 123, 108, 113, 110, 113, 108, 97 }, 24), _0x49c2be11) != null)
                {
                    WLog(_0x339c0fec._0x5bb166a0(new byte[24] { 52, 31, 5, 24, 26, 18, 59, 30, 28, 18, 87, 24, 7, 18, 25, 87, 30, 25, 3, 18, 25, 3, 77, 87 }, 119) + _0xaa30d4f9);
                    _0x2113b071.Call<AndroidJavaObject>(_0x339c0fec._0x5bb166a0(new byte[8] { 151, 146, 146, 176, 154, 151, 145, 133 }, 246), 0x10000000);
                    _0x8abae5b0.Call(_0x339c0fec._0x5bb166a0(new byte[13] { 197, 194, 215, 196, 194, 247, 213, 194, 223, 192, 223, 194, 207 }, 182), _0x2113b071);
                    return true;
                }

                if (_0xedda1aa0(_0x8c5f177e))
                    return true;
                if (!string.IsNullOrEmpty(_0x6451b96d))
                {
                    WLog(_0x339c0fec._0x5bb166a0(new byte[28] { 172, 135, 157, 128, 130, 138, 163, 134, 132, 138, 207, 134, 129, 155, 138, 129, 155, 207, 137, 142, 131, 131, 141, 142, 140, 132, 213, 207 }, 239) + _0x6451b96d);
                    if (_0x36ab2056(_0x6451b96d))
                        return _0x204a4901(_0x6451b96d, _0x8c5f177e);
                    return _0x23405d9a(_0x6451b96d);
                }

                WLog(_0x339c0fec._0x5bb166a0(new byte[30] { 7, 44, 54, 43, 41, 33, 8, 45, 47, 33, 100, 45, 42, 48, 33, 42, 48, 100, 42, 43, 100, 44, 37, 42, 32, 40, 33, 54, 126, 100 }, 68) + _0xaa30d4f9);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x339c0fec._0x5bb166a0(new byte[26] { 245, 222, 196, 217, 219, 211, 250, 223, 221, 211, 150, 223, 216, 194, 211, 216, 194, 150, 208, 215, 223, 218, 211, 210, 140, 150 }, 182) + e.Message);
            return true;
        }
    }

    private bool _0x7245e555()
    {
        var _0xce1b79e7 = _0x85eb7c97();
        if (_0xce1b79e7 == null)
            return false;
        WLog(_0x339c0fec._0x5bb166a0(new byte[31] { 104, 65, 82, 68, 87, 65, 82, 69, 0, 66, 65, 67, 75, 0, 13, 30, 0, 80, 79, 80, 85, 80, 0, 103, 79, 98, 65, 67, 75, 26, 0 }, 32) + _0xce1b79e7.Id);
        _0xce1b79e7.GoBack();
        return true;
    }

    private string _0x04ca1750()
    {
        string _0xf1d9b817 = _0x339c0fec._0x5bb166a0(new byte[62] { 191, 188, 189, 186, 187, 184, 185, 182, 183, 180, 181, 178, 179, 176, 177, 174, 175, 172, 173, 170, 171, 168, 169, 166, 167, 164, 159, 156, 157, 154, 155, 152, 153, 150, 151, 148, 149, 146, 147, 144, 145, 142, 143, 140, 141, 138, 139, 136, 137, 134, 135, 132, 238, 239, 236, 237, 234, 235, 232, 233, 230, 231 }, 222);
        System.Random _0xd01e36e3 = new System.Random();
        int _0xd6cde080 = _0xd01e36e3.Next(8, 16);
        return new string (Enumerable.Repeat(_0xf1d9b817, _0xd6cde080).Select(_0xd4028cac => _0xd4028cac[_0xd01e36e3.Next(_0xd4028cac.Length)]).ToArray());
    }

    // MAIN FLOW
    private bool _0x3ec822e7 { get; set; }

    private bool _0xae6c54fa = false;
}

internal static class _0x339c0fec
{
    internal static string _0x5bb166a0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}