/* Clear A. Tavarez, 2019
 * Made with help from Kiwasi Games: https://www.youtube.com/watch?v=c47QYgsJrWc 
 * 
 * This script gives definition to a slot so that objects may be dropped in them. */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{

    //checks to make sure the slot is empty
    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    //sets the slot to "full" if it has a child
    public void OnDrop(PointerEventData eventData)
    {
      if (!item)
        {
            DragDropHandler.itemBeingDragged.transform.SetParent(transform);
        }
    }
}
