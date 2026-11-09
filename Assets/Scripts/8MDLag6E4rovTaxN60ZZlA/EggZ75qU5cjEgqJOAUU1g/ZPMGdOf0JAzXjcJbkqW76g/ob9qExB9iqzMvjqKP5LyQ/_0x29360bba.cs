using UnityEngine;
using UnityEngine.UI;

public class _0x29360bba : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xf44d047f.Instance._0xf238399e(this.IsPhysicsRunOnClick));
    }

    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
}