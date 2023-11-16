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
    public bool canRun = true;
    
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {
            canRun = false;
            repeatEvent.Invoke();
            yield return wfsObj;
            counterNum.value --;
        }
        while (canRun == true)
        {
            yield return wfsObj;
            keepRunningEvent.Invoke();
        }


        endEvent.Invoke();
    }
}
