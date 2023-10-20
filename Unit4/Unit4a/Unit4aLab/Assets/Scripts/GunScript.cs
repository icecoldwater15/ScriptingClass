using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] public Transform bulletSpawnPoint;
    [SerializeField] public GameObject bulletPrefab;
    [SerializeField] public float bulletSpeed = 12f;
    [SerializeField] public int magazineSize = 20;
    [SerializeField] public int ammoHeld;
    [SerializeField] public int maxAmmo = 60;
    [SerializeField] public int currentAmmo;
    public int previousAmmo;
    public int ammoNeeded;

    

    void Start()
    {
        currentAmmo = magazineSize;
        ammoHeld = maxAmmo;
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
        if (Input.GetKeyDown(KeyCode.R) && ammoHeld > 0 && currentAmmo < magazineSize)
        {
            StartCoroutine(ReloadTime());
        }
        if  (ammoHeld < 0 )
        {
         ammoHeld = 0;
        }
        if  (ammoHeld > maxAmmo)
        {
         ammoHeld = maxAmmo;
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
