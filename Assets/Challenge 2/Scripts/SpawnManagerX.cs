using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        // Set the spawn interval to a random value between 3 and 5 seconds
        spawnInterval = Random.Range(3f, 5f);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Select a ball prefab from ballPrefabs at random to spawn
        GameObject selectedBall = ballPrefabs[Random.Range(0, ballPrefabs.Length)];

        // instantiate ball at random spawn location
        Instantiate(selectedBall, spawnPos, selectedBall.transform.rotation);
    }

}
