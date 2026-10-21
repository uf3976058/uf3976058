using UnityEngine;
using UnityEngine.UI;

/// One album slot: the gem once it has been set, a hollow claw mount until then.
public sealed class _0x65ed7b11 : MonoBehaviour
{
    [SerializeField]
    private Image _icon;
    public void _0xd7a737df(Sprite _0x3d35ad31, bool _0x0ff5f0d9)
    {
        if (this._plate != null)
        {
            this._plate.color = _0x0ff5f0d9 ? _0x21179992.Fade(_0x21179992.Violet, 0.35f) : _0x21179992.Fade(_0x21179992.BgDeep, 0.80f);
        }

        if (this._icon != null)
        {
            this._icon.sprite = _0x3d35ad31;
            this._icon.enabled = _0x3d35ad31 != null;
            this._icon.color = _0x0ff5f0d9 ? Color.white : _0x21179992.Fade(Color.white, 0.45f);
        }
    }

    [SerializeField]
    private Image _plate;
}