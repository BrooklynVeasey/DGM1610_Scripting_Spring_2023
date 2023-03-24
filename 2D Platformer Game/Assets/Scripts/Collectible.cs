using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject collectible;
    private int collectibleAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        //collectible stuff
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) //Collectible and Player
        {
            Destroy(gameObject); //Destroys game object
            Debug.Log("collectibleAmount += amount");
        }
    }

}
