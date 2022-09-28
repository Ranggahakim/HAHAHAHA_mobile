using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class forward_UI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool UIForward; //maju menggunakan ui
    public void OnPointerDown(PointerEventData eventData)
    {
        UIForward = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        UIForward = false;
    }
}
