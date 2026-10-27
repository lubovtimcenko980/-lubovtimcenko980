using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xd5dc767b : MonoBehaviour
{
    private TMP_Text _0xbb58a0ba;
    private List<string> _0x9485145b = new();
    private float _0x455d8623 = 0.6f;
    private float _0x5e4deae8 = 4;
    private AspectRatioFitter _0xad9733e0;
    private void Update()
    {
        int _0x8fb3783e = 1;
        if (this._0x9485145b.Count > 0)
        {
            string _0x44a87914 = this._0xbb58a0ba.text;
            foreach (string _0x5e29660a in this._0x9485145b)
                while (_0x44a87914.Contains(_0x5e29660a))
                    _0x44a87914 = _0x44a87914.Replace(_0x5e29660a, "");
            _0x8fb3783e = _0x44a87914.Length;
        }
        else
        {
            _0x8fb3783e = this._0xbb58a0ba.text.Length;
        }

        float _0x3b308fc8 = Mathf.Clamp(this._0x0325b07a + this._0x455d8623 * _0x8fb3783e, this._0x80c2fed7, this._0x5e4deae8);
        if (!Mathf.Approximately(this._0xad9733e0.aspectRatio, _0x3b308fc8))
            this._0xad9733e0.aspectRatio = _0x3b308fc8;
    }

    private float _0x0325b07a;
    private float _0x80c2fed7 = 1.5f;
}