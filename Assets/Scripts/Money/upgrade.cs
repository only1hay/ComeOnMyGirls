using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class upgrade : MonoBehaviour
{
    public TMP_Text money;
    public TMP_Text upgradePrice; //tower 각각의 price를 가져와야 함.
    private GameObject towerPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradeGirls()
    {
        int intUpgradePrice = int.Parse(upgradePrice.text);

        towerPosition = GameManager.instance.GetTowerPosition();
        if (GameManager.instance.ownedGold >= intUpgradePrice)
        {
            intUpgradePrice *= 2;
            GameManager.instance.ownedGold -= intUpgradePrice;
            TowerUpgrade();
        }

        upgradePrice.text = intUpgradePrice.ToString();

        //타워랑 연결시켜 타워의 능력치 등을 변화시켜줘야 함.
    }

    public void TowerUpgrade()
    {
        GameObject.Find("SpawnPoint").GetComponent<TowerSpanwer>().UpgradeTower1(towerPosition);
    }
}
