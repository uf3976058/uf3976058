using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x96c5878b : MonoBehaviour
{
    public float SecondPassSliderValue = 0.5f;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x1d80aee2._0x6bf6c866.SCENE_0 && !_0xe475b4a1)
        {
            this._0x8138440d();
        }
        else
        {
            this._0x7dae460d();
        }
    }

    public void _0x08d2bd66()
    {
        this._0x8d8cb009?.Kill();
        this.AnimationSlider.value = _0xe475b4a1 ? this.SecondPassSliderValue : 0.05f;
    }

    public void _0xe238b6b8()
    {
        this._0x8d8cb009?.Pause();
    }

    private static bool _0xe475b4a1 = false;
    public GameObject Error;
    public void _0x8f5ba30c()
    {
        this._0x8d8cb009?.Play();
    }

    public void _0x7dae460d()
    {
        this._0x08d2bd66();
        bool _0x5181d0a6 = _0xe475b4a1;
        this._0x8d8cb009 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x9c3cf397 => this.AnimationSlider.value = _0x9c3cf397, _0x5181d0a6 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xe475b4a1 = !_0xe475b4a1;
    }

    public GameObject Content;
    public float DefaultAnimationTime = 0.4f;
    public void _0x08a08079()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x8d8cb009?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xe475b4a1 = false;
    }

    public Slider AnimationSlider;
    private void _0x8138440d()
    {
        this.AnimationSlider.value = 0.05f;
        _0xe475b4a1 = !_0xe475b4a1;
        this._0x8d8cb009 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x9c3cf397 => this.AnimationSlider.value = _0x9c3cf397, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xe27b2536._0x25d86ebb?._0x272db0dc();
        });
    }

    public GameObject Background;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x96c5878b>();
    }

    public static _0x96c5878b Instance;
    private Sequence _0x8d8cb009;
    public float FirstAnimationTime = 10.0f;
}