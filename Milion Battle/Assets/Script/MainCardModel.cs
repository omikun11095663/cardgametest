using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCardModel : MonoBehaviour
{
    public int at;
    public int cost;
    public Sprite flame;
    public Sprite icon;
    public Sprite back;

    public MainCardModel(int cardID)
    {
        MainCardEntity cardEntity = Resources.Load<MainCardEntity>("MainCardEntityList/card" + cardID);
        at = cardEntity.at;
        cost = cardEntity.cost;
        flame = cardEntity.flame;
        icon = cardEntity.icon;
        back = cardEntity.back;
    }
}
