﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  //DIY

public class Changescenes : MonoBehaviour {

    public void Botton(string name)
    {

        SceneManager.LoadScene(name, LoadSceneMode.Single);
    }
}
