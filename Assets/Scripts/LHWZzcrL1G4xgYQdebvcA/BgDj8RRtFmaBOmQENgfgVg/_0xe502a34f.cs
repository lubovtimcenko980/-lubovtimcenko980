using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xe502a34f : MonoBehaviour
{
    private static readonly List<_0xe502a34f> _0x3b3ccd74 = new();
    private static void OrientationChanged()
    {
        _0x0c571ec5 = Screen.orientation;
        _0x10b36d7f.x = Screen.width;
        _0x10b36d7f.y = Screen.height;
        _0x86d72358 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xc0bc7d9d.Invoke();
    }

    private static void ResolutionChanged()
    {
        _0x10b36d7f.x = Screen.width;
        _0x10b36d7f.y = Screen.height;
        _0x86d72358 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xc0bc7d9d.Invoke();
    }

    private Canvas _0xe7abca07;
    private static Rect _0x86d72358 = Rect.zero;
    private static ScreenOrientation _0x0c571ec5 = ScreenOrientation.LandscapeLeft;
    private void _0xb608767e()
    {
        if (this._0x845c23bc == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x09445bcd = Screen.safeArea;
        Vector2 _0x31648d65 = _0x09445bcd.position;
        Vector2 _0x0b450a59 = _0x09445bcd.position + _0x09445bcd.size;
        _0x31648d65.x /= screenWidth;
        _0x31648d65.y /= screenHeight;
        _0x0b450a59.x /= screenWidth;
        _0x0b450a59.y /= screenHeight;
        this._0x845c23bc.anchorMin = _0x31648d65;
        this._0x845c23bc.anchorMax = _0x0b450a59;
        this._0x845c23bc.offsetMin = Vector2.zero;
        this._0x845c23bc.offsetMax = Vector2.zero;
        if (this._0x070bc291 == null)
            return;
        Vector2 _0xf3e01220 = _0x0b450a59 - _0x31648d65;
        float _0x2d18bc1a = 2f - _0xf3e01220.x;
        float _0x42e5158a = 2f - _0xf3e01220.y;
        this._0x070bc291.referenceResolution = this._0x07f8e5c2 * new Vector2(_0x2d18bc1a, _0x42e5158a);
    }

    private RectTransform _0x3be30c84;
    private RectTransform _0x845c23bc;
    private static void ApplySafeAreaToAll()
    {
        for (int _0x7155a250 = 0; _0x7155a250 < _0x3b3ccd74.Count; _0x7155a250++)
            _0x3b3ccd74[_0x7155a250]._0xb608767e();
    }

    private static UnityEvent _0xc0bc7d9d = new();
    private void Update()
    {
        if (_0x3b3ccd74.Count == 0 || _0x3b3ccd74[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x0c571ec5)
            OrientationChanged();
        if (Screen.safeArea != _0x86d72358)
            SafeAreaChanged();
        if (Screen.width != _0x10b36d7f.x || Screen.height != _0x10b36d7f.y)
            ResolutionChanged();
    }

    private static void SafeAreaChanged()
    {
        _0x86d72358 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private void Awake()
    {
        if (!_0x3b3ccd74.Contains(this))
            _0x3b3ccd74.Add(this);
        this._0xe7abca07 = this.GetComponent<Canvas>();
        this._0x070bc291 = this.GetComponent<CanvasScaler>();
        if (this._0x070bc291 != null)
            this._0x07f8e5c2 = this._0x070bc291.referenceResolution;
        this._0x3be30c84 = this.GetComponent<RectTransform>();
        this._0x845c23bc = this.transform.Find(_0xf4e3df51._0xb098210d(new byte[8] { 23, 37, 34, 33, 5, 54, 33, 37 }, 68)) as RectTransform;
        if (!_0x610649fb)
        {
            _0x0c571ec5 = Screen.orientation;
            _0x10b36d7f.x = Screen.width;
            _0x10b36d7f.y = Screen.height;
            _0x86d72358 = Screen.safeArea;
            _0x610649fb = true;
        }

        this._0xb608767e();
    }

    private void Start()
    {
    }

    private CanvasScaler _0x070bc291;
    private Vector2 _0x07f8e5c2;
    private void OnDestroy()
    {
        if (_0x3b3ccd74 != null && _0x3b3ccd74.Contains(this))
            _0x3b3ccd74.Remove(this);
    }

    private static bool _0x610649fb;
    private static Vector2 _0x10b36d7f = Vector2.zero;
}

internal static class _0xf4e3df51
{
    internal static string _0xb098210d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}