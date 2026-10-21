using UnityEngine;

public class _0xdd7c4427 : MonoBehaviour
{
    public bool IsStoryEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsTimerEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsTutorialEnabled;
    public static _0xdd7c4427 Instance;
    private void _0x45f2cccf()
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

    public bool IsBestScoreEnabled;
    private void _0xe737fe2a()
    {
    }

    public bool IsCheckScoreEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsLevelSelectorEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xdd7c4427>();
            DontDestroyOnLoad(this.gameObject);
            this._0x45f2cccf();
        }
        else
        {
            this._0xe737fe2a();
            Destroy(this.gameObject);
        }
    }
}