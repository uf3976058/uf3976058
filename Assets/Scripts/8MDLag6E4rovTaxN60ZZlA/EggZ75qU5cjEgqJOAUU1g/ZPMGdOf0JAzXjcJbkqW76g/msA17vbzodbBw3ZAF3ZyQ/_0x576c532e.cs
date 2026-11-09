using TMPro;
using UnityEngine;
using static _0x1d80aee2;

public class _0x576c532e : MonoBehaviour
{
    public void _0x53e2f21b()
    {
        this.MoneyCountText.text = _0xeef67835._0x81680469.ToString();
    }

    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x709e308c;
            if (this.gameObject.TryGetComponent(out _0x709e308c))
                this.MoneyCountText = _0x709e308c;
        }

        this._0x53e2f21b();
    }
}