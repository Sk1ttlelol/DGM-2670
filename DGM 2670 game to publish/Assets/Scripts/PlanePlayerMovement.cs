using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlanePlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotationOffset;

    private float boundBox = 2.15f;
   

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);

        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        //This allows the player to rotate while also following the mouse
        //transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + rotationOffset));

        Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = 0;
        transform.position = Vector3.MoveTowards(transform.position, targetPos,speed * Time.deltaTime);
        
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
