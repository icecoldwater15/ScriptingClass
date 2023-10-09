using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAmmoScript : MonoBehaviour
{
    // public GunScript gunScript;
    public string gunTag = "Gun";
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject gunObject = GameObject.FindGameObjectWithTag(gunTag);
            if (gunObject != null)
            {
                GunScript gunComponent = gunObject.GetComponent<GunScript>();
            
                if (gunComponent != null)
                {
                    if (gunComponent.currentAmmo < gunComponent.maxAmmo) 
                    {
                        gunComponent.currentAmmo += gunComponent.ammoNeeded;
                        Destroy(gameObject);
                        gunComponent.ammoNeeded = 0;

                        Debug.Log("Ammo Refilled.");
                    }
                    else
                    {
                        Debug.Log("Player has max ammo.");
                    }
                }
            }
        }
    }
    
    
    

}
