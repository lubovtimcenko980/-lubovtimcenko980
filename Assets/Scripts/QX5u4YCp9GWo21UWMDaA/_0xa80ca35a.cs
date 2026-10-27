using UnityEngine;

/// <summary>Integrates the slab's sweep across the sky: position is assigned every frame, the
/// direction flips at the amplitude and the speed ramps with the floor index. Nothing here is
/// driven by a body — the game moves transforms itself (design doc: physics none).</summary>
public sealed class _0xa80ca35a : MonoBehaviour
{
    public float _0x560416a0()
    {
        this._0x3545700e();
        return this._slab == null ? 0f : this._slab.anchoredPosition.x;
    }

    public void _0x5baac4aa()
    {
        this._0x4acc3073 = false;
    }

    public void _0x504b5b85(float _0x47defc92, float _0x56e5c458, int _0x5a4b4df2, float _0x7f4b0478)
    {
        this._0x3545700e();
        this._0xdc8ee623 = _0x47defc92;
        this._0xdd974240 = _0x56e5c458;
        this._0xf1b4e4f3 = _0x5a4b4df2 >= 0 ? 1 : -1;
        this._0x7ed19cd9 = _0x7f4b0478;
        this._0x4acc3073 = true;
        Vector2 _0x952cf241 = this._slab.anchoredPosition;
        _0x952cf241.x = this._0xdc8ee623 * this._0xf1b4e4f3;
        _0x952cf241.y = this._0x7ed19cd9;
        this._slab.anchoredPosition = _0x952cf241;
    }

    private float _0xdd974240;
    private float _0x7ed19cd9;
    private bool _0x4acc3073;
    [SerializeField]
    private RectTransform _slab;
    private int _0xf1b4e4f3 = 1;
    private float _0xdc8ee623;
    private void Start()
    {
        this._0x3545700e();
    }

    private void Update()
    {
        if (!this._0x4acc3073 || this._slab == null)
            return;
        if (_0x59a642a8.Instance == null || !_0x59a642a8.Instance._0xdb5e484e)
            return;
        Vector2 _0x26fa18ca = this._slab.anchoredPosition;
        _0x26fa18ca.x += this._0xf1b4e4f3 * this._0xdd974240 * Time.deltaTime;
        if (_0x26fa18ca.x > this._0xdc8ee623)
        {
            _0x26fa18ca.x = this._0xdc8ee623;
            this._0xf1b4e4f3 = -1;
        }
        else if (_0x26fa18ca.x < -this._0xdc8ee623)
        {
            _0x26fa18ca.x = -this._0xdc8ee623;
            this._0xf1b4e4f3 = 1;
        }

        this._slab.anchoredPosition = _0x26fa18ca;
    }

    public void _0x3545700e()
    {
        if (this._slab == null)
            this._slab = this.transform as RectTransform;
    }
}