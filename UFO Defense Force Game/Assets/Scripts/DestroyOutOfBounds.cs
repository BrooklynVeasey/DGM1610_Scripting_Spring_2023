using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;

    public ScoreManager scoreManager; //reference the score manager so that we can update the score

    private DetectCollisions detectCollision;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Getting the component ScoreManager
        detectCollision = GetComponent<DetectCollisions>();
    }

    void Awake()
    {
        //Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z <lowerBounds)
        {
            scoreManager.DecreaseScore(detectCollision.scoreToGive); //Everytime a ship sneaks past the lower bounds deduct points
            Debug.Log("Game Over!");
            Destroy(gameObject);
            //Time.timescale = 0;
        }
    }
}
