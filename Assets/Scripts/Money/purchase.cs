using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Purchase : MonoBehaviour
{
    [SerializeField] TMP_Text purchasePrice;
    public TMP_Text moneyText;
    [SerializeField]
    private GameObject towerPrefab;
    private GameObject towerPosition;

    public void PurchaseGirls()
    {
        int intPurchasePrice = int.Parse(purchasePrice.text);
        
        towerPosition = GameManager.instance.GetTowerPosition();
        if (GameManager.instance.ownedGold >= intPurchasePrice)
        {
            if (!towerPosition.transform.Find("Tower(Clone)"))
            {
                GameManager.instance.ownedGold -= intPurchasePrice;
                SpawnTower();
            }
        }
    }

    private void SpawnTower()
    {
        GameObject Clone = Instantiate(towerPrefab, towerPosition.transform.position, towerPosition.transform.rotation);
        Clone.transform.parent = towerPosition.transform;
    }
}
