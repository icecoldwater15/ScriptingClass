using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteControllerScript : MonoBehaviour
{
    public Color[] spriteColors = {Color.red, Color.green, Color.blue};
    public SpriteRenderer rendererObj;

    void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }


    public void ChangeObjColor(ColorID obj)
    {
        obj.color = spriteColors[Random.Range(0, spriteColors.Length)];
        rendererObj.color = obj.color;
    }
}
