using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DestroyerBehaviour : MonoBehaviour
{
    public float holdTime = 2f;
    public bool timedDestruction = true;
    public UnityEvent checkEnemies;
    
    
    IEnumerator Start()
    {
        if (timedDestruction)
        {
            yield return new WaitForSeconds(holdTime);
            Destroy(gameObject);
            checkEnemies.Invoke();
        }
    }
    

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
