using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawnerScript : MonoBehaviour
{
    //change "ammoPrefab" to desired prefab
    public GameObject ammoPrefab;
    public float itemSpeed = 7f;
    public float minSpawnDelay = 15f;
    public float maxSpawnDelay = 30f;
    public float nextSpawnTime;
    
    void Start()
    {
        nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
 

    }

    void Update()
    {
        if (Time.time >= nextSpawnTime) 
        { 
            Vector3 itemAmmoSpawnPoint = new Vector3(Random.Range(-10,11), 17, 20);
            var itemAmmo = Instantiate(ammoPrefab, itemAmmoSpawnPoint, Quaternion.identity);
            itemAmmo.GetComponent<Rigidbody>().velocity = new Vector3(0,0,-itemSpeed);
            nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
        }
    }
}
