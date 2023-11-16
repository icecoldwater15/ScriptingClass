using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Score : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }
    
    private void OnEnable()
    {
        value = 0;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }

}
