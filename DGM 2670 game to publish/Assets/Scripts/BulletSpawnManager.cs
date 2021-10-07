using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnManager : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float startDelay;
    public float repeatRate;
    private Vector3 spawnPos;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    private void Update()
    {
        spawnPos = transform.position;
    }

    void SpawnObstacle()
    {
        Instantiate(bulletPrefab, spawnPos, bulletPrefab.transform.rotation);
    }
}
