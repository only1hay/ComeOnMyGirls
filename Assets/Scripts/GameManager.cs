using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private TextMeshProUGUI curTILText;
    [SerializeField] private TextMeshProUGUI ownedGoldText;
    [SerializeField] private TextMeshProUGUI killScoreText;

    [Header("GameOverMenu")]
    [SerializeField] private TextMeshProUGUI gameOver_curKillScore;
    [SerializeField] private TextMeshProUGUI gameOver_bestKillScore;

    [Header("GameClearMenu")]
    [SerializeField] private TextMeshProUGUI gameClear_curKillScore;
    [SerializeField] private TextMeshProUGUI gameClear_bestKillScore;

    [HideInInspector]
    private int curTIL;
    private int killScore;
    private int ownedGold;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        curTILText.text = curTIL.ToString();
        killScoreText.text = killScore.ToString();
        ownedGoldText.text = ownedGold.ToString();
        curTIL = 0;
    }

    private void Update()
    {
        
    }

    public void AddTIL()
    {
        curTIL++;
        if (curTIL >= 40)
        {
            curTIL = 40;
            GameOver();
        }
    }

    public void GameOver()
    {

    }

    public void GameClear()
    {

    }
}
