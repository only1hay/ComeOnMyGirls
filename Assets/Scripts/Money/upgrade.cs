using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class upgrade : MonoBehaviour
{
    public TMP_Text money;
    public TMP_Text upgradePrice; //tower ������ price�� �����;� ��.
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

        

        //Ÿ���� ������� Ÿ���� �ɷ�ġ ���� ��ȭ������� ��.
    }

    public void TowerUpgrade()
    {
        GameObject.Find("SpawnPoint").GetComponent<TowerSpanwer>().UpgradeTower1(towerPosition);
    }
}
