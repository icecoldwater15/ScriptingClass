using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float minSpawnDelay = 10f;
    public float maxSpawnDelay = 20f;
    public int enemiesPerWave = 10;
    private int enemiesSpawned = 0;
    private int wavesSpawned = 0;
    public float nextSpawnTime;
    public float enemySpeed = 10f;

    void Start()
    {
        nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
    }

    void Update()
    {
        if (enemiesSpawned >= enemiesPerWave)
        {
            Debug.Log("Wave " + wavesSpawned + " Complete. Starting the next wave now.");
            wavesSpawned++;
            enemiesSpawned = 0;
            // StartCoroutine(StartNextWave());
            
        }

        // if (Time.time >= nextSpawnTime && enemiesSpawned < enemiesPerWave) 
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            EnemyScript enemyComponent = GetComponent<EnemyScript>();
            Vector3 enemySpawnPoint = new Vector3(Random.Range(-10,11), 19, 20);
            GameObject selectedEnemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
            var enemy = Instantiate(selectedEnemyPrefab, enemySpawnPoint, Quaternion.identity);
            // enemy.GetComponent<Rigidbody>().velocity = new Vector3(0,0,-enemyComponent.enemySpeed);
             enemy.GetComponent<Rigidbody>().velocity = new Vector3(0,0,-enemySpeed);
            // nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
            enemiesSpawned++;
        }
    }
    // IEnumerator StartNextWave()
    // {
    //     yield return new WaitForSeconds(5f);
    // }
}