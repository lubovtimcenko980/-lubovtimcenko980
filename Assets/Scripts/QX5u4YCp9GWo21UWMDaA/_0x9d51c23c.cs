using UnityEngine;
using UnityEngine.UI;

/// <summary>Both scenes raise their own splash, and the template ships its loading bar white on
/// a track at alpha 0.004 - invisible (rule G, ANDROID-3578). This paints the fill with the
/// palette accent and the track with the deepest palette ink, at real alpha.</summary>
public static class _0x9d51c23c
{
    public static void Apply()
    {
        _0x54ac6d04 _0x0cf3edfe = _0x54ac6d04.Instance;
        if (_0x0cf3edfe == null)
            return;
        Slider _0xf304dc1c = _0x0cf3edfe.AnimationSlider;
        if (_0xf304dc1c == null || _0xf304dc1c.fillRect == null)
            return;
        Image _0x5b42c397 = _0xf304dc1c.fillRect.GetComponent<Image>();
        if (_0x5b42c397 != null)
            _0x5b42c397.color = _0x5219e5ac.Secondary;
        Transform _0x99b8838c = _0xf304dc1c.fillRect.parent;
        Image _0xcedd01ce = _0x99b8838c == null ? null : _0x99b8838c.GetComponent<Image>();
        if (_0xcedd01ce != null)
            _0xcedd01ce.color = _0x5219e5ac.Deepest;
        Transform _0x1c571267 = _0x99b8838c == null ? null : _0x99b8838c.parent;
        Image _0x725a8ba6 = _0x1c571267 == null ? null : _0x1c571267.GetComponent<Image>();
        if (_0x725a8ba6 != null)
            _0x725a8ba6.color = _0x5219e5ac.Deep;
    }
}