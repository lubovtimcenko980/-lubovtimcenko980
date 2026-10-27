using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x55aae25c : MonoBehaviour
{
    private void _0x21530b8c()
    {
        if (_0x98f3cc43.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x765ed24c => _0x765ed24c.text = $"{this.ScoreCurrent}/{this._0xd3ac8e6a}");
        else
            this.ScoreText.ForEach(_0x765ed24c => _0x765ed24c.text = $"{this.ScoreCurrent}");
    }

    private int _0x92b5b449 => this.ScoreCurrent;

    private void Awake()
    {
        _0x7176cdce = this.gameObject.GetComponent<_0x55aae25c>();
    }

    private void _0xcdfe9838()
    {
        this.TimerText.ForEach(_0x765ed24c => _0x765ed24c.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xae2c20d5._0x74b568bd(new byte[6] { 89, 89, 104, 14, 71, 71 }, 52)));
    }

    private static _0x55aae25c _0x7176cdce;
    public List<Button> PauseButtons = new();
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xb11697b3;
        this.CurrentGameIndex = _0x59a642a8.Instance._0x609d206a;
        foreach (Button _0xbacabb04 in this.HomeButtons)
            _0xbacabb04.onClick.AddListener(() =>
            {
                this._0xe6467a69();
            });
        foreach (Button _0x73d4a21e in this.PauseButtons)
            _0x73d4a21e.onClick.AddListener(() =>
            {
                _0x59a642a8.Instance._0xf550d936(false);
                _0xa748a6be.Instance._0x1dbf829b(_0x5a9a28e3._0xe57848ce.PAUSE);
            });
        this._0x21530b8c();
        this.LevelNumberText.ForEach(_0x765ed24c => _0x765ed24c.text = $"LVL {_0x59a642a8._0x0f3156ff._0x75fec8b3 + 1}");
        if (_0x98f3cc43.Instance.IsTimerEnabled)
        {
            this._0xcdfe9838();
            this.StartCoroutine(this._0xa4451219());
        }
    }

    public List<TMP_Text> TimerText = new();
    private IEnumerator _0xa4451219()
    {
        this._0xcdfe9838();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x59a642a8.Instance._0x609d206a == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x59a642a8.Instance._0xdb5e484e)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xcdfe9838();
            }
        }

        if (!this.IsGameEnd)
            this._0x07799c27();
    }

    [HideInInspector]
    public int TimeLeft;
    public List<Button> HomeButtons = new();
    public void _0x2eea6b5d()
    {
        if (!this.IsGameEnd)
        {
            this._0x62140ac5();
            _0x59a642a8.IsAfterLevelComplete = true;
            _0x59a642a8.IsAfterLevelFailed = false;
            _0x696568ef _0xea48e28b = _0xa748a6be.Instance._0x0003d531(_0x5a9a28e3._0xe57848ce.WIN).GetComponent<_0x696568ef>();
            if (_0x98f3cc43.Instance.IsCheckScoreEnabled)
                _0xea48e28b.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xd3ac8e6a}";
            else
                _0xea48e28b.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x98f3cc43.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x5a9a28e3._0xbe8fc6df._0x878e04e0)
                    _0x5a9a28e3._0xbe8fc6df._0x878e04e0 = this.ScoreCurrent;
                _0xea48e28b.ContentAdditionalText.text = $"{_0x5a9a28e3._0xbe8fc6df._0x878e04e0}";
            }
            else
            {
                _0xea48e28b.ContentAdditionalText.text = $"{this._0x92b5b449}";
                _0x5a9a28e3._0xbe8fc6df._0x878e04e0 += this._0x92b5b449;
            }

            if (_0x98f3cc43.Instance.IsLevelIncrementOnWin)
                ++_0x59a642a8._0x0f3156ff._0x75fec8b3;
            _0xa748a6be.Instance._0x1dbf829b(_0x5a9a28e3._0xe57848ce.WIN);
        }
    }

    private int _0xd3ac8e6a => this.CustomTargetScore + _0x59a642a8._0x0f3156ff._0x75fec8b3 * 10;

    private void _0xb5ff0d9a()
    {
        if (this.ScoreCurrent >= this._0xd3ac8e6a)
            this._0x2eea6b5d();
        else
            this._0x07799c27();
    }

    [HideInInspector]
    public bool IsGameEnd;
    public int CustomTimeInitial = 30;
    [HideInInspector]
    public int ScoreCurrent;
    [HideInInspector]
    public int CurrentGameIndex;
    private int _0xb11697b3 => this.CustomTimeInitial + _0x59a642a8._0x0f3156ff._0x75fec8b3 * 10;

    public void _0xe6c06182(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x21530b8c();
            this._0xcd16eed9();
        }
    }

    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> ScoreText = new();
    private void _0xcd16eed9()
    {
        if (this.ScoreCurrent > _0x59a642a8._0x0f3156ff._0x9a4de410)
            _0x59a642a8._0x0f3156ff._0x9a4de410 = this.ScoreCurrent;
        if (_0x98f3cc43.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xd3ac8e6a)
                this._0x2eea6b5d();
    }

    private void _0x62140ac5()
    {
        this.IsGameEnd = true;
        _0x59a642a8.IsAfterLevelComplete = true;
    }

    public List<TMP_Text> SubtitleText = new();
    public void _0x07799c27()
    {
        if (_0x98f3cc43.Instance.IsOnlyWinGameEndEnabled)
            this._0x2eea6b5d();
        if (!this.IsGameEnd)
        {
            this._0x62140ac5();
            _0x59a642a8.IsAfterLevelComplete = false;
            _0x59a642a8.IsAfterLevelFailed = true;
            _0x696568ef _0xd01b4c9a = _0xa748a6be.Instance._0x0003d531(_0x5a9a28e3._0xe57848ce.LOSE).GetComponent<_0x696568ef>();
            if (_0x98f3cc43.Instance.IsCheckScoreEnabled)
                _0xd01b4c9a.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xd3ac8e6a}";
            else
                _0xd01b4c9a.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xd01b4c9a.ContentAdditionalText.text = $"{0}";
            _0x5a9a28e3._0xbe8fc6df._0x878e04e0 += 0;
            _0xa748a6be.Instance._0x1dbf829b(_0x5a9a28e3._0xe57848ce.LOSE);
        }
    }

    public int CustomTargetScore = 10;
    public void _0xe6467a69()
    {
        _0x59a642a8.Instance._0xf550d936(true);
        _0x59a642a8.Instance._0x50418091(_0x5a9a28e3._0x52964cd5.SCENE_0);
    }
}

internal static class _0xae2c20d5
{
    internal static string _0x74b568bd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}