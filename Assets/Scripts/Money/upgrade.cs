using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class upgrade : MonoBehaviour
{
    public TMP_Text money;
    public TMP_Text upgradePrice; //tower ������ price�� �����;� ��.

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

        if (GameManager.instance.ownedGold >= intUpgradePrice)
        {
            intUpgradePrice *= 2;
            GameManager.instance.ownedGold -= intUpgradePrice;
        }

        upgradePrice.text = intUpgradePrice.ToString();

        //Ÿ���� ������� Ÿ���� �ɷ�ġ ���� ��ȭ������� ��.
    }
}
