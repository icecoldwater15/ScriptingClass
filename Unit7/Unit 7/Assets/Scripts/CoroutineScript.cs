using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineScript: MonoBehaviour
{
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    public Score counterNum;
    public float seconds;
    public UnityEvent startEvent, repeatEvent, endEvent, keepRunningEvent;
    public bool canRun = false;
    
    void Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startEvent.Invoke();
        StartCoroutine(Counter());
    }
    
    
    public IEnumerator Counter()
    {
        yield return wfsObj;
        while (counterNum.value > 0)
        {
            repeatEvent.Invoke();
            yield return wfsObj;
            counterNum.value --;
            if (counterNum.value <= 0)
            {
                endEvent.Invoke();
                break;
            }
        }
    }

    public void StartKeepRunning()
    {
        canRun = true;
        StartCoroutine(KeepRunning());
    }

    
    private IEnumerator KeepRunning()
    {
        while (canRun == true)
        {
            yield return wfsObj;
            keepRunningEvent.Invoke();
        }
    }
}
