using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_UpgradePanel : MonoBehaviour
{
    Camera mainCamera;
    public UI_ShopPanel shopPanel;

    public void Init()
    {
        mainCamera = Camera.main;
        //CloseUpgrade();
    }

    public void OpenUpgrade()
    {
        gameObject.SetActive(true);
        shopPanel.gameObject.SetActive(false);
        //transform.position = mainCamera.WorldToScreenPoint(towerPosition.position);
    }
    //타워포지션을 클릭하면 shopPanel활성화

    public void CloseUpgrade()
    {
        gameObject.SetActive(false);
    }
}
