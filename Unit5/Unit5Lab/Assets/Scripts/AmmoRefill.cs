using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoRefill : MonoBehaviour
{
    public int ammoRefillAmount;
    public AmmoScript ammoScript;
    void RefillAmmo()
    {
        ammoRefillAmount = ammoScript.maxAmmo -= ammoScript.magazineSize;
        if (ammoScript.magazineSize < ammoScript.maxAmmo)
        {
            ammoScript.magazineSize = ammoRefillAmount;
        }
    }
}
