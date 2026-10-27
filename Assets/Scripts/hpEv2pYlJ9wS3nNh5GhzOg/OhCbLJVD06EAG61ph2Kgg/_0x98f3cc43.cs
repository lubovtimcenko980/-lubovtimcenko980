using UnityEngine;

public class _0x98f3cc43 : MonoBehaviour
{
    public static _0x98f3cc43 Instance;
    public bool IsLevelIncrementOnWin;
    private void _0x3f1f914d()
    {
    }

    public bool IsSkipSplashEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x98f3cc43>();
            DontDestroyOnLoad(this.gameObject);
            this._0x507ca4b3();
        }
        else
        {
            this._0x3f1f914d();
            Destroy(this.gameObject);
        }
    }

    public bool IsLevelSelectorEnabled;
    public bool IsTimerEnabled;
    private void _0x507ca4b3()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsOnlyWinGameEndEnabled;
    public bool IsTutorialEnabled;
    public bool IsBestScoreEnabled;
    public bool IsStoryEnabled;
    public bool IsCheckScoreEnabled;
}