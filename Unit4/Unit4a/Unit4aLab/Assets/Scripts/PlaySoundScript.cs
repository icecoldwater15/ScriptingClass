using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundScript : MonoBehaviour
{
    public AudioSource startButton;
    public AudioSource deathSound;
    public AudioSource gameSound;
    public AudioSource enemyDeathSound;
    public AudioSource playAgainButton;

    public void PlayStartButton()
    {
        startButton.Play();
    }

    public void PlayDeathSound()
    {
        deathSound.Play();
    }
    public void PlayGameSound()
    {
        gameSound.Play();
    }
    public void StopGameSound()
    {
        gameSound.Stop();
    }
    public void PlayEnemyDeathSound()
    {
        enemyDeathSound.Play();
    }
    public void PlayAgainButton()
    {
        playAgainButton.Play();
    }
}
