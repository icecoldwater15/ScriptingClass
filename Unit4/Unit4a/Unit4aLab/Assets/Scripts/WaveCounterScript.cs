using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveCounterScript : MonoBehaviour
{
    public EnemySpawnerScript enemySpawnerScript;
    public TextMeshProUGUI currentWave;
    
    void Update()
    {
        currentWave.text = "Wave " + enemySpawnerScript.wavesSpawned.ToString();
    }
}
