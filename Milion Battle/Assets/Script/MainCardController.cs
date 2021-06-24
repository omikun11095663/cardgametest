using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCardController : MonoBehaviour
{
    MainCardView view;          // 見かけ(view)に関することを操作
    public MainCardModel model;        // データ(model)に関することを操作
    public MainCardMovement movement;  // 移動(movement)に関することを操作
    MainGameManager gameManager;

    private void Awake()
    {
        model = GetComponent<MainCardModel>();
        view = GetComponent<MainCardView>();
        movement = GetComponent<MainCardMovement>();
    }
    public void Init(int cardID)
    {
        model = new MainCardModel(cardID);
        view.SetCard(model);
    }

    public void AttackEnemy()
    {
        gameManager.DamageBoss(model.at);
    }
}
