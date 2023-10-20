using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Image fillImage;
    public HealthScript healthScript;
    private Slider slider;

    void Awake()
    {
        slider = GetComponent<Slider>();
        
    }

    void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }
        else
        {
            fillImage.enabled = true;
        }

        float fillValue = healthScript.currentHealth;
        slider.value = fillValue;
    }
}
