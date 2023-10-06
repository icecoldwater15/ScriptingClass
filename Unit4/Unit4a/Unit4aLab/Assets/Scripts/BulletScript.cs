using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float life = 3f;
    public HealthScript healthScript;
    
    void Awake()
    {
        Destroy(gameObject, life);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Enemy"))
        {
            if(collision.gameObject.TryGetComponent(out healthScript))
            {
                healthScript.TakeDamage(1);
            }

        }
        Destroy(gameObject);
    }
}