using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // [SerializeField] public float enemySpeed; 
    public int enemyDamage;
    public string enemyScout = "ScoutEnemy";
    public string enemyReg = "RegEnemy";
    public string enemyBig = "BigEnemy";
    public string playerTag = "Player";
    public string homeBaseTag = "HomeBase";
    public float enemySpeed;

    public void EnemyStats()
    {
        HealthScript healthComponent = GetComponent<HealthScript>();
        enemySpeed = 0f;
        if (healthComponent != null)
        {
            if (gameObject.CompareTag(enemyScout))
            {
                enemyDamage = 1;
                enemySpeed = 4f;
                healthComponent.maxHealth = 2;
            }
            else if (gameObject.CompareTag(enemyReg))
            {
                enemyDamage = 2;
                enemySpeed = 3f;
                healthComponent.maxHealth = 4;
            }
            else if (gameObject.CompareTag(enemyBig))
            {
                enemyDamage = 5;
                enemySpeed = 2f;
                healthComponent.maxHealth = 8;
            }
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            HealthScript playerHealth = other.GetComponent<HealthScript>(); 
            if(playerHealth != null)
            {
                playerHealth.TakeDamage(enemyDamage);
            }
            Destroy(gameObject);
        }
        else if (other.CompareTag(homeBaseTag))
        {
            HealthScript homeBaseHealth = other.GetComponent<HealthScript>();
            if(homeBaseHealth != null)
            {
                homeBaseHealth.TakeDamage(enemyDamage);
            }
            Destroy(gameObject);
        }
        
    }
}
