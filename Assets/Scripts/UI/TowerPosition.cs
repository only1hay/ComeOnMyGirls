using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPosition : MonoBehaviour
{
    [SerializeField] UIManager UIMgr;
    //public GameObject shopPanel;

    //bool isClosedShop = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        UIMgr.SetTarget(this.transform);
        transform.Find("SelectTowerPoint").gameObject.SetActive(true);
        
    }
}
