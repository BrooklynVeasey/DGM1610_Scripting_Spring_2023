using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score; //Store score value
    public TextMeshProUGUI scoreText; //Reference visual text UI element to change

    public void IncreaseScore(int amount)
    {
        score += amount; //Add amount to the score
        UpdateScoreText(); //Update the score UI text
    }

    public void DecreaseScore(int amount)
    {
        score -= amount; //Subtract amount to the score
        UpdateScoreText(); //Update the score UI text
    }
 
    void UpdateScoreText()
    {
       scoreText.text = "Score:"+ score; 
    }
}
