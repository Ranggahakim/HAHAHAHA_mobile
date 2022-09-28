using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class rotateR_UI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool UIRotateR; //maju menggunakan ui
    public void OnPointerDown(PointerEventData eventData)
    {
        UIRotateR = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        UIRotateR = false;
    }
}
