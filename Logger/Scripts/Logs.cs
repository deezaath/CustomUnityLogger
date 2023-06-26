using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logs : MonoBehaviour
{
    public LoggerSettings loggerSettings;
    private void Awake()
    {
        Logger.Initialize(loggerSettings);
    }
}
