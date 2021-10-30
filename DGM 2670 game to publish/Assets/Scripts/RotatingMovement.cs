using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingMovement : MonoBehaviour
{
    public float Rotation;

    void Update()
    {
        transform.Rotate (0, 0, Rotation *Time.deltaTime);
    }
}
