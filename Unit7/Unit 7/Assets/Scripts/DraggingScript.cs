using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DraggingScript : MonoBehaviour
{
    private bool isDragging = false;
    public Vector3 offset;
    public UnityEvent dragEvent, dropEvent;

    public void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragEvent.Invoke();
    }

    private void OnMouseUp()
    {
        isDragging = false;
        dropEvent.Invoke();
    }
    
    void Update()
    {
        if (isDragging)
        {
            Vector3 cursorOnScreen = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z);
            Vector3 cusorPosition = Camera.main.ScreenToWorldPoint(cursorOnScreen) + offset;
            transform.position = cusorPosition;
        }
    }

}
