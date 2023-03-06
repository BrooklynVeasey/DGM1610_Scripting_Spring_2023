using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private ScoreManager scoreManager; //A variable to hold reference to the scoremanager

    public int scoreToGive;

    public ParticleSystem explosionParticle; //Store teh particle system

    private AudioSource explosionAudio;
    public AudioClip explosion;

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
            Explosion();
        }

        scoreManager.IncreaseScore(scoreToGive); //Increase score
    }

    void Explosion()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
    }

}
