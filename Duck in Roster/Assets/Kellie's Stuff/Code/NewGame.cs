using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void Scene1() 
    {  
        SceneManager.LoadScene("PROTOTYPE SPEED 1"); 
        
    }

    public void Scene2()
    { 
        Application.Quit();
    }

    public void Scene3()
    {
        SceneManager.LoadScene("SPEED");
    }

    public void scene4()
    {
        SceneManager.LoadScene("Terrain");
    }
    
    
}

