using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour

{

        public float moveSpeed = 1.0f;
        public float upperBound = 20;
        public ScoreManager scoreManager; //Stores a ref to scoremanager
        public Balloon balloon; //reference balloon script to get score


    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        // Make balloon float upward
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive); //reduces score for balloon leaving area
            Destroy(gameObject);
        }
    }
}
