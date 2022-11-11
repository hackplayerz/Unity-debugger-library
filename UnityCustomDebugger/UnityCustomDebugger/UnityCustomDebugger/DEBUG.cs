namespace UnityCustomDebugger
{
using UnityEngine;

public class DEBUG : MonoBehaviour
    {
        public static void Log(string message, LogType logType = LogType.Log, StackTraceLogType stackTraceLogType = StackTraceLogType.ScriptOnly)
        {
#if UNITY_EDITOR || UNITY
        Application.SetStackTraceLogType(logType,stackTraceLogType);
        Debug.Log(message);
#endif
        }

        public static void Warning(string message, LogType logType = LogType.Log, StackTraceLogType stackTraceLogType = StackTraceLogType.ScriptOnly)
        {
#if UNITY_EDITOR || UNITY
        Application.SetStackTraceLogType(logType,stackTraceLogType);
        Debug.LogWarning(message);
#endif

        }

        public static void Error(string message, bool forceQuit = false, LogType logType = LogType.Log, StackTraceLogType stackTraceLogType = StackTraceLogType.ScriptOnly)
        {
#if UNITY_EDITOR || UNITY
        Application.SetStackTraceLogType(logType,stackTraceLogType);
        Debug.LogError(message);
        if (forceQuit)
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}