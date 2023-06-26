using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript1 : MonoBehaviour
{
    private void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Logger.Log("This is Log message",this);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Logger.LogWarning("This is LogWarning message",this);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Logger.LogError("This is LogError message", this);
        }
    }
}
