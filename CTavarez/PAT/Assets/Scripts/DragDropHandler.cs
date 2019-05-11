/* Clear A. Tavarez, 2019
 * Made with help from Kiwasi Games: https://www.youtube.com/watch?v=c47QYgsJrWc 
 * 
 * This script allows for objects to be dragged to the position the user is dragging it to. 
 * In addition, this script will check if the object was dragged to an appropriate parent location. */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;

    //checks the correct item is being selected and allows it to begun being dragged
    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    //moves the object to user touch coordinates seamlessly
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    //checks for proper location drop, i.e. parent slot and allows it to drop or not
    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
    }
}
