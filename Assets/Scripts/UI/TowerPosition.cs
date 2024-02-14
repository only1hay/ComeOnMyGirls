using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPosition : MonoBehaviour
{
    [SerializeField] UIManager UIMgr;
    GameObject _selectTowerPoint;
    //public GameObject shopPanel;

    //bool isClosedShop = true;
    
    // Start is called before the first frame update
    void Start()
    {
        _selectTowerPoint= transform.Find("SelectTowerPoint").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GameManager.instance.SetTowerPosition(this);
        UIMgr.SetTarget(this);
        _selectTowerPoint.SetActive(true);
    }

    public void ClosePoint()
    {
        _selectTowerPoint.SetActive(false);
    }
}
