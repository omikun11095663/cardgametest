using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainDropPlace : MonoBehaviour, IDropHandler
{
    MainGameManager gameManager;
    public enum TYPE
    {
        HAND,
        FIELD,
    }

    public TYPE type;

    public void OnDrop(PointerEventData eventData)
    {

        if (type == TYPE.HAND)
        {
            return;
        }

        MainCardController card = eventData.pointerDrag.GetComponent<MainCardController>();

        if (card != null)
        {
            card.movement.defaultParent = this.transform;
            card.AttackEnemy();
        }
    }
}
