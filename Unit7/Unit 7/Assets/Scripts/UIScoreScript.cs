using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScoreScirpt : MonoBehaviour
{
    public TextMeshProUGUI currentScore;
    public TextMeshProUGUI highScore;
    public Score scoreScript;

    void Update()
    {
        currentScore.text = "Score: " + scoreScript.value.ToString();
    }
}
