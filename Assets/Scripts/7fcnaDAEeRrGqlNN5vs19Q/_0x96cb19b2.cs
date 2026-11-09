using TMPro;
using UnityEngine;

/// The template defines more panels and pops than this game dresses, and every one it does
/// not dress keeps its placeholder copy - which is how "Lorem Ipsum" and "HEADER" ship (C.15).
///
/// This game uses its own HOW TO PLAY sheet rather than the indexed tutorial panels
/// (SETUP_OBJECT.IsTutorialEnabled stays 0), so TUTORIAL0, TUTORIAL1, TUTORIAL2, TUTORIAL3,
/// TUTORIAL4, TUTORIAL5 and TUTORIAL6 are all blanked here. The panels themselves stay in
/// place: the controllers address them by index and pulling one out breaks navigation.
public sealed class _0x96cb19b2 : MonoBehaviour
{
    private void Start()
    {
        this._0x4f72772a();
        this._0x6fd98c8c();
    }

    private void _0x4f72772a()
    {
        _0x0b32188d _0x642fbca7 = _0x0b32188d.Instance;
        if (_0x642fbca7 == null || _0x642fbca7.Panels == null)
        {
            return;
        }

        int[] _0x72a831f8 =
        {
            _0x1d80aee2._0xb61edb9b.TUTORIAL0,
            _0x1d80aee2._0xb61edb9b.TUTORIAL1,
            _0x1d80aee2._0xb61edb9b.TUTORIAL2,
            _0x1d80aee2._0xb61edb9b.TUTORIAL3,
            _0x1d80aee2._0xb61edb9b.TUTORIAL4,
            _0x1d80aee2._0xb61edb9b.TUTORIAL5,
            _0x1d80aee2._0xb61edb9b.TUTORIAL6,
            _0x1d80aee2._0xb61edb9b.EMPTY,
        };
        for (int _0x4ca44d54 = 0; _0x4ca44d54 < _0x72a831f8.Length; _0x4ca44d54++)
        {
            int _0x9635ba65 = _0x72a831f8[_0x4ca44d54];
            if (_0x9635ba65 < 0 || _0x9635ba65 >= _0x642fbca7.Panels.Count)
            {
                continue;
            }

            _0xe96ae584 _0xde5d9c36 = _0x642fbca7.Panels[_0x9635ba65];
            if (_0xde5d9c36 == null || _0xde5d9c36.Content == null)
            {
                continue;
            }

            Blank(_0xde5d9c36.Content);
        }
    }

    private void _0x6fd98c8c()
    {
        _0xdfbf8824 _0xa88468f1 = _0xdfbf8824.Instance;
        if (_0xa88468f1 == null || _0xa88468f1.Pops == null)
        {
            return;
        }

        for (int _0x88fd3f56 = 0; _0x88fd3f56 < _0xa88468f1.Pops.Count; _0x88fd3f56++)
        {
            if (_0x88fd3f56 == _0x1d80aee2._0xd6db5f57.WIN || _0x88fd3f56 == _0x1d80aee2._0xd6db5f57.LOSE || _0x88fd3f56 == _0x1d80aee2._0xd6db5f57.PAUSE)
            {
                continue;
            }

            _0x0a38586f _0x6d4f6a81 = _0xa88468f1.Pops[_0x88fd3f56];
            if (_0x6d4f6a81 == null || _0x6d4f6a81.Content == null)
            {
                continue;
            }

            Blank(_0x6d4f6a81.Content);
        }
    }

    private static void Blank(GameObject _0x3d7fa657)
    {
        TMP_Text[] _0x704ecb80 = _0x3d7fa657.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x8efb6de0 = 0; _0x8efb6de0 < _0x704ecb80.Length; _0x8efb6de0++)
        {
            if (_0x704ecb80[_0x8efb6de0] != null)
            {
                _0x704ecb80[_0x8efb6de0].text = "";
            }
        }
    }
}