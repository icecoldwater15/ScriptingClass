using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteControllerScript : MonoBehaviour
{
    public SpriteRenderer rendererObj;
    private int num;

    void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }


    public void ChangeObjColor(ColorID obj)
    {
        rendererObj.color = obj.color;
    }

    public void ChangeObjColorRandom(ColorIDDataList obj)
    {
        rendererObj.color = obj.currentColor.color;
    }
}
