using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    private bool IsDraggable = true;


    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!IsDraggable)
        {
            return;
        }
        //Debug.Log("OnBeginDrag");
        rectTransform.anchoredPosition += eventData.delta;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
    }
    public void OnPointerDown(PointerEventData eventData){
        //Debug.Log("OnPointerDown");
    }

    public void DisableDragDrop()
    {
        IsDraggable = false;
    }
}