using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public float damageEnemy = 1f;

    void Start()
    {
        //enemyHealthScript = GameObject.Find("EnemyHealthOBJ").GetComponent<EnemyHealth>();
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("EnemyHit");
            //enemyHealthScript.RemoveHealth(damageEnemy);
        }
    }
}
