using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 25;

    public float xRange = 30;

    public int collectibleCount;

    public Transform blaster;
    public GameObject lazerBolt;
    public GameObject collectible;

    private AudioSource blasterAudio;
    public AudioClip laserBlast;

    void Start()
    {
        //Get AudioSource component
        blasterAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    // Set HorizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

    // Moves Player up and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keep player within bounds
        // Left side wall
        if(transform.position.x < -xRange )
        {
                transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
                // Right side wall
        if(transform.position.x > xRange )
        {
                transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
        //If Spacebar pressed create lazer bolt
        if(Input.GetKeyDown(KeyCode.Space))
            //Create lazer bolt at blaster position while keeping object rotation
        {
            blasterAudio.PlayOneShot(laserBlast,1.0f); //Play blasterAudio sound clip
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }

    }

    private void OnTriggerEnter(Collider collectible)
    {
        //Destroy(other.gameObject);
        //somehow add to score int
    }

}
