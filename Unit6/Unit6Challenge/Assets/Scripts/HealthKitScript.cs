using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthKitScript : MonoBehaviour
{
    public Slider healthBar;
    public GameObject healthKit;
    
    public void Heal()
    {
        healthBar.value = 1f;
    }
    void OnTriggerEnter()
    {
        healthKit.SetActive(false);
    }
}
