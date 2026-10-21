using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xdc34c00a : MonoBehaviour
{
    private void _0x119ca58c()
    {
        if (this._0x8edad9f1.canvasRenderer.GetColor() != this._0xe32040bc.canvasRenderer.GetColor())
            this._0xe32040bc.canvasRenderer.SetColor(this._0x8edad9f1.canvasRenderer.GetColor());
    }

    private TMP_Text _0xe32040bc;
    private Image _0x8edad9f1;
    private void Update()
    {
        this._0x119ca58c();
    }
}