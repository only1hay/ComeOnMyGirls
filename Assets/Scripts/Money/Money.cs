using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField] TMP_Text price;
    public TMP_Text money;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void purchaseGirls()
    {
        int intPrice = int.Parse(price.text);
        int intMoney = int.Parse (money.text);

        if(intMoney>=intPrice)
        {
            intMoney -= intPrice;
        }

        money.text = intMoney.ToString();

    }

}
