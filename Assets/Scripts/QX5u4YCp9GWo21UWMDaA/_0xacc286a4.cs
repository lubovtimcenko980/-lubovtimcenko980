using System.Collections.Generic;

/// <summary>Everything one attempt is made of. Produced by RunPlanFactory from a seed; no
/// constructor (C.59), the fields are set through Init and read back by the director.</summary>
public sealed class _0xacc286a4
{
    public int DistrictIndex;
    public _0xacc286a4 _0x67bc5804(int _0x2c97c870, int _0x4e542291, float _0x8191a4a5, int _0x72f5926b, float _0x19b3e9ab, float _0xd684bfce, float _0x83dd9847, float _0xbea43b1b, int _0x03c31fd9, float _0x07ee6031, bool _0x0b7fd2c3, float _0xfe29902c, int _0xf6e2e252, List<_0xea666a49> _0xfd7b50b5)
    {
        this.Seed = _0x2c97c870;
        this.StubFloors = _0x4e542291;
        this.StartWidthFactor = _0x8191a4a5;
        this.FirstDirection = _0x72f5926b;
        this.BaseSpeed = _0x19b3e9ab;
        this.SpeedRamp = _0xd684bfce;
        this.SpeedCap = _0x83dd9847;
        this.PerfectWindowFactor = _0xbea43b1b;
        this.CloudLanes = _0x03c31fd9;
        this.CloudDrift = _0x07ee6031;
        this.CraneOnRight = _0x0b7fd2c3;
        this.AirshipDelay = _0xfe29902c;
        this.DistrictIndex = _0xf6e2e252;
        this.Missions = _0xfd7b50b5;
        return this;
    }

    /// <summary>Sweep speed for floor i, in field units per second.</summary>
    public float _0x43e1db78(int _0x13dd7faa)
    {
        float _0xfa89cbe7 = this.BaseSpeed + this.SpeedRamp * _0x13dd7faa;
        return _0xfa89cbe7 > this.SpeedCap ? this.SpeedCap : _0xfa89cbe7;
    }

    public int CloudLanes;
    public float StartWidthFactor;
    public float BaseSpeed;
    public int StubFloors;
    public bool CraneOnRight;
    public float PerfectWindowFactor;
    public float SpeedCap;
    public List<_0xea666a49> Missions;
    public float CloudDrift;
    public float SpeedRamp;
    public int FirstDirection;
    public int Seed;
    public float AirshipDelay;
}