using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x4c6c4de9 : MonoBehaviour
{
    private void Update()
    {
        this._0x72a0273f();
    }

    private Image _0xf4611c3d;
    private void _0x72a0273f()
    {
        if (this._0xf4611c3d.canvasRenderer.GetColor() != this._0x1734cef0.canvasRenderer.GetColor())
            this._0x1734cef0.canvasRenderer.SetColor(this._0xf4611c3d.canvasRenderer.GetColor());
    }

    private TMP_Text _0x1734cef0;
}