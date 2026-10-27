using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>Clouds, the crane and an airship. They drift, they parallax with the stack slide,
/// and Reduced Motion settles the lot (C.7: the switch is visibly doing something).</summary>
public sealed class _0x2f62563f : MonoBehaviour
{
    [SerializeField]
    private RectTransform _crane;
    [SerializeField]
    private RectTransform _cloudC;
    [SerializeField]
    private RectTransform _cloudB;
    [SerializeField]
    private RectTransform _cloudLayer;
    private void _0xce5c2084(RectTransform _0x4b10fd2a, float _0x39f4bcdb, float _0x20785010)
    {
        if (_0x4b10fd2a == null)
            return;
        _0x4b10fd2a.DOAnchorPosY(_0x4b10fd2a.anchoredPosition.y - _0x39f4bcdb, _0x20785010).SetEase(Ease.InOutSine).SetLink(_0x4b10fd2a.gameObject);
    }

    private float _0x091e9d65 = 1242f;
    private void _0x20302862(RectTransform _0xcb4b3e4b, float _0xbb03a85a, float _0x834b298d)
    {
        if (_0xcb4b3e4b == null || _0xbb03a85a <= 0f)
            return;
        float _0x3b784c15 = this._0x091e9d65 * 1.3f;
        float _0xc6291e2d = _0x3b784c15 / Mathf.Max(_0xbb03a85a, 1f);
        Vector2 _0x667397f4 = _0xcb4b3e4b.anchoredPosition;
        _0xcb4b3e4b.anchoredPosition = new Vector2(-_0x3b784c15 * 0.5f, _0x667397f4.y);
        _0xcb4b3e4b.DOAnchorPosX(_0x3b784c15 * 0.5f, _0xc6291e2d).SetDelay(_0x834b298d).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart).SetLink(_0xcb4b3e4b.gameObject);
    }

    [SerializeField]
    private RectTransform _airship;
    [SerializeField]
    private RectTransform _cloudA;
    /// <summary>Called when the stack slides down so the sky follows at a fraction of it.</summary>
    public void _0x5be63dbd(float _0x8b5dea49, float _0xf4ca3f27)
    {
        if (_0x002cd05a._0xa31c7051)
            return;
        this._0xce5c2084(this._cloudLayer, _0x8b5dea49 * 0.35f, _0xf4ca3f27);
        this._0xce5c2084(this._crane, _0x8b5dea49 * 0.60f, _0xf4ca3f27);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
        if (this._cloudA != null)
            DOTween.Kill(this._cloudA);
        if (this._cloudB != null)
            DOTween.Kill(this._cloudB);
        if (this._cloudC != null)
            DOTween.Kill(this._cloudC);
        if (this._airship != null)
            DOTween.Kill(this._airship);
        if (this._crane != null)
            DOTween.Kill(this._crane);
        if (this._cloudLayer != null)
            DOTween.Kill(this._cloudLayer);
    }

    public void _0x4458f821(_0xacc286a4 _0x2bce23ac, float _0xf5ed6712)
    {
        this._0x091e9d65 = _0xf5ed6712;
        if (this._crane != null)
        {
            Vector2 _0xcc0c280b = this._crane.anchoredPosition;
            _0xcc0c280b.x = (_0x2bce23ac.CraneOnRight ? 1f : -1f) * _0xf5ed6712 * 0.30f;
            this._crane.anchoredPosition = _0xcc0c280b;
            this._crane.localScale = new Vector3(_0x2bce23ac.CraneOnRight ? 1f : -1f, 1f, 1f);
        }

        if (this._cloudC != null)
            this._cloudC.gameObject.SetActive(_0x2bce23ac.CloudLanes >= 3);
        if (_0x002cd05a._0xa31c7051)
            return;
        this._0x20302862(this._cloudA, _0x2bce23ac.CloudDrift, 0f);
        this._0x20302862(this._cloudB, _0x2bce23ac.CloudDrift * 0.72f, 1.3f);
        this._0x20302862(this._cloudC, _0x2bce23ac.CloudDrift * 1.24f, 2.6f);
        this._0x20302862(this._airship, _0x2bce23ac.CloudDrift * 1.9f, _0x2bce23ac.AirshipDelay);
    }

    [SerializeField]
    private Image _craneImage;
}