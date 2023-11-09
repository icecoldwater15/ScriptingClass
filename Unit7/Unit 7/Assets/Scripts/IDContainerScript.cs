using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDContainerScript : MonoBehaviour
{
    public ID objID;
    public UnityEvent startEvent;
    
    void Start()
    {
        startEvent.Invoke();
    }
}
