using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    public void exitbutton()
    {
        Debug.Log("exit game");
        Application.Quit();
    }
}