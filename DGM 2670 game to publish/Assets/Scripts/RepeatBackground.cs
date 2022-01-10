using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 spawnPos;
    public GameObject backgroundPrefab;

    public bool canSpawn = true;
    private float repeatWidth;
    
    
    void Start()
    {
        spawnPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.y / 2;
        
    }
    
    void Update()
    {
        if(transform.position.y < spawnPos.y - repeatWidth)
        {
            transform.position = spawnPos;
        }
    }

    void CoolStuff()
    {
        if(canSpawn == true && transform.position.y <= 6.1)
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
