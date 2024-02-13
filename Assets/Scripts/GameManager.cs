using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private TextMeshProUGUI curTILText;
    [SerializeField] private TextMeshProUGUI ownedGoldText;
    [SerializeField] private TextMeshProUGUI killScoreText;

    [Header("Game Over Menu")]
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private TextMeshProUGUI gameOver_curKillScore;
    [SerializeField] private TextMeshProUGUI gameOver_bestKillScore;

    [Header("Game Clear Menu")]
    [SerializeField] private GameObject gameClearUI;
    [SerializeField] private TextMeshProUGUI gameClear_curScore;
    [SerializeField] private TextMeshProUGUI gameClear_bestScore;

    [HideInInspector]
    private int curTIL;
    private int killScore;
    private int ownedGold;
    private int clearScore;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        curTIL = 0;
    }

    private void Update()
    {
        curTILText.text = curTIL.ToString();
        killScoreText.text = killScore.ToString();
        ownedGoldText.text = ownedGold.ToString();
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
        Time.timeScale = 0.0f;
        gameOver_curKillScore.text = killScore.ToString();
        if (PlayerPrefs.HasKey("bestScore") == false)
        {
            PlayerPrefs.SetInt("bestScore", killScore);
        }
        else
        {
            if(PlayerPrefs.GetInt("bestScore") < killScore)
            {
                PlayerPrefs.SetInt("bestScore", killScore);
            }
        }
        gameOver_bestKillScore.text = PlayerPrefs.GetInt("bestScore").ToString();
        gameOverUI.SetActive(true);
    }

    public void GameClear()
    {
        Time.timeScale = 0.0f;
        clearScore = killScore + (40 - curTIL);
        gameClear_curScore.text = clearScore.ToString();
        if (PlayerPrefs.HasKey("bestScore") == false)
        {
            PlayerPrefs.SetInt("bestScore", clearScore);
        }
        else
        {
            if (PlayerPrefs.GetInt("bestScore") < clearScore)
            {
                PlayerPrefs.SetInt("bestScore", clearScore);
            }
        }
        gameClear_bestScore.text = PlayerPrefs.GetInt("bestScore").ToString();
        gameClearUI.SetActive(true);
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("SHWScene");
    }

    public void GoToTitle()
    {
        SceneManager.LoadScene("SHWScene");
    }
}
