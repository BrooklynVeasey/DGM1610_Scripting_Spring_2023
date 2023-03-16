using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleChallenge : MonoBehaviour
{

    public GameObject collectible;
    public int increaseAmount;
    private int collectibleAmount;

   // public GameManager gameManager; //reference game manager when created

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) //Collectible and Player
        {
            Destroy(gameObject); //Destroys game object
          //  gameManager.IncreaseScore(increaseAmount);
        }
    }
}
