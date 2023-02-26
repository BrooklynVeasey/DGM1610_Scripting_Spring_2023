using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private ScoreManager scoreManager; //A variable to hold reference to the scoremanager

    public int scoreToGive;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Get scoremanager component
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Blaster")) //UFO vs Blaster
        {
            Destroy(gameObject); //Destroys game object (UFO)
            Destroy(other.gameObject); //Destroys blaster
        }

        scoreManager.IncreaseScore(scoreToGive); //Increase score
    }

}
