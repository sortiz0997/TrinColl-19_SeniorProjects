using UnityEngine;
using System.Collections;

public class ObjectColor : MonoBehaviour
{


    void OnSetColor(Color color)
    {
        Material mt = GetComponent<Renderer>().sharedMaterial;
        mt.color = color;
        GetComponent<Renderer>().sharedMaterial = mt;
    }

    void OnGetColor(ColorPicker picker)
    {
        picker.NotifyColor(GetComponent<Renderer>().sharedMaterial.color);
    }

    void OnApplicationQuit()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.white;

    }
}