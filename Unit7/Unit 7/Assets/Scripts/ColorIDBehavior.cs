using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehavior : IDContainerScript
{
    public ColorIDDataList colorIDList;

    private void Awake()
    {
        objID = colorIDList.currentColor;
    }
}
