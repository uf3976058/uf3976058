using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x9f827aaa : MonoBehaviour
{
    [HideInInspector]
    public bool IsGameEnd;
    public int CustomTargetScore = 10;
    public void _0xe2f9fdea()
    {
        if (!this.IsGameEnd)
        {
            this._0xffac74ff();
            _0xf44d047f.IsAfterLevelComplete = true;
            _0xf44d047f.IsAfterLevelFailed = false;
            _0x0a38586f _0x63e90805 = _0xdfbf8824.Instance._0x8b7bda89(_0x1d80aee2._0xd6db5f57.WIN).GetComponent<_0x0a38586f>();
            if (_0xdd7c4427.Instance.IsCheckScoreEnabled)
                _0x63e90805.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x1b141931}";
            else
                _0x63e90805.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xdd7c4427.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x1d80aee2._0xeef67835._0x81680469)
                    _0x1d80aee2._0xeef67835._0x81680469 = this.ScoreCurrent;
                _0x63e90805.ContentAdditionalText.text = $"{_0x1d80aee2._0xeef67835._0x81680469}";
            }
            else
            {
                _0x63e90805.ContentAdditionalText.text = $"{this._0x2e6f708f}";
                _0x1d80aee2._0xeef67835._0x81680469 += this._0x2e6f708f;
            }

            if (_0xdd7c4427.Instance.IsLevelIncrementOnWin)
                ++_0xf44d047f._0xbca4d9b4._0xe64019cd;
            _0xdfbf8824.Instance._0x8e2d9485(_0x1d80aee2._0xd6db5f57.WIN);
        }
    }

    public List<TMP_Text> ScoreText = new();
    private void _0x336f8676()
    {
        if (this.ScoreCurrent >= this._0x1b141931)
            this._0xe2f9fdea();
        else
            this._0x48533bd7();
    }

    private void _0xffac74ff()
    {
        this.IsGameEnd = true;
        _0xf44d047f.IsAfterLevelComplete = true;
    }

    private void _0xde5128b6()
    {
        if (_0xdd7c4427.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x4361902b => _0x4361902b.text = $"{this.ScoreCurrent}/{this._0x1b141931}");
        else
            this.ScoreText.ForEach(_0x4361902b => _0x4361902b.text = $"{this.ScoreCurrent}");
    }

    public List<TMP_Text> SubtitleText = new();
    public List<TMP_Text> TimerText = new();
    public void _0x838ed2a8(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xde5128b6();
            this._0x0990d3f0();
        }
    }

    public void _0x48533bd7()
    {
        if (_0xdd7c4427.Instance.IsOnlyWinGameEndEnabled)
            this._0xe2f9fdea();
        if (!this.IsGameEnd)
        {
            this._0xffac74ff();
            _0xf44d047f.IsAfterLevelComplete = false;
            _0xf44d047f.IsAfterLevelFailed = true;
            _0x0a38586f _0xc1b2852d = _0xdfbf8824.Instance._0x8b7bda89(_0x1d80aee2._0xd6db5f57.LOSE).GetComponent<_0x0a38586f>();
            if (_0xdd7c4427.Instance.IsCheckScoreEnabled)
                _0xc1b2852d.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x1b141931}";
            else
                _0xc1b2852d.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xc1b2852d.ContentAdditionalText.text = $"{0}";
            _0x1d80aee2._0xeef67835._0x81680469 += 0;
            _0xdfbf8824.Instance._0x8e2d9485(_0x1d80aee2._0xd6db5f57.LOSE);
        }
    }

    private void Awake()
    {
        _0x46991acc = this.gameObject.GetComponent<_0x9f827aaa>();
    }

    private int _0x1b141931 => this.CustomTargetScore + _0xf44d047f._0xbca4d9b4._0xe64019cd * 10;

    public int CustomTimeInitial = 30;
    public void _0x8de65b3b()
    {
        _0xf44d047f.Instance._0xf238399e(true);
        _0xf44d047f.Instance._0xfa79fc65(_0x1d80aee2._0x6bf6c866.SCENE_0);
    }

    private IEnumerator _0x91b86683()
    {
        this._0x85778e52();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xf44d047f.Instance._0x0583ccf6 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xf44d047f.Instance._0x892b5715)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x85778e52();
            }
        }

        if (!this.IsGameEnd)
            this._0x48533bd7();
    }

    private int _0xfe96a3b7 => this.CustomTimeInitial + _0xf44d047f._0xbca4d9b4._0xe64019cd * 10;

    private void _0x85778e52()
    {
        this.TimerText.ForEach(_0x4361902b => _0x4361902b.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x21f42ca7._0x38505f8c(new byte[6] { 152, 152, 169, 207, 134, 134 }, 245)));
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xfe96a3b7;
        this.CurrentGameIndex = _0xf44d047f.Instance._0x0583ccf6;
        foreach (Button _0xf404b0f6 in this.HomeButtons)
            _0xf404b0f6.onClick.AddListener(() =>
            {
                this._0x8de65b3b();
            });
        foreach (Button _0x9d38bc1d in this.PauseButtons)
            _0x9d38bc1d.onClick.AddListener(() =>
            {
                _0xf44d047f.Instance._0xf238399e(false);
                _0xdfbf8824.Instance._0x8e2d9485(_0x1d80aee2._0xd6db5f57.PAUSE);
            });
        this._0xde5128b6();
        this.LevelNumberText.ForEach(_0x4361902b => _0x4361902b.text = $"LVL {_0xf44d047f._0xbca4d9b4._0xe64019cd + 1}");
        if (_0xdd7c4427.Instance.IsTimerEnabled)
        {
            this._0x85778e52();
            this.StartCoroutine(this._0x91b86683());
        }
    }

    private int _0x2e6f708f => this.ScoreCurrent;

    [HideInInspector]
    public int CurrentGameIndex;
    private void _0x0990d3f0()
    {
        if (this.ScoreCurrent > _0xf44d047f._0xbca4d9b4._0x968f49ad)
            _0xf44d047f._0xbca4d9b4._0x968f49ad = this.ScoreCurrent;
        if (_0xdd7c4427.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x1b141931)
                this._0xe2f9fdea();
    }

    [HideInInspector]
    public int TimeLeft;
    public List<Button> HomeButtons = new();
    [HideInInspector]
    public int ScoreCurrent;
    public List<TMP_Text> LevelNumberText = new();
    private static _0x9f827aaa _0x46991acc;
    public List<Button> PauseButtons = new();
}

internal static class _0x21f42ca7
{
    internal static string _0x38505f8c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}