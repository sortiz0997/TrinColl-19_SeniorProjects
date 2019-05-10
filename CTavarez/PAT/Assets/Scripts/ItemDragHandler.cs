/* Clear A. Tavarez, 2019
 * 
 * This script drags an item to the mouse position and leaves it where the user left it */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IDragHandler
{

    //moves linked object to the spot the user drags it to
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
}