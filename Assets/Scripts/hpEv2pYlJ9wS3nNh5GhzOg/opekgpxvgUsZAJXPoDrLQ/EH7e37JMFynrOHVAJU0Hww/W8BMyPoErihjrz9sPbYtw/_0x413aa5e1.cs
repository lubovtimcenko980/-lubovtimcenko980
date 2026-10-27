using UnityEngine;
using UnityEngine.UI;

public class _0x413aa5e1 : MonoBehaviour
{
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xa748a6be.Instance._0xd5c1be30();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xa748a6be.Instance._0xf0687100());
        else
            this.Button.onClick.AddListener(() => _0xa748a6be.Instance._0x1dbf829b(this.PopToShowIndex));
    }

    public bool IsShowLastPop;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    public bool IsHideAllPops;
    public int PopToShowIndex;
}