using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject resumeBtn;
    public Transform towerPosition;
    //public Camera camera;

    public GameObject shopCanvas;


    // Start is called before the first frame update
    void Start()
    {
       // camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 screenPos = camera.WorldToScreenPoint(towerPosition.position);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseBtn.SetActive(false);
        resumeBtn.SetActive(true);
    }

    public void ResumeBtn()
    {
        Time .timeScale = 1;
        pauseBtn.SetActive(true);
        resumeBtn.SetActive(false);
    }

    public void ClickTowerPosition()
    {
        shopCanvas.SetActive(true);
    }
}
