using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// One symbol cell of a reel strip. The plate is the cell backing, the icon is the gem.
public sealed class _0x584aa2cd : MonoBehaviour
{
    [SerializeField]
    private Image _plate;
    public void _0xb0a27e36()
    {
        if (this._plate != null)
        {
            this._plate.color = _0x21179992.Fade(_0x21179992.BgPanelHi, 0.55f);
        }

        this.transform.localScale = Vector3.one;
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    public RectTransform _0xa9bc7377
    {
        get
        {
            if (this._0xd0eda6cf == null)
            {
                this._0xd0eda6cf = this.transform as RectTransform;
            }

            return this._0xd0eda6cf;
        }
    }

    private RectTransform _0xd0eda6cf;
    [SerializeField]
    private Image _icon;
    public void Show(int _0x04454ebd, Sprite _0xdbce4bae)
    {
        this._0x494565aa = _0x04454ebd;
        if (this._icon != null)
        {
            this._icon.sprite = _0xdbce4bae;
            this._icon.enabled = _0xdbce4bae != null;
        }

        this._0xb0a27e36();
    }

    /// Seats the cell on the strip. `y` is the distance DOWN from the top edge of the strip,
    /// which only holds if the cell is anchored to that top edge: the strip is taller than the
    /// reel window and hangs below it, so a centre-anchored cell would be seated against the
    /// strip's midpoint and the whole column would sit half a strip too low.
    public void _0x13d972e2(float _0xeb15c831)
    {
        RectTransform _0x43fe5787 = this._0xa9bc7377;
        if (_0x43fe5787 == null)
        {
            return;
        }

        _0x43fe5787.anchorMin = new Vector2(0.5f, 1f);
        _0x43fe5787.anchorMax = new Vector2(0.5f, 1f);
        _0x43fe5787.pivot = new Vector2(0.5f, 0.5f);
        _0x43fe5787.anchoredPosition = new Vector2(0f, _0xeb15c831);
    }

    private int _0x494565aa = -1;
    public int _0x1606c3f6
    {
        get
        {
            return this._0x494565aa;
        }
    }

    /// A winning cell brightens and breathes, so a paid line reads on a still frame.
    public void _0xdc01e924(Color _0x502e718a, bool _0xac1b5073)
    {
        if (this._plate != null)
        {
            this._plate.color = _0x21179992.Fade(_0x502e718a, 0.85f);
        }

        DOTween.Kill(this.transform);
        this.transform.localScale = Vector3.one;
        if (_0xac1b5073)
        {
            return;
        }

        this.transform.DOScale(1.12f, 0.22f).SetEase(Ease.InOutSine).SetLoops(4, LoopType.Yoyo).SetLink(this.gameObject);
    }
}