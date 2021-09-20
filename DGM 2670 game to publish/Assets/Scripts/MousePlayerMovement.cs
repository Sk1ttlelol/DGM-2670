using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;
using Vector3 = UnityEngine.Vector3;

public class MousePlayerMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float followSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.position = offset, followSpeed);
    }
}
