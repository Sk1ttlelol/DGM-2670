using UnityEngine;


public class Boss : MonoBehaviour
{
    public Vector3 spawnPos;

    public float topBound = 5.4f, botBound = -3.55f, sideBound = 1.8f;
    
    private bool bossInArena = false;
    
    private bool topHit = true, botHit = true, leftHit = true, rightHit = false;
    
    public float speed, rotationSpeed;
    

    private void Update()
    {

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
      
        if (bossInArena == false)
        {
            transform.position = spawnPos;
            bossInArena = true;
            Debug.Log("I should only see this once");
        }
        else
        {
            bossInArena = true;
        }

        if (topHit == true)
        {
            botHit = false;
            transform.Translate(Vector3.down * Time.deltaTime * speed,Space.World);
        }
        
        if (botHit == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed,Space.World);
        }
        
        if (rightHit == true)
        {
            leftHit = false;
            transform.Translate(Vector3.left * Time.deltaTime * speed,Space.World);
        }
        
        if (leftHit == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed,Space.World);
        }
        
        if (transform.position.y >= topBound)
        {
            topHit = true;
        }
        
        if (transform.position.y <= botBound)
        {
            botHit = true;
            topHit = false;
        }
        
        if (transform.position.x >= sideBound)
        {
            rightHit = true;
        }
        
        if (transform.position.x <= -sideBound)
        {
            leftHit = true;
            rightHit = false;
        }

        
        
        
        
        
        
        
        
        Debug.Log("I should see this a lot");
        
    }
    
}

