using UnityEngine;
using UnityEngine.UI;

public class _0x3ebfd358 : MonoBehaviour
{
    public bool IsPhysicsRunOnClick;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x59a642a8.Instance._0xf550d936(this.IsPhysicsRunOnClick));
    }

    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}