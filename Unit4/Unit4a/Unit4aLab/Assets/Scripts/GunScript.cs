using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] public Transform bulletSpawnPoint;
    [SerializeField] public GameObject bulletPrefab;
    [SerializeField] public float bulletSpeed = 10f;
    [SerializeField] public int magazineSize = 10;
    [SerializeField] public int ammoHeld;
    [SerializeField] public int maxAmmo = 40;
    [SerializeField] public int currentAmmo;
    public int previousAmmo;
    public int ammoNeeded;

    

    void Start()
    {
        currentAmmo = magazineSize;
        ammoHeld = maxAmmo;
        Debug.Log("AMMO: " + currentAmmo + "/" + ammoHeld);
        previousAmmo = currentAmmo;
    }
    void Update()
    {
        if (currentAmmo > 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                currentAmmo -= 1;
                ammoNeeded += 1;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Debug.Log("No more ammo. ");
                if  (ammoHeld > 0)
                {
                    Debug.Log("Press R to reload.");
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.R) && ammoHeld > 0 && currentAmmo < magazineSize)
        {
            Debug.Log("Reloading....");
            StartCoroutine(ReloadTime());
            if  (ammoHeld <= 0)
            {
                Debug.Log ("Find an ammo box to refill your ammo.");
            }
        
        
        }
        if  (ammoHeld < 0 )
        {
         ammoHeld = 0;
        }

        if (currentAmmo != previousAmmo)
        {
            Debug.Log("AMMO:" + currentAmmo + "/" + ammoHeld);
            previousAmmo = currentAmmo;
        }
        if  (ammoHeld > 35)
        {
         ammoHeld = 35;
        }
    }
    IEnumerator ReloadTime()
    {
        yield return new WaitForSeconds(1.5f);
        currentAmmo += ammoNeeded;
     ammoHeld -= ammoNeeded;
        ammoNeeded = 0;
    }
    
}
