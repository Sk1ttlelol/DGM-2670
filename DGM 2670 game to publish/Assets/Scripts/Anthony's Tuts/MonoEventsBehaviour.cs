using System;
using UnityEngine.Events;
using UnityEngine;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent;
    

    void Start()
    {
        startEvent.Invoke();
    }
    
}
