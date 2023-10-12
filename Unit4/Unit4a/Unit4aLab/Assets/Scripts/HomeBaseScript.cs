using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBaseScript : MonoBehaviour
{
    
    
    public HealthScript healthScript;
    private int previousHealth;

    // Start is called before the first frame update
    void Start()
    {
        healthScript = GetComponent<HealthScript>();
        if (healthScript != null)
        {
            healthScript.maxHealth = 15;
            previousHealth = healthScript.currentHealth;
        }
        Debug.Log("Homebase HP: " + healthScript.maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (healthScript.currentHealth != previousHealth)
        {
            Debug.Log("Homebase HP: " + healthScript.currentHealth);
            previousHealth = healthScript.currentHealth;
        }
        if (healthScript.currentHealth <= 0)
        {
            Debug.Log("YOU LOSE!");
        }
    }
}
