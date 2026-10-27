using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x5a9a28e3;

public class _0xf397bc59 : MonoBehaviour
{
    public void _0x2a4e0fb7()
    {
        this.LastPanelIndexes.RemoveAll(_0xbca452c2 => _0xbca452c2 == this.CurrentPanelIndex);
        int _0x8c1f4073 = this.LastPanelIndexes.Last();
        this._0x45fa1586(_0x8c1f4073);
        this._0x99a50b06(_0x8c1f4073);
        this.CurrentPanelIndex = _0x8c1f4073;
        this.Panels[_0x8c1f4073].Show();
    }

    public float StaticBlurMaterialInitialValue;
    public int CurrentPanelIndex;
    public void _0xbd01eb3c(int _0xfb3ba4d1)
    {
        this._0xcfb6266f(_0xfb3ba4d1);
        this._0x45fa1586(_0xfb3ba4d1);
        this.CurrentPanelIndex = _0xfb3ba4d1;
        this.Panels[_0xfb3ba4d1].Show();
    }

    private void _0x3afd0808()
    {
        this._0x8531e2f3(_0x379e6670.SPLASH);
        if (_0x59a642a8.Instance._0x609d206a == _0x52964cd5.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x54ac6d04.Instance.DefaultAnimationTime);
        }
    }

    public List<_0x2c8c7c28> Panels;
    private void SwitchSplash()
    {
        if (_0x98f3cc43.Instance.IsTutorialEnabled && !_0x59a642a8._0x0f3156ff._0x846ba247)
            this._0xbd01eb3c(_0x379e6670.TUTORIAL0);
        else
            this._0xbd01eb3c(_0x379e6670.DEFAULT);
    }

    private void _0x8531e2f3(int _0xf0ccce88)
    {
        this._0xcfb6266f(_0xf0ccce88);
        this._0x45fa1586(_0xf0ccce88);
        this.CurrentPanelIndex = _0xf0ccce88;
        this.Panels[_0xf0ccce88]._0xeeb78759();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0x99a50b06(int _0xd4b2c38a)
    {
        this.LastPanelIndexes.Add(_0xd4b2c38a);
        this.CurrentPanelIndex = _0xd4b2c38a;
        for (int _0x894df639 = 0; _0x894df639 < this.Panels.Count; _0x894df639++)
            if (_0x894df639 != _0xd4b2c38a && this.Panels[_0x894df639] != null)
                this.Panels[_0x894df639]._0x93be5a69();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xf397bc59>();
    }

    private void _0x45fa1586(int _0xe3da53dc)
    {
        if (_0xe3da53dc == _0x379e6670.SPLASH)
            _0x54ac6d04.Instance._0xe7509048();
        if (_0x59a642a8.Instance._0x609d206a == _0x52964cd5.SCENE_0)
        {
        }
    }

    public void _0xebe3ed74(int _0xc70b9e27)
    {
        if (_0xc70b9e27 == _0x379e6670.SPLASH && _0x59a642a8.Instance._0x609d206a != _0x52964cd5.SCENE_0)
            _0x54ac6d04.Instance._0x333f16d1();
        if (_0x59a642a8.Instance._0x609d206a != _0x52964cd5.SCENE_0)
        {
            if (_0xc70b9e27 == _0x379e6670.SPLASH || _0xc70b9e27 == _0x379e6670.TUTORIAL0)
                _0x59a642a8.Instance._0xf550d936(false);
            else if (_0xc70b9e27 == _0x379e6670.DEFAULT)
                _0x59a642a8.Instance._0xf550d936(true);
        }
    }

    private void Start()
    {
        this._0x3afd0808();
    }

    public bool IsShowSplashOnStart = true;
    public static _0xf397bc59 Instance;
    public float ScaleDuration = 0.4f;
    private _0x2c8c7c28 _0x96b791ac(int _0xe4299bb3)
    {
        return this.Panels[_0xe4299bb3];
    }

    private void _0xcfb6266f(int _0x95f05d3e)
    {
        this.LastPanelIndexes.Add(_0x95f05d3e);
        this.CurrentPanelIndex = _0x95f05d3e;
        for (int _0xcc30be7a = 0; _0xcc30be7a < this.Panels.Count; _0xcc30be7a++)
            if (_0xcc30be7a != _0x95f05d3e && this.Panels[_0xcc30be7a] != null)
                this.Panels[_0xcc30be7a]._0x93be5a69();
    }
}