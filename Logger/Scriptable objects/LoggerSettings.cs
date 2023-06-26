using UnityEngine;

[CreateAssetMenu(fileName = "LoggerSettings", menuName = "Custom/Logger Settings")]
public class LoggerSettings : ScriptableObject
{
    public Log log;
    public LogWarning logWarning;
    public LogError logError;
    #region Structs
    [System.Serializable]
    public struct Log
    {
        [Header("[Header]")]
        [Min(6)] public int h_FontSize;
        public Color h_Color;
        public bool h_bald;
        public bool h_italic;

        [Space(5)]

        [Header("Message")]
        [Min(6)] public int m_FontSize;
        public Color m_Color;
        public bool m_bald;
        public bool m_italic;
    }

    [System.Serializable]
    public struct LogWarning
    {
        [Header("[Header]")]
        [Min(6)] public int h_FontSize;
        public Color h_Color;
        public bool h_bald;
        public bool h_italic;

        [Space(5)]

        [Header("Message")]
        [Min(6)] public int m_FontSize;
        public Color m_Color;
        public bool m_bald;
        public bool m_italic;
    }

    [System.Serializable]
    public struct LogError
    {
        [Header("[Header]")]
        [Min(6)] public int h_FontSize;
        public Color h_Color;
        public bool h_bald;
        public bool h_italic;

        [Space(5)]

        [Header("Message")]
        [Min(6)] public int m_FontSize;
        public Color m_Color;
        public bool m_bald;
        public bool m_italic;
    }
    #endregion
}