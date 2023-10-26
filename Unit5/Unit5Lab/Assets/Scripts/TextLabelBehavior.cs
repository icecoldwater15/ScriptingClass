using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TexthealthLabelBehavior : MonoBehaviour
{
    public TextMeshProUGUI healthLabel;
    public HealthScript healthScript;
    public TextMeshProUGUI ammoLabel;
    public AmmoScript ammoScript;

    void Update()
    {
        healthLabel.text = "Health: " + healthScript.currentHealth.ToString();
        ammoLabel.text = "Ammo: " + ammoScript.magazineSize.ToString() + "/" + ammoScript.maxAmmo.ToString();
    }

}
