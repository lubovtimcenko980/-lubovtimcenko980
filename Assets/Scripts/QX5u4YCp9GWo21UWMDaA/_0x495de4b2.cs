using UnityEngine;

/// <summary>Every size in the game scene is derived from the play field's own rect — nothing is
/// an eyeballed constant, so the composition survives any screen shape (C.0, applied to the
/// UGUI space this game is built in).</summary>
public sealed class _0x495de4b2
{
    public float FieldH;
    public float TopY;
    public float BaseW;
    public float FloorH;
    public float MinW;
    public float PlinthH;
    public _0x495de4b2 _0x8c56e6d0(Rect _0xc5798c8e)
    {
        this.FieldW = _0xc5798c8e.width;
        this.FieldH = _0xc5798c8e.height;
        this.FloorH = this.FieldH * 0.034f;
        this.BaseW = this.FieldW * 0.40f;
        this.MinW = this.FieldW * 0.0563f;
        this.LaneY = this.FieldH * 0.330f;
        this.TopY = this.LaneY - this.FloorH;
        this.PlinthH = this.FloorH * 0.62f;
        this.Margin = this.FieldW * 0.0347f;
        return this;
    }

    public float LaneY;
    /// <summary>Lane height in the same units, used for the drop tween and the guide beam.</summary>
    public float _0x33d06762()
    {
        return this.LaneY * 0.92f;
    }

    public float FieldW;
    public float Margin;
    /// <summary>Half the travel of a slab of width w: it always stays fully on screen, and the
    /// narrower the slab the wider it swings.</summary>
    public float _0x7e8acb04(float _0x1aa44099)
    {
        float _0x0731b752 = this.FieldW * 0.5f - _0x1aa44099 * 0.5f - this.Margin;
        return _0x0731b752 < 0f ? 0f : _0x0731b752;
    }
}