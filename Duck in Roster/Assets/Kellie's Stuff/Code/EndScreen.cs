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
    private PlayerMovement movementScript;
    private AudioSource levelMusic;

    private void Start()
    {
        levelMusic = movementScript.mainTheme;
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
                /*
                levelMusic.Stop();
                levelMusic.loop = false;
                victoryTheme.Play();
                victoryTheme.loop = false;
                */
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
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    
}
