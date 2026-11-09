using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// One mission row. The accent bar lives in its own gutter and the text in its own band, so
/// the two never share x-space (C.25): gutter centre -440 half-width 21, text starts at -373.
public sealed class _0xa2c1fd78 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _title;
    [SerializeField]
    private Image _track;
    [SerializeField]
    private Image _plate;
    [SerializeField]
    private TMP_Text _progress;
    public const float TrackWidth = 700f;
    [SerializeField]
    private Image _accent;
    [SerializeField]
    private RectTransform _fill;
    public void _0x71dfe221(_0xaf17bb5a _0x041b25b2)
    {
        if (_0x041b25b2 == null)
        {
            return;
        }

        int _0xe00f4ddc = _0x64c39bc0.State(_0x041b25b2);
        Color _0x71f378a8 = _0x21179992.StateAccent(_0xe00f4ddc);
        if (this._plate != null)
        {
            this._plate.color = _0x21179992.Fade(_0x21179992.BgPanel, 0.92f);
        }

        if (this._accent != null)
        {
            this._accent.color = _0x71f378a8;
        }

        _0x32e32309.Apply(this._title, _0x041b25b2.Title, 44f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._progress, _0x64c39bc0.ProgressLine(_0x041b25b2), 38f, 34f, _0xe00f4ddc >= 2 ? _0x21179992.Mint : _0x21179992.TextMuted);
        if (this._track != null)
        {
            this._track.color = _0x21179992.Fade(_0x21179992.BgDeep, 0.9f);
        }

        if (this._fill != null)
        {
            this._fill.sizeDelta = new Vector2(TrackWidth * _0x64c39bc0.Fill(_0x041b25b2), 0f);
            Image _0x5f9d4f96 = this._fill.GetComponent<Image>();
            if (_0x5f9d4f96 != null)
            {
                _0x5f9d4f96.color = _0x71f378a8;
            }
        }
    }
}