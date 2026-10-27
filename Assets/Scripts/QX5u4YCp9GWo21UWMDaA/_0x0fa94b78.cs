using System.Collections.Generic;
using UnityEngine;

/// <summary>Draws a run from a seed, PROVES it is playable, and only then hands it over
/// (C.11). The hardcoded plan at the bottom exists as the fallback, never as the game.</summary>
public sealed class _0x0fa94b78
{
    private _0xacc286a4 _0x68ea3910(int _0x12b05fb7, int _0x80d92f0c)
    {
        float _0x7f180fc0 = this._0x61e7029c.FieldW;
        List<_0xea666a49> _0xe13d00dc = new List<_0xea666a49>();
        _0xe13d00dc.Add(new _0xea666a49()._0x5f088b3f(_0x38a6c9ac.KindHeight, 12, _0xf9875738._0xb0d5cdb2(new byte[10] { 19, 4, 0, 2, 9, 97, 112, 115, 97, 7 }, 65), 240));
        _0xe13d00dc.Add(new _0xea666a49()._0x5f088b3f(_0x38a6c9ac.KindPerfectRow, 3, _0xf9875738._0xb0d5cdb2(new byte[23] { 245, 248, 247, 253, 153, 138, 153, 233, 252, 235, 255, 252, 250, 237, 153, 240, 247, 153, 248, 153, 235, 246, 238 }, 185), 180));
        return new _0xacc286a4()._0x67bc5804(_0x12b05fb7, 3, 1f, -1, _0x7f180fc0 * 0.3f, _0x7f180fc0 * 0.011f, _0x7f180fc0 * 0.65f, 0.019f, 3, _0x7f180fc0 * 0.013f, true, 4f, _0x80d92f0c, _0xe13d00dc);
    }

    private _0x495de4b2 _0x61e7029c;
    private _0xacc286a4 _0x8227b636(System.Random _0x5afbc0b1, int _0x8d6f4aec, int _0x185f4468)
    {
        float _0xba865371 = this._0x61e7029c.FieldW;
        List<_0xea666a49> _0xbeb94a94 = _0x38a6c9ac.DrawPair(_0x5afbc0b1);
        return new _0xacc286a4()._0x67bc5804(_0x8d6f4aec, _0x5afbc0b1.Next(2, 5), 0.92f + (float)_0x5afbc0b1.NextDouble() * 0.08f, _0x5afbc0b1.Next(0, 2) == 0 ? -1 : 1, _0xba865371 * (0.299f + (float)_0x5afbc0b1.NextDouble() * 0.035f), _0xba865371 * (0.0104f + (float)_0x5afbc0b1.NextDouble() * 0.0035f), _0xba865371 * (0.639f + (float)_0x5afbc0b1.NextDouble() * 0.065f), 0.0182f + (float)_0x5afbc0b1.NextDouble() * 0.0030f, _0x5afbc0b1.Next(2, 5), _0xba865371 * (0.010f + (float)_0x5afbc0b1.NextDouble() * 0.010f), _0x5afbc0b1.Next(0, 2) == 0, 2f + (float)_0x5afbc0b1.NextDouble() * 5f, _0x185f4468, _0xbeb94a94);
    }

    private int _0x7af5f022;
    public _0xacc286a4 _0xffa8b7d0()
    {
        int _0x5feaa48d = _0xae21ba7c.SelectedIndex();
        int _0xc4a6a339 = (_0x5feaa48d * 7919) ^ (this._0x7af5f022 * 104729);
        System.Random _0x3a47de18 = new System.Random(_0xc4a6a339);
        _0xacc286a4 _0xe5a7a9cb = null;
        for (int _0xb499e594 = 0; _0xb499e594 < 20; _0xb499e594++)
        {
            _0xe5a7a9cb = this._0x8227b636(_0x3a47de18, _0xc4a6a339 + _0xb499e594, _0x5feaa48d);
            if (this._0x31a883a7(_0xe5a7a9cb))
            {
                {
#if B_LOGS
                    {
                        Debug.Log($"[run] seed={_0xe5a7a9cb.Seed} attempt={this._0x7af5f022} tries={_0xb499e594 + 1} stub={_0xe5a7a9cb.StubFloors} v0={_0xe5a7a9cb.BaseSpeed}");
                    }
#endif
                }

                return _0xe5a7a9cb;
            }
        }

        {
#if B_LOGS
            {
                Debug.Log($"[run] seed={_0xc4a6a339} fell back to the hardcoded plan");
            }
#endif
        }

        return this._0x68ea3910(_0xc4a6a339, _0x5feaa48d);
    }

    public _0x0fa94b78 _0xb7dfcb8d(_0x495de4b2 _0x9fb4d059, int _0xd6641c33)
    {
        this._0x61e7029c = _0x9fb4d059;
        this._0x7af5f022 = _0xd6641c33;
        return this;
    }

    /// <summary>Three conditions, all measured against the real geometry: the perfect window is
    /// physically tappable, the slab really crosses the footprint, and the harder mission target
    /// is reachable before the width clamps out.</summary>
    private bool _0x31a883a7(_0xacc286a4 _0xdffebdcb)
    {
        int _0xd0ab1d6d = 12;
        for (int _0x1dd09e20 = 0; _0x1dd09e20 < _0xdffebdcb.Missions.Count; _0x1dd09e20++)
            if (_0xdffebdcb.Missions[_0x1dd09e20].Kind == _0x38a6c9ac.KindHeight || _0xdffebdcb.Missions[_0x1dd09e20].Kind == _0x38a6c9ac.KindNoSupport)
                _0xd0ab1d6d = Mathf.Max(_0xd0ab1d6d, _0xdffebdcb.Missions[_0x1dd09e20].Target);
        _0xd0ab1d6d = Mathf.Min(_0xd0ab1d6d, 24);
        float width = this._0x61e7029c.BaseW * _0xdffebdcb.StartWidthFactor;
        float _0xab20e307 = this._0x61e7029c.FieldW * _0xdffebdcb.PerfectWindowFactor;
        for (int _0xba5ea7ef = 0; _0xba5ea7ef < _0xd0ab1d6d; _0xba5ea7ef++)
        {
            float _0x5514f38a = _0xdffebdcb._0x43e1db78(_0xba5ea7ef);
            if (_0x5514f38a <= 0f)
                return false;
            if (2f * _0xab20e307 / _0x5514f38a < 0.055f)
                return false;
            if (this._0x61e7029c._0x7e8acb04(width) <= width * 0.5f)
                return false;
            if (width < this._0x61e7029c.MinW * 1.15f)
                return false;
            // a tidy-but-not-perfect player shaves a little width every floor
            width -= _0xab20e307 * 0.55f;
        }

        return true;
    }
}

internal static class _0xf9875738
{
    internal static string _0xb0d5cdb2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}