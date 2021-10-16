using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, startShieldEvent, endShieldEvent;
    public bool canRun = false;
    public float holdTime = 0.5f;
    private WaitForSeconds wfs;

    public void StartCoroutineSimple()
    {
        StartCoroutine(CoroutineSimple());
    }
    
    
    IEnumerator CoroutineSimple()
    {
        canRun = true;
        wfs = new WaitForSeconds(holdTime);
        startShieldEvent.Invoke();
        
        while (canRun)
        {
            yield return wfs;
            canRun = false;
            endShieldEvent.Invoke();
        }
    }

    public void ChangeWaitTime(float time)
    {
        wfs = new WaitForSeconds(time);
    }

    public void StartCoroutineWithIncrease()
    {
        StartCoroutine(CoroutineWithIncrease());
    }

    private IEnumerator CoroutineWithIncrease()
    {
        wfs = new WaitForSeconds(holdTime);

        while (canRun)
        {
            yield return wfs;
            if (holdTime >= 0.1f)
            {
                holdTime -= 0.1f;
                wfs = new WaitForSeconds(holdTime);
            }
            startEvent.Invoke();
        }
            
    }
}

