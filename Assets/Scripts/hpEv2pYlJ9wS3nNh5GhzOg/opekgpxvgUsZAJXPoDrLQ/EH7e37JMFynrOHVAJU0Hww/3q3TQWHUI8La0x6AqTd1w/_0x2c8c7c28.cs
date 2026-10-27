using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x2c8c7c28 : MonoBehaviour
{
    public GameObject OuterBackground;
    public Ease Ease = Ease.OutSine;
    public GameObject Content;
    public void Show()
    {
        this._0x5aab9bf8();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xf397bc59.Instance._0xebe3ed74(_0xf397bc59.Instance.CurrentPanelIndex);
            });
        }
    }

    public TMP_Text MainText;
    public float ScaleDuration = 0.4f;
    public bool IsScaledDownOnAwake = true;
    private void _0x28fde0eb()
    {
        if (this.OuterBackground != null)
        {
            Image _0xf74cfd3d = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xf74cfd3d, true);
            _0xf74cfd3d.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public void _0x93be5a69()
    {
        this._0x6d3bd7b1();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0x5aab9bf8()
    {
        if (this.OuterBackground != null)
        {
            Image _0xc30108f8 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xc30108f8, true);
            _0xc30108f8.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public void _0xeeb78759()
    {
        this._0xc7c8e62c();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xf397bc59.Instance._0xebe3ed74(_0xf397bc59.Instance.CurrentPanelIndex);
    }

    private void _0x6d3bd7b1()
    {
        if (this.OuterBackground != null)
        {
            Image _0x7a9e6b1a = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x7a9e6b1a, true);
            _0x7a9e6b1a.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0xc7c8e62c()
    {
        if (this.OuterBackground != null)
        {
            Image _0x55794bd3 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x55794bd3, true);
            _0x55794bd3.DOFade(1f, 0f);
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x28fde0eb();
    }

    private bool _0x698e7dd2 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text HeaderText;
}