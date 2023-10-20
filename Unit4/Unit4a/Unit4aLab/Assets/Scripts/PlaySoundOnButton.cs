using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnButton : MonoBehaviour
{
    public AudioSource startButton;
    
    public void PlayStartButton()
    {
        startButton.Play();
    }
}
