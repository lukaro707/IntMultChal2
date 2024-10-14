using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //The total time after sending a dog before another dog can be sent
    public float totalDelayTime = 0.5f;
    //The remaining time left before another dog can be sent
    private float remainingDelayTime = 0f;

    // Update is called once per frame
    void Update()
    {
        // If there is time remaining before you can send a dog, reduce that time remaining by deltaTime
        if(remainingDelayTime > 0f)
        {
            remainingDelayTime -= Time.deltaTime;
        }
        // On spacebar press, send dog if there is no time remaing before you can send a dog
        if (Input.GetKeyDown(KeyCode.Space) && remainingDelayTime <= 0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            remainingDelayTime = totalDelayTime;
        }
        
    }
}
