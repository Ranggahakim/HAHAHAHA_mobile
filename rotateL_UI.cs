using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class rotateL_UI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool UIRotateL; //maju menggunakan ui
    public void OnPointerDown(PointerEventData eventData)
    {
        UIRotateL = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        UIRotateL = false;
    }
}
