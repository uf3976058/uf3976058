using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x1d80aee2;

public class _0xf44d047f : MonoBehaviour
{
    public Button DeleteProgressDataButton;
    public void _0xe56fc769()
    {
        this._0xfa79fc65(SceneManager.GetActiveScene().buildIndex);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xf44d047f>();
        this.RootGameObject = GameObject.FindWithTag(_0x07579409._0x8f6ab16b(new byte[4] { 123, 70, 70, 93 }, 41));
        if (this._0x0583ccf6 == _0x6bf6c866.SCENE_0)
            this._0xf238399e(true);
        else
            this._0xf238399e(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x576c532e>(true).ToList();
    }

    public void _0xfa79fc65(int _0xad58adb0)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x402cc626(_0xad58adb0));
    }

    public static bool IsAfterLevelFailed = false;
    public void _0xf7cd9b71()
    {
        _0xbca4d9b4._0xd99c9211 = true;
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private void _0xc1e9f669(bool _0xab232907)
    {
        Rigidbody2D[] _0x97a1464e = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xd0fed66d in _0x97a1464e)
            if (_0xab232907)
                _0xd0fed66d.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xd0fed66d.constraints = RigidbodyConstraints2D.None;
    }

    public Transform EnvironmentWithTweensToToggle;
    private IEnumerator _0x402cc626(int _0xf35b6938)
    {
        _0x0b32188d.Instance._0x1d843820(_0xb61edb9b.SPLASH);
        AsyncOperation _0x3379b10b = SceneManager.LoadSceneAsync(_0xf35b6938);
        while (!_0x3379b10b.isDone)
            yield return null;
    }

    public Button ShowResetTutorialButton;
    public int _0x0583ccf6 => SceneManager.GetActiveScene().buildIndex;

    private IEnumerator _0xde06cb5b(string _0xbbc4958c)
    {
        _0x0b32188d.Instance._0x1d843820(_0xb61edb9b.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x34e9b8e8 = SceneManager.LoadSceneAsync(_0xbbc4958c);
        while (!_0x34e9b8e8.isDone)
            yield return null;
    }

    public static _0xe22f035d _0xbca4d9b4 => _0xe22f035d.ALL_SCENES_SETTING_SINGLETONS[Instance._0x0583ccf6];

    public Transform Environment;
    private static _0xe22f035d _0x035a2a5e => _0xe22f035d.ALL_SCENES_SETTING_SINGLETONS[0];
    public bool _0x892b5715 { get; private set; }

    public void _0xf238399e(bool _0xc5953344)
    {
        this._0x892b5715 = _0xc5953344;
        this._0xc1e9f669(!this._0x892b5715);
        Physics2D.simulationMode = this._0x892b5715 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xa95b4012(this.EnvironmentWithTweensToToggle);
    }

    public static bool IsAfterLevelComplete;
    private void Start()
    {
        if (this._0x0583ccf6 != _0x6bf6c866.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0xfa79fc65(_0x6bf6c866.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xbca4d9b4._0xd99c9211 = false;
            _0xdfbf8824.Instance._0x3e0fd508();
            _0x0b32188d.Instance._0x1d843820(_0xb61edb9b.TUTORIAL0);
        });
    }

    public void _0xa1c5329d()
    {
        foreach (_0x576c532e _0x20d0a6f3 in this.MoneyCountContainers)
            _0x20d0a6f3._0x53e2f21b();
    }

    public static _0xf44d047f Instance;
    private void _0xc2f6f4c0()
    {
        IsAfterLevelComplete = true;
        Instance._0xfa79fc65(_0x6bf6c866.SCENE_0);
    }

    public Canvas MainCanvas;
    private static void ExitGame()
    {
        Application.Quit();
    }

    [HideInInspector]
    public List<_0x576c532e> MoneyCountContainers = new();
    private static void MakeGrid(List<RectTransform> _0xad02bd6e, AspectRatioFitter _0xa0a30614, float _0x0dad77fa, int _0x4205c9bf, int _0xc65bd4d6)
    {
        _0xa0a30614.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xa0a30614.aspectRatio = _0x0dad77fa;
        foreach (RectTransform _0x495c2f86 in _0xad02bd6e)
        {
            int _0x84956b6e = _0x495c2f86.transform.GetSiblingIndex();
            _0x495c2f86.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x84956b6e % _0x4205c9bf) * (1f / _0x4205c9bf), (_0xc65bd4d6 - (Mathf.FloorToInt((float)_0x84956b6e / _0x4205c9bf) % _0xc65bd4d6 + 1f)) * (1f / _0xc65bd4d6));
            _0x495c2f86.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x84956b6e % _0x4205c9bf + 1f) * (1f / _0x4205c9bf), (_0xc65bd4d6 - Mathf.FloorToInt((float)_0x84956b6e / _0x4205c9bf) % _0xc65bd4d6) * (1f / _0xc65bd4d6));
            _0x495c2f86.offsetMin = Vector2.zero;
            _0x495c2f86.offsetMax = Vector2.zero;
        }
    }

    private void _0xa95b4012(Transform _0x09196f6c)
    {
        Transform[] _0x5b97a75f = _0x09196f6c.GetComponentsInChildren<Transform>();
        foreach (Transform _0x51b45b65 in _0x5b97a75f)
            if (_0x51b45b65 != null && DOTween.IsTweening(_0x51b45b65))
            {
                if (this._0x892b5715)
                    DOTween.Play(_0x51b45b65);
                else
                    DOTween.Pause(_0x51b45b65);
            }
    }

    private static _0xe22f035d GAME_INDEX_SETTINGS(int _0x6a49024e)
    {
        return _0xe22f035d.ALL_SCENES_SETTING_SINGLETONS[_0x6a49024e];
    }
}

internal static class _0x07579409
{
    internal static string _0x8f6ab16b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}