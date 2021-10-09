using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleLauncher : MonoBehaviour
{
    public GameObject misslePrefab;
    private Vector3 spawnPos;

    private void Update()
    {
        spawnPos = transform.position;
    }

    public void SpawnMissle()
    {
        Instantiate(misslePrefab, spawnPos, misslePrefab.transform.rotation);
    }
}
