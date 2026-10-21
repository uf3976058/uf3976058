using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The splash mark. An ABSTRACT emblem and a functional line - the app's name appears
/// nowhere on screen. The scrim is what makes the loader read as a different screen from the
/// lobby even though both sit on the same background texture.
public sealed class _0xfe15f74f : MonoBehaviour
{
    private void Start()
    {
        if (this._scrim != null)
        {
            this._scrim.color = _0x21179992.Fade(_0x21179992.BgDeep, 0.78f);
        }

        _0x32e32309.Apply(this._tagline, _0xb99e617f._0xf60c4246(new byte[22] { 149, 138, 137, 140, 150, 141, 140, 139, 130, 229, 145, 141, 128, 229, 130, 128, 136, 229, 141, 132, 137, 137 }, 197), 38f, 34f, _0x21179992.TextMuted);
        if (this._emblem == null)
        {
            return;
        }

        this._emblem.color = Color.white;
        Transform _0xf1c6feb0 = this._emblem.transform;
        _0xf1c6feb0.localScale = Vector3.one * 0.86f;
        _0xf1c6feb0.DOScale(1f, 0.55f).SetEase(Ease.OutBack).SetLink(this._emblem.gameObject);
        _0xf1c6feb0.DOScale(1.03f, 2.2f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetDelay(0.6f).SetLink(this._emblem.gameObject);
    }

    [SerializeField]
    private Image _emblem;
    private void OnDestroy()
    {
        if (this._emblem != null)
        {
            DOTween.Kill(this._emblem.transform);
        }
    }

    [SerializeField]
    private Image _scrim;
    [SerializeField]
    private TMP_Text _tagline;
}

internal static class _0xb99e617f
{
    internal static string _0xf60c4246(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}