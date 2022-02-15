using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public AudioSource victoryTheme;
    private GameObject gameplayTheme;

    private void Start()
    {
        gameplayTheme = GameObject.Find("GameplayMusic");
        gameplayTheme.SetActive(true);

        if (GameIsPaused)
        {
            Resume();
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {


            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()

    {
        gameplayTheme.SetActive(false);
        victoryTheme.Play();
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        
    }
    
    
}
