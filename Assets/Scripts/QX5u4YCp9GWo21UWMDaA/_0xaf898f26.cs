using UnityEngine;

/// <summary>The only way this game shows or hides one of its own groups: a serialized reference
/// to a regular scene object. Nothing here ever touches a template placeholder (C.2).</summary>
public sealed class _0xaf898f26 : MonoBehaviour
{
    [SerializeField]
    private GameObject _content;
    public void _0x77a3fb66()
    {
        if (this._content != null)
            this._content.SetActive(false);
    }

    public RectTransform _0xf619b02c
    {
        get
        {
            return this._content == null ? null : this._content.transform as RectTransform;
        }
    }

    public void _0xe92ed3cc(bool _0xba433466)
    {
        if (this._content != null)
            this._content.SetActive(_0xba433466);
    }

    public void Show()
    {
        if (this._content != null)
            this._content.SetActive(true);
    }

    public bool _0x28ec231a
    {
        get
        {
            return this._content != null && this._content.activeSelf;
        }
    }
}