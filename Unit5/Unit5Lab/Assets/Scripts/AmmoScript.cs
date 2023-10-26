using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AmmoScript : ScriptableObject
{
    public int magazineSize;
    public int maxAmmo;
    public int ammoRefillAmount;
    public void RefillAmmo()
    {
        ammoRefillAmount = maxAmmo - magazineSize;

        if (magazineSize < maxAmmo)
        {
            magazineSize = ammoRefillAmount;
        }
    }
}
