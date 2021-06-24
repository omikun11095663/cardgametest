using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCardView : MonoBehaviour
{
    [SerializeField] Image backImage;
    [SerializeField] Image iconImage;
    [SerializeField] Image flameImage;
    [SerializeField] Text costText;
    [SerializeField] Text atText;

    public void SetCard(MainCardModel cardModel)
    {
        atText.text = cardModel.at.ToString();
        costText.text = cardModel.cost.ToString();
        iconImage.sprite = cardModel.icon;
        flameImage.sprite = cardModel.flame;
        backImage.sprite = cardModel.back;
    }
}
