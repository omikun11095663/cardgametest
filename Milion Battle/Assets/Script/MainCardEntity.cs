using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MainCardEntity", menuName = "Create MainCardEntity")]
//カードデータそのもの
public class MainCardEntity : ScriptableObject
{
    public int at;
    public int cost;
    public Sprite flame;
    public Sprite icon;
    public Sprite back;
}