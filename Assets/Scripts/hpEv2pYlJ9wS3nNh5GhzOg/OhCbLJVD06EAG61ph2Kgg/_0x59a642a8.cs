using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x5a9a28e3;

public class _0x59a642a8 : MonoBehaviour
{
    [HideInInspector]
    public List<_0xeb84bc8f> MoneyCountContainers = new();
    public void _0x50418091(int _0x0b4be9d7)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x7bedc761(_0x0b4be9d7));
    }

    public Canvas MainCanvas;
    public static _0x59a642a8 Instance;
    private static void ExitGame()
    {
        Application.Quit();
    }

    public Transform EnvironmentWithTweensToToggle;
    public Button ShowResetTutorialButton;
    private void Start()
    {
        if (this._0x609d206a != _0x52964cd5.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x50418091(_0x52964cd5.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x0f3156ff._0x846ba247 = false;
            _0xa748a6be.Instance._0xf0687100();
            _0xf397bc59.Instance._0xbd01eb3c(_0x379e6670.TUTORIAL0);
        });
    }

    public bool _0xdb5e484e { get; private set; }
    private static _0x68154f29 _0x9f09c74a => _0x68154f29.ALL_SCENES_SETTING_SINGLETONS[0];

    private void _0xe8e58022(Transform _0xe9c490d1)
    {
        Transform[] _0x94084b55 = _0xe9c490d1.GetComponentsInChildren<Transform>();
        foreach (Transform _0x0eeabc4a in _0x94084b55)
            if (_0x0eeabc4a != null && DOTween.IsTweening(_0x0eeabc4a))
            {
                if (this._0xdb5e484e)
                    DOTween.Play(_0x0eeabc4a);
                else
                    DOTween.Pause(_0x0eeabc4a);
            }
    }

    public static bool IsAfterLevelFailed = false;
    public static _0x68154f29 _0x0f3156ff => _0x68154f29.ALL_SCENES_SETTING_SINGLETONS[Instance._0x609d206a];

    public Button DeleteProgressDataButton;
    private void _0xfeaaa67f()
    {
        IsAfterLevelComplete = true;
        Instance._0x50418091(_0x52964cd5.SCENE_0);
    }

    private IEnumerator _0x5e94a7fe(string _0x3e8fe5c6)
    {
        _0xf397bc59.Instance._0xbd01eb3c(_0x379e6670.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x27eb7f6f = SceneManager.LoadSceneAsync(_0x3e8fe5c6);
        while (!_0x27eb7f6f.isDone)
            yield return null;
    }

    public static bool IsAfterLevelComplete;
    public void _0xf550d936(bool _0x3417db67)
    {
        this._0xdb5e484e = _0x3417db67;
        this._0x594cbe89(!this._0xdb5e484e);
        Physics2D.simulationMode = this._0xdb5e484e ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xe8e58022(this.EnvironmentWithTweensToToggle);
    }

    private static _0x68154f29 GAME_INDEX_SETTINGS(int _0x62938d75)
    {
        return _0x68154f29.ALL_SCENES_SETTING_SINGLETONS[_0x62938d75];
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private IEnumerator _0x7bedc761(int _0x39650d03)
    {
        _0xf397bc59.Instance._0xbd01eb3c(_0x379e6670.SPLASH);
        AsyncOperation _0x512ab93a = SceneManager.LoadSceneAsync(_0x39650d03);
        while (!_0x512ab93a.isDone)
            yield return null;
    }

    public void _0xc267ad97()
    {
        _0x0f3156ff._0x846ba247 = true;
    }

    public int _0x609d206a => SceneManager.GetActiveScene().buildIndex;

    private void _0x594cbe89(bool _0xeced687c)
    {
        Rigidbody2D[] _0xf98458eb = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xc1f4c21a in _0xf98458eb)
            if (_0xeced687c)
                _0xc1f4c21a.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xc1f4c21a.constraints = RigidbodyConstraints2D.None;
    }

    public void _0xfc8a6b05()
    {
        this._0x50418091(SceneManager.GetActiveScene().buildIndex);
    }

    public Transform Environment;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x59a642a8>();
        this.RootGameObject = GameObject.FindWithTag(_0x2c742d0c._0xafe4df9f(new byte[4] { 20, 41, 41, 50 }, 70));
        if (this._0x609d206a == _0x52964cd5.SCENE_0)
            this._0xf550d936(true);
        else
            this._0xf550d936(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xeb84bc8f>(true).ToList();
    }

    private static void MakeGrid(List<RectTransform> _0x14f066e8, AspectRatioFitter _0x1c896507, float _0xc0d52194, int _0xf625cfb8, int _0x663f0124)
    {
        _0x1c896507.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x1c896507.aspectRatio = _0xc0d52194;
        foreach (RectTransform _0x1800eb95 in _0x14f066e8)
        {
            int _0x99b2e459 = _0x1800eb95.transform.GetSiblingIndex();
            _0x1800eb95.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x99b2e459 % _0xf625cfb8) * (1f / _0xf625cfb8), (_0x663f0124 - (Mathf.FloorToInt((float)_0x99b2e459 / _0xf625cfb8) % _0x663f0124 + 1f)) * (1f / _0x663f0124));
            _0x1800eb95.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x99b2e459 % _0xf625cfb8 + 1f) * (1f / _0xf625cfb8), (_0x663f0124 - Mathf.FloorToInt((float)_0x99b2e459 / _0xf625cfb8) % _0x663f0124) * (1f / _0x663f0124));
            _0x1800eb95.offsetMin = Vector2.zero;
            _0x1800eb95.offsetMax = Vector2.zero;
        }
    }

    public void _0x04683bb5()
    {
        foreach (_0xeb84bc8f _0x106e910e in this.MoneyCountContainers)
            _0x106e910e._0x33dfbf8b();
    }
}

internal static class _0x2c742d0c
{
    internal static string _0xafe4df9f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}