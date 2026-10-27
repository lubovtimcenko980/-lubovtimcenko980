using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x696568ef : MonoBehaviour
{
    public TMP_Text ContentMainText;
    public void _0xac7eed6b()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private bool _0x50ce18dc => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0x2ee89936()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public GameObject Content;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x2ee89936();
    }

    public Image ContentImage;
    public float scaleDuration = 0.4f;
    public static void HideAllPops()
    {
        _0xa748a6be.Instance._0xf0687100();
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    private void Start()
    {
    // Content.SetActive(false);
    }

    public bool IsOnlyYScale;
    public bool IsScaledDownOnAwake = true;
    public TMP_Text ContentAdditionalText;
    public TMP_Text ContentHeaderText;
    public Ease ease = Ease.OutSine;
}