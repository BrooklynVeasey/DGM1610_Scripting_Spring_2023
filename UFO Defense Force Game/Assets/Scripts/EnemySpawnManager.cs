using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour

{
    
public GameObject[] enemyPrefabs;

[SerializeField]
private float spawnRangeX = 30.0f;
[SerializeField]
private float spawnPosZ = 30.0f;

private float startDelay = 2f;
private float spawnInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    void SpawnRandomEnemy()
    {
        //Generate a position to spawn at on x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);
        //Pick a random enemy UFO from array
        int enemyIndex = Random.Range(0,enemyPrefabs.Length);
        //Spawn the enemy indexed from the array
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
