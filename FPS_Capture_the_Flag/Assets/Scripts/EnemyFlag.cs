using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlag : MonoBehaviour
{
    private GameManager gm;
    private Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        gm.hasFlag = true; // Get flag and set bool hasFlag to true
        rend.enabled = false; //Hide the flag
    }
}
