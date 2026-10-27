using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xe72034d4 : MonoBehaviour
{
    private Touch? _0x31ce7c8f()
    {
        if (!_0x59a642a8.Instance._0xdb5e484e)
            return null;
        foreach (Touch _0xb3691445 in Touch.activeTouches)
            if (!_0xb3691445.ended)
                if (this._0x4f7d877d(_0xb3691445))
                    return _0xb3691445;
        return null;
    }

    private Touch? _0xd9eaa8c1(Bounds _0x1c577002)
    {
        if (!_0x59a642a8.Instance._0xdb5e484e)
            return null;
        foreach (Touch _0x92e1fd8c in Touch.activeTouches)
            if (!_0x92e1fd8c.ended)
            {
                Vector3 _0x46d83069 = Camera.main.ScreenToWorldPoint(_0x92e1fd8c.screenPosition);
                Vector3 _0xc2a68ee2 = new(_0x46d83069.x, _0x46d83069.y, _0x1c577002.center.z);
                if (_0x1c577002.Contains(_0xc2a68ee2) && this._0x4f7d877d(_0x92e1fd8c))
                    return _0x92e1fd8c;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x80c0239b = this.gameObject.GetComponent<_0xe72034d4>();
    }

    private static _0xe72034d4 _0x80c0239b;
    private bool _0x4f7d877d(Touch? _0x79998d34)
    {
        if (!_0x79998d34.HasValue)
            return false;
        Vector3 _0xb8f578bc = Camera.main.ScreenToWorldPoint(_0x79998d34.Value.screenPosition);
        Vector3 _0xe04df6aa = _0xb8f578bc;
        _0xe04df6aa.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xe04df6aa))
            return true;
        _0x79998d34 = null;
        return false;
    }

    private Touch? _0x5ad5f5d9(Bounds _0x79d72a23, TouchPhase _0xc77e4079)
    {
        if (!_0x59a642a8.Instance._0xdb5e484e)
            return null;
        foreach (Touch _0x7894f876 in Touch.activeTouches)
            if (_0x7894f876.phase == _0xc77e4079)
            {
                Vector3 _0x7ed0f8f7 = Camera.main.ScreenToWorldPoint(_0x7894f876.screenPosition);
                Vector3 _0xbaa7d65e = new(_0x7ed0f8f7.x, _0x7ed0f8f7.y, _0x79d72a23.center.z);
                if (_0x79d72a23.Contains(_0xbaa7d65e) && this._0x4f7d877d(_0x7894f876))
                    return _0x7894f876;
            }

        return null;
    }

    private Touch? _0x2f98633e()
    {
        if (!_0x59a642a8.Instance._0xdb5e484e)
            return null;
        foreach (Touch _0xee692f53 in Touch.activeTouches)
            if (_0xee692f53.ended)
                if (this._0x4f7d877d(_0xee692f53))
                    return _0xee692f53;
        return null;
    }

    private void _0x1b577a84(Touch? _0x6c73e804)
    {
        if (!_0x59a642a8.Instance._0xdb5e484e)
        {
            _0x6c73e804 = null;
            return;
        }

        int _0x61feef7f = _0x6c73e804.Value.touchId;
        _0x6c73e804 = Touch.activeTouches.FirstOrDefault(_0xc24c457e => _0xc24c457e.touchId == _0x61feef7f);
        if (!this._0x4f7d877d(_0x6c73e804.Value))
            _0x6c73e804 = null;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x4e65118d(Bounds _0xef815338)
    {
        if (!_0x59a642a8.Instance._0xdb5e484e)
            return null;
        foreach (Touch _0xc19f6bed in Touch.activeTouches)
            if (_0xc19f6bed.ended)
            {
                Vector3 _0x1ab3fa4b = Camera.main.ScreenToWorldPoint(_0xc19f6bed.screenPosition);
                Vector3 _0xc6acccf0 = new(_0x1ab3fa4b.x, _0x1ab3fa4b.y, _0xef815338.center.z);
                if (_0xef815338.Contains(_0xc6acccf0) && this._0x4f7d877d(_0xc19f6bed))
                    return _0xc19f6bed;
            }

        return null;
    }

    private bool _0x74cef7e6(Touch? _0xf1e387a9, Bounds _0xaafe4e8a, TouchPhase _0x054df445)
    {
        if (!_0x59a642a8.Instance._0xdb5e484e)
        {
            _0xf1e387a9 = null;
            return false;
        }

        if (_0xf1e387a9 != null)
            if (_0xf1e387a9.Value.phase == _0x054df445)
            {
                Vector3 _0xd535b576 = Camera.main.ScreenToWorldPoint(_0xf1e387a9.Value.screenPosition);
                Vector3 _0x323cecbf = new(_0xd535b576.x, _0xd535b576.y, _0xaafe4e8a.center.z);
                if (_0xaafe4e8a.Contains(_0x323cecbf) && this._0x4f7d877d(_0xf1e387a9.Value))
                    return true;
            }

        return false;
    }
}