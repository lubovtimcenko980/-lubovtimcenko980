using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x5bee87ee : MonoBehaviour
{
    private async Task<bool> _0x81e1cf5f()
    {
        {
#if B_LOGS
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[37] { 223, 208, 225, 247, 240, 217, 164, 215, 237, 227, 234, 205, 234, 209, 234, 237, 240, 253, 215, 225, 246, 242, 237, 231, 225, 247, 197, 234, 235, 234, 253, 233, 235, 241, 247, 232, 253 }, 132));
#endif
        }

        try
        {
            var _0x49093824 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x49093824);
            {
#if B_LOGS
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[32] { 41, 38, 23, 1, 6, 47, 82, 39, 28, 27, 6, 11, 33, 23, 0, 4, 27, 17, 23, 1, 82, 59, 28, 27, 6, 27, 19, 30, 27, 8, 23, 22 }, 114));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[20] { 72, 89, 79, 72, 60, 73, 114, 117, 104, 101, 79, 121, 110, 106, 117, 127, 121, 111, 38, 60 }, 28) + ex.Message);
#endif
            }

            _0x4a1e206f?._0x751741fe();
            return true;
        }

        bool _0x8d92a7d5 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x8d92a7d5 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x4ad53cb9._0x340c215b(new byte[37] { 118, 121, 72, 94, 89, 112, 13, 126, 68, 74, 67, 0, 68, 67, 13, 108, 67, 66, 67, 84, 64, 66, 88, 94, 3, 13, 125, 65, 76, 84, 72, 95, 13, 100, 105, 23, 13 }, 45) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x43a5b5ba = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x4ad53cb9._0x340c215b(new byte[25] { 121, 104, 126, 121, 13, 126, 68, 74, 67, 0, 68, 67, 13, 108, 88, 89, 69, 13, 104, 127, 127, 98, 127, 23, 13 }, 45) + ex.Message);
#endif
                }

                _0x4a1e206f?._0x751741fe();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x4ad53cb9._0x340c215b(new byte[28] { 1, 16, 6, 1, 117, 6, 60, 50, 59, 120, 60, 59, 117, 7, 48, 36, 32, 48, 38, 33, 117, 16, 7, 7, 26, 7, 111, 117 }, 85) + ex.Message);
#endif
                }

                _0x4a1e206f?._0x751741fe();
                return true;
            }
        }
        while (!_0x8d92a7d5);
        return false;
    }

    private bool OpenUrlExternally(string _0xd5ee81d8)
    {
        return _0x6d6ddf0a(_0xd5ee81d8);
    }

    private bool _0xb806a7a0 = false;
    private bool _0x6d6ddf0a(string _0x4bf17e8e)
    {
        try
        {
            using (var _0xd163a878 = new AndroidJavaClass(_0x4ad53cb9._0x340c215b(new byte[30] { 37, 41, 43, 104, 51, 40, 47, 50, 63, 117, 34, 104, 54, 42, 39, 63, 35, 52, 104, 19, 40, 47, 50, 63, 22, 42, 39, 63, 35, 52 }, 70)))
            using (var _0xd1ab2f74 = _0xd163a878.GetStatic<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[15] { 139, 157, 154, 154, 141, 134, 156, 169, 139, 156, 129, 158, 129, 156, 145 }, 232)))
            using (var _0xb012080e = new AndroidJavaClass(_0x4ad53cb9._0x340c215b(new byte[15] { 221, 210, 216, 206, 211, 213, 216, 146, 210, 217, 200, 146, 233, 206, 213 }, 188)))
            using (var _0x28e70089 = _0xb012080e.CallStatic<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[5] { 48, 33, 50, 51, 37 }, 64), _0x4bf17e8e))
            using (var _0x68f06e67 = new AndroidJavaObject(_0x4ad53cb9._0x340c215b(new byte[22] { 253, 242, 248, 238, 243, 245, 248, 178, 255, 243, 242, 232, 249, 242, 232, 178, 213, 242, 232, 249, 242, 232 }, 156), _0x4ad53cb9._0x340c215b(new byte[26] { 206, 193, 203, 221, 192, 198, 203, 129, 198, 193, 219, 202, 193, 219, 129, 206, 204, 219, 198, 192, 193, 129, 249, 230, 234, 248 }, 175), _0x28e70089))
            {
                WLog(_0x4ad53cb9._0x340c215b(new byte[26] { 18, 57, 35, 62, 60, 52, 29, 56, 58, 52, 113, 62, 33, 52, 63, 113, 52, 41, 37, 52, 35, 63, 48, 61, 107, 113 }, 81) + _0x4bf17e8e);
                _0x68f06e67.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[11] { 59, 62, 62, 25, 59, 46, 63, 61, 53, 40, 35 }, 90), _0x4ad53cb9._0x340c215b(new byte[33] { 214, 217, 211, 197, 216, 222, 211, 153, 222, 217, 195, 210, 217, 195, 153, 212, 214, 195, 210, 208, 216, 197, 206, 153, 245, 229, 248, 224, 228, 246, 245, 251, 242 }, 183));
                _0x68f06e67.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[8] { 43, 46, 46, 12, 38, 43, 45, 57 }, 74), 0x10000000);
                _0xd1ab2f74.Call(_0x4ad53cb9._0x340c215b(new byte[13] { 21, 18, 7, 20, 18, 39, 5, 18, 15, 16, 15, 18, 31 }, 102), _0x68f06e67);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x4ad53cb9._0x340c215b(new byte[28] { 121, 82, 72, 85, 87, 95, 118, 83, 81, 95, 26, 95, 66, 78, 95, 72, 84, 91, 86, 26, 92, 91, 83, 86, 95, 94, 0, 26 }, 58) + e.Message);
            Application.OpenURL(_0x4bf17e8e);
            return true;
        }
    }

    private void _0x9d3ed7a1(string _0xd1b5d676)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[34] { 49, 62, 15, 25, 30, 55, 74, 44, 15, 30, 9, 2, 74, 47, 18, 30, 24, 11, 74, 58, 31, 25, 2, 74, 46, 11, 30, 11, 74, 56, 11, 29, 80, 74 }, 106) + _0xd1b5d676);
#endif
            }
        }

        var _0x8e280161 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xd1b5d676);
        StartCoroutine(_0x04f8ab8f(_0x8e280161));
    }

    private string _0x387f03e7 = "";
    // NATIVE WEB VIEW METHODS
    private UniWebView _0xde949823 = null;
    private void _0x2944f58d()
    {
        using (var _0xd79b5d51 = new AndroidJavaClass(_0x4ad53cb9._0x340c215b(new byte[30] { 172, 160, 162, 225, 186, 161, 166, 187, 182, 252, 171, 225, 191, 163, 174, 182, 170, 189, 225, 154, 161, 166, 187, 182, 159, 163, 174, 182, 170, 189 }, 207)))
        using (var _0x1934b7b1 = _0xd79b5d51.GetStatic<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[15] { 13, 27, 28, 28, 11, 0, 26, 47, 13, 26, 7, 24, 7, 26, 23 }, 110)))
        using (var _0x19af99a5 = _0x1934b7b1.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[9] { 244, 246, 231, 218, 253, 231, 246, 253, 231 }, 147)))
        {
            if (_0x19af99a5 == null)
                return;
            using (var _0x9449c378 = _0x19af99a5.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[9] { 53, 55, 38, 23, 42, 38, 32, 51, 33 }, 82)))
            {
                if (_0x9449c378 == null)
                    return;
                using (var _0x5bafc63a = new AndroidJavaObject(_0x4ad53cb9._0x340c215b(new byte[19] { 181, 168, 189, 244, 176, 169, 181, 180, 244, 144, 137, 149, 148, 149, 184, 176, 191, 185, 174 }, 218)))
                using (var _0xac5a1115 = _0x9449c378.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[6] { 138, 132, 152, 178, 132, 149 }, 225)))
                using (var _0x8cc052df = _0xac5a1115.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[8] { 218, 199, 214, 193, 210, 199, 220, 193 }, 179)))
                {
                    while (_0x8cc052df.Call<bool>(_0x4ad53cb9._0x340c215b(new byte[7] { 186, 179, 161, 156, 183, 170, 166 }, 210)))
                    {
                        string _0x7dbb46f8 = _0x8cc052df.Call<string>(_0x4ad53cb9._0x340c215b(new byte[4] { 102, 109, 112, 124 }, 8));
                        using (var _0xc48975f5 = _0x9449c378.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[3] { 79, 77, 92 }, 40), _0x7dbb46f8))
                        {
                            _0x5bafc63a.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[3] { 227, 230, 231 }, 147), _0x7dbb46f8, _0xc48975f5);
                        }
                    }

                    string _0x0af7e9e2 = _0x5bafc63a.Call<string>(_0x4ad53cb9._0x340c215b(new byte[8] { 117, 110, 82, 117, 115, 104, 111, 102 }, 1));
                    if (!string.IsNullOrEmpty(_0x0af7e9e2))
                    {
                        _0xae6328d9(_0x0af7e9e2);
                        _0x9d3ed7a1(_0x0af7e9e2);
                    }
                }
            }
        }
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xd3a88595(string _0xc7f90312, string _0x94239d78)
    {
        try
        {
            using var _0x33a08c23 = Aes.Create();
            _0x33a08c23.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x94239d78));
            _0x33a08c23.GenerateIV();
            using var _0x1f21e745 = new MemoryStream();
            _0x1f21e745.Write(_0x33a08c23.IV, 0, _0x33a08c23.IV.Length);
            using (var _0xdf27dbf5 = new CryptoStream(_0x1f21e745, _0x33a08c23.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x97ae32ca = Encoding.UTF8.GetBytes(_0xc7f90312);
                _0xdf27dbf5.Write(_0x97ae32ca, 0, _0x97ae32ca.Length);
                _0xdf27dbf5.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x1f21e745.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x43a5b5ba = "";
    private string _0xd1767389 = "";
    internal bool ContainsIgnoreCase(string _0xd9a8afda, string _0x99f6cd9d)
    {
        if (string.IsNullOrEmpty(_0xd9a8afda) || string.IsNullOrEmpty(_0x99f6cd9d))
            return false;
        return _0xd9a8afda.IndexOf(_0x99f6cd9d, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private int _0xf16d1b61 = 0;
    private string _0xf499c873 = "";
    private bool _0xa52c7549 = false;
    private int _0x20d64bd0 = -1;
    private void _0x20f4f8d3()
    {
        WLog(_0x4ad53cb9._0x340c215b(new byte[21] { 105, 64, 83, 69, 86, 64, 83, 68, 1, 67, 64, 66, 74, 1, 81, 83, 68, 82, 82, 68, 69 }, 33));
        if (Time.frameCount == _0x20d64bd0)
            return;
        _0x20d64bd0 = Time.frameCount;
        if (_0x0c392569())
            return;
        _0x305f1167();
    }

    private async Task<string> _0x7786317c(int _0x7194e1b8 = 5, int _0xb3856f25 = 500)
    {
        try
        {
            List<EntityData> _0x15cce1b8 = new List<EntityData>();
            int _0x4b90b184 = 0;
            do
            {
                _0x15cce1b8 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x4ad53cb9._0x340c215b(new byte[8] { 27, 7, 10, 18, 14, 25, 34, 15 }, 107), _0x43a5b5ba, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x43a5b5ba }), new QueryOptions())).ToList();
                await Task.Delay(_0xb3856f25);
            }
            while (_0x15cce1b8.Count == 0 && _0x4b90b184++ < _0x7194e1b8);
            {
#if B_LOGS
                {
                    Debug.Log(_0x4ad53cb9._0x340c215b(new byte[33] { 45, 34, 19, 5, 2, 43, 86, 37, 23, 0, 19, 18, 86, 58, 31, 24, 29, 86, 39, 3, 19, 4, 15, 86, 4, 19, 5, 3, 26, 2, 5, 76, 86 }, 118) + JsonConvert.SerializeObject(_0x15cce1b8, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x4ad53cb9._0x340c215b(new byte[39] { 21, 26, 43, 61, 58, 19, 110, 29, 47, 56, 43, 42, 110, 2, 39, 32, 37, 110, 31, 59, 43, 60, 55, 110, 60, 43, 61, 59, 34, 58, 61, 110, 45, 33, 59, 32, 58, 116, 110 }, 78) + _0x15cce1b8.Count);
                }
#endif
            }

            var _0xb7b813af = _0x15cce1b8.SelectMany(_0x336a2411 => _0x336a2411.Data).FirstOrDefault(_0xdcf8f590 => _0xdcf8f590.Key == _0x43a5b5ba)?.Value.GetAs<string>() ?? string.Empty;
            _0xb7b813af = Decrypt(_0xb7b813af, _0x43a5b5ba);
            {
#if B_LOGS
                {
                    Debug.Log(_0x4ad53cb9._0x340c215b(new byte[24] { 253, 242, 195, 213, 210, 251, 134, 234, 201, 199, 194, 134, 213, 199, 208, 195, 194, 134, 202, 207, 200, 205, 156, 134 }, 166) + _0xb7b813af);
                }
#endif
            }

            return _0xb7b813af;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4ad53cb9._0x340c215b(new byte[39] { 51, 60, 13, 27, 28, 53, 72, 47, 13, 28, 72, 7, 26, 72, 24, 9, 26, 27, 13, 72, 27, 9, 30, 13, 12, 72, 4, 1, 6, 3, 72, 14, 9, 1, 4, 13, 12, 82, 72 }, 104) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    internal Vector2 lastSize = Vector2.zero;
    internal Button _0x44715cc4(string _0x184d8173, Transform _0xdc1cde6e)
    {
        var _0x8742f6a9 = new GameObject(_0x184d8173 + _0x4ad53cb9._0x340c215b(new byte[3] { 98, 84, 78 }, 32), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x4fa790f3 = _0x8742f6a9.GetComponent<RectTransform>();
        _0x4fa790f3.SetParent(_0xdc1cde6e, false);
        var _0x493c9faa = _0x8742f6a9.GetComponent<Image>();
        _0x493c9faa.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x701eeab0 = _0x8742f6a9.GetComponent<Button>();
        var _0x832724d4 = _0x701eeab0.colors;
        _0x832724d4.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x832724d4.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x701eeab0.colors = _0x832724d4;
        var _0x85330a47 = new GameObject(_0x4ad53cb9._0x340c215b(new byte[4] { 225, 208, 205, 193 }, 181), typeof(RectTransform), typeof(Text));
        var _0x782f43d2 = _0x85330a47.GetComponent<RectTransform>();
        _0x782f43d2.SetParent(_0x8742f6a9.transform, false);
        _0x782f43d2.anchorMin = Vector2.zero;
        _0x782f43d2.anchorMax = Vector2.one;
        _0x782f43d2.offsetMin = _0x782f43d2.offsetMax = Vector2.zero;
        var _0x7348f764 = _0x85330a47.GetComponent<Text>();
        _0x7348f764.text = _0x184d8173;
        _0x7348f764.alignment = TextAnchor.MiddleCenter;
        _0x7348f764.color = Color.black;
        _0x7348f764.font = Resources.GetBuiltinResource<Font>(_0x4ad53cb9._0x340c215b(new byte[9] { 26, 41, 50, 58, 55, 117, 47, 47, 61 }, 91));
        _0x7348f764.fontSize = 28;
        WLog(_0x4ad53cb9._0x340c215b(new byte[14] { 139, 186, 173, 169, 188, 173, 138, 189, 188, 188, 167, 166, 232, 239 }, 200) + _0x184d8173 + _0x4ad53cb9._0x340c215b(new byte[1] { 70 }, 97));
        return _0x701eeab0;
    }

    // PART 3
    private string _0x61911407()
    {
        try
        {
            var _0x38d8f077 = new AndroidJavaClass(_0x4ad53cb9._0x340c215b(new byte[30] { 98, 110, 108, 47, 116, 111, 104, 117, 120, 50, 101, 47, 113, 109, 96, 120, 100, 115, 47, 84, 111, 104, 117, 120, 81, 109, 96, 120, 100, 115 }, 1));
            var _0x5289e9b1 = _0x38d8f077.GetStatic<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[15] { 58, 44, 43, 43, 60, 55, 45, 24, 58, 45, 48, 47, 48, 45, 32 }, 89));
            var _0xf5272ed2 = new AndroidJavaClass(_0x4ad53cb9._0x340c215b(new byte[57] { 234, 230, 228, 167, 238, 230, 230, 238, 229, 236, 167, 232, 231, 237, 251, 230, 224, 237, 167, 238, 228, 250, 167, 232, 237, 250, 167, 224, 237, 236, 231, 253, 224, 239, 224, 236, 251, 167, 200, 237, 255, 236, 251, 253, 224, 250, 224, 231, 238, 192, 237, 202, 229, 224, 236, 231, 253 }, 137));
            var _0x80f014ef = _0xf5272ed2.CallStatic<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[20] { 14, 12, 29, 40, 13, 31, 12, 27, 29, 0, 26, 0, 7, 14, 32, 13, 32, 7, 15, 6 }, 105), _0x5289e9b1);
            var _0xcc615964 = _0x80f014ef.Call<string>(_0x4ad53cb9._0x340c215b(new byte[5] { 193, 195, 210, 239, 194 }, 166));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xcc615964}");
#endif
            }

            return string.IsNullOrEmpty(_0xcc615964) ? "" : _0xcc615964;
        }
        catch
        {
            return "";
        }
    }

    private Text _0x7569e3fa;
    private string _0x54810c34()
    {
        string _0x63ce1a98 = _0x4ad53cb9._0x340c215b(new byte[62] { 95, 92, 93, 90, 91, 88, 89, 86, 87, 84, 85, 82, 83, 80, 81, 78, 79, 76, 77, 74, 75, 72, 73, 70, 71, 68, 127, 124, 125, 122, 123, 120, 121, 118, 119, 116, 117, 114, 115, 112, 113, 110, 111, 108, 109, 106, 107, 104, 105, 102, 103, 100, 14, 15, 12, 13, 10, 11, 8, 9, 6, 7 }, 62);
        System.Random _0x312ecc44 = new System.Random();
        int _0xe835e545 = _0x312ecc44.Next(8, 16);
        return new string (Enumerable.Repeat(_0x63ce1a98, _0xe835e545).Select(_0x4368fe2f => _0x4368fe2f[_0x312ecc44.Next(_0x4368fe2f.Length)]).ToArray());
    }

    private bool _0xb0d3b796()
    {
        var _0x9c397976 = Keyboard.current;
        return _0x9c397976 != null && _0x9c397976.escapeKey.wasPressedThisFrame;
    }

    internal bool isDestroyedForce = false;
    private bool _0x4d0d4e5d(string _0xc9a91c68)
    {
        try
        {
            using (var _0x54b2aaa3 = new AndroidJavaClass(_0x4ad53cb9._0x340c215b(new byte[30] { 136, 132, 134, 197, 158, 133, 130, 159, 146, 216, 143, 197, 155, 135, 138, 146, 142, 153, 197, 190, 133, 130, 159, 146, 187, 135, 138, 146, 142, 153 }, 235)))
            using (var _0x1e1bd60a = _0x54b2aaa3.GetStatic<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[15] { 126, 104, 111, 111, 120, 115, 105, 92, 126, 105, 116, 107, 116, 105, 100 }, 29)))
            using (var _0x695e0fcb = _0x1e1bd60a.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[17] { 164, 166, 183, 147, 162, 160, 168, 162, 164, 166, 142, 162, 173, 162, 164, 166, 177 }, 195)))
            using (var _0x98b81f1f = new AndroidJavaClass(_0x4ad53cb9._0x340c215b(new byte[22] { 47, 32, 42, 60, 33, 39, 42, 96, 45, 33, 32, 58, 43, 32, 58, 96, 7, 32, 58, 43, 32, 58 }, 78)))
            using (var _0x7d920a53 = _0x98b81f1f.CallStatic<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[8] { 97, 112, 99, 98, 116, 68, 99, 120 }, 17), _0xc9a91c68, 1))
            {
                string _0xe66154af = _0x7d920a53.Call<string>(_0x4ad53cb9._0x340c215b(new byte[14] { 128, 130, 147, 180, 147, 149, 142, 137, 128, 162, 159, 147, 149, 134 }, 231), _0x4ad53cb9._0x340c215b(new byte[20] { 206, 222, 195, 219, 223, 201, 222, 243, 202, 205, 192, 192, 206, 205, 207, 199, 243, 217, 222, 192 }, 172));
                string _0x39e1122f = _0x7d920a53.Call<string>(_0x4ad53cb9._0x340c215b(new byte[10] { 151, 149, 132, 160, 145, 147, 155, 145, 151, 149 }, 240));
                _0x7d920a53.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[11] { 65, 68, 68, 99, 65, 84, 69, 71, 79, 82, 89 }, 32), _0x4ad53cb9._0x340c215b(new byte[33] { 32, 47, 37, 51, 46, 40, 37, 111, 40, 47, 53, 36, 47, 53, 111, 34, 32, 53, 36, 38, 46, 51, 56, 111, 3, 19, 14, 22, 18, 0, 3, 13, 4 }, 65));
                _0x7d920a53.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[11] { 56, 47, 39, 37, 60, 47, 15, 50, 62, 56, 43 }, 74), _0x4ad53cb9._0x340c215b(new byte[20] { 26, 10, 23, 15, 11, 29, 10, 39, 30, 25, 20, 20, 26, 25, 27, 19, 39, 13, 10, 20 }, 120));
                if (_0x7d920a53.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[15] { 243, 228, 242, 238, 237, 247, 228, 192, 226, 245, 232, 247, 232, 245, 248 }, 129), _0x695e0fcb) != null)
                {
                    WLog(_0x4ad53cb9._0x340c215b(new byte[24] { 124, 87, 77, 80, 82, 90, 115, 86, 84, 90, 31, 80, 79, 90, 81, 31, 86, 81, 75, 90, 81, 75, 5, 31 }, 63) + _0xc9a91c68);
                    _0x7d920a53.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[8] { 161, 164, 164, 134, 172, 161, 167, 179 }, 192), 0x10000000);
                    _0x1e1bd60a.Call(_0x4ad53cb9._0x340c215b(new byte[13] { 90, 93, 72, 91, 93, 104, 74, 93, 64, 95, 64, 93, 80 }, 41), _0x7d920a53);
                    return true;
                }

                if (_0x44630b15(_0x39e1122f))
                    return true;
                if (!string.IsNullOrEmpty(_0xe66154af))
                {
                    WLog(_0x4ad53cb9._0x340c215b(new byte[28] { 3, 40, 50, 47, 45, 37, 12, 41, 43, 37, 96, 41, 46, 52, 37, 46, 52, 96, 38, 33, 44, 44, 34, 33, 35, 43, 122, 96 }, 64) + _0xe66154af);
                    if (_0x7245da7f(_0xe66154af))
                        return _0x192c9bbc(_0xe66154af, _0x39e1122f);
                    return _0x6d6ddf0a(_0xe66154af);
                }

                WLog(_0x4ad53cb9._0x340c215b(new byte[30] { 63, 20, 14, 19, 17, 25, 48, 21, 23, 25, 92, 21, 18, 8, 25, 18, 8, 92, 18, 19, 92, 20, 29, 18, 24, 16, 25, 14, 70, 92 }, 124) + _0xc9a91c68);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x4ad53cb9._0x340c215b(new byte[26] { 6, 45, 55, 42, 40, 32, 9, 44, 46, 32, 101, 44, 43, 49, 32, 43, 49, 101, 35, 36, 44, 41, 32, 33, 127, 101 }, 69) + e.Message);
            return true;
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x751741fe();
    }

    private async void Start()
    {
        await _0xd64eaab3();
    }

    // WEB VIEW LOGIC END
    internal void _0x2fba5add()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xc3c0acf6 = new AndroidNotificationChannel
        {
            Id = _0x4ad53cb9._0x340c215b(new byte[15] { 189, 188, 191, 184, 172, 181, 173, 134, 186, 177, 184, 183, 183, 188, 181 }, 217),
            Name = _0x4ad53cb9._0x340c215b(new byte[15] { 72, 105, 106, 109, 121, 96, 120, 44, 79, 100, 109, 98, 98, 105, 96 }, 12),
            Importance = Importance.High,
            Description = _0x4ad53cb9._0x340c215b(new byte[21] { 85, 119, 124, 119, 96, 115, 126, 50, 124, 125, 102, 123, 116, 123, 113, 115, 102, 123, 125, 124, 97 }, 18)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xc3c0acf6);
        // Build notification
        var _0x2667e6bb = new AndroidNotification
        {
            Title = _0xcafa3f0b[UnityEngine.Random.Range(0, _0xcafa3f0b.Length)],
            Text = _0x4ad53cb9._0x340c215b(new byte[21] { 160, 147, 132, 193, 152, 142, 148, 193, 146, 148, 147, 132, 193, 149, 142, 193, 132, 153, 136, 149, 222 }, 225),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x2667e6bb, _0x4ad53cb9._0x340c215b(new byte[15] { 35, 34, 33, 38, 50, 43, 51, 24, 36, 47, 38, 41, 41, 34, 43 }, 71));
    }

    private JObject _0x6e9b9a61(params string[] _0xb95812e8)
    {
        JObject _0x3f4a6e09 = new JObject();
        foreach (var _0x9b92bfc8 in _0xb95812e8)
        {
            string _0x83aaa108 = _0x54810c34();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x83aaa108} val={_0x9b92bfc8}");
#endif
            }

            _0x3f4a6e09.Add(_0x83aaa108, _0x9b92bfc8 == null ? "" : _0x9b92bfc8);
        }

        return _0x3f4a6e09;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x2bde8301)
    {
        if (_0x2bde8301 == null || _0x2bde8301.Extra == null)
            return null;
        object _0x00b5e6e3;
        if (!_0x2bde8301.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x00b5e6e3))
            return null;
        return _0x00b5e6e3 as string;
    }

    private bool _0x868ee576 = false;
    // MAIN FLOW
    private bool _0xb4d8b0df { get; set; }

    private void WLog(string _0x9f7ce5cd)
    {
#if B_LOGS
        {
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[7] { 223, 208, 225, 247, 240, 217, 164 }, 132) + _0x9f7ce5cd);
        }
#endif
    }

    private bool _0x37e425c1 = false;
    private void _0xae6328d9(string _0x46f5354b)
    {
        Dictionary<string, object> _0xc1212c53;
        try
        {
            _0xc1212c53 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x46f5354b);
        }
        catch
        {
            return;
        }

        var _0x9f5e786b = ReadPushField(_0xc1212c53, _0x4ad53cb9._0x340c215b(new byte[3] { 101, 98, 124 }, 16));
        if (string.IsNullOrWhiteSpace(_0x9f5e786b))
            return;
        _0x9f5e786b = _0x9f5e786b.Trim();
        if (!IsHttpUrl(_0x9f5e786b))
            return;
        if (string.Equals(_0x9f5e786b, _0x8212c1b6, StringComparison.Ordinal))
            return;
        _0x8212c1b6 = _0x9f5e786b;
        OpenUrlExternally(_0x9f5e786b);
    }

    private string _0xfa6fec2f = "";
    private bool _0x6342dc2d(int _0x5f20edd9, string _0xb5c95114, string _0x2f5f2637)
    {
        if (string.IsNullOrEmpty(_0x2f5f2637))
            return false;
        if (!IsHttpUrl(_0x2f5f2637))
            return true;
        if (string.IsNullOrEmpty(_0xb5c95114))
            return false;
        return _0xb5c95114.IndexOf(_0x4ad53cb9._0x340c215b(new byte[20] { 66, 85, 85, 88, 68, 72, 73, 73, 66, 68, 83, 78, 72, 73, 88, 85, 66, 84, 66, 83 }, 7), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb5c95114.IndexOf(_0x4ad53cb9._0x340c215b(new byte[22] { 75, 92, 92, 81, 77, 65, 64, 64, 75, 77, 90, 71, 65, 64, 81, 92, 75, 72, 91, 93, 75, 74 }, 14), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb5c95114.IndexOf(_0x4ad53cb9._0x340c215b(new byte[21] { 215, 192, 192, 205, 209, 221, 220, 220, 215, 209, 198, 219, 221, 220, 205, 209, 222, 221, 193, 215, 214 }, 146), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb5c95114.IndexOf(_0x4ad53cb9._0x340c215b(new byte[22] { 178, 165, 165, 168, 162, 185, 188, 185, 184, 160, 185, 168, 162, 165, 187, 168, 164, 180, 191, 178, 186, 178 }, 247), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal bool IsAboutBlank(string _0x63fd266f)
    {
        if (string.IsNullOrEmpty(_0x63fd266f))
            return false;
        return _0x63fd266f.StartsWith(_0x4ad53cb9._0x340c215b(new byte[11] { 51, 48, 61, 39, 38, 104, 48, 62, 51, 60, 57 }, 82), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x2cdf6bf9 = "";
    private string _0xa95576d3 = "";
    private string _0x8212c1b6;
    private RectTransform _0x276cc78e;
    private void _0x0ceda8d7()
    {
        if (_0x776a6972 != null)
            return;
        var _0x736be020 = _0xd7850fef();
        _0x776a6972 = new GameObject(_0x4ad53cb9._0x340c215b(new byte[14] { 46, 28, 27, 47, 16, 28, 14, 42, 9, 16, 23, 23, 28, 11 }, 121), typeof(RectTransform), typeof(Text));
        _0x276cc78e = _0x776a6972.GetComponent<RectTransform>();
        _0x276cc78e.SetParent(_0x736be020.transform, false);
        _0x276cc78e.anchorMin = new Vector2(0.5f, 0.5f);
        _0x276cc78e.anchorMax = new Vector2(0.5f, 0.5f);
        _0x276cc78e.pivot = new Vector2(0.5f, 0.5f);
        _0x276cc78e.sizeDelta = new Vector2(600f, 600f);
        _0x276cc78e.anchoredPosition = Vector2.zero;
        _0x7569e3fa = _0x776a6972.GetComponent<Text>();
        _0x7569e3fa.text = _0x4ad53cb9._0x340c215b(new byte[1] { 33 }, 14);
        _0x7569e3fa.font = Resources.GetBuiltinResource<Font>(_0x4ad53cb9._0x340c215b(new byte[17] { 217, 240, 242, 244, 246, 236, 199, 224, 251, 225, 252, 248, 240, 187, 225, 225, 243 }, 149));
        _0x7569e3fa.fontSize = 200;
        _0x7569e3fa.alignment = TextAnchor.MiddleCenter;
        _0x7569e3fa.color = Color.white;
        _0x7569e3fa.raycastTarget = false;
        _0x776a6972.SetActive(false);
    }

    private string _0xf3b02835 = "";
    private async Task<bool> _0x94624b9a()
    {
        _0x54ac6d04.Instance?._0x25bf46b8();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xe0a477c3) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4ad53cb9._0x340c215b(new byte[32] { 64, 79, 126, 104, 111, 70, 59, 78, 117, 114, 111, 98, 59, 75, 110, 104, 115, 59, 85, 116, 111, 114, 125, 114, 120, 122, 111, 114, 116, 117, 33, 59 }, 27) + string.Join(_0x4ad53cb9._0x340c215b(new byte[1] { 2 }, 11), _0xe0a477c3));
                }
#endif
            }
        };
        try
        {
            _0x50289b00 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4ad53cb9._0x340c215b(new byte[31] { 148, 155, 170, 188, 187, 146, 239, 137, 174, 166, 163, 170, 171, 239, 187, 160, 239, 168, 170, 187, 239, 191, 186, 188, 167, 239, 187, 160, 164, 170, 161 }, 207));
                }
#endif
            }

            _0x50289b00 = "";
        }

        _0x8f53c4be = !string.IsNullOrEmpty(_0x50289b00);
        _0xd1767389 = _0xf2a4fbf1();
        {
#if B_LOGS
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[25] { 234, 229, 212, 194, 197, 236, 145, 228, 223, 216, 197, 200, 145, 225, 196, 194, 217, 145, 229, 222, 218, 212, 223, 139, 145 }, 177) + _0x50289b00);
#endif
        }

        _0x54ac6d04.Instance?._0xc5255e69();
        return false;
    }

    public void _0x751741fe()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[18] { 75, 68, 117, 99, 100, 77, 48, 92, 113, 101, 126, 115, 120, 48, 87, 113, 125, 117 }, 16));
#endif
        }

        _0x54ac6d04.Instance?._0x03f811e8();
        _0xf397bc59.Instance._0xbd01eb3c(_0x5a9a28e3._0x379e6670.DEFAULT);
    }

    internal bool _0x7245da7f(string _0xa7c611c1)
    {
        return _0xa7c611c1.StartsWith(_0x4ad53cb9._0x340c215b(new byte[9] { 239, 227, 240, 233, 231, 246, 184, 173, 173 }, 130), StringComparison.OrdinalIgnoreCase) || _0xa7c611c1.StartsWith(_0x4ad53cb9._0x340c215b(new byte[24] { 161, 189, 189, 185, 186, 243, 230, 230, 185, 165, 168, 176, 231, 174, 166, 166, 174, 165, 172, 231, 170, 166, 164, 230 }, 201), StringComparison.OrdinalIgnoreCase) || _0xa7c611c1.StartsWith(_0x4ad53cb9._0x340c215b(new byte[23] { 53, 41, 41, 45, 103, 114, 114, 45, 49, 60, 36, 115, 58, 50, 50, 58, 49, 56, 115, 62, 50, 48, 114 }, 93), StringComparison.OrdinalIgnoreCase);
    }

    private Canvas _0xd7850fef()
    {
        if (_0x87976ee3 != null)
            return _0x87976ee3;
        var _0x74223b05 = gameObject.GetComponentInChildren<Canvas>();
        if (_0x74223b05 == null)
        {
            var _0xd207bbd3 = new GameObject(_0x4ad53cb9._0x340c215b(new byte[6] { 197, 231, 232, 240, 231, 245 }, 134), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x74223b05 = _0xd207bbd3.GetComponent<Canvas>();
            _0x74223b05.transform.SetParent(transform, false);
            _0x74223b05.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x87976ee3 = _0x74223b05;
        return _0x87976ee3;
    }

    private IEnumerator _0xe4d0767b()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[26] { 115, 124, 77, 91, 92, 117, 8, 97, 70, 65, 92, 65, 73, 68, 65, 82, 77, 122, 77, 78, 78, 77, 90, 77, 90, 8 }, 40));
            }
#endif
        }

        bool _0x5647ab9d = false;
        InstallReferrer.GetReferrer((_0x5c4e6a91) =>
        {
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[24] { 143, 128, 177, 167, 160, 244, 134, 177, 178, 177, 166, 166, 177, 166, 137, 244, 179, 177, 160, 244, 54, 82, 70, 244 }, 212) + _0x76f99a62);
            if (_0x5c4e6a91.IsSuccess)
            {
                _0x76f99a62 = _0x5c4e6a91.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x4ad53cb9._0x340c215b(new byte[28] { 101, 106, 91, 77, 74, 30, 108, 91, 88, 91, 76, 76, 91, 76, 99, 30, 109, 75, 93, 93, 91, 77, 77, 30, 220, 184, 172, 30 }, 62) + _0x76f99a62);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x4ad53cb9._0x340c215b(new byte[27] { 131, 140, 189, 171, 172, 248, 138, 189, 190, 189, 170, 170, 189, 170, 133, 248, 158, 185, 177, 180, 189, 188, 248, 58, 94, 74, 248 }, 216) + _0x5c4e6a91);
#endif
                }

                _0x76f99a62 = "";
            }

            _0xb4d8b0df = true;
        });
        StartCoroutine(_0xe6d9a874(2f));
        yield return new WaitUntil(() => _0xb4d8b0df);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x76f99a62}");
#endif
        }

        bool _0x51703b51 = _0x76f99a62.Contains(_0x4ad53cb9._0x340c215b(new byte[6] { 238, 234, 229, 224, 237, 180 }, 137));
        _0x5647ab9d = _0x51703b51 || _0x76f99a62.Contains(_0x4ad53cb9._0x340c215b(new byte[18] { 254, 239, 239, 236, 177, 246, 241, 236, 235, 254, 248, 237, 254, 242, 177, 252, 240, 242 }, 159)) || _0x76f99a62.Contains(_0x4ad53cb9._0x340c215b(new byte[17] { 183, 166, 166, 165, 248, 176, 183, 181, 179, 180, 185, 185, 189, 248, 181, 185, 187 }, 214));
        _0x6f203428 = _0x51703b51 ? "" : (_0x5647ab9d ? "" : _0x6f203428);
        _0x6f203428 = _0x6f203428 ?? "";
        _0x02d3ab97 = _0x02d3ab97 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x6f203428}");
#endif
        }
    }

    private bool _0xaf9e5e5f = false;
    private bool _0x192c9bbc(string _0x5bd97735, string _0xdca325ff)
    {
        string _0x75f1ba8f = _0x72a82b9f(_0x5bd97735);
        if (string.IsNullOrEmpty(_0x75f1ba8f))
            _0x75f1ba8f = _0xdca325ff;
        if (_0x44630b15(_0x75f1ba8f))
            return true;
        string _0x53b0233b = string.IsNullOrEmpty(_0x75f1ba8f) ? _0x4ad53cb9._0x340c215b(new byte[29] { 114, 110, 110, 106, 105, 32, 53, 53, 106, 118, 123, 99, 52, 125, 117, 117, 125, 118, 127, 52, 121, 117, 119, 53, 105, 110, 117, 104, 127 }, 26) : _0x4ad53cb9._0x340c215b(new byte[46] { 101, 121, 121, 125, 126, 55, 34, 34, 125, 97, 108, 116, 35, 106, 98, 98, 106, 97, 104, 35, 110, 98, 96, 34, 126, 121, 98, 127, 104, 34, 108, 125, 125, 126, 34, 105, 104, 121, 108, 100, 97, 126, 50, 100, 105, 48 }, 13) + _0x75f1ba8f;
        WLog(_0x4ad53cb9._0x340c215b(new byte[35] { 102, 77, 87, 74, 72, 64, 105, 76, 78, 64, 5, 72, 68, 87, 78, 64, 81, 5, 67, 68, 73, 73, 71, 68, 70, 78, 5, 68, 86, 5, 82, 64, 71, 31, 5 }, 37) + _0x53b0233b);
        return _0x6d6ddf0a(_0x53b0233b);
    }

    private string _0x651fb707()
    {
        try
        {
            using (var _0xf1b6b3df = new AndroidJavaClass(_0x4ad53cb9._0x340c215b(new byte[30] { 168, 164, 166, 229, 190, 165, 162, 191, 178, 248, 175, 229, 187, 167, 170, 178, 174, 185, 229, 158, 165, 162, 191, 178, 155, 167, 170, 178, 174, 185 }, 203)))
            {
                var _0x4699b10b = _0xf1b6b3df.GetStatic<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[15] { 81, 71, 64, 64, 87, 92, 70, 115, 81, 70, 91, 68, 91, 70, 75 }, 50));
                var _0xd36ac36f = _0x4699b10b.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[21] { 189, 191, 174, 155, 170, 170, 182, 179, 185, 187, 174, 179, 181, 180, 153, 181, 180, 174, 191, 162, 174 }, 218));
                using (var _0x88a6680a = new AndroidJavaClass(_0x4ad53cb9._0x340c215b(new byte[26] { 90, 85, 95, 73, 84, 82, 95, 21, 76, 94, 89, 80, 82, 79, 21, 108, 94, 89, 104, 94, 79, 79, 82, 85, 92, 72 }, 59)))
                {
                    return _0x88a6680a.CallStatic<string>(_0x4ad53cb9._0x340c215b(new byte[19] { 27, 25, 8, 56, 25, 26, 29, 9, 16, 8, 41, 15, 25, 14, 61, 27, 25, 18, 8 }, 124), _0xd36ac36f);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private IEnumerator _0x04f8ab8f(Dictionary<string, object> _0x6c914ed8)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[30] { 146, 157, 172, 186, 189, 148, 233, 143, 172, 189, 170, 161, 233, 140, 177, 189, 187, 168, 233, 153, 188, 186, 161, 233, 141, 168, 189, 168, 243, 233 }, 201) + string.Join(_0x4ad53cb9._0x340c215b(new byte[1] { 11 }, 2), _0x6c914ed8));
#endif
            }
        }

        string _0x8ab73d25 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x6c914ed8 != null && _0x6c914ed8.TryGetValue(_0x4ad53cb9._0x340c215b(new byte[16] { 142, 143, 148, 137, 134, 137, 131, 129, 148, 137, 143, 142, 164, 129, 148, 129 }, 224), out var raw))
        {
            try
            {
                var _0xd7e82cf1 = raw?.ToString();
                var _0x1c631b0c = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xd7e82cf1);
                if (_0x1c631b0c != null && _0x1c631b0c.TryGetValue(_0x4ad53cb9._0x340c215b(new byte[6] { 236, 250, 241, 251, 246, 251 }, 159), out var val))
                {
                    _0x8ab73d25 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x4ad53cb9._0x340c215b(new byte[30] { 5, 10, 59, 45, 42, 126, 14, 43, 45, 54, 3, 126, 20, 13, 17, 16, 126, 46, 63, 44, 45, 59, 126, 59, 44, 44, 49, 44, 100, 126 }, 94) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x8ab73d25) && _0x6c914ed8 != null && _0x6c914ed8.TryGetValue(_0x4ad53cb9._0x340c215b(new byte[6] { 91, 77, 70, 76, 65, 76 }, 40), out var lab))
        {
            _0x8ab73d25 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[38] { 182, 185, 136, 158, 153, 205, 189, 152, 158, 133, 176, 205, 171, 136, 153, 142, 133, 136, 137, 205, 158, 136, 131, 137, 132, 137, 205, 139, 159, 130, 128, 205, 135, 158, 130, 131, 215, 205 }, 237) + _0x8ab73d25);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x8ab73d25))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[38] { 139, 132, 181, 163, 164, 240, 128, 165, 163, 184, 141, 240, 135, 177, 185, 164, 240, 164, 191, 240, 191, 160, 181, 190, 240, 167, 185, 164, 184, 240, 163, 181, 190, 180, 185, 180, 234, 240 }, 208) + _0x8ab73d25);
            }
#endif
        }

        _0x43ce09a0 = _0x8ab73d25;
        yield return new WaitUntil(() => _0xbe2190d9);
        var _0x259c70c4 = _0x7786317c(2, 100);
        yield return new WaitUntil(() => _0x259c70c4.IsCompleted);
        string _0x9390097b = _0x259c70c4.Result;
        if (!string.IsNullOrEmpty(_0x9390097b))
        {
            string _0xb43e8a73 = _0x41b8baff(_0x9390097b, _0x8ab73d25);
            {
#if B_LOGS
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[33] { 48, 63, 14, 24, 31, 75, 59, 30, 24, 3, 54, 75, 57, 14, 7, 4, 10, 15, 75, 60, 14, 9, 61, 2, 14, 28, 75, 28, 2, 31, 3, 81, 75 }, 107) + _0xb43e8a73);
#endif
            }

            _0xde949823.Load(_0xb43e8a73);
        }
    }

    private static readonly string WindowsDesktopUserAgent = _0x4ad53cb9._0x340c215b(new byte[111] { 167, 133, 144, 131, 134, 134, 139, 197, 223, 196, 218, 202, 194, 189, 131, 132, 142, 133, 157, 153, 202, 164, 190, 202, 219, 218, 196, 218, 209, 202, 189, 131, 132, 220, 222, 209, 202, 146, 220, 222, 195, 202, 171, 154, 154, 134, 143, 189, 143, 136, 161, 131, 158, 197, 223, 217, 221, 196, 217, 220, 202, 194, 161, 162, 190, 167, 166, 198, 202, 134, 131, 129, 143, 202, 173, 143, 137, 129, 133, 195, 202, 169, 130, 152, 133, 135, 143, 197, 219, 216, 218, 196, 218, 196, 218, 196, 218, 202, 185, 139, 140, 139, 152, 131, 197, 223, 217, 221, 196, 217, 220 }, 234);
    private async Task _0x33bb27b9()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x2b0bdcc9 = _0x4ad53cb9._0x340c215b(new byte[5] { 66, 69, 72, 87, 65 }, 36);
        _0x02fcec53 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x8e5d77e3 = DateTime.UtcNow.Ticks.ToString();
        _0x2043d937 = "";
        JObject _0x0deaa807 = _0x6e9b9a61(_0x15b9ab1b, _0x4be284df, _0xccbd1be9, _0x50289b00, _0x76f99a62, _0x6f203428, _0x02d3ab97, _0x4f9eb2f3, _0x387f03e7, _0x2cdf6bf9, _0x2b0bdcc9, _0x2043d937, _0x9d8a13d5, _0xf3b02835, _0x39e09ea5.ToString(), _0xb640c5cf, _0x8e5d77e3, _0x02fcec53, _0x43a5b5ba, _0xa95576d3, _0xfa6fec2f, _0xd1767389, _0xf2a4fbf1());
        var _0x2924cb6f = _0xd3a88595(_0x0deaa807.ToString(), _0x43a5b5ba);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x0deaa807}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x4ad53cb9._0x340c215b(new byte[7] { 198, 215, 207, 218, 217, 215, 210 }, 182) + _0x43a5b5ba, _0x2924cb6f } });
            await Task.Delay(500);
            string _0x71aaa863 = "";
            for (int _0x45ac5cc9 = 0; _0x45ac5cc9 < 20; _0x45ac5cc9++)
            {
                if (await _0xdd463611(1, 1))
                {
                    await _0xcdb22da7(_0x4ad53cb9._0x340c215b(new byte[7] { 59, 53, 54, 58, 50, 60, 61 }, 89));
                    _0x751741fe();
                    return;
                }

                _0x71aaa863 = await _0x7786317c(1, 500);
                if (!string.IsNullOrEmpty(_0x71aaa863))
                    break;
            }

            _0x6317ad63(_0x71aaa863);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[22] { 214, 217, 200, 222, 217, 208, 173, 202, 232, 227, 232, 255, 236, 225, 173, 232, 255, 255, 226, 255, 183, 173 }, 141) + e.Message);
#endif
            }

            _0x751741fe();
        }
    }

    internal string _0x72a82b9f(string _0x4dd6b642)
    {
        int _0x3b0abaad = _0x4dd6b642.IndexOf(_0x4ad53cb9._0x340c215b(new byte[3] { 5, 8, 81 }, 108), StringComparison.OrdinalIgnoreCase);
        if (_0x3b0abaad < 0)
            return null;
        string _0xc48ce221 = _0x4dd6b642.Substring(_0x3b0abaad + 3);
        int _0x7893ea66 = _0xc48ce221.IndexOf('&');
        return _0x7893ea66 >= 0 ? _0xc48ce221.Substring(0, _0x7893ea66) : _0xc48ce221;
    }

    private GameObject _0x776a6972;
    // WS_SOURCE MONO
    public static _0x5bee87ee _0x4a1e206f { get; private set; }

    private IEnumerator _0xc707abaa(IEnumerator _0xf3c22995, TaskCompletionSource<bool> _0xf72707cd)
    {
        yield return _0xf3c22995;
        _0xf72707cd.SetResult(true);
    }

    private string _0x15b9ab1b = "";
    private string Decrypt(string _0x6cff427a, string _0xd52baadb)
    {
        try
        {
            var _0xa7f45932 = Convert.FromBase64String(_0x6cff427a);
            using var _0xef0bcf98 = Aes.Create();
            _0xef0bcf98.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xd52baadb));
            var _0xc24b2fa5 = new byte[16];
            Buffer.BlockCopy(_0xa7f45932, 0, _0xc24b2fa5, 0, 16);
            _0xef0bcf98.IV = _0xc24b2fa5;
            using var _0x12222d58 = new MemoryStream(_0xa7f45932, 16, _0xa7f45932.Length - 16);
            using var _0x28e6e2d6 = new CryptoStream(_0x12222d58, _0xef0bcf98.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x27bfb689 = new StreamReader(_0x28e6e2d6, Encoding.UTF8);
            return _0x27bfb689.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x02d3ab97 { get; set; }

    private async Task _0xd64eaab3()
    {
        if (await _0x81e1cf5f())
            return;
        if (await _0x94624b9a())
            return;
        if (await _0x0a9b1564())
            return;
        _0xc8a901ee();
        await _0xd5136142(_0xe4d0767b());
        _0x387f03e7 = await _0x579e6af3();
        await _0x33bb27b9();
    }

    private IEnumerator _0x91a921e2()
    {
        yield return _0x7078973f(Permission.Camera);
    }

    private void _0xc8a901ee()
    {
        {
#if B_LOGS
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[22] { 154, 149, 164, 178, 181, 156, 225, 146, 181, 174, 179, 164, 133, 164, 183, 168, 162, 164, 136, 175, 167, 174 }, 193));
#endif
        }

        _0x9d8a13d5 = SystemInfo.deviceModel;
        _0xf3b02835 = Application.version;
        _0x39e09ea5 = Application.installMode;
        _0xb640c5cf = Application.installerName;
        _0x15b9ab1b = Application.identifier;
        _0xccbd1be9 = _0x61911407();
        _0x4f9eb2f3 = _0x651fb707();
        _0x2cdf6bf9 = SystemInfo.deviceUniqueIdentifier;
        _0xa95576d3 = SystemInfo.graphicsDeviceName;
        _0xfa6fec2f = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0xf3b02835 = _0x4ad53cb9._0x340c215b(new byte[5] { 38, 63, 38, 63, 38 }, 17);
                _0x39e09ea5 = ApplicationInstallMode.Store;
                _0xb640c5cf = _0x4ad53cb9._0x340c215b(new byte[19] { 206, 194, 192, 131, 204, 195, 201, 223, 194, 196, 201, 131, 219, 200, 195, 201, 196, 195, 202 }, 173);
                _0x4f9eb2f3 = _0x4ad53cb9._0x340c215b(new byte[8] { 239, 231, 250, 254, 243, 170, 255, 235 }, 138);
                _0x2cdf6bf9 = Guid.NewGuid().ToString().Replace(_0x4ad53cb9._0x340c215b(new byte[1] { 151 }, 186), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[17] { 41, 38, 23, 1, 6, 47, 82, 22, 23, 4, 63, 29, 22, 23, 30, 72, 82 }, 114) + _0x9d8a13d5);
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[19] { 28, 19, 34, 52, 51, 26, 103, 38, 55, 55, 17, 34, 53, 52, 46, 40, 41, 125, 103 }, 71) + _0xf3b02835);
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[20] { 109, 98, 83, 69, 66, 107, 22, 95, 88, 69, 66, 87, 90, 90, 123, 89, 82, 83, 12, 22 }, 54) + _0x39e09ea5);
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[23] { 39, 40, 25, 15, 8, 33, 92, 21, 18, 15, 8, 29, 16, 16, 25, 14, 47, 8, 19, 14, 25, 70, 92 }, 124) + _0xb640c5cf);
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[14] { 54, 57, 8, 30, 25, 48, 77, 12, 29, 29, 36, 9, 87, 77 }, 109) + _0x15b9ab1b);
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[14] { 225, 238, 223, 201, 206, 231, 154, 219, 222, 204, 243, 222, 128, 154 }, 186) + _0xccbd1be9);
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[18] { 134, 137, 184, 174, 169, 128, 253, 168, 174, 184, 175, 156, 186, 184, 179, 169, 231, 253 }, 221) + _0x4f9eb2f3);
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[17] { 30, 17, 32, 54, 49, 24, 101, 54, 60, 54, 1, 32, 51, 12, 33, 127, 101 }, 69) + _0x2cdf6bf9);
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[12] { 15, 0, 49, 39, 32, 9, 116, 51, 36, 33, 110, 116 }, 84) + _0xa95576d3);
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[12] { 26, 21, 36, 50, 53, 28, 97, 34, 49, 52, 123, 97 }, 65) + _0xfa6fec2f);
#endif
        }
    }

    private void _0x40ca63a3(string _0xb988a686)
    {
        if (string.IsNullOrEmpty(_0xb988a686))
            return;
        if (TryOpenExternalLikeChrome(_0xb988a686))
            return;
        OpenUrlExternally(_0xb988a686);
    }

    private async Task<bool> _0x0a9b1564()
    {
        {
#if B_LOGS
            Debug.Log(_0x4ad53cb9._0x340c215b(new byte[29] { 63, 48, 1, 23, 16, 57, 68, 45, 23, 52, 22, 13, 18, 5, 7, 29, 37, 10, 0, 55, 5, 18, 1, 0, 39, 12, 1, 7, 15 }, 100));
#endif
        }

        string _0x4d48e3d8 = "";
        for (int _0x47234afa = 0; _0x47234afa < 2; _0x47234afa++)
        {
            if (await _0xdd463611(1, 100))
            {
                await _0xcdb22da7(_0x4ad53cb9._0x340c215b(new byte[7] { 34, 44, 47, 35, 43, 37, 36 }, 64));
                _0x751741fe();
                return true;
            }

            _0x4d48e3d8 = await _0x7786317c(1, 100);
            if (!string.IsNullOrEmpty(_0x4d48e3d8))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x4d48e3d8))
            {
                if (!string.IsNullOrEmpty(_0x43ce09a0))
                {
                    _0x4d48e3d8 = _0x41b8baff(_0x4d48e3d8, _0x43ce09a0);
                    {
#if B_LOGS
                        Debug.Log(_0x4ad53cb9._0x340c215b(new byte[53] { 148, 155, 170, 188, 187, 146, 239, 140, 174, 172, 167, 170, 171, 239, 169, 166, 161, 174, 163, 154, 189, 163, 239, 184, 166, 187, 167, 239, 188, 170, 161, 171, 166, 171, 239, 45, 73, 93, 239, 188, 167, 160, 184, 239, 152, 170, 173, 153, 166, 170, 184, 245, 239 }, 207) + _0x4d48e3d8);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x4ad53cb9._0x340c215b(new byte[39] { 8, 7, 54, 32, 39, 14, 115, 16, 50, 48, 59, 54, 55, 115, 53, 58, 61, 50, 63, 6, 33, 63, 115, 177, 213, 193, 115, 32, 59, 60, 36, 115, 4, 54, 49, 5, 58, 54, 36 }, 83));
#endif
                    }
                }

                _0x868ee576 = true;
                _0x08a6dd2d(_0x4d48e3d8);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4ad53cb9._0x340c215b(new byte[44] { 189, 178, 131, 149, 146, 187, 198, 163, 158, 133, 131, 150, 146, 143, 137, 136, 198, 145, 142, 143, 138, 131, 198, 133, 142, 131, 133, 141, 143, 136, 129, 198, 149, 135, 144, 131, 130, 198, 138, 143, 136, 141, 220, 198 }, 230) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private string _0x32a04098()
    {
        if (string.IsNullOrEmpty(_0x4f9eb2f3) && _0xde949823 != null)
            _0x4f9eb2f3 = _0xde949823.GetUserAgent();
        if (string.IsNullOrEmpty(_0x4f9eb2f3))
            return string.Empty;
        string _0x9c74dfcc = Regex.Replace(_0x4f9eb2f3, _0x4ad53cb9._0x340c215b(new byte[11] { 83, 124, 37, 52, 83, 124, 37, 120, 121, 83, 109 }, 15), string.Empty);
        _0x9c74dfcc = Regex.Replace(_0x9c74dfcc, _0x4ad53cb9._0x340c215b(new byte[15] { 252, 211, 139, 226, 213, 201, 204, 196, 143, 251, 254, 155, 137, 253, 139 }, 160), string.Empty);
        _0x9c74dfcc = Regex.Replace(_0x9c74dfcc, _0x4ad53cb9._0x340c215b(new byte[15] { 124, 79, 88, 89, 67, 69, 68, 5, 30, 118, 4, 26, 118, 89, 0 }, 42), string.Empty);
        return Regex.Replace(_0x9c74dfcc, _0x4ad53cb9._0x340c215b(new byte[6] { 162, 141, 133, 204, 210, 131 }, 254), _0x4ad53cb9._0x340c215b(new byte[1] { 127 }, 95)).Trim();
    }

    private void _0x90041a3a()
    {
        if (_0xde949823 == null)
            return;
        if (_0xa52c7549)
            _0xde949823.SetUserAgent(_0x32a04098());
        else
            _0xde949823.SetUserAgent("");
    }

    internal bool firstLoadShown = false;
    private bool _0xd61bbffa()
    {
        _0x96aa0d0e.RemoveAll(_0x3479c5dc => _0x3479c5dc == null || !_0x3479c5dc.IsAlive);
        return _0x96aa0d0e.Count > 0;
    }

    private void _0x2d20e4dc()
    {
        _0xa52c7549 = true;
        if (_0xde949823 != null)
            _0xde949823.SetUserAgent(_0x32a04098());
    }

    private void OnApplicationPause(bool _0xa9fdc4c0)
    {
        isApplicationPause = _0xa9fdc4c0;
    }

    // WEB VIEW LOGIC
    public bool _0xbe2190d9 { get; set; }

    internal bool IsHttpUrl(string _0x48de5136)
    {
        if (string.IsNullOrEmpty(_0x48de5136))
            return false;
        return _0x48de5136.StartsWith(_0x4ad53cb9._0x340c215b(new byte[7] { 81, 77, 77, 73, 3, 22, 22 }, 57), StringComparison.OrdinalIgnoreCase) || _0x48de5136.StartsWith(_0x4ad53cb9._0x340c215b(new byte[8] { 108, 112, 112, 116, 119, 62, 43, 43 }, 4), StringComparison.OrdinalIgnoreCase);
    }

    private readonly string[] _0xcafa3f0b = new string[]
    {
        _0x4ad53cb9._0x340c215b(new byte[60] { 33, 78, 95, 97, 241, 133, 185, 180, 241, 163, 180, 180, 189, 162, 241, 176, 163, 180, 241, 185, 190, 165, 241, 163, 184, 182, 185, 165, 241, 191, 190, 166, 241, 51, 81, 66, 241, 181, 190, 191, 51, 81, 72, 165, 241, 188, 184, 162, 162, 241, 168, 190, 164, 163, 241, 162, 161, 184, 191, 240 }, 209),
        _0x4ad53cb9._0x340c215b(new byte[52] { 28, 115, 97, 108, 204, 165, 152, 204, 143, 131, 153, 128, 136, 204, 142, 137, 204, 149, 131, 153, 158, 204, 128, 153, 143, 135, 149, 204, 129, 131, 129, 137, 130, 152, 204, 14, 108, 127, 204, 155, 132, 149, 204, 159, 152, 131, 156, 204, 130, 131, 155, 211 }, 236),
        _0x4ad53cb9._0x340c215b(new byte[66] { 132, 252, 199, 137, 222, 233, 70, 36, 15, 1, 70, 17, 15, 8, 21, 70, 7, 20, 3, 70, 14, 15, 18, 18, 15, 8, 1, 70, 11, 9, 20, 3, 70, 9, 0, 18, 3, 8, 70, 18, 9, 2, 7, 31, 70, 132, 230, 245, 70, 21, 18, 7, 31, 70, 15, 8, 70, 18, 14, 3, 70, 1, 7, 11, 3, 72 }, 102),
        _0x4ad53cb9._0x340c215b(new byte[54] { 24, 119, 125, 122, 200, 188, 128, 129, 155, 200, 129, 155, 200, 152, 154, 129, 133, 141, 200, 156, 129, 133, 141, 200, 10, 104, 123, 200, 156, 128, 141, 200, 138, 141, 155, 156, 200, 152, 132, 137, 145, 141, 154, 155, 200, 152, 132, 137, 145, 200, 134, 135, 159, 198 }, 232),
        _0x4ad53cb9._0x340c215b(new byte[48] { 142, 225, 234, 219, 94, 39, 17, 11, 12, 94, 9, 23, 16, 16, 23, 16, 25, 94, 13, 10, 12, 27, 31, 21, 94, 29, 17, 11, 18, 26, 94, 28, 27, 94, 17, 16, 27, 94, 13, 14, 23, 16, 94, 31, 9, 31, 7, 80 }, 126),
        _0x4ad53cb9._0x340c215b(new byte[65] { 123, 20, 17, 11, 171, 193, 234, 232, 224, 251, 228, 255, 248, 171, 234, 249, 238, 171, 230, 228, 249, 238, 171, 234, 232, 255, 226, 253, 238, 171, 255, 228, 229, 226, 236, 227, 255, 171, 105, 11, 24, 171, 248, 255, 234, 242, 171, 234, 229, 239, 171, 255, 249, 242, 171, 242, 228, 254, 249, 171, 231, 254, 232, 224, 165 }, 139),
        _0x4ad53cb9._0x340c215b(new byte[55] { 111, 0, 17, 45, 191, 218, 233, 250, 237, 230, 191, 236, 239, 246, 241, 191, 252, 240, 234, 241, 235, 236, 191, 125, 31, 12, 191, 235, 247, 250, 191, 241, 250, 231, 235, 191, 240, 241, 250, 191, 252, 240, 234, 243, 251, 191, 253, 250, 191, 230, 240, 234, 237, 236, 177 }, 159),
        _0x4ad53cb9._0x340c215b(new byte[63] { 128, 207, 242, 141, 218, 237, 66, 50, 14, 3, 27, 7, 16, 17, 66, 16, 11, 5, 10, 22, 66, 12, 13, 21, 66, 3, 16, 7, 66, 21, 11, 12, 12, 11, 12, 5, 66, 128, 226, 241, 66, 6, 13, 12, 128, 226, 251, 22, 66, 21, 3, 14, 9, 66, 3, 21, 3, 27, 66, 27, 7, 22, 76 }, 98),
        _0x4ad53cb9._0x340c215b(new byte[51] { 74, 37, 53, 60, 154, 245, 212, 214, 195, 154, 206, 210, 213, 201, 223, 154, 205, 210, 213, 154, 201, 206, 219, 195, 154, 211, 212, 154, 206, 210, 223, 154, 221, 219, 215, 223, 154, 205, 211, 212, 154, 206, 210, 223, 154, 202, 200, 211, 192, 223, 148 }, 186),
        _0x4ad53cb9._0x340c215b(new byte[64] { 97, 25, 34, 108, 59, 12, 163, 206, 236, 238, 230, 237, 247, 246, 238, 163, 234, 240, 163, 230, 245, 230, 241, 250, 247, 235, 234, 237, 228, 163, 97, 3, 16, 163, 232, 230, 230, 243, 163, 240, 243, 234, 237, 237, 234, 237, 228, 163, 229, 236, 241, 163, 250, 236, 246, 241, 163, 224, 235, 226, 237, 224, 230, 173 }, 131)
    };
    private void _0x3765277a()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private float _0xa9175fea = 0f;
    private string _0x43ce09a0;
    private void _0x6317ad63(string _0x1ea544a6)
    {
        bool _0xd1f98ccc = !string.IsNullOrEmpty(_0x1ea544a6);
        if (_0xd1f98ccc)
        {
            {
#if B_LOGS
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[13] { 11, 4, 53, 35, 36, 13, 112, 3, 56, 63, 39, 106, 112 }, 80) + _0x1ea544a6);
#endif
            }

            _0x08a6dd2d(_0x1ea544a6);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[39] { 36, 43, 26, 12, 11, 34, 95, 57, 30, 19, 19, 29, 30, 28, 20, 95, 157, 249, 237, 95, 56, 30, 18, 26, 95, 87, 17, 16, 95, 25, 22, 17, 30, 19, 95, 42, 45, 51, 86 }, 127));
#endif
            }

            _0x751741fe();
            return;
        }
    }

    private Canvas _0x87976ee3;
    private void _0xc9b2b54c(UniWebView _0xb930cd0a)
    {
        _0xb930cd0a.BackgroundColor = Color.clear;
        _0xb930cd0a.SetSupportMultipleWindows(true, true);
        _0xb930cd0a.SetBackButtonEnabled(false);
        _0xde949823.SetUserAgent(_0x32a04098());
    }

    private bool _0x7f2d3787 = false;
    private string _0x96f18f44()
    {
        string _0x843abf47 = _0x32a04098();
        if (string.IsNullOrEmpty(_0x843abf47))
            return _0x4ad53cb9._0x340c215b(new byte[7] { 125, 100, 98, 111, 43, 59, 48 }, 11);
        string _0x3d3aa1ce = _0x843abf47.Replace(_0x4ad53cb9._0x340c215b(new byte[1] { 223 }, 131), _0x4ad53cb9._0x340c215b(new byte[2] { 150, 150 }, 202)).Replace(_0x4ad53cb9._0x340c215b(new byte[1] { 67 }, 100), _0x4ad53cb9._0x340c215b(new byte[2] { 111, 20 }, 51));
        var _0x73193b71 = Regex.Match(_0x843abf47, _0x4ad53cb9._0x340c215b(new byte[12] { 225, 202, 208, 205, 207, 199, 141, 138, 254, 198, 137, 139 }, 162));
        string _0x79a5ffbe = _0x73193b71.Success ? _0x73193b71.Groups[1].Value : _0x4ad53cb9._0x340c215b(new byte[3] { 120, 123, 121 }, 73);
        return _0x4ad53cb9._0x340c215b(new byte[12] { 129, 207, 220, 199, 202, 221, 192, 198, 199, 129, 128, 210 }, 169) + _0x4ad53cb9._0x340c215b(new byte[8] { 10, 29, 14, 92, 9, 29, 65, 91 }, 124) + _0x3d3aa1ce + _0x4ad53cb9._0x340c215b(new byte[2] { 13, 17 }, 42) + _0x4ad53cb9._0x340c215b(new byte[30] { 241, 230, 245, 167, 247, 245, 232, 243, 232, 186, 201, 230, 241, 238, 224, 230, 243, 232, 245, 169, 247, 245, 232, 243, 232, 243, 254, 247, 226, 188 }, 135) + _0x4ad53cb9._0x340c215b(new byte[121] { 132, 151, 140, 129, 150, 139, 141, 140, 194, 134, 135, 132, 202, 141, 128, 136, 206, 137, 135, 155, 206, 148, 131, 142, 203, 153, 150, 144, 155, 153, 173, 128, 136, 135, 129, 150, 204, 134, 135, 132, 139, 140, 135, 178, 144, 141, 146, 135, 144, 150, 155, 202, 141, 128, 136, 206, 137, 135, 155, 206, 153, 133, 135, 150, 216, 132, 151, 140, 129, 150, 139, 141, 140, 202, 203, 153, 144, 135, 150, 151, 144, 140, 194, 148, 131, 142, 217, 159, 206, 129, 141, 140, 132, 139, 133, 151, 144, 131, 128, 142, 135, 216, 150, 144, 151, 135, 159, 203, 217, 159, 129, 131, 150, 129, 138, 202, 135, 203, 153, 159, 159 }, 226) + _0x4ad53cb9._0x340c215b(new byte[26] { 130, 131, 128, 206, 150, 148, 137, 146, 137, 202, 193, 147, 149, 131, 148, 167, 129, 131, 136, 146, 193, 202, 147, 135, 207, 221 }, 230) + _0x4ad53cb9._0x340c215b(new byte[52] { 99, 98, 97, 47, 119, 117, 104, 115, 104, 43, 32, 102, 119, 119, 81, 98, 117, 116, 110, 104, 105, 32, 43, 114, 102, 41, 117, 98, 119, 107, 102, 100, 98, 47, 40, 89, 74, 104, 125, 110, 107, 107, 102, 91, 40, 40, 43, 32, 32, 46, 46, 60 }, 7) + _0x4ad53cb9._0x340c215b(new byte[37] { 194, 195, 192, 142, 214, 212, 201, 210, 201, 138, 129, 214, 202, 199, 210, 192, 201, 212, 203, 129, 138, 129, 234, 207, 200, 211, 222, 134, 199, 212, 203, 208, 158, 202, 129, 143, 157 }, 166) + _0x4ad53cb9._0x340c215b(new byte[34] { 58, 59, 56, 118, 46, 44, 49, 42, 49, 114, 121, 40, 59, 48, 58, 49, 44, 121, 114, 121, 25, 49, 49, 57, 50, 59, 126, 23, 48, 61, 112, 121, 119, 101 }, 94) + _0x4ad53cb9._0x340c215b(new byte[30] { 70, 71, 68, 10, 82, 80, 77, 86, 77, 14, 5, 79, 67, 90, 118, 77, 87, 65, 74, 114, 77, 75, 76, 86, 81, 5, 14, 23, 11, 25 }, 34) + _0x4ad53cb9._0x340c215b(new byte[48] { 146, 148, 159, 157, 144, 135, 148, 198, 147, 135, 130, 219, 157, 132, 148, 135, 136, 130, 149, 220, 189, 157, 132, 148, 135, 136, 130, 220, 193, 165, 142, 148, 137, 139, 143, 147, 139, 193, 202, 144, 131, 148, 149, 143, 137, 136, 220, 193 }, 230) + _0x79a5ffbe + _0x4ad53cb9._0x340c215b(new byte[35] { 137, 211, 130, 213, 204, 220, 207, 192, 202, 148, 137, 233, 193, 193, 201, 194, 203, 142, 237, 198, 220, 193, 195, 203, 137, 130, 216, 203, 220, 221, 199, 193, 192, 148, 137 }, 174) + _0x79a5ffbe + _0x4ad53cb9._0x340c215b(new byte[238] { 11, 81, 0, 87, 78, 94, 77, 66, 72, 22, 11, 98, 67, 88, 17, 109, 19, 110, 94, 77, 66, 72, 11, 0, 90, 73, 94, 95, 69, 67, 66, 22, 11, 30, 24, 11, 81, 113, 0, 65, 67, 78, 69, 64, 73, 22, 88, 94, 89, 73, 0, 92, 64, 77, 88, 74, 67, 94, 65, 22, 11, 109, 66, 72, 94, 67, 69, 72, 11, 0, 75, 73, 88, 100, 69, 75, 68, 105, 66, 88, 94, 67, 92, 85, 122, 77, 64, 89, 73, 95, 22, 74, 89, 66, 79, 88, 69, 67, 66, 4, 5, 87, 94, 73, 88, 89, 94, 66, 12, 124, 94, 67, 65, 69, 95, 73, 2, 94, 73, 95, 67, 64, 90, 73, 4, 87, 77, 94, 79, 68, 69, 88, 73, 79, 88, 89, 94, 73, 22, 11, 77, 94, 65, 11, 0, 78, 69, 88, 66, 73, 95, 95, 22, 11, 26, 24, 11, 0, 65, 67, 78, 69, 64, 73, 22, 88, 94, 89, 73, 0, 65, 67, 72, 73, 64, 22, 11, 11, 0, 92, 64, 77, 88, 74, 67, 94, 65, 22, 11, 109, 66, 72, 94, 67, 69, 72, 11, 0, 92, 64, 77, 88, 74, 67, 94, 65, 122, 73, 94, 95, 69, 67, 66, 22, 11, 29, 24, 2, 28, 2, 28, 11, 0, 89, 77, 106, 89, 64, 64, 122, 73, 94, 95, 69, 67, 66, 22, 11 }, 44) + _0x79a5ffbe + _0x4ad53cb9._0x340c215b(new byte[117] { 172, 178, 172, 178, 172, 178, 165, 255, 171, 185, 255, 255, 185, 205, 224, 232, 231, 225, 246, 172, 230, 231, 228, 235, 236, 231, 210, 240, 237, 242, 231, 240, 246, 251, 170, 242, 240, 237, 246, 237, 174, 165, 247, 241, 231, 240, 195, 229, 231, 236, 246, 198, 227, 246, 227, 165, 174, 249, 229, 231, 246, 184, 228, 247, 236, 225, 246, 235, 237, 236, 170, 171, 249, 240, 231, 246, 247, 240, 236, 162, 247, 227, 230, 185, 255, 174, 225, 237, 236, 228, 235, 229, 247, 240, 227, 224, 238, 231, 184, 246, 240, 247, 231, 255, 171, 185, 255, 225, 227, 246, 225, 234, 170, 231, 171, 249, 255 }, 130) + _0x4ad53cb9._0x340c215b(new byte[5] { 19, 71, 70, 71, 85 }, 110);
    }

    private readonly List<UniWebViewPopup> _0x96aa0d0e = new List<UniWebViewPopup>();
    private IEnumerator _0xa2bb4a17(string _0x2ad4a077)
    {
        if (_0xde949823 != null && _0xbe2190d9)
            yield break;
        _0xde949823 = gameObject.AddComponent<UniWebView>();
        _0xc9b2b54c(_0xde949823);
        _0x61aadd32(_0xde949823);
        _0xde949823.BackgroundColor = Color.clear;
        var _0x44b1738e = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xd5107793();
        yield return new WaitForEndOfFrame();
        _0xbe2190d9 = true;
        _0x0ceda8d7();
        _0x673ab349(true);
        _0x7f2d3787 = false;
        _0xa52c7549 = false;
        _0x96aa0d0e.Clear();
        _0x20d64bd0 = -1;
        firstLoadShown = false;
        _0xb806a7a0 = false;
        _0x9efb78ba = false;
        _0xde949823.SetUserAgent("");
        _0xa9175fea = Time.realtimeSinceStartup;
        _0xde949823.Stop();
        _0xde949823.Load(_0x2ad4a077);
        _0xde949823.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x4ad53cb9._0x340c215b(new byte[25] { 57, 21, 29, 26, 84, 35, 17, 22, 34, 29, 17, 3, 84, 61, 26, 29, 0, 29, 21, 24, 84, 39, 28, 27, 3 }, 116));
    }

    private string _0x4be284df = "";
    private void OnApplicationFocus(bool _0xf924a2d0)
    {
        isApplicationFocus = _0xf924a2d0;
        if (_0xf924a2d0 && _0xbe2190d9)
        {
            _0x2944f58d();
        }
    }

    private void Awake()
    {
        if (_0x4a1e206f != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x4a1e206f = gameObject.GetComponent<_0x5bee87ee>();
        DontDestroyOnLoad(gameObject);
        _0x50289b00 = _0x6f203428 = _0x02d3ab97 = "";
        _0xf499c873 = "";
        _0xbe2190d9 = false;
    }

    private string _0x2043d937 = "";
    private void _0x61aadd32(UniWebView _0x4b3f74b6)
    {
        if (_0x37e425c1)
            return;
        _0x37e425c1 = true;
        _0x4b3f74b6.AddUrlScheme(_0x4ad53cb9._0x340c215b(new byte[2] { 60, 47 }, 72));
        _0x4b3f74b6.AddUrlScheme(_0x4ad53cb9._0x340c215b(new byte[6] { 126, 121, 99, 114, 121, 99 }, 23));
        _0x4b3f74b6.AddUrlScheme(_0x4ad53cb9._0x340c215b(new byte[6] { 238, 226, 241, 232, 230, 247 }, 131));
        _0x4b3f74b6.OnMessageReceived += (_0x6cecf82d, _0xefd99f0b) =>
        {
            if (TryOpenExternalLikeChrome(_0xefd99f0b.RawMessage))
            {
                _0x673ab349(false);
                return;
            }
        };
        _0x4b3f74b6.RegisterShouldHandleRequest(_0x7deba7c2 =>
        {
            string _0x01ae550b = _0x7deba7c2 != null ? _0x7deba7c2.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x01ae550b))
                return true;
            WLog(_0x4ad53cb9._0x340c215b(new byte[21] { 110, 85, 82, 72, 81, 89, 117, 92, 83, 89, 81, 88, 111, 88, 76, 72, 88, 78, 73, 7, 29 }, 61) + _0x01ae550b);
            if (TryOpenExternalLikeChrome(_0x01ae550b))
            {
                _0x673ab349(false);
                return false;
            }

            if (_0x7deba7c2 != null && _0x7deba7c2.IsMainFrame && IsGoogleAuthFlowUrl(_0x01ae550b) && !_0xa52c7549)
            {
                WLog(_0x4ad53cb9._0x340c215b(new byte[62] { 31, 51, 59, 60, 114, 5, 55, 48, 4, 59, 55, 37, 114, 54, 55, 38, 55, 49, 38, 55, 54, 114, 21, 61, 61, 53, 62, 55, 114, 51, 39, 38, 58, 114, 7, 0, 30, 114, 127, 108, 114, 32, 55, 62, 61, 51, 54, 114, 37, 59, 38, 58, 114, 21, 61, 61, 53, 62, 55, 114, 7, 19 }, 82));
                _0xa52c7549 = true;
                _0x673ab349(true);
                _0xde949823.SetUserAgent(_0x32a04098());
                _0xde949823.Load(_0x01ae550b);
                return false;
            }

            return true;
        });
        _0x4b3f74b6.OnLoadingErrorReceived += (_0x6cecf82d, _0x95a53377, _0xefd99f0b, _0x9668933f) =>
        {
            WLog(_0x4ad53cb9._0x340c215b(new byte[25] { 232, 196, 204, 203, 133, 242, 192, 199, 243, 204, 192, 210, 133, 224, 215, 215, 202, 215, 159, 133, 198, 202, 193, 192, 152 }, 165) + _0x95a53377 + _0x4ad53cb9._0x340c215b(new byte[9] { 209, 156, 148, 130, 130, 144, 150, 148, 204 }, 241) + _0xefd99f0b);
            string _0x52121a59 = GetFailingUrl(_0x9668933f);
            if (string.IsNullOrEmpty(_0x52121a59) || IsAboutBlank(_0x52121a59))
                return;
            _ = _0xcdb22da7(_0x4ad53cb9._0x340c215b(new byte[8] { 242, 243, 218, 224, 247, 247, 234, 247 }, 133));
            WLog(_0x4ad53cb9._0x340c215b(new byte[45] { 173, 129, 137, 142, 192, 183, 133, 130, 182, 137, 133, 151, 192, 134, 129, 137, 140, 137, 142, 135, 192, 181, 178, 172, 192, 205, 222, 192, 143, 144, 133, 142, 192, 133, 152, 148, 133, 146, 142, 129, 140, 140, 153, 218, 192 }, 224) + _0x52121a59);
            StopCurrentFailedLoad(_0x6cecf82d);
            _0x40ca63a3(_0x52121a59);
        };
        _0x4b3f74b6.OnPageStarted += (_0x6cecf82d, _0x94578d32) =>
        {
            _0xf16d1b61 = 0;
            if (_0x7f2d3787 && IsAboutBlank(_0x94578d32))
            {
                WLog(_0x4ad53cb9._0x340c215b(new byte[27] { 190, 156, 139, 153, 143, 156, 131, 206, 143, 140, 129, 155, 154, 212, 140, 130, 143, 128, 133, 206, 157, 154, 143, 156, 154, 139, 138 }, 238));
                return;
            }

            WLog(_0x4ad53cb9._0x340c215b(new byte[29] { 29, 49, 57, 62, 112, 7, 53, 50, 6, 57, 53, 39, 112, 31, 62, 0, 49, 55, 53, 3, 36, 49, 34, 36, 53, 52, 106, 112, 123 }, 80) + (Time.realtimeSinceStartup - _0xa9175fea).ToString(_0x4ad53cb9._0x340c215b(new byte[5] { 120, 102, 120, 120, 120 }, 72)) + _0x4ad53cb9._0x340c215b(new byte[2] { 23, 68 }, 100) + _0x94578d32);
            if (TryOpenExternalLikeChrome(_0x94578d32))
            {
                StopCurrentFailedLoad(_0x6cecf82d);
                return;
            }

            if (ContainsIgnoreCase(_0x94578d32, _0x4ad53cb9._0x340c215b(new byte[8] { 32, 45, 45, 37, 106, 37, 52, 52 }, 68)) || ContainsIgnoreCase(_0x94578d32, _0x4ad53cb9._0x340c215b(new byte[15] { 77, 92, 68, 19, 74, 84, 89, 90, 88, 73, 19, 95, 81, 82, 90 }, 61)) || _0x94578d32.StartsWith(_0x4ad53cb9._0x340c215b(new byte[25] { 158, 130, 130, 134, 133, 204, 217, 217, 148, 134, 145, 154, 153, 148, 151, 154, 144, 151, 128, 216, 154, 159, 128, 147, 217 }, 246), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x6cecf82d);
                OpenUrlExternally(_0x94578d32);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x94578d32))
            {
                _0x673ab349(true);
                WLog(_0x4ad53cb9._0x340c215b(new byte[41] { 26, 50, 50, 58, 49, 56, 125, 60, 40, 41, 53, 125, 59, 49, 50, 42, 125, 57, 56, 41, 56, 62, 41, 56, 57, 125, 112, 99, 125, 54, 56, 56, 45, 125, 43, 52, 46, 52, 63, 49, 56 }, 93));
                return;
            }

            _0xb806a7a0 = true;
            _0x673ab349(true);
            WLog(_0x4ad53cb9._0x340c215b(new byte[43] { 65, 115, 116, 64, 127, 115, 97, 54, 122, 121, 119, 114, 127, 120, 113, 57, 100, 115, 114, 127, 100, 115, 117, 98, 127, 120, 113, 54, 59, 40, 54, 125, 115, 115, 102, 54, 96, 127, 101, 127, 116, 122, 115 }, 22));
        };
        _0x4b3f74b6.OnPageCommitted += (_0x6cecf82d, _0x94578d32) =>
        {
            if (_0x7f2d3787 && IsAboutBlank(_0x94578d32))
                return;
            WLog(_0x4ad53cb9._0x340c215b(new byte[31] { 194, 238, 230, 225, 175, 216, 234, 237, 217, 230, 234, 248, 175, 192, 225, 223, 238, 232, 234, 204, 224, 226, 226, 230, 251, 251, 234, 235, 181, 175, 164 }, 143) + (Time.realtimeSinceStartup - _0xa9175fea).ToString(_0x4ad53cb9._0x340c215b(new byte[5] { 182, 168, 182, 182, 182 }, 134)) + _0x4ad53cb9._0x340c215b(new byte[2] { 212, 135 }, 167) + _0x94578d32);
            if (!firstLoadShown && IsHttpUrl(_0x94578d32))
            {
                firstLoadShown = true;
                _0xb806a7a0 = false;
                _0x673ab349(false);
                _0x3765277a();
                _0xd5107793();
                _0x6cecf82d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xcdb22da7(_0x4ad53cb9._0x340c215b(new byte[9] { 17, 16, 57, 9, 22, 3, 8, 3, 2 }, 102));
                WLog(_0x4ad53cb9._0x340c215b(new byte[39] { 207, 227, 235, 236, 162, 213, 231, 224, 212, 235, 231, 245, 162, 241, 234, 237, 245, 236, 162, 237, 236, 162, 225, 237, 239, 239, 235, 246, 246, 231, 230, 162, 225, 237, 236, 246, 231, 236, 246 }, 130));
            }
        };
        _0x4b3f74b6.OnPageProgressChanged += (_0x6cecf82d, _0x9eadd42d) =>
        {
            if (_0x7f2d3787)
                return;
            if (!firstLoadShown && _0x9eadd42d >= 0.65f)
            {
                firstLoadShown = true;
                _0xb806a7a0 = false;
                _0x673ab349(false);
                _0x3765277a();
                _0xd5107793();
                _0x6cecf82d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xcdb22da7(_0x4ad53cb9._0x340c215b(new byte[9] { 116, 117, 92, 108, 115, 102, 109, 102, 103 }, 3));
                WLog(_0x4ad53cb9._0x340c215b(new byte[32] { 58, 22, 30, 25, 87, 32, 18, 21, 33, 30, 18, 0, 87, 4, 31, 24, 0, 25, 87, 21, 14, 87, 7, 5, 24, 16, 5, 18, 4, 4, 77, 87 }, 119) + _0x9eadd42d);
            }
        };
        _0x4b3f74b6.OnPageFinished += (_0x6cecf82d, _0x95a53377, _0x94578d32) =>
        {
            if (_0x7f2d3787 && IsAboutBlank(_0x94578d32))
            {
                _0x7f2d3787 = false;
                WLog(_0x4ad53cb9._0x340c215b(new byte[28] { 180, 150, 129, 147, 133, 150, 137, 196, 133, 134, 139, 145, 144, 222, 134, 136, 133, 138, 143, 196, 130, 141, 138, 141, 151, 140, 129, 128 }, 228));
                return;
            }

            WLog(_0x4ad53cb9._0x340c215b(new byte[24] { 15, 35, 43, 44, 98, 21, 39, 32, 20, 43, 39, 53, 98, 4, 43, 44, 43, 49, 42, 39, 38, 120, 98, 105 }, 66) + (Time.realtimeSinceStartup - _0xa9175fea).ToString(_0x4ad53cb9._0x340c215b(new byte[5] { 113, 111, 113, 113, 113 }, 65)) + _0x4ad53cb9._0x340c215b(new byte[7] { 160, 243, 176, 188, 183, 182, 238 }, 211) + _0x95a53377 + _0x4ad53cb9._0x340c215b(new byte[5] { 244, 161, 166, 184, 233 }, 212) + _0x94578d32);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xb806a7a0 = false;
                _0x673ab349(false);
                _0x3765277a();
                _0xd5107793();
                _0x6cecf82d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xcdb22da7(_0x4ad53cb9._0x340c215b(new byte[9] { 82, 83, 122, 74, 85, 64, 75, 64, 65 }, 37));
                WLog(_0x4ad53cb9._0x340c215b(new byte[33] { 177, 157, 149, 146, 220, 171, 153, 158, 170, 149, 153, 139, 220, 154, 149, 142, 143, 136, 220, 144, 147, 157, 152, 220, 159, 147, 145, 140, 144, 153, 136, 153, 152 }, 252));
            }
            else if (_0xb806a7a0)
            {
                _0xb806a7a0 = false;
                _0x673ab349(false);
                _0x6cecf82d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x4ad53cb9._0x340c215b(new byte[40] { 214, 250, 242, 245, 187, 204, 254, 249, 205, 242, 254, 236, 187, 200, 243, 244, 236, 187, 250, 253, 239, 254, 233, 187, 247, 244, 250, 255, 242, 245, 252, 187, 253, 242, 245, 242, 232, 243, 254, 255 }, 155));
            }
            else
            {
                _0x673ab349(false);
            }

            if (_0xa52c7549 && !IsGoogleAuthFlowUrl(_0x94578d32) && !IsGoogleAuthFlowUrl(_0x94578d32))
            {
                WLog(_0x4ad53cb9._0x340c215b(new byte[48] { 87, 127, 127, 119, 124, 117, 48, 113, 101, 100, 120, 48, 99, 117, 117, 125, 99, 48, 118, 121, 126, 121, 99, 120, 117, 116, 48, 61, 46, 48, 98, 117, 99, 100, 127, 98, 117, 48, 116, 117, 118, 113, 101, 124, 100, 48, 69, 81 }, 16));
                _0xa52c7549 = false;
                _0xde949823.SetUserAgent("");
            }
        };
        _0x4b3f74b6.OnShouldClose += _0x6cecf82d =>
        {
            WLog(_0x4ad53cb9._0x340c215b(new byte[41] { 217, 214, 231, 241, 246, 223, 162, 207, 227, 235, 236, 162, 213, 231, 224, 212, 235, 231, 245, 162, 205, 236, 209, 234, 237, 247, 238, 230, 193, 238, 237, 241, 231, 162, 235, 236, 244, 237, 233, 231, 230 }, 130));
            _0x20f4f8d3();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x4b3f74b6.SetPopupPageEventEnabled(true);
        bool _0x1fbdae36 = false;
        bool _0x851ce848 = false;
        _0x4b3f74b6.OnMultipleWindowOpened += (_0x6cecf82d, _0x9a597995) =>
        {
            _0x6cecf82d.ScrollTo(0, 0, false);
            WLog(_0x4ad53cb9._0x340c215b(new byte[43] { 21, 26, 43, 61, 58, 19, 110, 3, 47, 39, 32, 110, 25, 43, 44, 24, 39, 43, 57, 110, 3, 59, 34, 58, 39, 62, 34, 43, 25, 39, 32, 42, 33, 57, 110, 1, 62, 43, 32, 43, 42, 116, 110 }, 78) + _0x9a597995);
            var _0xcd963dab = _0x4b3f74b6.GetPopupWindow(_0x9a597995);
            if (_0xcd963dab == null)
                return;
            _0x96aa0d0e.Add(_0xcd963dab);
            Debug.Log($"[Test] Popup ID: {_0xcd963dab.Id}");
            _0xcd963dab.OnPageStarted += (_0xaebb8086, _0x94578d32) =>
            {
                WLog(_0x4ad53cb9._0x340c215b(new byte[36] { 245, 250, 203, 221, 218, 243, 142, 254, 193, 222, 219, 222, 142, 249, 203, 204, 248, 199, 203, 217, 142, 225, 192, 254, 207, 201, 203, 253, 218, 207, 220, 218, 203, 202, 148, 142 }, 174) + _0x94578d32);
                _0xf16d1b61 = 0;
                if (string.IsNullOrEmpty(_0x94578d32) || IsAboutBlank(_0x94578d32))
                    return;
                if (IsGoogleAuthFlowUrl(_0x94578d32))
                {
                    WLog(_0x4ad53cb9._0x340c215b(new byte[57] { 62, 49, 0, 22, 17, 56, 69, 53, 10, 21, 16, 21, 69, 34, 10, 10, 2, 9, 0, 69, 4, 16, 17, 13, 69, 3, 9, 10, 18, 69, 72, 91, 69, 22, 21, 10, 10, 3, 69, 34, 10, 10, 2, 9, 0, 69, 38, 13, 23, 10, 8, 0, 69, 48, 36, 95, 69 }, 101) + _0x94578d32);
                    _0x1fbdae36 = false;
                    _0x2d20e4dc();
                    if (_0xaebb8086 != null && _0xaebb8086.IsAlive)
                        _0xaebb8086.EvaluateJavaScript(_0x96f18f44());
                    return;
                }

                if (_0xde949823 == null)
                    return;
                if (!_0x1fbdae36)
                {
                    _0x1fbdae36 = true;
                    _0xde949823.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x4ad53cb9._0x340c215b(new byte[39] { 174, 161, 144, 134, 129, 168, 213, 165, 154, 133, 128, 133, 213, 148, 133, 133, 153, 140, 213, 162, 156, 155, 145, 154, 130, 134, 213, 145, 144, 134, 158, 129, 154, 133, 213, 160, 180, 207, 213 }, 245) + _0x94578d32);
                }

                if (_0xaebb8086 != null && _0xaebb8086.IsAlive)
                    _0xaebb8086.EvaluateJavaScript(_0x5a17765c());
                if (!_0x851ce848 && _0xaebb8086 != null && _0xaebb8086.IsAlive && IsHttpUrl(_0x94578d32))
                {
                    _0x851ce848 = true;
                }
            };
            _0xcd963dab.OnPageFinished += (_0xaebb8086, _0x9668933f) =>
            {
                string _0xa89e60db = _0x9668933f != null ? _0x9668933f.data : string.Empty;
                WLog(_0x4ad53cb9._0x340c215b(new byte[35] { 95, 80, 97, 119, 112, 89, 36, 84, 107, 116, 113, 116, 36, 83, 97, 102, 82, 109, 97, 115, 36, 66, 109, 106, 109, 119, 108, 97, 96, 62, 36, 113, 118, 104, 57 }, 4) + _0xa89e60db);
                if (_0xaebb8086 == null || !_0xaebb8086.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xa89e60db))
                {
                    _0x2d20e4dc();
                    _0xaebb8086.EvaluateJavaScript(_0x96f18f44());
                    return;
                }

                if (!_0x1fbdae36)
                    return;
                _0xaebb8086.EvaluateJavaScript(_0x5a17765c());
            };
        };
        _0x4b3f74b6.OnMultipleWindowClosed += (_0x6cecf82d, _0x9a597995) =>
        {
            _0x96aa0d0e.RemoveAll(_0x3479c5dc => _0x3479c5dc == null || _0x3479c5dc.Id == _0x9a597995 || !_0x3479c5dc.IsAlive);
            _0x673ab349(false);
            if (_0x96aa0d0e.Count == 0 && _0xde949823 != null)
            {
                _0x1fbdae36 = false;
                _0x851ce848 = false;
                _0x90041a3a();
            }

            WLog(_0x4ad53cb9._0x340c215b(new byte[43] { 209, 222, 239, 249, 254, 215, 170, 199, 235, 227, 228, 170, 221, 239, 232, 220, 227, 239, 253, 170, 199, 255, 230, 254, 227, 250, 230, 239, 221, 227, 228, 238, 229, 253, 170, 201, 230, 229, 249, 239, 238, 176, 170 }, 138) + _0x9a597995);
        };
        _0x4b3f74b6.RegisterOnRequestMediaCapturePermission(_0x7deba7c2 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private Action _0x082a4120;
    internal bool isApplicationFocus = false;
    private UniWebViewPopup _0x61785968()
    {
        for (int _0xd80d9f19 = _0x96aa0d0e.Count - 1; _0xd80d9f19 >= 0; _0xd80d9f19--)
        {
            var _0x2738a3b5 = _0x96aa0d0e[_0xd80d9f19];
            if (_0x2738a3b5 != null && _0x2738a3b5.IsAlive)
                return _0x2738a3b5;
            _0x96aa0d0e.RemoveAt(_0xd80d9f19);
        }

        return null;
    }

    private bool _0x8f53c4be = false;
    private string _0x41b8baff(string _0x85203978, string _0x7c0da3d5)
    {
        if (string.IsNullOrEmpty(_0x7c0da3d5))
            return _0x85203978;
        if (_0x85203978.Contains(_0x4ad53cb9._0x340c215b(new byte[1] { 155 }, 164)))
            return _0x85203978 + _0x4ad53cb9._0x340c215b(new byte[8] { 128, 213, 195, 200, 194, 207, 194, 155 }, 166) + UnityWebRequest.EscapeURL(_0x7c0da3d5);
        else
            return _0x85203978 + _0x4ad53cb9._0x340c215b(new byte[8] { 204, 128, 150, 157, 151, 154, 151, 206 }, 243) + UnityWebRequest.EscapeURL(_0x7c0da3d5);
    }

    private ApplicationInstallMode _0x39e09ea5 = ApplicationInstallMode.Unknown;
    private static string ReadPushField(Dictionary<string, object> _0xb017b4eb, string _0x07885e12)
    {
        if (_0xb017b4eb == null || string.IsNullOrEmpty(_0x07885e12))
            return string.Empty;
        if (_0xb017b4eb.TryGetValue(_0x4ad53cb9._0x340c215b(new byte[16] { 248, 249, 226, 255, 240, 255, 245, 247, 226, 255, 249, 248, 210, 247, 226, 247 }, 150), out var raw))
        {
            try
            {
                var _0x591fd4a7 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x591fd4a7 != null && _0x591fd4a7.TryGetValue(_0x07885e12, out var nestedVal))
                {
                    var _0x2c3ccab5 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x2c3ccab5))
                        return _0x2c3ccab5;
                }
            }
            catch
            {
            }
        }

        if (_0xb017b4eb.TryGetValue(_0x07885e12, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    internal bool isApplicationPause = false;
    private string _0x76f99a62 = "";
    private string _0xb640c5cf = "";
    private bool _0x44630b15(string _0x01cd1966)
    {
        if (string.IsNullOrEmpty(_0x01cd1966))
            return false;
        try
        {
            using (var _0x4edd53a4 = new AndroidJavaClass(_0x4ad53cb9._0x340c215b(new byte[30] { 222, 210, 208, 147, 200, 211, 212, 201, 196, 142, 217, 147, 205, 209, 220, 196, 216, 207, 147, 232, 211, 212, 201, 196, 237, 209, 220, 196, 216, 207 }, 189)))
            using (var _0xe8ed6ce5 = _0x4edd53a4.GetStatic<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[15] { 33, 55, 48, 48, 39, 44, 54, 3, 33, 54, 43, 52, 43, 54, 59 }, 66)))
            using (var _0x28988586 = _0xe8ed6ce5.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[17] { 125, 127, 110, 74, 123, 121, 113, 123, 125, 127, 87, 123, 116, 123, 125, 127, 104 }, 26)))
            using (var _0xe4b47376 = _0x28988586.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[25] { 132, 134, 151, 175, 130, 150, 141, 128, 139, 170, 141, 151, 134, 141, 151, 165, 140, 145, 179, 130, 128, 136, 130, 132, 134 }, 227), _0x01cd1966))
            {
                if (_0xe4b47376 == null)
                    return false;
                WLog(_0x4ad53cb9._0x340c215b(new byte[37] { 173, 134, 156, 129, 131, 139, 162, 135, 133, 139, 206, 130, 143, 155, 128, 141, 134, 206, 135, 128, 157, 154, 143, 130, 130, 139, 138, 206, 158, 143, 141, 133, 143, 137, 139, 212, 206 }, 238) + _0x01cd1966);
                _0xe4b47376.Call<AndroidJavaObject>(_0x4ad53cb9._0x340c215b(new byte[8] { 48, 53, 53, 23, 61, 48, 54, 34 }, 81), 0x10000000);
                _0xe8ed6ce5.Call(_0x4ad53cb9._0x340c215b(new byte[13] { 100, 99, 118, 101, 99, 86, 116, 99, 126, 97, 126, 99, 110 }, 23), _0xe4b47376);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private int _0x05697838 = 5, _0x8cb10e71 = 5, _0x841079c8 = 5, _0x5e0860bf = 5;
    internal void _0xd5107793()
    {
        Rect _0x5dd64a9f = Screen.safeArea;
        Vector2 _0x7b2a7977 = new Vector2(Screen.width, Screen.height);
        if (_0x5dd64a9f == lastSafe && _0x7b2a7977 == lastSize)
            return;
        // Apply manual padding
        _0x5dd64a9f.xMin += _0x841079c8;
        _0x5dd64a9f.xMax -= _0x5e0860bf;
        _0x5dd64a9f.yMin += _0x8cb10e71;
        _0x5dd64a9f.yMax -= _0x05697838;
        // Convert Unity safe area -> native WebView frame
        Rect _0x7de7ea96 = new Rect(_0x5dd64a9f.x, _0x7b2a7977.y - _0x5dd64a9f.y - _0x5dd64a9f.height, // Y flip for native coordinate system
 _0x5dd64a9f.width, _0x5dd64a9f.height);
        _0xde949823.Frame = _0x7de7ea96;
        lastSafe = Screen.safeArea;
        lastSize = _0x7b2a7977;
    }

    private string _0x6f203428 { get; set; }

    private IEnumerator _0x7078973f(string _0xd0b2bf55)
    {
        if (Permission.HasUserAuthorizedPermission(_0xd0b2bf55))
            yield break;
        bool _0x467e3235 = false;
        var _0x08931126 = new PermissionCallbacks();
        _0x08931126.PermissionGranted += _0xfec5680b => _0x467e3235 = true;
        _0x08931126.PermissionDenied += _0xfec5680b => _0x467e3235 = true;
        Permission.RequestUserPermission(_0xd0b2bf55, _0x08931126);
        yield return new WaitUntil(() => _0x467e3235);
    }

    private bool _0x8786b044 = false;
    private bool _0x0c392569()
    {
        if (_0x30dc0564())
            return true;
        if (_0xde949823 != null && _0xde949823.CanGoBack)
        {
            WLog(_0x4ad53cb9._0x340c215b(new byte[36] { 186, 147, 128, 150, 133, 147, 128, 151, 210, 144, 147, 145, 153, 210, 223, 204, 210, 159, 147, 155, 156, 210, 165, 151, 144, 164, 155, 151, 133, 210, 181, 157, 176, 147, 145, 153 }, 242));
            _0xde949823.GoBack();
            return true;
        }

        return false;
    }

    private static bool IsPrivacyItemTrue(Item _0x7dd176da)
    {
        if (_0x7dd176da.Key != _0x4ad53cb9._0x340c215b(new byte[9] { 142, 148, 183, 149, 142, 145, 134, 132, 158 }, 231))
            return false;
        try
        {
            var _0x50c6bb23 = _0x7dd176da.Value.GetAs<object>();
            return _0x50c6bb23 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private async Task _0xcdb22da7(string _0xaddc2802)
    {
        if (_0xaf9e5e5f || string.IsNullOrEmpty(_0x43a5b5ba) || string.IsNullOrEmpty(_0xaddc2802) || _0x868ee576)
            return;
        _0xaf9e5e5f = true;
        try
        {
            JObject _0x65ea6a91 = _0x6e9b9a61(_0xaddc2802, _0x43a5b5ba, _0xf2a4fbf1());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xaddc2802} payload: {_0x65ea6a91}");
                }
#endif
            }

            var _0x24fd8dc0 = _0xd3a88595(_0x65ea6a91.ToString(), _0x43a5b5ba);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x4ad53cb9._0x340c215b(new byte[4] { 167, 164, 170, 175 }, 203) + _0x43a5b5ba, _0x24fd8dc0 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[24] { 186, 181, 164, 178, 181, 188, 193, 173, 142, 128, 133, 193, 145, 128, 146, 146, 193, 132, 147, 147, 142, 147, 219, 193 }, 225) + e.Message);
#endif
            }
        }
    }

    private string _0x50289b00 = "";
    private string _0x9d8a13d5 = "";
    private void _0x673ab349(bool _0x15a504e0)
    {
        _0x0ceda8d7();
        _0x776a6972.SetActive(_0x15a504e0);
        _0x8786b044 = _0x15a504e0;
        if (_0x15a504e0)
        {
            _0x776a6972.transform.SetAsLastSibling();
            if (_0x276cc78e != null)
                _0x276cc78e.localRotation = Quaternion.identity;
        }
    }

    private IEnumerator _0xe6d9a874(float _0x5b08a72d)
    {
        yield return new WaitForSeconds(_0x5b08a72d);
        if (!_0xb4d8b0df)
        {
            _0xb4d8b0df = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x76f99a62}");
                }
#endif
            }
        }
    }

    private string _0x2b0bdcc9 = "";
    private AndroidJavaObject _0x44e3ca8a { get; set; }

    internal bool IsGoogleAuthFlowUrl(string _0xe38f82a9)
    {
        if (string.IsNullOrEmpty(_0xe38f82a9))
            return false;
        return _0xe38f82a9.IndexOf(_0x4ad53cb9._0x340c215b(new byte[19] { 242, 240, 240, 252, 230, 253, 231, 224, 189, 244, 252, 252, 244, 255, 246, 189, 240, 252, 254 }, 147), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe38f82a9.IndexOf(_0x4ad53cb9._0x340c215b(new byte[16] { 224, 226, 226, 238, 244, 239, 245, 242, 175, 230, 238, 238, 230, 237, 228, 175 }, 129), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe38f82a9.IndexOf(_0x4ad53cb9._0x340c215b(new byte[21] { 162, 170, 170, 162, 169, 160, 176, 182, 160, 183, 166, 170, 171, 177, 160, 171, 177, 235, 166, 170, 168 }, 197), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe38f82a9.IndexOf(_0x4ad53cb9._0x340c215b(new byte[11] { 11, 31, 24, 13, 24, 5, 15, 66, 15, 3, 1 }, 108), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0x9efb78ba = false;
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x579e6af3()
    {
        var _0xd416992b = _0x4ad53cb9._0x340c215b(new byte[40] { 12, 16, 16, 20, 23, 94, 75, 75, 19, 19, 19, 74, 7, 8, 11, 17, 0, 2, 8, 5, 22, 1, 74, 7, 11, 9, 75, 7, 0, 10, 73, 7, 3, 13, 75, 16, 22, 5, 7, 1 }, 100);
        using (UnityWebRequest _0x04940c15 = UnityWebRequest.Get(_0xd416992b))
        {
            await _0x04940c15.SendWebRequest();
            string[] _0x3cb0d926 = _0x04940c15.downloadHandler.text.Split('\n');
            foreach (string _0xeaf8ba1c in _0x3cb0d926)
            {
                if (_0xeaf8ba1c.StartsWith(_0x4ad53cb9._0x340c215b(new byte[3] { 217, 192, 141 }, 176)))
                {
                    string _0xe2c04372 = _0xeaf8ba1c.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xe2c04372} from {_0xd416992b}");
                        }
#endif
                    }

                    return _0xe2c04372;
                }
            }
        }

        return "";
    }

    internal Rect lastSafe = Rect.zero;
    private Task _0xd5136142(IEnumerator _0xfe4399ff)
    {
        var _0xb529439f = new TaskCompletionSource<bool>();
        StartCoroutine(_0xc707abaa(_0xfe4399ff, _0xb529439f));
        return _0xb529439f.Task;
    }

    private string _0xf2a4fbf1()
    {
        float _0x8c53e473 = Time.realtimeSinceStartup;
        if (_0x8c53e473 < 0f)
            _0x8c53e473 = 0f;
        int _0x9de2370b = (int)(_0x8c53e473 * 1000f);
        int _0x8037da30 = _0x9de2370b / 60000;
        int _0x9c83cadc = (_0x9de2370b / 1000) % 60;
        int _0x2b6a9a29 = _0x9de2370b % 1000;
        return string.Format(_0x4ad53cb9._0x340c215b(new byte[21] { 203, 128, 138, 128, 128, 205, 138, 203, 129, 138, 128, 128, 205, 138, 203, 130, 138, 128, 128, 128, 205 }, 176), _0x8037da30, _0x9c83cadc, _0x2b6a9a29);
    }

    private string _0x4f9eb2f3 = "";
    private void StopCurrentFailedLoad(UniWebView _0x13e4e226)
    {
        _0x673ab349(false);
        if (_0x13e4e226 == null)
            return;
        _0x13e4e226.Stop();
        if (_0x13e4e226.CanGoBack)
            _0x13e4e226.GoBack();
    }

    internal void Update()
    {
        if (_0xde949823 == null)
            return;
        if (_0xb0d3b796())
            _0x20f4f8d3();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xd5107793();
        if (_0x8786b044 && _0x276cc78e != null)
            _0x276cc78e.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private string _0x5a17765c()
    {
        return _0x4ad53cb9._0x340c215b(new byte[12] { 36, 106, 121, 98, 111, 120, 101, 99, 98, 36, 37, 119 }, 12) + _0x4ad53cb9._0x340c215b(new byte[8] { 191, 168, 187, 233, 188, 168, 244, 238 }, 201) + WindowsDesktopUserAgent + _0x4ad53cb9._0x340c215b(new byte[2] { 116, 104 }, 83) + _0x4ad53cb9._0x340c215b(new byte[30] { 218, 205, 222, 140, 220, 222, 195, 216, 195, 145, 226, 205, 218, 197, 203, 205, 216, 195, 222, 130, 220, 222, 195, 216, 195, 216, 213, 220, 201, 151 }, 172) + _0x4ad53cb9._0x340c215b(new byte[121] { 50, 33, 58, 55, 32, 61, 59, 58, 116, 48, 49, 50, 124, 59, 54, 62, 120, 63, 49, 45, 120, 34, 53, 56, 125, 47, 32, 38, 45, 47, 27, 54, 62, 49, 55, 32, 122, 48, 49, 50, 61, 58, 49, 4, 38, 59, 36, 49, 38, 32, 45, 124, 59, 54, 62, 120, 63, 49, 45, 120, 47, 51, 49, 32, 110, 50, 33, 58, 55, 32, 61, 59, 58, 124, 125, 47, 38, 49, 32, 33, 38, 58, 116, 34, 53, 56, 111, 41, 120, 55, 59, 58, 50, 61, 51, 33, 38, 53, 54, 56, 49, 110, 32, 38, 33, 49, 41, 125, 111, 41, 55, 53, 32, 55, 60, 124, 49, 125, 47, 41, 41 }, 84) + _0x4ad53cb9._0x340c215b(new byte[26] { 164, 165, 166, 232, 176, 178, 175, 180, 175, 236, 231, 181, 179, 165, 178, 129, 167, 165, 174, 180, 231, 236, 181, 161, 233, 251 }, 192) + _0x4ad53cb9._0x340c215b(new byte[130] { 137, 136, 139, 197, 157, 159, 130, 153, 130, 193, 202, 140, 157, 157, 187, 136, 159, 158, 132, 130, 131, 202, 193, 202, 216, 195, 221, 205, 197, 186, 132, 131, 137, 130, 154, 158, 205, 163, 185, 205, 220, 221, 195, 221, 214, 205, 186, 132, 131, 219, 217, 214, 205, 149, 219, 217, 196, 205, 172, 157, 157, 129, 136, 186, 136, 143, 166, 132, 153, 194, 216, 222, 218, 195, 222, 219, 205, 197, 166, 165, 185, 160, 161, 193, 205, 129, 132, 134, 136, 205, 170, 136, 142, 134, 130, 196, 205, 174, 133, 159, 130, 128, 136, 194, 220, 223, 221, 195, 221, 195, 221, 195, 221, 205, 190, 140, 139, 140, 159, 132, 194, 216, 222, 218, 195, 222, 219, 202, 196, 214 }, 237) + _0x4ad53cb9._0x340c215b(new byte[30] { 45, 44, 47, 97, 57, 59, 38, 61, 38, 101, 110, 57, 37, 40, 61, 47, 38, 59, 36, 110, 101, 110, 30, 32, 39, 122, 123, 110, 96, 114 }, 73) + _0x4ad53cb9._0x340c215b(new byte[34] { 147, 146, 145, 223, 135, 133, 152, 131, 152, 219, 208, 129, 146, 153, 147, 152, 133, 208, 219, 208, 176, 152, 152, 144, 155, 146, 215, 190, 153, 148, 217, 208, 222, 204 }, 247) + _0x4ad53cb9._0x340c215b(new byte[30] { 123, 122, 121, 55, 111, 109, 112, 107, 112, 51, 56, 114, 126, 103, 75, 112, 106, 124, 119, 79, 112, 118, 113, 107, 108, 56, 51, 47, 54, 36 }, 31) + _0x4ad53cb9._0x340c215b(new byte[449] { 255, 249, 242, 240, 253, 234, 249, 171, 254, 234, 239, 182, 240, 233, 249, 234, 229, 239, 248, 177, 208, 240, 233, 249, 234, 229, 239, 177, 172, 200, 227, 249, 228, 230, 226, 254, 230, 172, 167, 253, 238, 249, 248, 226, 228, 229, 177, 172, 186, 185, 187, 172, 246, 167, 240, 233, 249, 234, 229, 239, 177, 172, 204, 228, 228, 236, 231, 238, 171, 200, 227, 249, 228, 230, 238, 172, 167, 253, 238, 249, 248, 226, 228, 229, 177, 172, 186, 185, 187, 172, 246, 167, 240, 233, 249, 234, 229, 239, 177, 172, 197, 228, 255, 182, 202, 180, 201, 249, 234, 229, 239, 172, 167, 253, 238, 249, 248, 226, 228, 229, 177, 172, 185, 191, 172, 246, 214, 167, 230, 228, 233, 226, 231, 238, 177, 237, 234, 231, 248, 238, 167, 251, 231, 234, 255, 237, 228, 249, 230, 177, 172, 220, 226, 229, 239, 228, 252, 248, 172, 167, 236, 238, 255, 195, 226, 236, 227, 206, 229, 255, 249, 228, 251, 242, 221, 234, 231, 254, 238, 248, 177, 237, 254, 229, 232, 255, 226, 228, 229, 163, 162, 240, 249, 238, 255, 254, 249, 229, 171, 219, 249, 228, 230, 226, 248, 238, 165, 249, 238, 248, 228, 231, 253, 238, 163, 240, 234, 249, 232, 227, 226, 255, 238, 232, 255, 254, 249, 238, 177, 172, 243, 179, 189, 172, 167, 233, 226, 255, 229, 238, 248, 248, 177, 172, 189, 191, 172, 167, 230, 228, 233, 226, 231, 238, 177, 237, 234, 231, 248, 238, 167, 230, 228, 239, 238, 231, 177, 172, 172, 167, 251, 231, 234, 255, 237, 228, 249, 230, 177, 172, 220, 226, 229, 239, 228, 252, 248, 172, 167, 251, 231, 234, 255, 237, 228, 249, 230, 221, 238, 249, 248, 226, 228, 229, 177, 172, 186, 190, 165, 187, 165, 187, 172, 167, 254, 234, 205, 254, 231, 231, 221, 238, 249, 248, 226, 228, 229, 177, 172, 186, 185, 187, 165, 187, 165, 187, 165, 187, 172, 246, 162, 176, 246, 246, 176, 196, 233, 225, 238, 232, 255, 165, 239, 238, 237, 226, 229, 238, 219, 249, 228, 251, 238, 249, 255, 242, 163, 251, 249, 228, 255, 228, 167, 172, 254, 248, 238, 249, 202, 236, 238, 229, 255, 207, 234, 255, 234, 172, 167, 240, 236, 238, 255, 177, 237, 254, 229, 232, 255, 226, 228, 229, 163, 162, 240, 249, 238, 255, 254, 249, 229, 171, 254, 234, 239, 176, 246, 167, 232, 228, 229, 237, 226, 236, 254, 249, 234, 233, 231, 238, 177, 255, 249, 254, 238, 246, 162, 176, 246, 232, 234, 255, 232, 227, 163, 238, 162, 240, 246 }, 139) + _0x4ad53cb9._0x340c215b(new byte[112] { 158, 159, 156, 210, 137, 153, 136, 159, 159, 148, 214, 221, 141, 147, 158, 142, 146, 221, 214, 203, 195, 200, 202, 211, 193, 158, 159, 156, 210, 137, 153, 136, 159, 159, 148, 214, 221, 146, 159, 147, 157, 146, 142, 221, 214, 203, 202, 194, 202, 211, 193, 158, 159, 156, 210, 137, 153, 136, 159, 159, 148, 214, 221, 155, 140, 155, 147, 150, 173, 147, 158, 142, 146, 221, 214, 203, 195, 200, 202, 211, 193, 158, 159, 156, 210, 137, 153, 136, 159, 159, 148, 214, 221, 155, 140, 155, 147, 150, 178, 159, 147, 157, 146, 142, 221, 214, 203, 202, 206, 202, 211, 193 }, 250) + _0x4ad53cb9._0x340c215b(new byte[45] { 112, 118, 125, 127, 115, 109, 106, 96, 107, 115, 42, 107, 106, 112, 107, 113, 103, 108, 119, 112, 101, 118, 112, 57, 113, 106, 96, 97, 98, 109, 106, 97, 96, 63, 121, 103, 101, 112, 103, 108, 44, 97, 45, 127, 121 }, 4) + _0x4ad53cb9._0x340c215b(new byte[721] { 202, 204, 199, 197, 200, 223, 204, 158, 209, 204, 215, 217, 131, 201, 215, 208, 218, 209, 201, 144, 211, 223, 202, 221, 214, 243, 219, 218, 215, 223, 144, 220, 215, 208, 218, 150, 201, 215, 208, 218, 209, 201, 151, 133, 201, 215, 208, 218, 209, 201, 144, 211, 223, 202, 221, 214, 243, 219, 218, 215, 223, 131, 216, 203, 208, 221, 202, 215, 209, 208, 150, 207, 151, 197, 200, 223, 204, 158, 205, 131, 237, 202, 204, 215, 208, 217, 150, 207, 151, 144, 202, 209, 242, 209, 201, 219, 204, 253, 223, 205, 219, 150, 151, 133, 215, 216, 150, 205, 144, 215, 208, 218, 219, 198, 241, 216, 150, 153, 206, 209, 215, 208, 202, 219, 204, 132, 158, 221, 209, 223, 204, 205, 219, 153, 151, 128, 131, 142, 194, 194, 205, 144, 215, 208, 218, 219, 198, 241, 216, 150, 153, 214, 209, 200, 219, 204, 132, 158, 208, 209, 208, 219, 153, 151, 128, 131, 142, 194, 194, 205, 144, 215, 208, 218, 219, 198, 241, 216, 150, 153, 211, 223, 198, 147, 201, 215, 218, 202, 214, 153, 151, 128, 131, 142, 194, 194, 205, 144, 215, 208, 218, 219, 198, 241, 216, 150, 153, 211, 223, 198, 147, 218, 219, 200, 215, 221, 219, 147, 201, 215, 218, 202, 214, 153, 151, 128, 131, 142, 151, 204, 219, 202, 203, 204, 208, 158, 197, 211, 223, 202, 221, 214, 219, 205, 132, 216, 223, 210, 205, 219, 146, 211, 219, 218, 215, 223, 132, 207, 146, 209, 208, 221, 214, 223, 208, 217, 219, 132, 208, 203, 210, 210, 146, 223, 218, 218, 242, 215, 205, 202, 219, 208, 219, 204, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 195, 146, 204, 219, 211, 209, 200, 219, 242, 215, 205, 202, 219, 208, 219, 204, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 195, 146, 223, 218, 218, 251, 200, 219, 208, 202, 242, 215, 205, 202, 219, 208, 219, 204, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 195, 146, 204, 219, 211, 209, 200, 219, 251, 200, 219, 208, 202, 242, 215, 205, 202, 219, 208, 219, 204, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 195, 146, 218, 215, 205, 206, 223, 202, 221, 214, 251, 200, 219, 208, 202, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 204, 219, 202, 203, 204, 208, 158, 216, 223, 210, 205, 219, 133, 195, 195, 133, 215, 216, 150, 205, 144, 215, 208, 218, 219, 198, 241, 216, 150, 153, 206, 209, 215, 208, 202, 219, 204, 132, 158, 216, 215, 208, 219, 153, 151, 128, 131, 142, 194, 194, 205, 144, 215, 208, 218, 219, 198, 241, 216, 150, 153, 214, 209, 200, 219, 204, 132, 158, 214, 209, 200, 219, 204, 153, 151, 128, 131, 142, 151, 204, 219, 202, 203, 204, 208, 158, 197, 211, 223, 202, 221, 214, 219, 205, 132, 202, 204, 203, 219, 146, 211, 219, 218, 215, 223, 132, 207, 146, 209, 208, 221, 214, 223, 208, 217, 219, 132, 208, 203, 210, 210, 146, 223, 218, 218, 242, 215, 205, 202, 219, 208, 219, 204, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 195, 146, 204, 219, 211, 209, 200, 219, 242, 215, 205, 202, 219, 208, 219, 204, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 195, 146, 223, 218, 218, 251, 200, 219, 208, 202, 242, 215, 205, 202, 219, 208, 219, 204, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 195, 146, 204, 219, 211, 209, 200, 219, 251, 200, 219, 208, 202, 242, 215, 205, 202, 219, 208, 219, 204, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 195, 146, 218, 215, 205, 206, 223, 202, 221, 214, 251, 200, 219, 208, 202, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 204, 219, 202, 203, 204, 208, 158, 216, 223, 210, 205, 219, 133, 195, 195, 133, 204, 219, 202, 203, 204, 208, 158, 209, 204, 215, 217, 150, 207, 151, 133, 195, 133, 195, 221, 223, 202, 221, 214, 150, 219, 151, 197, 195 }, 190) + _0x4ad53cb9._0x340c215b(new byte[5] { 240, 164, 165, 164, 182 }, 141);
    }

    private void _0x08a6dd2d(string _0xd5005f70)
    {
        _0x2944f58d();
        StartCoroutine(_0xa2bb4a17(_0xd5005f70));
    }

    public void _0x430fec7d()
    {
        if (_0xbe2190d9)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[33] { 48, 63, 14, 24, 31, 54, 75, 63, 2, 6, 14, 25, 75, 4, 30, 31, 75, 70, 85, 75, 6, 4, 29, 14, 75, 31, 4, 75, 24, 8, 14, 5, 14 }, 107));
            }
#endif
        }

        _0x751741fe();
    }

    private bool TryOpenExternalLikeChrome(string _0xa8e196c1)
    {
        if (string.IsNullOrEmpty(_0xa8e196c1))
            return false;
        if (_0xa8e196c1.StartsWith(_0x4ad53cb9._0x340c215b(new byte[9] { 209, 214, 204, 221, 214, 204, 130, 151, 151 }, 184), StringComparison.OrdinalIgnoreCase))
            return _0x4d0d4e5d(_0xa8e196c1);
        if (_0x7245da7f(_0xa8e196c1))
            return _0x192c9bbc(_0xa8e196c1, null);
        if (!_0xa8e196c1.StartsWith(_0x4ad53cb9._0x340c215b(new byte[7] { 202, 214, 214, 210, 152, 141, 141 }, 162), StringComparison.OrdinalIgnoreCase) && !_0xa8e196c1.StartsWith(_0x4ad53cb9._0x340c215b(new byte[8] { 64, 92, 92, 88, 91, 18, 7, 7 }, 40), StringComparison.OrdinalIgnoreCase) && !_0xa8e196c1.StartsWith(_0x4ad53cb9._0x340c215b(new byte[11] { 61, 62, 51, 41, 40, 102, 62, 48, 61, 50, 55 }, 92), StringComparison.OrdinalIgnoreCase))
        {
            return _0x6d6ddf0a(_0xa8e196c1);
        }

        return false;
    }

    private bool _0x30dc0564()
    {
        var _0x540a086c = _0x61785968();
        if (_0x540a086c == null)
            return false;
        WLog(_0x4ad53cb9._0x340c215b(new byte[31] { 172, 133, 150, 128, 147, 133, 150, 129, 196, 134, 133, 135, 143, 196, 201, 218, 196, 148, 139, 148, 145, 148, 196, 163, 139, 166, 133, 135, 143, 222, 196 }, 228) + _0x540a086c.Id);
        _0x540a086c.GoBack();
        return true;
    }

    private string _0x02fcec53 = "";
    private void _0x305f1167()
    {
        if (_0x9efb78ba)
        {
            WLog(_0x4ad53cb9._0x340c215b(new byte[18] { 198, 251, 234, 247, 163, 226, 239, 241, 230, 226, 231, 250, 163, 240, 235, 236, 244, 237 }, 131));
            return;
        }

        _0x673ab349(false);
        WLog(_0x4ad53cb9._0x340c215b(new byte[46] { 66, 110, 102, 97, 47, 88, 106, 109, 89, 102, 106, 120, 47, 95, 122, 124, 103, 47, 65, 96, 123, 102, 105, 102, 108, 110, 123, 102, 96, 97, 47, 39, 103, 110, 125, 107, 120, 110, 125, 106, 47, 109, 110, 108, 100, 38 }, 15));
        ++_0xf16d1b61;
        _0x2fba5add();
        if (_0xf16d1b61 <= 1)
            return;
        if (_0xd61bbffa())
        {
            WLog(_0x4ad53cb9._0x340c215b(new byte[37] { 79, 114, 99, 126, 42, 121, 97, 99, 122, 122, 111, 110, 42, 39, 52, 42, 122, 101, 122, 127, 122, 121, 42, 121, 126, 99, 102, 102, 42, 101, 122, 111, 100, 111, 110, 48, 42 }, 10) + _0x96aa0d0e.Count);
            return;
        }

        Application.Quit();
    }

    private string _0xccbd1be9 = "";
    private string _0x8e5d77e3 = "";
    private async Task<bool> _0xdd463611(int _0x9cdeea43 = 5, int _0xcbe8ed2e = 500)
    {
        List<EntityData> _0x464f8024 = new List<EntityData>();
        int _0xbc261c58 = 0;
        do
        {
            try
            {
                _0x464f8024 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x4ad53cb9._0x340c215b(new byte[8] { 195, 223, 210, 202, 214, 193, 250, 215 }, 179), _0x43a5b5ba, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x4ad53cb9._0x340c215b(new byte[9] { 42, 48, 19, 49, 42, 53, 34, 32, 58 }, 67) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x4ad53cb9._0x340c215b(new byte[32] { 196, 203, 250, 236, 235, 194, 191, 238, 234, 250, 237, 230, 222, 236, 230, 241, 252, 205, 250, 236, 234, 243, 235, 236, 191, 250, 237, 237, 240, 237, 165, 191 }, 159) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xcbe8ed2e);
        }
        while (_0x464f8024.Count == 0 && _0xbc261c58++ < _0x9cdeea43);
        {
#if B_LOGS
            {
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[32] { 226, 237, 220, 202, 205, 228, 153, 240, 202, 233, 203, 208, 207, 216, 218, 192, 153, 232, 204, 220, 203, 192, 153, 203, 220, 202, 204, 213, 205, 202, 131, 153 }, 185) + JsonConvert.SerializeObject(_0x464f8024, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[38] { 118, 121, 72, 94, 89, 112, 13, 100, 94, 125, 95, 68, 91, 76, 78, 84, 13, 124, 88, 72, 95, 84, 13, 95, 72, 94, 88, 65, 89, 94, 13, 78, 66, 88, 67, 89, 23, 13 }, 45) + _0x464f8024.Count);
            }
#endif
        }

        bool _0x4cd366e5 = true;
        if (_0x464f8024.Count == 0)
        {
            _0x4cd366e5 = false;
        }
        else
        {
            _0x4cd366e5 = _0x464f8024.Any(_0x336a2411 => _0x336a2411.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x4ad53cb9._0x340c215b(new byte[25] { 196, 203, 250, 236, 235, 194, 191, 214, 236, 207, 237, 246, 233, 254, 252, 230, 191, 237, 250, 236, 234, 243, 235, 165, 191 }, 159) + _0x4cd366e5);
            }
#endif
        }

        return _0x4cd366e5;
    }
}

internal static class _0x4ad53cb9
{
    internal static string _0x340c215b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}