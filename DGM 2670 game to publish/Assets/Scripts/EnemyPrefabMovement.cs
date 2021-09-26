using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrefabMovement : MonoBehaviour
{
    public float speed;

    private float boundBox = 2.15f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down *Time.deltaTime * speed);

        if (transform.position.x < -boundBox)
        {
            transform.position = new Vector3(-boundBox, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > boundBox)
        {
            transform.position = new Vector3(boundBox, transform.position.y, transform.position.z);
        }
    }
}
