using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// One settings row: a label on the left, a control on the right. Every control here changes
/// something the player can see immediately - there is no sound in these games, so there is
/// no sound row to switch (C.20).
public sealed class _0x9fd35ab1 : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    [SerializeField]
    private Image _control;
    [SerializeField]
    private TMP_Text _state;
    public void _0xfccc87ae(string _0x21794673, string _0x22ef0651, bool _0xd406f67e, System.Action _0x16edcb40)
    {
        if (this._plate != null)
        {
            this._plate.color = _0x21179992.Fade(_0x21179992.BgPanel, 0.90f);
        }

        if (this._control != null)
        {
            this._control.color = _0xd406f67e ? _0x21179992.Fade(_0x21179992.Mint, 0.85f) : _0x21179992.Fade(_0x21179992.BgDeep, 0.85f);
        }

        _0x32e32309.Apply(this._label, _0x21794673, 44f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._state, _0x22ef0651, 38f, 34f, _0xd406f67e ? _0x21179992.Mint : _0x21179992.TextMuted);
        if (this._button != null)
        {
            this._button.onClick.RemoveAllListeners();
            System.Action _0x188432de = _0x16edcb40;
            this._button.onClick.AddListener(() => _0x188432de());
        }
    }

    [SerializeField]
    private TMP_Text _label;
    [SerializeField]
    private Image _plate;
}