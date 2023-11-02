using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
    public ParticleSystem particleSystem;

    void Start()
    {
        particleSystem.Stop();
    }
    
    
    public void PlayParticle()
    {
        particleSystem.Play();
    }

    public void StopParticle()
    {
        particleSystem.Stop();
    }
}
