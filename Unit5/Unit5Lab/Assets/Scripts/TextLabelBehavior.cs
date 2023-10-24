using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextLabelBehavior : MonoBehaviour
{
    public TextMeshProUGUI label;
    public FloatData floatData;

    void Update()
    {
        label.text = floatData.value.ToString();
    }

}
