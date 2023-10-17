using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoDisplay : MonoBehaviour
{
    public GunScript gunScript;
    public TextMeshProUGUI ammoCount;
    public TextMeshProUGUI reloadPrompt;
    public TextMeshProUGUI findAmmoBoxPrompt;

    void Update()
    {
        ammoCount.text = "Ammo: " + gunScript.currentAmmo.ToString() + "/" + gunScript.ammoHeld.ToString();
        if(gunScript.currentAmmo <= 0 && gunScript.ammoHeld > 0)
        {
            reloadPrompt.gameObject.SetActive(true);
        }
        else
        {
            reloadPrompt.gameObject.SetActive(false);
        }
        if (gunScript.ammoHeld <= 0)
        {
            findAmmoBoxPrompt.gameObject.SetActive(true);
        }
        else
        {
            findAmmoBoxPrompt.gameObject.SetActive(false);
        }
    }
}
