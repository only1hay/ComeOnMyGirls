using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class upgrade : MonoBehaviour
{
    //tower 각각의 price를 가져와야 함.
    [SerializeField] UIManager _UIManager;
    public TMP_Text upgradePrice;


    TowerSystem towerSystem;
    TowerAbility towerAbility;

    public void UpgradeGirls()
    {
        towerSystem = _UIManager.GetSelectTowerSystem();
        towerAbility = towerSystem.GetTowerAbility();
        if (towerSystem == null)
        {
            return;
        }

        int intUpgradePrice = (int)towerAbility.bulletDamage * 500;

        if (GameManager.instance.ownedGold >= intUpgradePrice)
        {
            intUpgradePrice *= 2;
            GameManager.instance.ownedGold -= intUpgradePrice;
            TowerUpgrade();
        }

        

        //타워랑 연결시켜 타워의 능력치 등을 변화시켜줘야 함.
    }

    public void TowerUpgrade()
    {
        TowerSystem towerSystem = _UIManager.GetSelectTowerSystem();
        TowerAbility towerAbility = towerSystem.GetTowerAbility();
        towerAbility.bulletDamage++;

        //GameObject.Find("SpawnPoint").GetComponent<TowerSpanwer>().UpgradeTower1(towerPosition);
    }

    private void Update()
    {
        upgradePrice.text = $"{(int)towerAbility.bulletDamage * 500}";
    }

    private void Awake()
    {
        towerSystem = _UIManager.GetSelectTowerSystem();
        towerAbility = towerSystem.GetTowerAbility();
    }
}
