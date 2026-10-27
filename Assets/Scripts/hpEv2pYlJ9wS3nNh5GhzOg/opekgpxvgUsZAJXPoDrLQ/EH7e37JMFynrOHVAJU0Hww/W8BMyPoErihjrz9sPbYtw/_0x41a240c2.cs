using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x41a240c2 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x59a642a8.Instance._0x50418091(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x59a642a8.Instance._0x50418091(this.LoadSceneId));
    }

    public int LoadSceneId;
    public bool IsLoadCurrentScene;
    public Button Button;
}