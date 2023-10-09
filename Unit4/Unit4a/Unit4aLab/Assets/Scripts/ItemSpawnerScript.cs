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
        // nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
    }

    void Update()
    {
        //  if (Time.time >= nextSpawnTime) 
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            Vector3 itemSpawnPoint = new Vector3(Random.Range(-10,11), 17, 20);
            var item = Instantiate(ammoPrefab, itemSpawnPoint, Quaternion.identity);
            item.GetComponent<Rigidbody>().velocity = new Vector3(0,0,-itemSpeed);

            // nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
        }
    }
}
