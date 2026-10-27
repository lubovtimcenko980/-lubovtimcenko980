using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x5a9a28e3;

public class _0xa748a6be : MonoBehaviour
{
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x696568ef _0x8d3fe914 in this.Pops)
            if (_0x8d3fe914 != null)
                _0x8d3fe914.gameObject.SetActive(true);
    }

    public float ScaleDuration = 0.4f;
    public List<_0x696568ef> Pops;
    private void _0xb0978fb1(bool _0x9958420c = false)
    {
        for (int _0x06530492 = 0; _0x06530492 < this.Pops.Count; ++_0x06530492)
            if (this.Pops[_0x06530492] != null && !(_0x06530492 == this.CurrentPopIndex && _0x9958420c))
                this.Pops[_0x06530492]._0xac7eed6b();
    }

    public List<int> LastPopIndexes = new();
    public int CurrentPopIndex;
    private void _0xa6db6c69()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public void _0x1dbf829b(int _0x13d6a369)
    {
        this.CurrentPopIndex = _0x13d6a369;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xb0978fb1(true);
        this._0xa6db6c69();
        this.Pops[_0x13d6a369].Show();
        foreach (GameObject _0xff87615f in this.GameObjectsToHide)
            _0xff87615f.SetActive(false);
    }

    public void _0xf0687100()
    {
        this.LastPopIndexes.Clear();
        this._0xb0978fb1();
        foreach (GameObject _0x7583d67a in this.GameObjectsToHide)
            if (_0x7583d67a != null)
                _0x7583d67a.SetActive(true);
        this._0x25bcf1ae();
    }

    public void _0xd5c1be30()
    {
        this.LastPopIndexes.RemoveAll(_0xbca452c2 => _0xbca452c2 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xf0687100();
        else
            this._0x1dbf829b(this.LastPopIndexes.Last());
    }

    private void _0x25bcf1ae()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public _0x696568ef _0x0003d531(int _0xa31be4c7)
    {
        return this.Pops[_0xa31be4c7];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xa748a6be>();
    }

    public GameObject BlurBackground;
    public List<GameObject> GameObjectsToHide;
    public static _0xa748a6be Instance;
}