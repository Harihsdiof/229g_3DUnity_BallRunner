using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int highScore;
    public Text scoreText;
    public Text highScoreText;

 
    void Start()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreText(); 
    }

   
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            score++;
            scoreText.text = "Score: " + score;
            Destroy(other.gameObject);

            
            if (score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("HighScore", highScore); 
                UpdateHighScoreText(); 
            }
        }
    }

    void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + highScore;
    }
}
