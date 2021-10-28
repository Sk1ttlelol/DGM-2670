using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Wave
{
    public string waveName;
    public int noOfEnemies;
    public GameObject[] typeOfEnemies;
    public float spawnInterval;
}
public class WaveSpawner : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnLocations;

    public Animator animator;
    public Text waveName;

    private bool canSpawn = true;
    private bool canAnimate = false;
    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;

    public GameObject[] totalEnemies;
    
    // Wave Spawner found on YouTube from ChronoABI "Simple Wave spawner in Unity 2D"

    private void Update()
    {
        currentWave = waves[currentWaveNumber];
        SpawnWave();
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (totalEnemies.Length == 0 )
        {
            if (currentWaveNumber + 1 != waves.Length )
            {
                if (canAnimate)
                {
                    waveName.text = waves[currentWaveNumber + 1].waveName;
                    animator.SetTrigger("WaveComplete");
                    canAnimate = false;
                }
            } 
            else
            {
                Debug.Log("Game Finish");
            }
        }
    }

    public void SpawnNextWave()
    {
        currentWaveNumber++;
        canSpawn = true;
    }

    void SpawnWave()
    {
        if (canSpawn && nextSpawnTime < Time.time)
        {
            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];
            Transform randomPoint = spawnLocations[Random.Range(0, spawnLocations.Length)];
            Instantiate(randomEnemy, randomPoint.position, Quaternion.Euler(90, -180, 0));
            currentWave.noOfEnemies--;
            nextSpawnTime = Time.time + currentWave.spawnInterval;

            if (currentWave.noOfEnemies == 0)
            {
                canSpawn = false;
                canAnimate = true;
            }
        }
        
    }


}
