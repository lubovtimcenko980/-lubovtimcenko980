using TMPro;
using UnityEngine;
using static _0x5a9a28e3;

public class _0xeb84bc8f : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    public void _0x33dfbf8b()
    {
        this.MoneyCountText.text = _0xbe8fc6df._0x878e04e0.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xdd3726d9;
            if (this.gameObject.TryGetComponent(out _0xdd3726d9))
                this.MoneyCountText = _0xdd3726d9;
        }

        this._0x33dfbf8b();
    }
}