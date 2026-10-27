using TMPro;
using UnityEngine;

/// <summary>The template ships seven tutorial panel slots this game does not use, and the ones
/// that exist carry placeholder copy. The panels stay in place - the controller addresses them
/// by index - but every caption under them is emptied at runtime (C.15). Panels are reached
/// through SETTINGS.PANELS indices, never by name.</summary>
public sealed class _0xe23ec0d5 : MonoBehaviour
{
    public void _0x5e1b8c6d()
    {
        _0xf397bc59 _0x90ba8bf0 = _0xf397bc59.Instance;
        if (_0x90ba8bf0 == null || _0x90ba8bf0.Panels == null)
            return;
        for (int _0xedaf77db = _0x5a9a28e3._0x379e6670.TUTORIAL0; _0xedaf77db <= _0x5a9a28e3._0x379e6670.TUTORIAL6; _0xedaf77db++)
        {
            if (_0xedaf77db < 0 || _0xedaf77db >= _0x90ba8bf0.Panels.Count)
                continue;
            _0x2c8c7c28 _0xc1b878ba = _0x90ba8bf0.Panels[_0xedaf77db];
            if (_0xc1b878ba == null || _0xc1b878ba.Content == null)
                continue;
            TMP_Text[] _0x89bda585 = _0xc1b878ba.Content.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x61b29a8b = 0; _0x61b29a8b < _0x89bda585.Length; _0x61b29a8b++)
                if (_0x89bda585[_0x61b29a8b] != null)
                    _0x89bda585[_0x61b29a8b].text = string.Empty;
        }
    }

    private void Start()
    {
        this._0x5e1b8c6d();
    }
}