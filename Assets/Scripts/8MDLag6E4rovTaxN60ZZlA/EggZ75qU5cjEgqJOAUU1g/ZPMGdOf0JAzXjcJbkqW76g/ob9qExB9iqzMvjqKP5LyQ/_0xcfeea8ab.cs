using UnityEngine;
using UnityEngine.UI;

public class _0xcfeea8ab : MonoBehaviour
{
    public bool IsShowLastPop;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int PopToShowIndex;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xdfbf8824.Instance._0x313d9b4d();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xdfbf8824.Instance._0x3e0fd508());
        else
            this.Button.onClick.AddListener(() => _0xdfbf8824.Instance._0x8e2d9485(this.PopToShowIndex));
    }

    public Button Button;
    public bool IsHideAllPops;
}