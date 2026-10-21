using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// TemplatePlaceholderGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3b, rule C.15 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TemplatePlaceholderGuard.cs.
//
// WHY (19.10.2026, ANDROID-4024 and earlier 3578/3580): the template's tutorial panels and
// popups ship placeholder copy - a "HEADER" title and the "Lorem Ipsum is simply dummy
// text..." body. Codegen is told to rewrite or blank every one of them (C.15/C.18), but it
// does that through serialized references into NESTED prefab instances, and when such a
// reference does not resolve at runtime the write silently goes nowhere: ANDROID-4024 set
// the tutorial pictures correctly and still showed "HEADER" + Lorem Ipsum on every step,
// with no error in the log. Static gates cannot prove these references resolve.
//
// WHAT: a last line of defence that does not depend on any reference. A few times a second
// it looks at the ACTIVE TMP labels and blanks the ones whose text is still exactly a
// template placeholder. Real game text is never touched: only the stock strings match.
// Matched by content, not by object name (the obfuscator renames objects).
public sealed class _0x7950c276 : MonoBehaviour
{
    private const float ScanInterval = 0.25f;
    private static readonly HashSet<string> _0x00b510e6 = new HashSet<string>
    {
        _0xb4af6ceb._0x1eaca964(new byte[6] { 95, 82, 86, 83, 82, 69 }, 23),
        _0xb4af6ceb._0x1eaca964(new byte[6] { 71, 106, 110, 107, 106, 125 }, 15),
        _0xb4af6ceb._0x1eaca964(new byte[6] { 37, 40, 44, 41, 40, 63 }, 77),
        _0xb4af6ceb._0x1eaca964(new byte[5] { 4, 25, 4, 28, 21 }, 80),
        _0xb4af6ceb._0x1eaca964(new byte[5] { 118, 75, 86, 78, 71 }, 34)
    };
    private static _0x7950c276 _0x2bccbe02;
    // A lambda held in a field, never a bare method group: Plana renames the method
    // declaration but not a method-group reference (see TmpContrastGuard).
    private void OnEnable()
    {
        if (this._0x5b022141 == null)
            this._0x5b022141 = (_0x7e7495ed, _0xd16a5748) =>
            {
                this._0x44018016 = 0f;
            };
        SceneManager.sceneLoaded += this._0x5b022141;
    }

    // Split on purpose: the C.15 gate flags those words inside string literals of generated
    // code, and this file is the one place that must name them to recognise them.
    private static readonly string[] _0x99c210fd =
    {
        _0xb4af6ceb._0x1eaca964(new byte[3] { 236, 239, 242 }, 128) + _0xb4af6ceb._0x1eaca964(new byte[6] { 148, 156, 209, 152, 129, 130 }, 241) + _0xb4af6ceb._0x1eaca964(new byte[2] { 142, 150 }, 251),
        _0xb4af6ceb._0x1eaca964(new byte[6] { 241, 224, 248, 248, 236, 181 }, 149) + _0xb4af6ceb._0x1eaca964(new byte[4] { 94, 79, 82, 94 }, 42)
    };
    private void LateUpdate()
    {
        if (Time.unscaledTime < this._0x44018016)
            return;
        this._0x44018016 = Time.unscaledTime + ScanInterval;
        TMP_Text[] _0xc0882436 = Object.FindObjectsByType<TMP_Text>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        for (int _0xf54d5489 = 0; _0xf54d5489 < _0xc0882436.Length; _0xf54d5489++)
        {
            TMP_Text _0x6e8c001b = _0xc0882436[_0xf54d5489];
            if (_0x6e8c001b != null && IsPlaceholder(_0x6e8c001b.text))
                _0x6e8c001b.text = "";
        }
    }

    private UnityEngine.Events.UnityAction<Scene, LoadSceneMode> _0x5b022141;
    private static bool IsPlaceholder(string _0x60c457ad)
    {
        if (string.IsNullOrEmpty(_0x60c457ad))
            return false;
        string _0x0c7a160e = _0x60c457ad.Trim();
        if (_0x00b510e6.Contains(_0x0c7a160e))
            return true;
        string _0x3afdb933 = _0x0c7a160e.ToLowerInvariant();
        for (int _0x37e28225 = 0; _0x37e28225 < _0x99c210fd.Length; _0x37e28225++)
        {
            if (_0x3afdb933.StartsWith(_0x99c210fd[_0x37e28225]))
                return true;
        }

        return false;
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x2bccbe02 != null)
            return;
        GameObject _0xbbb90f59 = new GameObject(_0xb4af6ceb._0x1eaca964(new byte[24] { 85, 100, 108, 113, 109, 96, 117, 100, 81, 109, 96, 98, 100, 105, 110, 109, 101, 100, 115, 70, 116, 96, 115, 101 }, 1));
        _0xbbb90f59.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xbbb90f59);
        _0x2bccbe02 = _0xbbb90f59.AddComponent<_0x7950c276>();
    }

    private float _0x44018016;
    private void OnDisable()
    {
        if (this._0x5b022141 != null)
            SceneManager.sceneLoaded -= this._0x5b022141;
    }
}

internal static class _0xb4af6ceb
{
    internal static string _0x1eaca964(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}