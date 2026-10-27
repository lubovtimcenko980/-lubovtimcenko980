using UnityEngine;

/// <summary>Puts the tower screen into the game scene's DefaultPanel and themes that scene's own
/// splash bar. The view goes in as the FIRST child so the template's top strip keeps drawing
/// (and keeps taking taps) above the full-screen drop catcher underneath it.</summary>
public sealed class _0x4d78f78c : MonoBehaviour
{
    private void Start()
    {
        _0x9d51c23c.Apply();
        _0xf397bc59 _0x2f63d9ed = _0xf397bc59.Instance;
        if (_0x2f63d9ed == null || _0x2f63d9ed.Panels == null)
            return;
        // Each scene raises its OWN splash, so the brand goes into this one too - as the
        // first child, which keeps the template loading bar on top of it.
        int _0x19d2c1d8 = _0x5a9a28e3._0x379e6670.SPLASH;
        if (_0x19d2c1d8 >= 0 && _0x19d2c1d8 < _0x2f63d9ed.Panels.Count && this._splashViewPrefab != null)
        {
            _0x2c8c7c28 _0xe94162f3 = _0x2f63d9ed.Panels[_0x19d2c1d8];
            if (_0xe94162f3 != null && _0xe94162f3.Content != null)
            {
                GameObject _0xd3d399bb = Instantiate(this._splashViewPrefab, _0xe94162f3.Content.transform, false);
                _0xd3d399bb.transform.SetAsFirstSibling();
            }
        }

        int _0xf27816b8 = _0x5a9a28e3._0x379e6670.DEFAULT;
        if (_0xf27816b8 < 0 || _0xf27816b8 >= _0x2f63d9ed.Panels.Count)
            return;
        _0x2c8c7c28 _0x6747758e = _0x2f63d9ed.Panels[_0xf27816b8];
        if (_0x6747758e == null || _0x6747758e.Content == null || this._gameViewPrefab == null)
            return;
        GameObject _0xa850c109 = Instantiate(this._gameViewPrefab, _0x6747758e.Content.transform, false);
        _0xa850c109.transform.SetAsFirstSibling();
    }

    [SerializeField]
    private GameObject _gameViewPrefab;
    [SerializeField]
    private GameObject _splashViewPrefab;
}