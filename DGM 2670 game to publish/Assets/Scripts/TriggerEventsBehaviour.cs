using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, playerEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        
        if (other.gameObject.CompareTag("Player"))
        {
            playerEvent.Invoke();
        }
    }
   

}
