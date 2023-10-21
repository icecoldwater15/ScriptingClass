using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBaseScript : MonoBehaviour
{
    
    
    public HealthScript healthScript;
    private int previousHealth;
    public GameManagerScript gameManagerScript;
    public PlaySoundScript playSoundScript;
    private bool isDead;
    private GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        healthScript = GetComponent<HealthScript>();
        if (healthScript != null)
        {
            healthScript.maxHealth = 15;
            previousHealth = healthScript.currentHealth;
        }
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (healthScript.currentHealth <= 0 && !isDead)
        {
            playSoundScript.StopGameSound();
            isDead = true;
            playSoundScript.PlayDeathSound();
            playerObject.SetActive(false);
            gameManagerScript.gameOver();
        }
    }
}
