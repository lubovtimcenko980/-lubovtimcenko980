using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x54ac6d04 : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x5a9a28e3._0x52964cd5.SCENE_0 && !_0x575b3e3c)
        {
            this._0xc57cd0ca();
        }
        else
        {
            this._0x333f16d1();
        }
    }

    private static bool _0x575b3e3c = false;
    public GameObject Error;
    public float DefaultAnimationTime = 0.4f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x54ac6d04>();
    }

    public Slider AnimationSlider;
    public float FirstAnimationTime = 10.0f;
    public void _0x25bf46b8()
    {
        this._0xb7b325a0?.Pause();
    }

    public void _0xe7509048()
    {
        this._0xb7b325a0?.Kill();
        this.AnimationSlider.value = _0x575b3e3c ? this.SecondPassSliderValue : 0.05f;
    }

    public float SecondPassSliderValue = 0.5f;
    public GameObject Background;
    private void _0xc57cd0ca()
    {
        this.AnimationSlider.value = 0.05f;
        _0x575b3e3c = !_0x575b3e3c;
        this._0xb7b325a0 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x37be62ce => this.AnimationSlider.value = _0x37be62ce, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x5bee87ee._0x4a1e206f?._0x430fec7d();
        });
    }

    private Sequence _0xb7b325a0;
    public GameObject Content;
    public void _0x333f16d1()
    {
        this._0xe7509048();
        bool _0x68780f49 = _0x575b3e3c;
        this._0xb7b325a0 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x37be62ce => this.AnimationSlider.value = _0x37be62ce, _0x68780f49 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x575b3e3c = !_0x575b3e3c;
    }

    public static _0x54ac6d04 Instance;
    public void _0x03f811e8()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xb7b325a0?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x575b3e3c = false;
    }

    public void _0xc5255e69()
    {
        this._0xb7b325a0?.Play();
    }
}