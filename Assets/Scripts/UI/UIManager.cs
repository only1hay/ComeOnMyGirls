using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Transform towerPosition;
    Camera mainCamera;

    public UI_ShopPanel shopPanel;
    public UI_TopPanel topPanel;

    void Awake()
    {
        shopPanel.Init();
    }

    public void SetTarget(Transform towerPosition)
    {
        this.towerPosition = towerPosition;
        //transform.position = mainCamera.WorldToScreenPoint(target.position);
        shopPanel.OpenShop(towerPosition);
    }

    void CallDescription()
    {

    }

    private void OnMouseEnter()
    {
        
    }
}
