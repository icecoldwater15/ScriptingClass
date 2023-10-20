using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 3f;
    public int enemiesPerWave = 10;
    private int enemiesSpawned = 0;
    public int wavesSpawned = 1;
    public float nextSpawnTime;
    public int previousWave;
    public float enemySpeedMultiplier = 1.2f;
    void Start()
    {
        nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
        previousWave = wavesSpawned;
    }

    void Update()
    {
        if (enemiesSpawned >= enemiesPerWave)
        {
            Debug.Log("Wave " + wavesSpawned + " Complete. Starting the next wave now.");
            wavesSpawned++;
            enemiesSpawned = 0;
            StartCoroutine(StartNextWave());
        }
        if (Time.time >= nextSpawnTime && enemiesSpawned < enemiesPerWave)
        { 
    
            GameObject selectedEnemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
            var enemy = Instantiate(selectedEnemyPrefab);
            EnemyScript enemyComponent = enemy.GetComponent<EnemyScript>();
            
                if (enemyComponent != null)
                {
                    if (wavesSpawned != previousWave)
                    {
                        enemyComponent.enemySpeed *= enemySpeedMultiplier;
                    }
                    enemyComponent.EnemyStats();
                    Vector3 enemySpawnPoint = new Vector3(Random.Range(-10,11), 17.5f, 20);
                    enemy.transform.position = enemySpawnPoint;
                    enemy.GetComponent<Rigidbody>().velocity = new Vector3(0,0,-enemyComponent.enemySpeed);
                    nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
                    enemiesSpawned++;;
                }
        }
    }
    IEnumerator StartNextWave()
    {
        yield return new WaitForSeconds(90f);
    }
}