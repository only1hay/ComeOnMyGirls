using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject resumeBtn;

    public GameObject shopCanvas;

    public void PauseGame()//�Ͻ�����
    {
        Time.timeScale = 0;
        pauseBtn.SetActive(false);
        resumeBtn.SetActive(true);
    }

    public void ResumeGame()//�÷���
    {
        Time.timeScale = 1;
        pauseBtn.SetActive(true);
        resumeBtn.SetActive(false);
    }

    public void CloseShop()
    {
        shopCanvas.SetActive(false);
    }


}
