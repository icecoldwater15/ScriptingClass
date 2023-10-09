using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollideDestroyerScript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AmmoBox"))
        {
            Destroy(other.gameObject);
        }
    }
}
