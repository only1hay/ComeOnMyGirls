using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Purchase : MonoBehaviour
{
    [SerializeField] TMP_Text purchasePrice;
    public TMP_Text moneyText;
    private GameObject towerPosition;

    private void Awake()
    {
        
    }

    public void PurchaseGirls()
    {
        int intPurchasePrice = int.Parse(purchasePrice.text);
        
        towerPosition = GameManager.instance.GetTowerPosition();
        if (GameManager.instance.ownedGold >= intPurchasePrice)
        {
            if (!towerPosition.transform.Find("Tower(Clone)"))
            {
                GameManager.instance.ownedGold -= intPurchasePrice;
                SpawnTower(intPurchasePrice);
            }
        }
    }

    private void SpawnTower(int money)
    {
        switch (money)
        {
            case 400: GameObject.Find("SpawnPoint").GetComponent<TowerSpanwer>().SpawnTower1(towerPosition.transform); break;
        }
        
    }
}
