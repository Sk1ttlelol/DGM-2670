using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private float leftBound = -2.1f;
    private float rightBound = 2.1f;

    public Button moveRightButton;
    public Button moveLeftButton;

    public float forceMult = 5;
    private Rigidbody playerRb;
    public float gravityMod;

    public Vector3 playerSpawnPos;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
        Physics.gravity *= gravityMod;
    }

    // Update is called once per frame
    void Update()
    {
        //moveRightButton.onClick.AddListener(MoveRight);
        //moveLeftButton.onClick.AddListener(MoveLeft);
        

        if(transform.position.x < leftBound)
        {
            transform.position = new Vector3(leftBound, transform.position.y, transform.position.z);
        }
        
        if(transform.position.x > rightBound)
        {
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);
        }
    }


    public void Movement()
    {
        //while loop for player movement here
    }

    public void MoveRight()
    {
        playerRb.AddForce(transform.right * Time.deltaTime * forceMult);
    }

    public void MoveLeft()
    {
        playerRb.AddForce(-transform.right * Time.deltaTime * forceMult);
    }
}
