using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x1226b55e : MonoBehaviour
{
    private static void OrientationChanged()
    {
        _0x1aced593 = Screen.orientation;
        _0x8bcec51f.x = Screen.width;
        _0x8bcec51f.y = Screen.height;
        _0x0ec7ba5a.Invoke();
    }

    private void Update()
    {
        if (_0x7223851f[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x1aced593)
            OrientationChanged();
        if (Screen.safeArea != _0xc2afb5d5)
            SafeAreaChanged();
        if (Screen.width != _0x8bcec51f.x || Screen.height != _0x8bcec51f.y)
            ResolutionChanged();
    }

    private static UnityEvent _0x0ec7ba5a = new();
    private static bool _0x4818023d;
    private static readonly List<_0x1226b55e> _0x7223851f = new();
    private static void ResolutionChanged()
    {
        _0x8bcec51f.x = Screen.width;
        _0x8bcec51f.y = Screen.height;
        _0x0ec7ba5a.Invoke();
    }

    private void Awake()
    {
        if (!_0x7223851f.Contains(this))
            _0x7223851f.Add(this);
        this._0x61a9d7cf = this.GetComponent<Canvas>();
        this._0x8dc73ea4 = this.GetComponent<RectTransform>();
        this._0xd2997189 = this.transform.Find(_0x9f90db77._0x335248fc(new byte[8] { 6, 52, 51, 48, 20, 39, 48, 52 }, 85)) as RectTransform;
        if (!_0x4818023d)
        {
            _0x1aced593 = Screen.orientation;
            _0x8bcec51f.x = Screen.width;
            _0x8bcec51f.y = Screen.height;
            _0xc2afb5d5 = Screen.safeArea;
            _0x4818023d = true;
        }

        this._0xf5a5b9e6();
    }

    private RectTransform _0xd2997189;
    private Canvas _0x61a9d7cf;
    private static Rect _0xc2afb5d5 = Rect.zero;
    private RectTransform _0x8dc73ea4;
    private static void SafeAreaChanged()
    {
        _0xc2afb5d5 = Screen.safeArea;
        for (int _0x1ef52d78 = 0; _0x1ef52d78 < _0x7223851f.Count; _0x1ef52d78++)
            _0x7223851f[_0x1ef52d78]._0xf5a5b9e6();
    }

    private static Vector2 _0x8bcec51f = Vector2.zero;
    private static ScreenOrientation _0x1aced593 = ScreenOrientation.LandscapeLeft;
    private void OnDestroy()
    {
        if (_0x7223851f != null && _0x7223851f.Contains(this))
            _0x7223851f.Remove(this);
    }

    private void _0xf5a5b9e6()
    {
        if (this._0xd2997189 == null)
            return;
        Rect _0xb1d4fc06 = Screen.safeArea;
        Vector2 _0xfe78fc4c = _0xb1d4fc06.position;
        Vector2 _0x8d680dc4 = _0xb1d4fc06.position + _0xb1d4fc06.size;
        _0xfe78fc4c.x /= this._0x61a9d7cf.pixelRect.width;
        _0xfe78fc4c.y /= this._0x61a9d7cf.pixelRect.height;
        _0x8d680dc4.x /= this._0x61a9d7cf.pixelRect.width;
        _0x8d680dc4.y /= this._0x61a9d7cf.pixelRect.height;
        this._0xd2997189.anchorMin = _0xfe78fc4c;
        this._0xd2997189.anchorMax = _0x8d680dc4;
    }
}

internal static class _0x9f90db77
{
    internal static string _0x335248fc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}