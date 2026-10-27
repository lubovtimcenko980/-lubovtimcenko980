using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>The one gold moment: a burst behind the slab plus a chevron marker, so the signal
/// reads without relying on hue alone when high contrast is on.</summary>
public sealed class _0x83d99e47 : MonoBehaviour
{
    [SerializeField]
    private Image _burstImage;
    [SerializeField]
    private RectTransform _burst;
    [SerializeField]
    private Image _markerImage;
    public void _0x1ca4305f(Vector2 _0x1edd9c7a, float _0x3afb9a54)
    {
        if (this._burst == null || this._burstImage == null)
            return;
        Color _0x8882e631 = _0x002cd05a._0x3e16228f;
        if (_0x002cd05a._0xa31c7051)
        {
            this._burst.gameObject.SetActive(false);
        }
        else
        {
            this._burst.gameObject.SetActive(true);
            this._burst.anchoredPosition = _0x1edd9c7a;
            this._burst.sizeDelta = new Vector2(_0x3afb9a54, _0x3afb9a54);
            this._burstImage.color = _0x5219e5ac.With(_0x8882e631, 0f);
            float _0x39338412 = _0x002cd05a.Duration(0.17f);
            this._burstImage.DOFade(0.85f, _0x39338412).SetEase(Ease.OutQuad).SetLink(this.gameObject);
            this._burstImage.DOFade(0f, _0x39338412).SetDelay(_0x39338412).SetEase(Ease.InQuad).SetLink(this.gameObject);
        }

        if (this._marker != null && this._markerImage != null)
        {
            this._marker.gameObject.SetActive(_0x002cd05a._0xc0e0e5e0);
            if (_0x002cd05a._0xc0e0e5e0)
            {
                this._marker.anchoredPosition = new Vector2(_0x1edd9c7a.x, _0x1edd9c7a.y + _0x3afb9a54 * 0.62f);
                this._markerImage.color = _0x8882e631;
                this._marker.localScale = Vector3.one * 0.8f;
                this._marker.DOScale(1.15f, _0x002cd05a.Duration(0.28f)).SetEase(Ease.OutBack).SetLink(this.gameObject);
            }
        }

        _0x002cd05a.Buzz();
    }

    [SerializeField]
    private RectTransform _marker;
    private void Start()
    {
        this._0xc5441929();
    }

    public void _0xc5441929()
    {
        if (this._burst != null)
            this._burst.gameObject.SetActive(false);
        if (this._marker != null)
            this._marker.gameObject.SetActive(false);
    }
}