using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MatchingScript : MonoBehaviour
{
    public IDContainerScript objID;
    public UnityEvent Match, noMatch;
    
    void OnTriggerEnter(Collider other)
    {
        var otherObjID = other.GetComponent<IDContainerScript>().objID;
        if (objID.objID == otherObjID)
        {
            Match.Invoke();
        }
        else if (objID.objID != otherObjID)
        {
            noMatch.Invoke();
        }
    }
}
