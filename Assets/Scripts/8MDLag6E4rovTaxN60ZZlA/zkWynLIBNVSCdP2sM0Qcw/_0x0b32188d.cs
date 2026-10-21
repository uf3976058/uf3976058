using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x1d80aee2;

public class _0x0b32188d : MonoBehaviour
{
    private void _0x1f43d539(int _0x8d330f84)
    {
        this.LastPanelIndexes.Add(_0x8d330f84);
        this.CurrentPanelIndex = _0x8d330f84;
        for (int _0x8850eba5 = 0; _0x8850eba5 < this.Panels.Count; _0x8850eba5++)
            if (_0x8850eba5 != _0x8d330f84 && this.Panels[_0x8850eba5] != null)
                this.Panels[_0x8850eba5]._0x82a3d8da();
    }

    private void _0x4913a5c5(int _0x6b56dbb5)
    {
        this.LastPanelIndexes.Add(_0x6b56dbb5);
        this.CurrentPanelIndex = _0x6b56dbb5;
        for (int _0xc506cd1b = 0; _0xc506cd1b < this.Panels.Count; _0xc506cd1b++)
            if (_0xc506cd1b != _0x6b56dbb5 && this.Panels[_0xc506cd1b] != null)
                this.Panels[_0xc506cd1b]._0x82a3d8da();
    }

    private _0xe96ae584 _0x9c779d71(int _0x150c10f2)
    {
        return this.Panels[_0x150c10f2];
    }

    private void _0x729b0a55()
    {
        this._0x158922f6(_0xb61edb9b.SPLASH);
        if (_0xf44d047f.Instance._0x0583ccf6 == _0x6bf6c866.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x96c5878b.Instance.DefaultAnimationTime);
        }
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x0b32188d>();
    }

    public void _0x1d843820(int _0x2fb5b30b)
    {
        this._0x1f43d539(_0x2fb5b30b);
        this._0x07cf1d13(_0x2fb5b30b);
        this.CurrentPanelIndex = _0x2fb5b30b;
        this.Panels[_0x2fb5b30b].Show();
    }

    public void _0xd8ba69fa()
    {
        this.LastPanelIndexes.RemoveAll(_0x6eaade3d => _0x6eaade3d == this.CurrentPanelIndex);
        int _0x1381ebe9 = this.LastPanelIndexes.Last();
        this._0x07cf1d13(_0x1381ebe9);
        this._0x4913a5c5(_0x1381ebe9);
        this.CurrentPanelIndex = _0x1381ebe9;
        this.Panels[_0x1381ebe9].Show();
    }

    private void Start()
    {
        this._0x729b0a55();
    }

    private void _0x07cf1d13(int _0xc368c0ce)
    {
        if (_0xc368c0ce == _0xb61edb9b.SPLASH)
            _0x96c5878b.Instance._0x08d2bd66();
        if (_0xf44d047f.Instance._0x0583ccf6 == _0x6bf6c866.SCENE_0)
        {
        }
    }

    public List<_0xe96ae584> Panels;
    public float ScaleDuration = 0.4f;
    public float StaticBlurMaterialInitialValue;
    public bool IsShowSplashOnStart = true;
    private void _0x158922f6(int _0x668d2a7f)
    {
        this._0x1f43d539(_0x668d2a7f);
        this._0x07cf1d13(_0x668d2a7f);
        this.CurrentPanelIndex = _0x668d2a7f;
        this.Panels[_0x668d2a7f]._0x67e392d8();
    }

    private void SwitchSplash()
    {
        if (_0xdd7c4427.Instance.IsTutorialEnabled && !_0xf44d047f._0xbca4d9b4._0xd99c9211)
            this._0x1d843820(_0xb61edb9b.TUTORIAL0);
        else
            this._0x1d843820(_0xb61edb9b.DEFAULT);
    }

    public static _0x0b32188d Instance;
    public int CurrentPanelIndex;
    public void _0x5cb3c2a2(int _0x0322717b)
    {
        if (_0x0322717b == _0xb61edb9b.SPLASH && _0xf44d047f.Instance._0x0583ccf6 != _0x6bf6c866.SCENE_0)
            _0x96c5878b.Instance._0x7dae460d();
        if (_0xf44d047f.Instance._0x0583ccf6 != _0x6bf6c866.SCENE_0)
        {
            if (_0x0322717b == _0xb61edb9b.SPLASH || _0x0322717b == _0xb61edb9b.TUTORIAL0)
                _0xf44d047f.Instance._0xf238399e(false);
            else if (_0x0322717b == _0xb61edb9b.DEFAULT)
                _0xf44d047f.Instance._0xf238399e(true);
        }
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
}