using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class upgrade : MonoBehaviour
{

    //tower ������ price�� �����;� ��.
    [SerializeField] UIManager _UIManager;
    public TMP_Text money;
    public TMP_Text upgradePrice; //tower ������ price�� �����;� ��.
    private GameObject towerPosition;
    private TowerAbility _ability;




    TowerSystem towerSystem;
    TowerAbility towerAbility;

    // Update is called once per frame
    void Update()
    {
        towerPosition = GameManager.instance.GetTowerPosition();
        upgradePrice.text = (towerPosition.transform.Find("Tower(Clone)").GetComponent<TowerAbility>().bulletDamage * 500).ToString();
    }


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

        

        //Ÿ���� ������� Ÿ���� �ɷ�ġ ���� ��ȭ������� ��.
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
