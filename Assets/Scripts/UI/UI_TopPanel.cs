using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_TopPanel : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject resumeBtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PauseGame()//일시정지
    {
        Time.timeScale = 0;
        pauseBtn.SetActive(false);
        resumeBtn.SetActive(true);
    }

    public void ResumeGame()//플레이
    {
        Time.timeScale = 1;
        pauseBtn.SetActive(true);
        resumeBtn.SetActive(false);
    }
}
