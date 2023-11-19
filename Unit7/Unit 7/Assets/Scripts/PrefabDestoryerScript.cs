using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDestoryerScript : MonoBehaviour
{
    public float life;

    void Awake()
    {
        Destroy(gameObject, life);
    }
    public void DestoryGameObj(GameObject obj)
    {
        Destroy(obj);
    }
}
