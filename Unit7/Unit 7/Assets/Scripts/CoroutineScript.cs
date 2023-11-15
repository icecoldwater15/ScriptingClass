using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineScript: MonoBehaviour
{
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    public int counterNum = 3;
    public float seconds = 3f;
    public UnityEvent repeatEvent;
    
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();

        while (counterNum > 0)
        {
            yield return wfsObj;
            counterNum --;
            repeatEvent.Invoke();
            Debug.Log("nuts");
        }

    }
}
