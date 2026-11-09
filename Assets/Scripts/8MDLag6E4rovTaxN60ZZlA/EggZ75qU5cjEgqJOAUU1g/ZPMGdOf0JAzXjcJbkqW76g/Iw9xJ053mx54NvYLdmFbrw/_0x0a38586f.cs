using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x0a38586f : MonoBehaviour
{
    public float scaleDuration = 0.4f;
    public TMP_Text ContentHeaderText;
    public static void HideAllPops()
    {
        _0xdfbf8824.Instance._0x3e0fd508();
    }

    private bool _0x77527447 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public bool IsOnlyYScale;
    public bool IsScaledDownOnAwake = true;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public void _0x51513397()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public Image ContentImage;
    public TMP_Text ContentAdditionalText;
    private void _0x43a3ecee()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public TMP_Text ContentMainText;
    public GameObject Content;
    public Ease ease = Ease.OutSine;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x43a3ecee();
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }
}