using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TowerPosition towerPosition;
    [SerializeField] TowerSystem selectTower;
    Camera mainCamera;

    public UI_ShopPanel shopPanel;
    public UI_TopPanel topPanel;
    public UI_UpgradePanel upgradePanel;

    void Awake()
    {
        shopPanel.Init(this);
    }

    public TowerSystem GetSelectTowerSystem()
    {
        return selectTower;
    }

    public void SetTarget(TowerPosition _towerPosition)
    {
        if(towerPosition != null)
        {
            towerPosition.ClosePoint();
        }
        this.towerPosition = _towerPosition;
        //transform.position = mainCamera.WorldToScreenPoint(target.position);

        selectTower = towerPosition.GetComponentInChildren<TowerSystem> ();

        if (selectTower!=null)
        {
            SetTarget2();
        }
        else
        {
            shopPanel.OpenShop();
        }
        
    }

    public void SetTarget2(/*Transform tower*/)
    {
        /*this.tower = tower;*/
        //transform.position = mainCamera.WorldToScreenPoint(tower.position);
        upgradePanel.OpenUpgrade();
    }

    public void CloseShop()
    {
        towerPosition.ClosePoint();
        towerPosition = null;
    }

    public void UpgradePrice()
    {
        
    }
}
