using UnityEngine;
using UnityEngine.UI;

public class _0x0f76586a : MonoBehaviour
{
    public Button NextTutorialButton;
    public int EndTutorialPanelIndex = 1;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xf397bc59.Instance._0xbd01eb3c(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x59a642a8.Instance._0xc267ad97());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xf397bc59.Instance._0xbd01eb3c(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xf397bc59.Instance._0xbd01eb3c(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x59a642a8.Instance._0xc267ad97());
        }
    }

    public bool IsTutorialEndPanel;
    public Button TutorialEndButton;
    public int NextTutorialPanelIndex;
}