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
            if (intMoney >= intPurchasePrice)
            {
                intMoney -= intPurchasePrice;
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
}
