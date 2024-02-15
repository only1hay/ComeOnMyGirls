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
    [SerializeField] private TextMeshProUGUI curRoundText;

    [Header("Game Over Menu")]
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private TextMeshProUGUI gameOver_curKillScore;
    [SerializeField] private TextMeshProUGUI gameOver_bestKillScore;

    [Header("Game Clear Menu")]
    [SerializeField] private GameObject gameClearUI;
    [SerializeField] private TextMeshProUGUI gameClear_curScore;
    [SerializeField] private TextMeshProUGUI gameClear_bestScore;

    [Header("UI")]
    [SerializeField] private GameObject pauseBtn;
    [SerializeField] private GameObject resumeBtn;

    [HideInInspector]
    public int curTIL;
    public int killScore;
    public int ownedGold;
    public int clearScore;
    public int curRound;

    [Header("TowerPosition")]
    [SerializeField] private GameObject TowerPosition;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1.0f;
        curTIL = 0;
        killScore = 0;
        clearScore = 0;
        ownedGold = 10000;
        curRound = 0;
    }

    private void Update()
    {
        curTILText.text = curTIL.ToString();
        killScoreText.text = killScore.ToString();
        ownedGoldText.text = ownedGold.ToString();
        curRoundText.text = curRound.ToString();
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
        pauseBtn.SetActive(false);
        resumeBtn.SetActive(false);
        gameOver_curKillScore.text = killScore.ToString();
        if (PlayerPrefs.HasKey("bestkillScore") == false)
        {
            PlayerPrefs.SetInt("bestkillScore", killScore);
        }
        else
        {
            if(PlayerPrefs.GetInt("bestkillScore") < killScore)
            {
                PlayerPrefs.SetInt("bestkillScore", killScore);
            }
        }
        gameOver_bestKillScore.text = PlayerPrefs.GetInt("bestkillScore").ToString();
        gameOverUI.SetActive(true);
    }

    public void GameClear()
    {
        Time.timeScale = 0.0f;
        pauseBtn.SetActive(false);
        resumeBtn.SetActive(false);
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

    public void AddGold()
    {
       ownedGold += GameObject.FindWithTag("Enemy").GetComponent<Enemy>().reward;
    }

    public void AddKillScore()
    {
        killScore++;
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("SHWScene");
    }

    public void GoToTitle()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void SetTowerPosition(TowerPosition towerPosition)
    {
        TowerPosition = towerPosition.gameObject;
    }

    public GameObject GetTowerPosition()
    {
        return TowerPosition;
    }
}
