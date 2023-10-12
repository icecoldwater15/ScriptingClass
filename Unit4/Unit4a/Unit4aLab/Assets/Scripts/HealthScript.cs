using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [SerializeField] public int maxHealth;
    [SerializeField] public int currentHealth;
    public bool objectDestroyed = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth < 1)
        {
            Destroy(gameObject);
            objectDestroyed = true;
        }
    }
}
