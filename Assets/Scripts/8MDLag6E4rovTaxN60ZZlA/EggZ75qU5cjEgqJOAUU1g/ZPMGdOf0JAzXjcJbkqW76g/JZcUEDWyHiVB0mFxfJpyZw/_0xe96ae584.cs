using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xe96ae584 : MonoBehaviour
{
    public void _0x82a3d8da()
    {
        this._0xdcc5fd6c();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public Ease Ease = Ease.OutSine;
    private bool _0x9529b428 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0x0596619b()
    {
        if (this.OuterBackground != null)
        {
            Image _0x2fda0d76 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x2fda0d76, true);
            _0x2fda0d76.DOFade(1f, 0f);
        }
    }

    public TMP_Text HeaderText;
    public bool IsScaledDownOnAwake = true;
    public void Show()
    {
        this._0xf4ecda05();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x0b32188d.Instance._0x5cb3c2a2(_0x0b32188d.Instance.CurrentPanelIndex);
            });
        }
    }

    public GameObject Content;
    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x5b396ffc();
    }

    private void _0x5b396ffc()
    {
        if (this.OuterBackground != null)
        {
            Image _0xe5c2fa7b = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xe5c2fa7b, true);
            _0xe5c2fa7b.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private void _0xdcc5fd6c()
    {
        if (this.OuterBackground != null)
        {
            Image _0x3b3ce090 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x3b3ce090, true);
            _0x3b3ce090.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0xf4ecda05()
    {
        if (this.OuterBackground != null)
        {
            Image _0x0b11525e = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x0b11525e, true);
            _0x0b11525e.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public void _0x67e392d8()
    {
        this._0x0596619b();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x0b32188d.Instance._0x5cb3c2a2(_0x0b32188d.Instance.CurrentPanelIndex);
    }

    public GameObject OuterBackground;
    public TMP_Text MainText;
}