using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrefabMovement : MonoBehaviour
{
    public float speed;
    public bool canMove;
    

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed,Space.World);  
        }
    }
}
