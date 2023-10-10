using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // [SerializeField] public float enemySpeed; 
    [SerializeField] public int enemyDamage;
    public string enemyScout = "ScoutEnemy";
    public string enemyReg = "RegEnemy";
    public string enemyBig = "BigEnemy";
    public string playerTag = "Player";
    public string homeBaseTag = "HomeBase";

    void Awake()
    {
        HealthScript healthComponent = GetComponent<HealthScript>();
        GameObject scoutEnemy = GameObject.FindGameObjectWithTag(enemyScout);
        GameObject regEnemy = GameObject.FindGameObjectWithTag(enemyReg);
        GameObject bigEnemy = GameObject.FindGameObjectWithTag(enemyBig);
        
        if (scoutEnemy != null)
        {
            enemyDamage = 1;
            // enemySpeed = 10f;
            healthComponent.maxHealth = 2;
        }
        else if (regEnemy != null)
        {
            enemyDamage = 2;
            // enemySpeed = 7f;
            healthComponent.maxHealth = 4;
        }
        else if (bigEnemy != null)
        {
            enemyDamage = 5;
            // enemySpeed = 4f;
            healthComponent.maxHealth = 8;
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        HealthScript healthComponent = GetComponent<HealthScript>();
        if (collision.gameObject.CompareTag(playerTag) || collision.gameObject.CompareTag(homeBaseTag))
        {
            healthComponent.TakeDamage(enemyDamage);
        }
    }
}
