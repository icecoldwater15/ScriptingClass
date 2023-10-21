using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public PlaySoundScript playSoundScript;

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void Restart()
    {
        playSoundScript.PlayAgainButton();
        StartCoroutine(LoadNewScene());
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QuitGame");
    }
    private IEnumerator LoadNewScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }

}
