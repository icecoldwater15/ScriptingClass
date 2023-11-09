using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Score : ScriptableObject
{
    public int value;
    
    private void OnEnable()
    {
        value = 0;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }

}
