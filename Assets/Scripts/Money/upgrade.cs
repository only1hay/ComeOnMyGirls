using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class upgrade : MonoBehaviour
{
    public TMP_Text money;
    public TMP_Text upgradePrice; //tower 각각의 price를 가져와야 함.

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

        //타워랑 연결시켜 타워의 능력치 등을 변화시켜줘야 함.
    }
}
