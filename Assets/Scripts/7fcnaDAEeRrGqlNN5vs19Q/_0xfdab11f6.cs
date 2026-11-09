using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// This game's own onboarding sheet. The template carries indexed tutorial panels, but they
/// are switched off in SETUP_OBJECT and dressing them would hijack the game scene on the way
/// in (PanelController arms SwitchSplash only outside the menu scene), so the rules are
/// explained here instead - fully themed and reachable whenever the player wants it.
public sealed class _0xfdab11f6 : MonoBehaviour
{
    [SerializeField]
    private _0x708fc31f _lobby;
    [SerializeField]
    private TMP_Text _bodyTwo;
    [SerializeField]
    private TMP_Text _playLabel;
    private void _0xb373f990()
    {
        _0xf44d047f.Instance._0xfa79fc65(_0x1d80aee2._0x6bf6c866.SCENE_1);
    }

    [SerializeField]
    private Image _cardPlate;
    [SerializeField]
    private TMP_Text _hint;
    [SerializeField]
    private TMP_Text _backLabel;
    [SerializeField]
    private TMP_Text _bodyOne;
    private void _0x0304882c()
    {
        if (this._0x1698dff3)
        {
            return;
        }

        this._0x1698dff3 = true;
        if (this._cardPlate != null)
        {
            this._cardPlate.color = _0x21179992.Fade(_0x21179992.BgPanel, 0.98f);
        }

        if (this._playPlate != null)
        {
            this._playPlate.color = _0x21179992.Violet;
        }

        _0x32e32309.Apply(this._heading, _0xe3e287f4._0x463babd1(new byte[11] { 104, 111, 119, 0, 116, 111, 0, 112, 108, 97, 121 }, 32), 72f, 48f, _0x21179992.Cream);
        _0x32e32309.Apply(this._bodyOne, _0xe3e287f4._0x463babd1(new byte[27] { 35, 54, 39, 87, 36, 39, 62, 57, 87, 54, 57, 51, 87, 35, 63, 50, 87, 49, 62, 33, 50, 87, 37, 50, 50, 59, 36 }, 119) + _0xe3e287f4._0x463babd1(new byte[1] { 156 }, 150) + _0xe3e287f4._0x463babd1(new byte[30] { 48, 55, 44, 51, 67, 55, 43, 38, 46, 48, 38, 47, 53, 38, 48, 79, 67, 47, 38, 37, 55, 67, 55, 44, 67, 49, 42, 36, 43, 55 }, 99), 44f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._bodyTwo, _0xe3e287f4._0x463babd1(new byte[29] { 81, 93, 72, 95, 84, 60, 47, 60, 83, 78, 60, 81, 83, 78, 89, 60, 90, 78, 83, 81, 60, 72, 84, 89, 60, 80, 89, 90, 72 }, 28) + _0xe3e287f4._0x463babd1(new byte[1] { 133 }, 143) + _0xe3e287f4._0x463babd1(new byte[21] { 45, 44, 66, 35, 44, 59, 66, 45, 36, 66, 54, 42, 39, 66, 87, 66, 46, 43, 44, 39, 49 }, 98), 44f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._hint, _0xe3e287f4._0x463babd1(new byte[54] { 150, 130, 149, 149, 240, 147, 159, 153, 158, 131, 240, 159, 158, 156, 137, 240, 253, 240, 158, 159, 132, 152, 153, 158, 151, 240, 152, 149, 130, 149, 240, 153, 131, 240, 146, 159, 133, 151, 152, 132, 240, 159, 130, 240, 147, 145, 131, 152, 149, 148, 240, 159, 133, 132 }, 208), 34f, 34f, _0x21179992.TextMuted);
        _0x32e32309.Apply(this._playLabel, _0xe3e287f4._0x463babd1(new byte[8] { 17, 13, 0, 24, 97, 15, 14, 22 }, 65), 48f, 34f, _0x21179992.Cream);
        _0x32e32309.Apply(this._backLabel, _0xe3e287f4._0x463babd1(new byte[12] { 229, 230, 228, 236, 135, 243, 232, 135, 239, 230, 235, 235 }, 167), 44f, 34f, _0x21179992.Cream);
        string[] _0x3e0da9e7 =
        {
            _0xe3e287f4._0x463babd1(new byte[7] { 72, 71, 80, 41, 78, 76, 68 }, 9) + _0xe3e287f4._0x463babd1(new byte[1] { 3 }, 9) + _0xe3e287f4._0x463babd1(new byte[11] { 99, 114, 106, 96, 19, 117, 97, 124, 126, 19, 0 }, 51),
            _0xe3e287f4._0x463babd1(new byte[11] { 108, 110, 117, 111, 113, 28, 111, 116, 125, 110, 120 }, 60) + _0xe3e287f4._0x463babd1(new byte[1] { 53 }, 63) + _0xe3e287f4._0x463babd1(new byte[11] { 148, 146, 133, 148, 147, 142, 147, 146, 147, 130, 148 }, 199),
            _0xe3e287f4._0x463babd1(new byte[7] { 96, 109, 98, 120, 105, 126, 98 }, 44) + _0xe3e287f4._0x463babd1(new byte[1] { 76 }, 70) + _0xe3e287f4._0x463babd1(new byte[10] { 175, 187, 172, 172, 201, 186, 185, 160, 167, 186 }, 233)
        };
        if (this._symbolCaptions != null)
        {
            for (int _0x3611eaeb = 0; _0x3611eaeb < this._symbolCaptions.Length && _0x3611eaeb < _0x3e0da9e7.Length; _0x3611eaeb++)
            {
                _0x32e32309.Apply(this._symbolCaptions[_0x3611eaeb], _0x3e0da9e7[_0x3611eaeb], 36f, 34f, _0x21179992.TextMuted);
            }
        }

        if (this._symbolArt != null)
        {
            for (int _0x172a7d41 = 0; _0x172a7d41 < this._symbolArt.Length; _0x172a7d41++)
            {
                if (this._symbolArt[_0x172a7d41] != null)
                {
                    this._symbolArt[_0x172a7d41].color = Color.white;
                }
            }
        }

        if (this._playButton != null)
        {
            this._playButton.onClick.AddListener(() => this._0xb373f990());
        }

        if (this._backButton != null)
        {
            this._backButton.onClick.AddListener(() => this._0x681eba61());
        }
    }

    public void _0x1ad2b4b5()
    {
        this._0x0304882c();
    }

    [SerializeField]
    private Button _backButton;
    [SerializeField]
    private Button _playButton;
    [SerializeField]
    private TMP_Text _heading;
    [SerializeField]
    private Image _playPlate;
    private bool _0x1698dff3;
    private void _0x681eba61()
    {
        if (this._lobby != null)
        {
            this._lobby._0x586aa695();
        }
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    [SerializeField]
    private TMP_Text[] _symbolCaptions;
    [SerializeField]
    private Image[] _symbolArt;
}

internal static class _0xe3e287f4
{
    internal static string _0x463babd1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}