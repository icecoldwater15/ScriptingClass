using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InstancerScript : ScriptableObject
{
    public Vector3 circleSpawn;
    public Vector3 playerSpawn;

    public void CreateInstance(GameObject obj)
    {
        Instantiate(obj);
        circleSpawn = new Vector3(Random.Range(-5,5), 5, 0);
        obj.transform.position = circleSpawn;
    }
    public void CreatePlayerInstance(GameObject obj)
    {
        Instantiate(obj);
        playerSpawn = new Vector3(0, -4, 0);
        obj.transform.position = playerSpawn;
    }
}
