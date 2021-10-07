using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBehaviour : MonoBehaviour
{
    public float holdTime = 2f;
    public bool timedDestruction = true;
    
    
    IEnumerator Start()
    {
        if (timedDestruction)
        {
            yield return new WaitForSeconds(holdTime);
            Destroy(gameObject);
        }
    }
    

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
