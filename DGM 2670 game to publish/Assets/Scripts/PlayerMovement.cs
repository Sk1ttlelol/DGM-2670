using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float leftBound = -2.1f;
    private float rightBound = 2.1f;

    public float hInput;
    public float speed;
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
        hInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * Time.deltaTime * speed * hInput);
        
        if(transform.position.x < leftBound)
        {
            transform.position = new Vector3(leftBound, transform.position.y, transform.position.z);
        }
        
        if(transform.position.x > rightBound)
        {
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);
        }
    }
}
