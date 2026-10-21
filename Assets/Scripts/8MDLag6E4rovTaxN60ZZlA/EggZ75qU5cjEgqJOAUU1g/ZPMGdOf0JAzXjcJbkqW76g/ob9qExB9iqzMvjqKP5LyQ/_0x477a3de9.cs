using UnityEngine;
using UnityEngine.UI;

public class _0x477a3de9 : MonoBehaviour
{
    private void Awake()
    {
        if (this._0x18d95445 == null)
            if (!this.TryGetComponent(out this._0x18d95445))
                this._0x18d95445 = this.GetComponentInChildren<Button>();
    }

    private int _0xea4b2ea1;
    private Button _0x18d95445;
    private bool _0xa06a95b2;
    private void Start()
    {
        if (this._0xa06a95b2)
            this._0x18d95445.onClick.AddListener(() => _0x0b32188d.Instance._0xd8ba69fa());
        else
            this._0x18d95445.onClick.AddListener(() => _0x0b32188d.Instance._0x1d843820(this._0xea4b2ea1));
    }
}