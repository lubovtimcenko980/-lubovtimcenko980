using UnityEngine;
using UnityEngine.UI;

public class _0xb4fff388 : MonoBehaviour
{
    private Button _0x96807068;
    private bool _0xa58e4bfe;
    private void Start()
    {
        if (this._0xa58e4bfe)
            this._0x96807068.onClick.AddListener(() => _0xf397bc59.Instance._0x2a4e0fb7());
        else
            this._0x96807068.onClick.AddListener(() => _0xf397bc59.Instance._0xbd01eb3c(this._0x3468d58b));
    }

    private int _0x3468d58b;
    private void Awake()
    {
        if (this._0x96807068 == null)
            if (!this.TryGetComponent(out this._0x96807068))
                this._0x96807068 = this.GetComponentInChildren<Button>();
    }
}