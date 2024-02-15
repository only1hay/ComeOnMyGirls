using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class upgrade : MonoBehaviour
{
    public TMP_Text money;
    public TMP_Text upgradePrice; //tower 각각의 price를 가져와야 함.
    private GameObject towerPosition;
    private TowerAbility _ability;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        towerPosition = GameManager.instance.GetTowerPosition();
        upgradePrice.text = (towerPosition.transform.Find("Tower").GetComponent<TowerAbility>().bulletDamage * 500).ToString();
    }

    public void UpgradeGirls()
    {
        int intUpgradePrice = int.Parse(upgradePrice.text);

        towerPosition = GameManager.instance.GetTowerPosition();
        if (GameManager.instance.ownedGold >= intUpgradePrice)
        {
            GameManager.instance.ownedGold -= intUpgradePrice;
            TowerUpgrade();
        }

        

        //타워랑 연결시켜 타워의 능력치 등을 변화시켜줘야 함.
    }

    public void TowerUpgrade()
    {
        GameObject.Find("SpawnPoint").GetComponent<TowerSpanwer>().UpgradeTower1(towerPosition);
    }
}
