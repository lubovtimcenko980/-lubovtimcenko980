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
public sealed class _0xbbda346d : MonoBehaviour
{
    private void OnDisable()
    {
        if (this._0x10a1dc0e != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x10a1dc0e);
    }

    private void OnEnable()
    {
        if (this._0x10a1dc0e == null)
            this._0x10a1dc0e = _0x7405e03c => this._0x1db39737(_0x7405e03c);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x10a1dc0e);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x4149b928)
    {
        return 0.2126f * Linear(_0x4149b928.r) + 0.7152f * Linear(_0x4149b928.g) + 0.0722f * Linear(_0x4149b928.b);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x1db39737(Object _0x1d4524f9)
    {
        TMP_Text _0x7a735123 = _0x1d4524f9 as TMP_Text;
        if (_0x7a735123 != null)
            this._0x1b085564.Add(_0x7a735123);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x10a1dc0e;
    private const float MinOutlineWidth = 0.01f;
    private const float MinRatio = 4.5f;
    private static _0xbbda346d _0x94656dfd;
    private readonly HashSet<TMP_Text> _0x1b085564 = new HashSet<TMP_Text>();
    private static float Linear(float _0x67811f42)
    {
        _0x67811f42 = Mathf.Clamp01(_0x67811f42);
        return _0x67811f42 <= 0.03928f ? _0x67811f42 / 12.92f : Mathf.Pow((_0x67811f42 + 0.055f) / 1.055f, 2.4f);
    }

    private const float TargetRatio = 7f;
    private readonly List<TMP_Text> _0x7f2e3fa8 = new List<TMP_Text>();
    private void LateUpdate()
    {
        if (this._0x1b085564.Count == 0)
            return;
        this._0x7f2e3fa8.Clear();
        this._0x7f2e3fa8.AddRange(this._0x1b085564);
        this._0x1b085564.Clear();
        for (int _0xf728c8d5 = 0; _0xf728c8d5 < this._0x7f2e3fa8.Count; _0xf728c8d5++)
            Fix(this._0x7f2e3fa8[_0xf728c8d5]);
    }

    private static void Fix(TMP_Text _0x1b3d3eda)
    {
        if (_0x1b3d3eda == null || !_0x1b3d3eda.isActiveAndEnabled)
            return;
        Material _0x03f6520c = _0x1b3d3eda.fontSharedMaterial;
        if (_0x03f6520c == null || !_0x03f6520c.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x03f6520c.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x03f6520c.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xf08e291a = _0x1b3d3eda.color;
        if (_0xf08e291a.a <= 0f)
            return;
        Color _0x62ebd452 = _0x03f6520c.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xf08e291a, _0x62ebd452) >= MinRatio)
            return;
        Color _0x99d1ba03 = Luminance(_0x62ebd452) < 0.5f ? Color.white : Color.black;
        Color _0x56ebb576;
        if (Ratio(_0x99d1ba03, _0x62ebd452) < TargetRatio)
        {
            _0x56ebb576 = _0x99d1ba03;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x1f36abc1 = 0f;
            float _0x332b9e55 = 1f;
            for (int _0x8766d9bd = 0; _0x8766d9bd < 20; _0x8766d9bd++)
            {
                float _0xad16608a = (_0x1f36abc1 + _0x332b9e55) * 0.5f;
                if (Ratio(Color.Lerp(_0xf08e291a, _0x99d1ba03, _0xad16608a), _0x62ebd452) >= TargetRatio)
                    _0x332b9e55 = _0xad16608a;
                else
                    _0x1f36abc1 = _0xad16608a;
            }

            _0x56ebb576 = Color.Lerp(_0xf08e291a, _0x99d1ba03, _0x332b9e55);
        }

        _0x56ebb576.a = _0xf08e291a.a;
        _0x1b3d3eda.color = _0x56ebb576;
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x94656dfd != null)
            return;
        GameObject _0x8916bfd9 = new GameObject(_0xbe3a1151._0x9d9741d7(new byte[16] { 250, 195, 222, 237, 193, 192, 218, 220, 207, 221, 218, 233, 219, 207, 220, 202 }, 174));
        _0x8916bfd9.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x8916bfd9);
        _0x94656dfd = _0x8916bfd9.AddComponent<_0xbbda346d>();
    }

    private static float Ratio(Color _0xa2ce9b21, Color _0xdd55305c)
    {
        float _0x42023649 = Luminance(_0xa2ce9b21);
        float _0xf890b375 = Luminance(_0xdd55305c);
        return (Mathf.Max(_0x42023649, _0xf890b375) + 0.05f) / (Mathf.Min(_0x42023649, _0xf890b375) + 0.05f);
    }
}

internal static class _0xbe3a1151
{
    internal static string _0x9d9741d7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}