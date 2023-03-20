using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int collectible;
    public TextMeshProUGUI scoreText;
 
    public void IncreaseScore(int amount)
    {
        collectible += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
      scoreText.text = "Collectibles:"+ collectible;
    }

}
