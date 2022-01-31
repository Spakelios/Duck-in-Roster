using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void Start()
    {
        LoadScene();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

