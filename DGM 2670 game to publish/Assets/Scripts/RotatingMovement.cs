using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingMovement : MonoBehaviour
{
    public float Rotation;

    void Update()
    {
        transform.Rotate (35 * Time.deltaTime, 25 * Time.deltaTime, Rotation *Time.deltaTime);
    }
}
