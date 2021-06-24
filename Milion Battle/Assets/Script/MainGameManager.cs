using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainGameManager : MonoBehaviour
{
    [SerializeField] public Transform playerHandTransform;
    [SerializeField] public Transform enemyHandTransform;
    [SerializeField] MainCardController cardPrefab;
    //シングルトン化(どこからでもアクセスできるようにする)
    public static MainGameManager instance;

    [SerializeField] Slider slider;

    MainCardView cardView;

    [SerializeField] int bossHp;



    List<int> EnemyDeck = new List<int>() { 1, 2, 3, 4, 5, };
    List<int> PlayerDeck = new List<int>() { 1, 2, 3, 4, 5, };

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        slider.value = 30000;
        slider.maxValue = 30000;
        bossHp = 30000;
        PlayerDeck = new List<int>() { 1, 2, 3, 4, 5,};
        EnemyDeck = new List<int>() { 1, 2, 3, 4, 5, };
        SettingInitHand();
    }
    void SettingInitHand()
    {
        // カードをプレイヤーに5まい配る
        for (int i = 0; i < 5; i++)
        {
            GiveCardToHand(PlayerDeck, playerHandTransform);
        }

        for (int i = 0; i < 5; i++)
        {
            GiveCardToHand(EnemyDeck, enemyHandTransform);
        }
    } 
    void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
#endif
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) Quit();
    }

    public void EndGame()
    {
        Quit();
    }

    public void GiveCardToHand(List<int> deck, Transform hand)
    {
        if (deck.Count == 0)
        {
            return;
        }

        //デッキからランダムにドロー
        int rnd = UnityEngine.Random.Range(0, deck.Count);
        int cardID = deck[rnd];
        deck.RemoveAt(rnd);

        CreateCard(cardID, hand);
    }
    void CreateCard(int cardID, Transform hand)
    {
        // カードの生成とデータの受け渡し
        MainCardController card = Instantiate(cardPrefab, hand, false);
        card.Init(cardID);
    }
    public void DestroyCard(GameObject desCard)
    {
        Destroy(desCard);
    }
    public void DamageBoss(int at)
    {
        bossHp -= at;
        slider.value -= at;
    }
}
