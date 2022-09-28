using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class back_UI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool UIback; //maju menggunakan ui
    public void OnPointerDown(PointerEventData eventData)
    {
        UIback = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        UIback = false;
    }
}
