using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Transform towerPosition;
    [SerializeField] Transform tower;
    Camera mainCamera;

    public UI_ShopPanel shopPanel;
    public UI_TopPanel topPanel;
    public UI_UpgradePanel upgradePanel;

    void Awake()
    {
        shopPanel.Init();
    }

    public void SetTarget(Transform towerPosition)
    {
        this.towerPosition = towerPosition;
        //transform.position = mainCamera.WorldToScreenPoint(target.position);
        shopPanel.OpenShop(towerPosition);
    }

    public void SetTarget2(Transform tower)
    {
        this.tower = tower;
        //transform.position = mainCamera.WorldToScreenPoint(tower.position);
        upgradePanel.OpenUpgrade(tower);
    }
}
