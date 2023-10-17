using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float life = 3f;
    public HealthScript healthScript;
    [SerializeField] public string[] enemyTags;
    
    void SetEnemyTags()
    {
        string[] tagsToAdd = { "ScoutEnemy", "RegEnemy", "BigEnemy" };
        enemyTags = tagsToAdd;
    }
    void Awake()
    {
        Destroy(gameObject, life);
        SetEnemyTags();
    }
    void OnTriggerEnter(Collider other)
    {
        foreach (string enemyTag in enemyTags)
        {
            if (other.CompareTag(enemyTag))
            {
                if(other.TryGetComponent(out healthScript))
                {
                    healthScript.TakeDamage(1);
                }
                
                break;
            }
        }
        Destroy(gameObject);
    }
}