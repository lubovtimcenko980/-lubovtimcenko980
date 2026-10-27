using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>Puts this game into the menu scene's template panels. Panels are addressed by
/// SETTINGS index (never by name), the views are prefabs this codegen authored, and the only
/// template object touched is the Play slot - whose own rect the hub's face is welded onto, so
/// the panel keeps exactly ONE button there (rule H).</summary>
public sealed class _0x780f55bd : MonoBehaviour
{
    private _0x2c8c7c28 _0x80e085b2(_0xf397bc59 _0xc94e879d, int _0x9f2905fa)
    {
        if (_0x9f2905fa < 0 || _0x9f2905fa >= _0xc94e879d.Panels.Count)
            return null;
        return _0xc94e879d.Panels[_0x9f2905fa];
    }

    [SerializeField]
    private GameObject _menuViewPrefab;
    [SerializeField]
    private GameObject _splashViewPrefab;
    private void Start()
    {
        _0xf397bc59 _0xb1337477 = _0xf397bc59.Instance;
        if (_0xb1337477 == null || _0xb1337477.Panels == null)
            return;
        _0x2c8c7c28 _0x45a11f7b = this._0x80e085b2(_0xb1337477, _0x5a9a28e3._0x379e6670.SPLASH);
        if (_0x45a11f7b != null && _0x45a11f7b.Content != null && this._splashViewPrefab != null)
        {
            GameObject _0x232914cf = Instantiate(this._splashViewPrefab, _0x45a11f7b.Content.transform, false);
            _0x232914cf.transform.SetAsFirstSibling();
        }

        _0x9d51c23c.Apply();
        _0x2c8c7c28 _0x0172de73 = this._0x80e085b2(_0xb1337477, _0x5a9a28e3._0x379e6670.DEFAULT);
        if (_0x0172de73 == null || _0x0172de73.Content == null || this._menuViewPrefab == null)
            return;
        // The template's Play slot is the only Button in this panel; resolve it BEFORE the hub
        // adds its own chips, so the lookup cannot pick one of those up instead.
        Button _0xeb1caa12 = _0x0172de73.Content.GetComponentInChildren<Button>(true);
        GameObject _0xde6dfc11 = Instantiate(this._menuViewPrefab, _0x0172de73.Content.transform, false);
        _0xde6dfc11.transform.SetAsLastSibling();
        _0xea655647 _0xad7cec70 = _0xde6dfc11.GetComponentInChildren<_0xea655647>(true);
        if (_0xad7cec70 != null && _0xeb1caa12 != null)
            _0xad7cec70._0xfb890f38(_0xeb1caa12.transform as RectTransform);
        // The template slot keeps its own driver (LoadSceneButton -> SCENE_1); this only makes
        // sure no leftover caption of its own shows through the face drawn over it.
        if (_0xeb1caa12 != null)
        {
            TMP_Text _0xfde07d20 = _0xeb1caa12.GetComponentInChildren<TMP_Text>(true);
            if (_0xfde07d20 != null)
            {
                _0xfde07d20.text = string.Empty;
                _0xfde07d20.gameObject.SetActive(false);
            }
        }
    }
}