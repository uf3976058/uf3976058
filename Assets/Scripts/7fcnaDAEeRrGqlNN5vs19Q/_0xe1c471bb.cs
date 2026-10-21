using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Dresses the three template pops - WIN 7, LOSE 8, PAUSE 6 - in this game's words and
/// colours, including the pieces a text-only pass leaves behind (C.3 / C.17):
///
/// * the close cross gets ITS OWN sprite through a serialized reference and NO caption. The
///   template leaves that Image unset, which Unity draws as a white square;
/// * action buttons are told apart by the template GROUPS, not by traversal order. The cross
///   lives in TOP_BTNS and the actions in BOT_BTNS, and since names are renamed by the
///   obfuscator the groups are recognised by geometry: the cross is the small square high on
///   the card, the actions are the wide pair along its bottom edge. Each action gets its own
///   caption; the cross gets none;
/// * the static "Score:" / "Reward:" labels beside the result rows are renamed to metrics
///   this game actually has, found as the sibling of the value the pop itself drives;
/// * the pops release themselves after a while, so a capture step that lands on one still
///   moves on instead of photographing the same card five times.
///
/// Every pop button already carries a template driver (ShowPopButton / LoadSceneButton /
/// SetPhysicsRunButton), so NO listener is added here - a second handler would double-fire.
public sealed class _0xe1c471bb : MonoBehaviour
{
    private const float BodyOffsetY = 220f;
    private void _0xb13649ea(TMP_Text _0x67573d68, string _0xf565af16, string _0xdfe8f43f, Color _0xcc67f29d)
    {
        if (_0x67573d68 == null)
        {
            return;
        }

        _0x67573d68.gameObject.SetActive(true);
        _0x32e32309.Apply(_0x67573d68, _0xdfe8f43f, 56f, 40f, _0xcc67f29d);
        Transform _0xd444f19e = _0x67573d68.transform.parent;
        if (_0xd444f19e == null)
        {
            return;
        }

        // The label is the sibling of the value - a template "Score:" / "Reward:" caption that
        // names a metric this game does not have. Renamed, never left empty beside a number.
        TMP_Text[] _0xddf3f3a5 = _0xd444f19e.GetComponentsInChildren<TMP_Text>(true);
        for (int _0xa61d5f5c = 0; _0xa61d5f5c < _0xddf3f3a5.Length; _0xa61d5f5c++)
        {
            if (_0xddf3f3a5[_0xa61d5f5c] == _0x67573d68)
            {
                continue;
            }

            _0x32e32309.Apply(_0xddf3f3a5[_0xa61d5f5c], _0xf565af16, 40f, 34f, _0x21179992.TextMuted);
        }
    }

    private void _0x99986916(Button _0x8e466fa2, string _0x7504e70d, Color _0xf10491bd)
    {
        if (_0x8e466fa2 == null)
        {
            return;
        }

        TMP_Text[] _0xf8e342f3 = _0x8e466fa2.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x2c88cdc9 = 0; _0x2c88cdc9 < _0xf8e342f3.Length; _0x2c88cdc9++)
        {
            _0xf8e342f3[_0x2c88cdc9].gameObject.SetActive(true);
            _0x32e32309.Apply(_0xf8e342f3[_0x2c88cdc9], _0x2c88cdc9 == 0 ? _0x7504e70d : "", 44f, 34f, _0xf10491bd);
        }
    }

    /// A result pop must not hold the screen forever: the review capture taps on a timer.
    private void _0xcc5d5ccd()
    {
        if (_0xdfbf8824.Instance == null)
        {
            return;
        }

        if (_0xdfbf8824.Instance.CurrentPopIndex == _0x1d80aee2._0xd6db5f57.PAUSE)
        {
            return;
        }

        _0xdfbf8824.Instance._0x3e0fd508();
        if (_0xf44d047f.Instance != null && !_0xf44d047f.Instance._0x892b5715)
        {
            _0xf44d047f.Instance._0xf238399e(true);
        }
    }

    public void _0xb8a39f0b(int _0xdf61d0c2, int _0x0bcfd8be)
    {
        _0x0a38586f _0xd6ff8511 = _0xdfbf8824.Instance._0x8b7bda89(_0x1d80aee2._0xd6db5f57.LOSE);
        this._0x81d8821c(_0xd6ff8511, _0x846ef663._0x8c3048d2(new byte[18] { 89, 69, 72, 45, 91, 76, 88, 65, 89, 45, 68, 94, 45, 72, 64, 93, 89, 84 }, 13), _0x846ef663._0x8c3048d2(new byte[15] { 67, 95, 82, 55, 95, 86, 91, 91, 55, 80, 69, 86, 89, 67, 68 }, 23) + _0x846ef663._0x8c3048d2(new byte[1] { 5 }, 15) + _0x32e32309.Coins(_0xdf61d0c2) + _0x846ef663._0x8c3048d2(new byte[15] { 235, 136, 132, 158, 153, 159, 142, 152, 146, 235, 136, 132, 130, 133, 152 }, 203), _0x21179992.Mint, "", _0x846ef663._0x8c3048d2(new byte[7] { 96, 117, 102, 105, 115, 98, 99 }, 39), _0x846ef663._0x8c3048d2(new byte[1] { 246 }, 221) + _0x32e32309.Coins(_0xdf61d0c2), _0x846ef663._0x8c3048d2(new byte[7] { 139, 136, 133, 136, 135, 138, 140 }, 201), _0x32e32309.Coins(_0x0bcfd8be));
        this._0x76aeee8c(_0xd6ff8511, _0x846ef663._0x8c3048d2(new byte[13] { 65, 79, 79, 90, 42, 89, 90, 67, 68, 68, 67, 68, 77 }, 10), _0x846ef663._0x8c3048d2(new byte[8] { 161, 163, 171, 198, 174, 167, 170, 170 }, 230));
        _0xdfbf8824.Instance._0x8e2d9485(_0x1d80aee2._0xd6db5f57.LOSE);
        this._0xf5bbefb8();
    }

    private bool _0xd64fef62;
    private void _0x81d8821c(_0x0a38586f _0xac873e13, string _0x6893f8a1, string _0x40a70875, Color _0xc11f69c7, string _0xd8aa1df9, string _0x5c16c399, string _0x16d2136c, string _0xdc5c5c67, string _0x5cf079a0)
    {
        if (_0xac873e13 == null)
        {
            return;
        }

        // Building into a pop body that Pop.Awake left switched off gives TMP labels with no
        // font asset, and reading their material throws before ShowPop is ever reached.
        if (_0xac873e13.Content != null)
        {
            _0xac873e13.Content.SetActive(true);
            DOTween.Kill(_0xac873e13.Content.transform);
            _0xac873e13.Content.transform.localScale = Vector3.zero;
        }

        _0x32e32309.Apply(_0xac873e13.ContentHeaderText, _0x6893f8a1, 96f, 56f, _0x21179992.Gold);
        this._0x5278c4ae(_0xac873e13.ContentHeaderText, HeaderOffsetY, 1000f, 130f);
        string _0xbbcd0a33 = string.IsNullOrEmpty(_0xd8aa1df9) ? _0x40a70875 : _0x40a70875 + _0x846ef663._0x8c3048d2(new byte[1] { 44 }, 38) + _0xd8aa1df9;
        if (_0xac873e13.ContentAdditionalText == null || string.IsNullOrEmpty(_0x5c16c399))
        {
            // No second slot on this pop instance - merge rather than lose half the body.
            _0x32e32309.Apply(_0xac873e13.ContentMainText, _0xbbcd0a33, 56f, 40f, _0xc11f69c7);
            this._0x5278c4ae(_0xac873e13.ContentMainText, PauseBodyOffsetY, 1000f, 320f);
            this._0x5c33cee4(_0xac873e13);
            return;
        }

        this._0x128954f5(_0xac873e13, _0xbbcd0a33, _0xc11f69c7);
        this._0xb13649ea(_0xac873e13.ContentMainText, _0x5c16c399, _0x16d2136c, _0x21179992.Mint);
        this._0xb13649ea(_0xac873e13.ContentAdditionalText, _0xdc5c5c67, _0x5cf079a0, _0x21179992.Gold);
        this._0xef512936(_0xac873e13.ContentMainText);
        this._0x5c33cee4(_0xac873e13);
    }

    private const float CrossMaxWidth = 320f;
    private const float ActionMinWidth = 380f;
    public bool _0xa18b76a6
    {
        get
        {
            return this._0xd64fef62;
        }
    }

    /// The template's own result rows hold the numbers; the sentence above them is this
    /// game's, so it is added once and reused.
    private void _0x128954f5(_0x0a38586f _0xb85d3ce3, string _0xf4bad3b1, Color _0x6800025e)
    {
        TMP_Text _0x3b5ce6ba = _0xb85d3ce3.ContentHeaderText;
        if (_0x3b5ce6ba == null)
        {
            return;
        }

        Transform _0x73d9e568 = _0x3b5ce6ba.transform.parent;
        TMP_Text _0x738692f8 = null;
        for (int _0x10e7d8d3 = 0; _0x10e7d8d3 < _0x73d9e568.childCount; _0x10e7d8d3++)
        {
            TMP_Text _0xe2511bf2 = _0x73d9e568.GetChild(_0x10e7d8d3).GetComponent<TMP_Text>();
            if (_0xe2511bf2 != null && _0xe2511bf2 != _0x3b5ce6ba && _0xe2511bf2 != _0xb85d3ce3.ContentMainText && _0xe2511bf2 != _0xb85d3ce3.ContentAdditionalText)
            {
                _0x738692f8 = _0xe2511bf2;
                break;
            }
        }

        if (_0x738692f8 == null)
        {
            GameObject _0x2ae4dcda = Instantiate(_0x3b5ce6ba.gameObject, _0x73d9e568, false);
            _0x738692f8 = _0x2ae4dcda.GetComponent<TMP_Text>();
        }

        if (_0x738692f8 == null)
        {
            return;
        }

        _0x738692f8.gameObject.SetActive(true);
        _0x32e32309.Apply(_0x738692f8, _0xf4bad3b1, 52f, 38f, _0x6800025e);
        this._0x5278c4ae(_0x738692f8, BodyOffsetY, 1000f, 200f);
    }

    private const float HeaderOffsetY = 380f;
    private const float PauseBodyOffsetY = 85f;
    /// The header ships anchored to the card's top EDGE, so half of it hangs over the frame.
    private void _0x5278c4ae(TMP_Text _0xf484456e, float _0x0cf1ca6b, float width, float height)
    {
        if (_0xf484456e == null)
        {
            return;
        }

        RectTransform _0xa3cf58de = _0xf484456e.rectTransform;
        _0xa3cf58de.anchorMin = new Vector2(0.5f, 0.5f);
        _0xa3cf58de.anchorMax = new Vector2(0.5f, 0.5f);
        _0xa3cf58de.pivot = new Vector2(0.5f, 0.5f);
        _0xa3cf58de.sizeDelta = new Vector2(width, height);
        _0xa3cf58de.anchoredPosition = new Vector2(0f, _0x0cf1ca6b);
    }

    [SerializeField]
    private Sprite _closeIcon;
    private const float ResultsOffsetY = -55f;
    private void _0xef512936(TMP_Text _0x610f5607)
    {
        if (_0x610f5607 == null)
        {
            return;
        }

        Transform _0x0a4af993 = _0x610f5607.transform.parent;
        Transform _0xba62a439 = _0x0a4af993 == null ? null : _0x0a4af993.parent;
        RectTransform _0x8209625f = _0xba62a439 as RectTransform;
        if (_0x8209625f == null)
        {
            return;
        }

        _0x8209625f.anchorMin = new Vector2(0.5f, 0.5f);
        _0x8209625f.anchorMax = new Vector2(0.5f, 0.5f);
        _0x8209625f.pivot = new Vector2(0.5f, 0.5f);
        _0x8209625f.anchoredPosition = new Vector2(0f, ResultsOffsetY);
    }

    /// TOP_BTNS holds the close cross, BOT_BTNS the actions. Obfuscation renames the objects,
    /// so the groups are told apart by shape: the cross is a small square, an action is wide.
    private void _0x5c33cee4(_0x0a38586f _0x5595e679)
    {
        if (_0x5595e679 == null || _0x5595e679.Content == null)
        {
            return;
        }

        Button[] _0x3af009bd = _0x5595e679.Content.GetComponentsInChildren<Button>(true);
        for (int _0x581270fa = 0; _0x581270fa < _0x3af009bd.Length; _0x581270fa++)
        {
            if (!_0x3af009bd[_0x581270fa].gameObject.activeInHierarchy)
            {
                continue; // the template ships nine spare slots per group, all switched off
            }

            RectTransform _0xce1e715b = _0x3af009bd[_0x581270fa].transform as RectTransform;
            if (_0xce1e715b == null || _0xce1e715b.rect.width > CrossMaxWidth)
            {
                continue;
            }

            TMP_Text[] _0xb3b0c5ee = _0x3af009bd[_0x581270fa].GetComponentsInChildren<TMP_Text>(true);
            for (int _0x6e652866 = 0; _0x6e652866 < _0xb3b0c5ee.Length; _0x6e652866++)
            {
                _0x32e32309.Apply(_0xb3b0c5ee[_0x6e652866], "", 40f, 34f, _0x21179992.Cream);
            }

            if (this._closeIcon == null)
            {
                continue;
            }

            Image _0xbd7d546f = null;
            for (int _0x0829f3bc = 0; _0x0829f3bc < _0xce1e715b.childCount && _0xbd7d546f == null; _0x0829f3bc++)
            {
                Image _0xfed674ca = _0xce1e715b.GetChild(_0x0829f3bc).GetComponent<Image>();
                if (_0xfed674ca != null && this._closeIcon == _0xfed674ca.sprite)
                {
                    _0xbd7d546f = _0xfed674ca;
                }
            }

            if (_0xbd7d546f == null)
            {
                GameObject _0x5e64442d = new GameObject(_0x846ef663._0x8c3048d2(new byte[9] { 244, 219, 216, 196, 210, 250, 214, 197, 220 }, 183), typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
                RectTransform _0x14b23000 = _0x5e64442d.transform as RectTransform;
                _0x14b23000.SetParent(_0xce1e715b, false);
                _0x14b23000.anchorMin = new Vector2(0.5f, 0.5f);
                _0x14b23000.anchorMax = new Vector2(0.5f, 0.5f);
                _0x14b23000.pivot = new Vector2(0.5f, 0.5f);
                _0x14b23000.sizeDelta = new Vector2(92f, 92f);
                _0x14b23000.anchoredPosition = Vector2.zero;
                _0xbd7d546f = _0x5e64442d.GetComponent<Image>();
                _0xbd7d546f.raycastTarget = false;
                _0xbd7d546f.preserveAspect = true;
            }

            _0xbd7d546f.preserveAspect = true; // the glyph is square; never let the slot stretch it
            _0xbd7d546f.sprite = this._closeIcon;
            _0xbd7d546f.color = _0x21179992.Gold;
            this._0xd64fef62 = true;
        }
    }

    /// One caption per action button, by group and never by traversal order: the left-hand
    /// action sits at the lower x, the right-hand one at the higher.
    private void _0x76aeee8c(_0x0a38586f _0xb4fd3990, string _0xb7317c45, string _0x0e241328)
    {
        if (_0xb4fd3990 == null || _0xb4fd3990.Content == null)
        {
            return;
        }

        Button[] _0x789a4861 = _0xb4fd3990.Content.GetComponentsInChildren<Button>(true);
        Button _0xf42ade41 = null;
        Button _0x55057824 = null;
        float _0xcd795e42 = 0f;
        float _0xb005986c = 0f;
        for (int _0xbbbe331c = 0; _0xbbbe331c < _0x789a4861.Length; _0xbbbe331c++)
        {
            if (!_0x789a4861[_0xbbbe331c].gameObject.activeInHierarchy)
            {
                continue; // only the one live slot in each group carries a caption
            }

            RectTransform _0x2a96c6b9 = _0x789a4861[_0xbbbe331c].transform as RectTransform;
            if (_0x2a96c6b9 == null || _0x2a96c6b9.rect.width < ActionMinWidth)
            {
                continue;
            }

            float _0xff8fb66c = _0x2a96c6b9.position.x;
            if (_0xf42ade41 == null || _0xff8fb66c < _0xcd795e42)
            {
                _0xf42ade41 = _0x789a4861[_0xbbbe331c];
                _0xcd795e42 = _0xff8fb66c;
            }

            if (_0x55057824 == null || _0xff8fb66c > _0xb005986c)
            {
                _0x55057824 = _0x789a4861[_0xbbbe331c];
                _0xb005986c = _0xff8fb66c;
            }
        }

        this._0x99986916(_0x55057824, _0xb7317c45, _0x21179992.Cream);
        if (_0xf42ade41 != _0x55057824)
        {
            this._0x99986916(_0xf42ade41, _0x0e241328, _0x21179992.Gold);
        }
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    public void _0x584b4d51(int _0xec56cf3e, int _0x44add0ae, int _0x66fe9bc3)
    {
        _0x0a38586f _0x7d506b7b = _0xdfbf8824.Instance._0x8b7bda89(_0x1d80aee2._0xd6db5f57.PAUSE);
        this._0x81d8821c(_0x7d506b7b, _0x846ef663._0x8c3048d2(new byte[6] { 219, 202, 222, 216, 206, 207 }, 139), _0x846ef663._0x8c3048d2(new byte[8] { 101, 102, 107, 102, 105, 100, 98, 7 }, 39) + _0x32e32309.Coins(_0xec56cf3e) + _0x846ef663._0x8c3048d2(new byte[1] { 214 }, 220) + _0x846ef663._0x8c3048d2(new byte[4] { 23, 16, 1, 117 }, 85) + _0x32e32309.Coins(_0x44add0ae) + _0x846ef663._0x8c3048d2(new byte[1] { 209 }, 219) + _0x846ef663._0x8c3048d2(new byte[6] { 60, 63, 38, 33, 60, 79 }, 111) + _0x66fe9bc3, _0x21179992.Cream, "", "", "", "", "");
        this._0x76aeee8c(_0x7d506b7b, _0x846ef663._0x8c3048d2(new byte[6] { 74, 93, 75, 77, 85, 93 }, 24), _0x846ef663._0x8c3048d2(new byte[8] { 252, 254, 246, 155, 243, 250, 247, 247 }, 187));
        _0xf44d047f.Instance._0xf238399e(false);
        _0xdfbf8824.Instance._0x8e2d9485(_0x1d80aee2._0xd6db5f57.PAUSE);
    }

    public void _0xed68928c(int _0xca48bbc7, int _0x80c59485, int _0x64dab868)
    {
        _0x0a38586f _0x36e0005d = _0xdfbf8824.Instance._0x8b7bda89(_0x1d80aee2._0xd6db5f57.WIN);
        this._0x81d8821c(_0x36e0005d, _0x846ef663._0x8c3048d2(new byte[7] { 209, 218, 212, 179, 196, 218, 221 }, 147), _0x846ef663._0x8c3048d2(new byte[1] { 181 }, 158) + _0x32e32309.Coins(_0xca48bbc7) + _0x846ef663._0x8c3048d2(new byte[6] { 250, 153, 149, 147, 148, 137 }, 218), _0x21179992.Gold, _0x80c59485 + _0x846ef663._0x8c3048d2(new byte[10] { 66, 58, 67, 85, 79, 72, 58, 88, 95, 78 }, 26), _0x846ef663._0x8c3048d2(new byte[3] { 223, 193, 198 }, 136), _0x32e32309.Coins(_0xca48bbc7), _0x846ef663._0x8c3048d2(new byte[7] { 212, 215, 218, 215, 216, 213, 211 }, 150), _0x32e32309.Coins(_0x64dab868));
        this._0x76aeee8c(_0x36e0005d, _0x846ef663._0x8c3048d2(new byte[10] { 41, 42, 51, 52, 90, 59, 61, 59, 51, 52 }, 122), _0x846ef663._0x8c3048d2(new byte[8] { 229, 231, 239, 130, 234, 227, 238, 238 }, 162));
        _0xdfbf8824.Instance._0x8e2d9485(_0x1d80aee2._0xd6db5f57.WIN);
        this._0xf5bbefb8();
    }

    private void _0xf5bbefb8()
    {
        DOVirtual.DelayedCall(_0xafff65e6.PopAutoRelease, () => this._0xcc5d5ccd()).SetLink(this.gameObject);
    }
}

internal static class _0x846ef663
{
    internal static string _0x8c3048d2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}