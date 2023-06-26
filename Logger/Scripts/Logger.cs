using Unity.VisualScripting;
using UnityEngine;

public static class Logger 
{

    private static LoggerSettings loggerSettings;

    public static LoggerSettings Custom => loggerSettings;

    public static void Initialize(LoggerSettings holder)
    {
        loggerSettings = holder;
    }
    public static void Log(string message, Object context = null)
    {
        string contextName = (context != null) ? context.GetType().Name : "Logs";
        if(Custom)
              Debug.Log($"<color=#{Custom.log.h_Color.ToHexString()}><size={Custom.log.h_FontSize}>" +
                  $"{(Custom.log.h_bald ? "<b>" : "")}{(Custom.log.h_italic ? "<i>" : "")}[{contextName}]{(Custom.log.h_italic ? "</i>" : "")}{(Custom.log.h_bald ? "</b>" : "")}</size></color>" +
                  $" <color=#{Custom.log.m_Color.ToHexString()}><size={Custom.log.m_FontSize}>" +
                  $"{(Custom.log.m_bald ? "<b>" : "")}{(Custom.log.m_italic ? "<i>" : "")} {message} {(Custom.log.m_italic? "</i>" : "")}{(Custom.log.m_bald ? "</b>" : "")}</size></color>"
                  ,context);
        else
            Debug.Log($"<color=#60be92> <b>[{contextName}]</b></color> <b>{message}</b>", context);
    }
    public static void LogWarning(string message, Object context = null)
    {
        string contextName = (context != null) ? context.GetType().Name : "Logs";
        if (Custom)
            Debug.LogWarning($"<color=#{Custom.logWarning.h_Color.ToHexString()}><size={Custom.logWarning.h_FontSize}>" +
                $"{(Custom.logWarning.h_bald ? "<b>" : "")}{(Custom.logWarning.h_italic ? "<i>" : "")}[{contextName}]{(Custom.logWarning.h_italic ? "</i>" : "")}{(Custom.logWarning.h_bald ? "</b>" : "")}</size></color>" +
                $" <color=#{Custom.logWarning.m_Color.ToHexString()}><size={Custom.logWarning.m_FontSize}>" +
                $"{(Custom.logWarning.m_bald ? "<b>" : "")}{(Custom.logWarning.m_italic ? "<i>" : "")} {message} {(Custom.logWarning.m_italic ? "</i>" : "")}{(Custom.logWarning.m_bald ? "</b>" : "")}</size></color>"
                , context);
        else
            Debug.LogWarning($"<color=#FFF288> <b>[{contextName}]</b></color> <b>{message}</b>", context);
    }

    public static void LogError(string message, Object context = null)
    {
        string contextName = (context != null) ? context.GetType().Name : "Logs";
        if (Custom)
            Debug.LogError($"<color=#{Custom.logError.h_Color.ToHexString()}><size={Custom.logError.h_FontSize}>" +
                $"{(Custom.logError.h_bald ? "<b>" : "")}{(Custom.logError.h_italic ? "<i>" : "")}[{contextName}]{(Custom.logError.h_italic ? "</i>" : "")}{(Custom.logError.h_bald ? "</b>" : "")}</size></color>" +
                $" <color=#{Custom.logError.m_Color.ToHexString()}><size={Custom.logError.m_FontSize}>" +
                $"{(Custom.logError.m_bald ? "<b>" : "")}{(Custom.logError.m_italic ? "<i>" : "")} {message} {(Custom.logError.m_italic ? "</i>" : "")}{(Custom.logError.m_bald ? "</b>" : "")}</size></color>"
                , context);
        else
            Debug.LogError($"<color=#f2686a><b>[{contextName}]</b></color> <b>{message}</b>", context);
    }
}
