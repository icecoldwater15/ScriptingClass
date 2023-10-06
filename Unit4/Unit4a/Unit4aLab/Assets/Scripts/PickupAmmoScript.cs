using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAmmoScript : MonoBehaviour
{
    public GunScript gunScript;
    public int ammoPickupAmount;

    
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    
    
    

}
