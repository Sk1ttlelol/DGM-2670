using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MissleLauncher : MonoBehaviour
{
    public GameObject misslePrefab;
    public UnityEvent missleSound;
    private Vector3 spawnPos;
    public bool canShoot = false;
    public float startDelay;
    public float repeatRate;

    private void Update()
    {
        spawnPos = transform.position;
    }
    
    public void ShootMissle()
    {
        canShoot = true;
        Debug.Log("can fire missles");
    }
    
    public void NoShootMissle()
    {
        canShoot = false;
        Debug.Log("can not fire missles");
        CancelInvoke();
    }

    public void startMissles()
    {
        if (canShoot)
        {
            InvokeRepeating("SpawnMissle", startDelay, repeatRate);
        }

    }

    public void SpawnMissle()
    {
        Instantiate(misslePrefab, spawnPos, misslePrefab.transform.rotation);
        missleSound.Invoke();
    }

  
    
   

    
    
}
