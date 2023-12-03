using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreenScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool gamePaused = false;
    public GunScript gunScript;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gamePaused = !gamePaused;
        }
        
        if (gamePaused == false)
        {
            ResumeGame();
        }
        else if (gamePaused == true)
        {
            PauseGame();
        }

    }

    public void PauseGame()
    {   
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gunScript.enabled = false;
    }
    public void ResumeGame()
    {
        gamePaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gunScript.enabled = true;
    }

}