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
        int intMoney = int.Parse(money.text);
        int intUpgradePrice = int.Parse(upgradePrice.text);

        if (intMoney>=intUpgradePrice)
        {
            intMoney -= intUpgradePrice;
            intUpgradePrice *= 2;
        }

        money.text = intMoney.ToString();
        upgradePrice.text = intUpgradePrice.ToString();

        //Ÿ���� ������� Ÿ���� �ɷ�ġ ���� ��ȭ������� ��.
    }
}
