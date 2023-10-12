using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] public Transform bulletSpawnPoint;
    [SerializeField] public GameObject bulletPrefab;
    [SerializeField] public float bulletSpeed = 10f;
    [SerializeField] public int maxAmmo = 15;
    [SerializeField] public int currentAmmo;
    public int ammoNeeded;
    public PlayerController playerController;
    public PickupAmmoScript pickupAmmoScript;
    public int previousAmmo;
    

    void Start()
    {
        currentAmmo = maxAmmo;
        Debug.Log("AMMO: " + currentAmmo);
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
        if (currentAmmo != previousAmmo)
        {
            Debug.Log("AMMO:" + currentAmmo);
            previousAmmo = currentAmmo;
        }
    }
    
}
