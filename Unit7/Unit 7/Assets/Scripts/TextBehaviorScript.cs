using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBehaviorScript : MonoBehaviour
{
    public TextMeshProUGUI label;

    public void UpdateLabel(Score obj)
    {
        label.text = obj.value.ToString();
    }
    public void NewLabel(string word)
    {
        label.text = word;
    }
}
