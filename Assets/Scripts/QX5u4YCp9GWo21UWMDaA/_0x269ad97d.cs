using DG.Tweening;
using TMPro;
using UnityEngine;

/// <summary>"PERFECT  +52" rising off the drop point and fading out.</summary>
public sealed class _0x269ad97d : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _label;
    public void _0x85b4d077()
    {
        if (this._rect == null)
            this._rect = this.transform as RectTransform;
        if (this._label == null)
            this._label = this.GetComponentInChildren<TMP_Text>();
    }

    [SerializeField]
    private RectTransform _rect;
    public void _0xd523d3e0(Vector2 _0xdbbd6e4a, string _0xdd8ceb75, Color _0x84a6686e)
    {
        this._0x85b4d077();
        if (this._rect == null)
            return;
        this._rect.anchoredPosition = _0xdbbd6e4a;
        _0xeea80888.Apply(this._label, _0xdd8ceb75, 40f, _0x84a6686e);
        float _0xea89ac88 = _0x002cd05a.Duration(0.6f);
        this._rect.DOAnchorPosY(_0xdbbd6e4a.y + 90f, _0xea89ac88).SetEase(Ease.OutCubic).SetLink(this.gameObject);
        if (this._label != null)
            this._label.DOFade(0f, _0xea89ac88).SetEase(Ease.InQuad).SetLink(this.gameObject);
        Object.Destroy(this.gameObject, _0xea89ac88 + 0.1f);
    }
}