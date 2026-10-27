using UnityEngine;

/// <summary>The outcome of one drop. No constructor — Init returns the filled object.</summary>
public sealed class _0xa10a6a07
{
    public float NewWidth;
    public const int Perfect = 0;
    public int TrimSign;
    public _0xa10a6a07 _0x5afe6455(int _0x572a21ca, float _0x1f126a73, float _0xe13ea8e0, float _0x155a2269, float _0x7348f593, int _0xf03037a4, bool _0xe59da257)
    {
        this.Kind = _0x572a21ca;
        this.NewWidth = _0x1f126a73;
        this.NewCentre = _0xe13ea8e0;
        this.TrimWidth = _0x155a2269;
        this.TrimCentre = _0x7348f593;
        this.TrimSign = _0xf03037a4;
        this.Clamped = _0xe59da257;
        return this;
    }

    public float TrimWidth;
    public const int Trim = 1;
    public float TrimCentre;
    public float NewCentre;
    public const int Miss = 2;
    public bool Clamped;
    public int Kind;
}

/// <summary>Pure maths: widths, centres and how a drop resolves. Touches no scene object, so
/// the rules can be reasoned about (and the solvability proof above trusts them).</summary>
public sealed class _0x4c375b28
{
    private _0x495de4b2 _0xcc528370;
    private float _0x04443bf3;
    private float _0x4752987c;
    private void _0xc497f1bc()
    {
        if (this._0x27a3263b > 0)
        {
            this._0x27a3263b--;
            if (this._0x27a3263b <= 0)
                this._0x2c254282 = this._0x4e53ae5e;
        }
        else
        {
            this._0x2c254282 = this._0x4e53ae5e;
        }
    }

    public float _0xd4e7e9a1
    {
        get
        {
            return this._0xcc528370 == null ? 0f : this._0x4752987c / this._0xcc528370.BaseW;
        }
    }

    public float _0x6fd5306c
    {
        get
        {
            return this._0x04443bf3;
        }
    }

    public float _0x1ac5f09e
    {
        get
        {
            return this._0x2c254282;
        }
    }

    private int _0x37d0d7ad;
    public int _0x44f62d10
    {
        get
        {
            return this._0x37d0d7ad;
        }
    }

    public _0xa10a6a07 _0x027a4b17(float _0xd9b4d5fc)
    {
        float _0x40f34bdd = _0xd9b4d5fc - this._0x04443bf3;
        float _0xc4549618 = _0x40f34bdd < 0f ? -_0x40f34bdd : _0x40f34bdd;
        float _0x63fa4746 = this._0x4752987c - _0xc4549618;
        if (_0xc4549618 <= this._0x2c254282)
        {
            this._0x9b7b9401();
            this._0x37d0d7ad++;
            return new _0xa10a6a07()._0x5afe6455(_0xa10a6a07.Perfect, this._0x4752987c, this._0x04443bf3, 0f, 0f, 0, false);
        }

        this._0xc497f1bc();
        if (_0x63fa4746 <= 0f)
            return new _0xa10a6a07()._0x5afe6455(_0xa10a6a07.Miss, this._0x4752987c, this._0x04443bf3, 0f, 0f, _0x40f34bdd < 0f ? -1 : 1, false);
        int _0xd18ebc8c = _0x40f34bdd < 0f ? -1 : 1;
        float _0xd405144d = _0x63fa4746;
        float _0xe27a0772 = this._0x04443bf3 + _0x40f34bdd * 0.5f;
        float _0x1e85ff26 = _0xc4549618;
        float _0x63fcebea = _0xe27a0772 + _0xd18ebc8c * (_0xd405144d + _0x1e85ff26) * 0.5f;
        bool _0x520ff61c = false;
        if (_0xd405144d < this._0xcc528370.MinW)
        {
            _0xd405144d = this._0xcc528370.MinW;
            _0x520ff61c = true;
        }

        this._0x4752987c = _0xd405144d;
        this._0x04443bf3 = _0xe27a0772;
        this._0x37d0d7ad++;
        return new _0xa10a6a07()._0x5afe6455(_0xa10a6a07.Trim, _0xd405144d, _0xe27a0772, _0x1e85ff26, _0x63fcebea, _0xd18ebc8c, _0x520ff61c);
    }

    public _0x4c375b28 _0x325e08d1(_0x495de4b2 _0x1a73f674, float _0x5a76218d, float _0x76dccc7e, int _0x847ac6dd)
    {
        this._0xcc528370 = _0x1a73f674;
        this._0x4752987c = _0x5a76218d;
        this._0x04443bf3 = 0f;
        this._0x37d0d7ad = _0x847ac6dd;
        this._0x4e53ae5e = _0x76dccc7e;
        this._0x2c254282 = _0x76dccc7e;
        this._0x27a3263b = 0;
        return this;
    }

    private float _0x2c254282;
    /// <summary>A missed drop costs a scaffold support, not the run; the slab comes back at the
    /// same width so there is always something visible and tappable on screen (C.5).</summary>
    public void _0xd7d702c4()
    {
        this._0x2c254282 = this._0x4e53ae5e;
    }

    private void _0x9b7b9401()
    {
        this._0x2c254282 *= 1.18f;
        float _0x4068de79 = this._0x4e53ae5e * 2.2f;
        if (this._0x2c254282 > _0x4068de79)
            this._0x2c254282 = _0x4068de79;
        this._0x27a3263b = 3;
    }

    public float _0x1fd0e203
    {
        get
        {
            return this._0x4752987c;
        }
    }

    private float _0x4e53ae5e;
    private int _0x27a3263b;
}