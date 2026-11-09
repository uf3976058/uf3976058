using UnityEngine;
using UnityEngine.UI;

public class _0xdcace1c8 : MonoBehaviour
{
    public int NextTutorialPanelIndex;
    public int EndTutorialPanelIndex = 1;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x0b32188d.Instance._0x1d843820(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xf44d047f.Instance._0xf7cd9b71());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x0b32188d.Instance._0x1d843820(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x0b32188d.Instance._0x1d843820(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xf44d047f.Instance._0xf7cd9b71());
        }
    }

    public Button TutorialEndButton;
    public Button NextTutorialButton;
    public bool IsTutorialEndPanel;
}