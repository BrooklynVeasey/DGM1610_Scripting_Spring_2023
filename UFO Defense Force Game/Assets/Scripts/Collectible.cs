using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float speed = -5.0f;

    public GameObject collectible;
    public float xSpawnRange = 15;
    private float zSpawnPos;
    public float startDelay = 0.5f;
    public float spawnInterval = 1f;
    private int collectCount;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCollectible", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //Move GameObject forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void SpawnCollectible()
    {
        //Generate the X spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, 10);
        Instantiate(collectible, spawnPos, collectible.transform.rotation);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) //Collectible and Player
        {
            Destroy(gameObject); //Destroys game object
            Debug.Log("collectCount += amount");
        }

    }
}

//record pickup count in an integer??? somehow???