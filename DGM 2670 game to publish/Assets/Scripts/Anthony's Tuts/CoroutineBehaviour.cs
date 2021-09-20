using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent;
    public bool canRun = true;
    public float holdTime = 0.5f;
    private WaitForSeconds wfs;
    
    IEnumerator Start()
    {
        wfs = new WaitForSeconds(holdTime);
        
        while (canRun)
        {
            yield return wfs;
            startEvent.Invoke();
        }
    }
}

