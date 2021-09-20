using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class PlayerMovement : MonoBehaviour
{

    private float leftBound = -2.1f;
    private float rightBound = 2.1f;
    
    public float forceMult = 5;
    public Rigidbody playerRb;
    public float gravityMod;

    public Button moveRightButton;
    public Button moveLeftButton;
    


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
        Physics.gravity *= gravityMod;
    }

    // Update is called once per frame
    void Update()
    {
        moveRightButton.onClick.AddListener(MoveRight);
        moveLeftButton.onClick.AddListener(MoveLeft);
        
       
       if(transform.position.x < leftBound)
        {
            transform.position = new Vector3(leftBound, transform.position.y, transform.position.z);
        }
        
        if(transform.position.x > rightBound)
        {
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);
        }
    }

    void MoveRight()
    {
        playerRb.AddForce(transform.right * Time.deltaTime * forceMult);
    }
    
    void MoveLeft()
    {
        playerRb.AddForce(-transform.right * Time.deltaTime * forceMult);
    }
}
