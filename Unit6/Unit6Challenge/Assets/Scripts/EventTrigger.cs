using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    
    public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
