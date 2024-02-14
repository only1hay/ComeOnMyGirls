using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Purchase : MonoBehaviour
{
    [SerializeField] TMP_Text purchasePrice;
    //[SerializeField] TMP_Text salePrice;
    //[SerializeField] TMP_Text upgradePrice;
    public TMP_Text money;
    //public GameObject shopPanel;
    //public GameObject upgradePanel;
    [SerializeField]
    private GameObject towerPrefab;
    private GameObject towerPosition;


    private void Awake()
    {

    }
    public void PurchaseGirls()
    {
        int intPurchasePrice = int.Parse(purchasePrice.text);
        //int intSalePrice = int.Parse(salePrice.text);
        int intMoney = int.Parse(money.text);
        //int intUpgradePrice = int.Parse(upgradePrice.text);

        //bool _shop = shopPanel.activeSelf;
        //bool _upgrade = upgradePanel.activeSelf;

        //if (_shop == true)
        //{
        towerPosition = GameManager.instance.GetTowerPosition();
        if (intMoney >= intPurchasePrice)
        {
            
            if (!towerPosition.transform.Find("Tower(Clone)"))
            {
                intMoney -= intPurchasePrice;
                SpawnTower();
            }
                
        }
        //}
        //if (_upgrade == true)
        //{
        //    if (intMoney >= intUpgradePrice)
        //    {
        //        intMoney -= intUpgradePrice;
        //    }
        //    intMoney += intSalePrice;
        //}

        money.text = intMoney.ToString();
    }

    private void SpawnTower()
    {

        GameObject Clone = Instantiate(towerPrefab, towerPosition.transform.position, towerPosition.transform.rotation);
        Clone.transform.parent = towerPosition.transform;
    }
}
