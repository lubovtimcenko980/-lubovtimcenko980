using UnityEngine;

/// <summary>Three switches the settings sheet drives. Every one of them changes something the
/// player can see or feel (C.7, C.20 — there is no sound in this game, so there is no sound row).</summary>
public static class _0x002cd05a
{
    private const int HighContrastBit = 4;
    public static void Buzz()
    {
        if (_0x00a98ad2)
            Handheld.Vibrate();
    }

    private static void SetBit(int _0x69b8be05, bool _0x76a71c7b)
    {
        int _0x963f5d53 = _0x7815908a._0xe6c37e23;
        _0x7815908a._0xe6c37e23 = _0x76a71c7b ? (_0x963f5d53 | _0x69b8be05) : (_0x963f5d53 & ~_0x69b8be05);
    }

    public static float Duration(float _0x7813f1e3)
    {
        return _0xa31c7051 ? _0x7813f1e3 * 0.5f : _0x7813f1e3;
    }

    public static bool _0xc0e0e5e0
    {
        get
        {
            return (_0x7815908a._0xe6c37e23 & HighContrastBit) != 0;
        }

        set
        {
            SetBit(HighContrastBit, value);
        }
    }

    public static bool _0xa31c7051
    {
        get
        {
            return (_0x7815908a._0xe6c37e23 & ReducedMotionBit) != 0;
        }

        set
        {
            SetBit(ReducedMotionBit, value);
        }
    }

    private const int HapticsBit = 1;
    private const int ReducedMotionBit = 2;
    public static bool _0x00a98ad2
    {
        get
        {
            return (_0x7815908a._0xe6c37e23 & HapticsBit) != 0;
        }

        set
        {
            SetBit(HapticsBit, value);
        }
    }

    /// <summary>Colour the perfect flash uses: gold normally, cyan in high contrast (the
    /// chevron marker is added separately so the signal never relies on hue alone).</summary>
    public static Color _0x3e16228f
    {
        get
        {
            return _0xc0e0e5e0 ? _0x5219e5ac.Secondary : _0x5219e5ac.Accent;
        }
    }
}