using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_UpgradePanel : MonoBehaviour
{
    Camera mainCamera;
    public UI_ShopPanel shopPanel;
    public Image salePanel;
    [SerializeField] private Image Image1;
    [SerializeField] private Image Image2;
    [SerializeField] private Image Image3;
    [SerializeField] private Image _image;
    


    public void Init()
    {
        mainCamera = Camera.main;
        //CloseUpgrade();
    }

    public void OpenUpgrade()
    {
        gameObject.SetActive(true);
        shopPanel.gameObject.SetActive(false);

        GameObject _gameObject = GameManager.instance.GetTowerPosition();
        string strType = _gameObject.transform.Find("Tower").GetComponent<TowerAbility>().type.ToString();
        switch (strType)
        {
            case "Nomal": _image.sprite = Image1.sprite; break;
            case "Laser": _image.sprite = Image2.sprite; break;
            case "Bomb": _image.sprite = Image3.sprite; break;
        }
        //transform.position = mainCamera.WorldToScreenPoint(towerPosition.position);
    }
    //타워포지션을 클릭하면 shopPanel활성화

    public void CloseUpgrade()
    {
        if (gameObject.activeSelf == true)
        {
            gameObject.SetActive(false);
        }
        
    }

    public void WarningSalesGirl()
    {
        salePanel.gameObject.SetActive(false);
    }

    public void CloseWarning()
    {
        salePanel.gameObject.SetActive(true) ;
        Invoke("WarningSalesGirl", 0.5f);
    }
}
