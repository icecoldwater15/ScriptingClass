using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI finalScore;
    public TextMeshProUGUI gameOver;
    public SpriteRenderer playerSprite;
    public Score scoreScript;
    public UnityEvent ChangeHighScore;
    public HighScore highScoreScript;
    public TextMeshProUGUI newBest;
    public bool newHighScore = false;
    public UnityEvent gameOverAnim;
    
    public void NewHighScore()
    {
        highScoreScript.value = scoreScript.value;
        newHighScore = true;
    }

    void Start()
    {
        gameOver.enabled = false;
        finalScore.enabled = false;
        newBest.enabled = false;
    }
    
    public void GameOver()
    {
        playerSprite.enabled = false;
        finalScore.text = "Score: " + scoreScript.value.ToString();
        gameOver.enabled = true;
        finalScore.enabled = true;
        if (newHighScore == true)
        {
            newBest.enabled = true;
        }
        gameOverAnim.Invoke();
    }
    
    void Update()
    {
        if (scoreScript.value > highScoreScript.value)
        {
            ChangeHighScore.Invoke();
        }
    }
}
