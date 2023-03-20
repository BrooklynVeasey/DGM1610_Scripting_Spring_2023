using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleChallenge : MonoBehaviour
{
    private GameManager gameManager;

    public int increaseScore;
    private int scoreToGive;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Destroys game object
        gameManager.IncreaseScore(scoreToGive);
    }
}
