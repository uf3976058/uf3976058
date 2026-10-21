using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x9fdc0bee : MonoBehaviour
{
    private List<string> _0x8effc9c1 = new();
    private TMP_Text _0xb7ff9a62;
    private float _0xc0501fcd = 4;
    private float _0xf6447073 = 0.6f;
    private float _0x14ef6c3a = 1.5f;
    private AspectRatioFitter _0xe364babc;
    private void Update()
    {
        int _0xc47b6341 = 1;
        if (this._0x8effc9c1.Count > 0)
        {
            string _0xb6dbf799 = this._0xb7ff9a62.text;
            foreach (string _0xa313dfa9 in this._0x8effc9c1)
                while (_0xb6dbf799.Contains(_0xa313dfa9))
                    _0xb6dbf799 = _0xb6dbf799.Replace(_0xa313dfa9, "");
            _0xc47b6341 = _0xb6dbf799.Length;
        }
        else
        {
            _0xc47b6341 = this._0xb7ff9a62.text.Length;
        }

        float _0xc059027c = Mathf.Clamp(this._0x1b1cd4d1 + this._0xf6447073 * _0xc47b6341, this._0x14ef6c3a, this._0xc0501fcd);
        if (!Mathf.Approximately(this._0xe364babc.aspectRatio, _0xc059027c))
            this._0xe364babc.aspectRatio = _0xc059027c;
    }

    private float _0x1b1cd4d1;
}