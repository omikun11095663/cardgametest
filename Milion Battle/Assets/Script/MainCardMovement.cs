using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainCardMovement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Transform defaultParent;

    public bool isDraggable;

    MainGameManager gameManager = MainGameManager.instance;
    void Start()
    {
        defaultParent = transform.parent;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        MainCardController card = GetComponent<MainCardController>();

        defaultParent = transform.parent;
        transform.SetParent(defaultParent.parent, false);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(defaultParent, false);

        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
