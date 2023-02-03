using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score; //Keep track of game score
    public TextMeshProUGUI scoreText; // reference to a text object to be modified


    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

        public void DecreaseScoreText(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }
    
    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score;
    }
}
