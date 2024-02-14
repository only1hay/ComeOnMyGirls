using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ShopPanel : MonoBehaviour
{
    Camera mainCamera;
    //public GameObject selectTowerPoint;
    UIManager _UImanager;

    public void Init(UIManager uIManager)
    {
        _UImanager = uIManager;
        mainCamera = Camera.main;
    }

    public void OpenShop()
    {
        gameObject.SetActive(true);
        //transform.position = mainCamera.WorldToScreenPoint(towerPosition.position);
    }
    //타워포지션을 클릭하면 shopPanel활성화

    public void CloseShop()
    {
        gameObject.SetActive(false);
        //selectTowerPoint.SetActive(false);
        _UImanager.CloseShop();
    }
}
