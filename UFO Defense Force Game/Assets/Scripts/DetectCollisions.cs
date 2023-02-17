using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Blaster")) //UFO vs Blaster
        {
            Destroy(gameObject); //Destroys game object (UFO)
            Destroy(other.gameObject); //Destroys blaster
        }

    
    }

}
