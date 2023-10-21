using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public PlaySoundScript playSoundScript;
    public void PlayGame()
    {
        playSoundScript.PlayStartButton();
        StartCoroutine(LoadNextScene());
    }
    private IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
