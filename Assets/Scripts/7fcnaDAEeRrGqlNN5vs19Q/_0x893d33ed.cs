using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x893d33ed : MonoBehaviour
{
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x2f60a659;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x4b07f2a4 != null)
            return;
        GameObject _0x22229c2d = new GameObject(_0x7a780b07._0x7b55129e(new byte[16] { 236, 213, 200, 251, 215, 214, 204, 202, 217, 203, 204, 255, 205, 217, 202, 220 }, 184));
        _0x22229c2d.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x22229c2d);
        _0x4b07f2a4 = _0x22229c2d.AddComponent<_0x893d33ed>();
    }

    private const float TargetRatio = 7f;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x487b7147)
    {
        return 0.2126f * Linear(_0x487b7147.r) + 0.7152f * Linear(_0x487b7147.g) + 0.0722f * Linear(_0x487b7147.b);
    }

    private static _0x893d33ed _0x4b07f2a4;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x2ea67386(Object _0xf1af8874)
    {
        TMP_Text _0xab32524e = _0xf1af8874 as TMP_Text;
        if (_0xab32524e != null)
            this._0x2990433b.Add(_0xab32524e);
    }

    private void OnDisable()
    {
        if (this._0x2f60a659 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x2f60a659);
    }

    private const float MinRatio = 4.5f;
    private static void Fix(TMP_Text _0x0b502118)
    {
        if (_0x0b502118 == null || !_0x0b502118.isActiveAndEnabled)
            return;
        Material _0x45c1bcf1 = _0x0b502118.fontSharedMaterial;
        if (_0x45c1bcf1 == null || !_0x45c1bcf1.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x45c1bcf1.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x45c1bcf1.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x930d095a = _0x0b502118.color;
        if (_0x930d095a.a <= 0f)
            return;
        Color _0x26dcb0fd = _0x45c1bcf1.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x930d095a, _0x26dcb0fd) >= MinRatio)
            return;
        Color _0x2b86c1b3 = Luminance(_0x26dcb0fd) < 0.5f ? Color.white : Color.black;
        Color _0x348afccf;
        if (Ratio(_0x2b86c1b3, _0x26dcb0fd) < TargetRatio)
        {
            _0x348afccf = _0x2b86c1b3;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xfa374521 = 0f;
            float _0xf575cd7e = 1f;
            for (int _0xf79ad2f1 = 0; _0xf79ad2f1 < 20; _0xf79ad2f1++)
            {
                float _0x2746b550 = (_0xfa374521 + _0xf575cd7e) * 0.5f;
                if (Ratio(Color.Lerp(_0x930d095a, _0x2b86c1b3, _0x2746b550), _0x26dcb0fd) >= TargetRatio)
                    _0xf575cd7e = _0x2746b550;
                else
                    _0xfa374521 = _0x2746b550;
            }

            _0x348afccf = Color.Lerp(_0x930d095a, _0x2b86c1b3, _0xf575cd7e);
        }

        _0x348afccf.a = _0x930d095a.a;
        _0x0b502118.color = _0x348afccf;
    }

    private static float Linear(float _0x31113f0f)
    {
        _0x31113f0f = Mathf.Clamp01(_0x31113f0f);
        return _0x31113f0f <= 0.03928f ? _0x31113f0f / 12.92f : Mathf.Pow((_0x31113f0f + 0.055f) / 1.055f, 2.4f);
    }

    private static float Ratio(Color _0x7441ecb6, Color _0x5bf6a6f4)
    {
        float _0x90bd0608 = Luminance(_0x7441ecb6);
        float _0xcb06b77c = Luminance(_0x5bf6a6f4);
        return (Mathf.Max(_0x90bd0608, _0xcb06b77c) + 0.05f) / (Mathf.Min(_0x90bd0608, _0xcb06b77c) + 0.05f);
    }

    private void LateUpdate()
    {
        if (this._0x2990433b.Count == 0)
            return;
        this._0x70206842.Clear();
        this._0x70206842.AddRange(this._0x2990433b);
        this._0x2990433b.Clear();
        for (int _0x24121a98 = 0; _0x24121a98 < this._0x70206842.Count; _0x24121a98++)
            Fix(this._0x70206842[_0x24121a98]);
    }

    private const float MinOutlineWidth = 0.01f;
    private readonly List<TMP_Text> _0x70206842 = new List<TMP_Text>();
    private readonly HashSet<TMP_Text> _0x2990433b = new HashSet<TMP_Text>();
    private void OnEnable()
    {
        if (this._0x2f60a659 == null)
            this._0x2f60a659 = _0xf6d1f921 => this._0x2ea67386(_0xf6d1f921);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x2f60a659);
    }
}

internal static class _0x7a780b07
{
    internal static string _0x7b55129e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}