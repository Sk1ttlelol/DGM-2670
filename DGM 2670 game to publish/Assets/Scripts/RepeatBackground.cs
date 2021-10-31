using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public Vector3 spawnPos;
    public GameObject backgroundPrefab;

    public bool canSpawn = true;
    
    
    void Start()
    {
        // Get start position on Background
        
        // Finding half of the background size on the X
        
    }
    
    void Update()
    {
        if(canSpawn == true && transform.position.y <= 6)
        {
            Instantiate(backgroundPrefab, spawnPos, Quaternion.identity);
            canSpawn = false;
        }
        if(transform.position.y <= -14.4)
        {
            canSpawn = true;
            Destroy(gameObject);
        }
    }
}
