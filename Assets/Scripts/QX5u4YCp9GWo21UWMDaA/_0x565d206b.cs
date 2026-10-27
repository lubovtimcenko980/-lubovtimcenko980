using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>The sheared-off piece: it drops away, spins a little and fades. Tween-driven, so it
/// is destroyed with its own object through SetLink (C.56).</summary>
public sealed class _0x565d206b : MonoBehaviour
{
    [SerializeField]
    private RectTransform _rect;
    [SerializeField]
    private Image _image;
    public void _0xe727df62()
    {
        if (this._rect == null)
            this._rect = this.transform as RectTransform;
        if (this._image == null)
            this._image = this.GetComponent<Image>();
    }

    public void _0x51c56361(Vector2 _0x956cf2ac, Vector2 _0xebc11206, int _0x77419e79, float _0xb6c9f07c, Color _0x9dd73454)
    {
        this._0xe727df62();
        if (this._rect == null)
            return;
        this._rect.anchoredPosition = _0x956cf2ac;
        this._rect.sizeDelta = _0xebc11206;
        this._rect.localEulerAngles = Vector3.zero;
        if (this._image != null)
            this._image.color = _0x9dd73454;
        float _0x6f3eedac = _0x002cd05a.Duration(0.55f);
        this._rect.DOAnchorPosY(_0x956cf2ac.y - _0xb6c9f07c, _0x6f3eedac).SetEase(Ease.InQuad).SetLink(this.gameObject);
        this._rect.DOLocalRotate(new Vector3(0f, 0f, _0x77419e79 * -42f), _0x6f3eedac).SetEase(Ease.InQuad).SetLink(this.gameObject);
        if (this._image != null)
            this._image.DOFade(0f, _0x6f3eedac).SetEase(Ease.InQuad).SetLink(this.gameObject);
        Object.Destroy(this.gameObject, _0x6f3eedac + 0.1f);
    }
}