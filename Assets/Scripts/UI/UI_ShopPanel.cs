using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ShopPanel : MonoBehaviour
{
    Camera mainCamera;

    public void Init()
    {
        mainCamera = Camera.main;
        CloseShop();
    }

    public void OpenShop(Transform towerPosition)
    {
        gameObject.SetActive(true);
        //transform.position = mainCamera.WorldToScreenPoint(towerPosition.position);
    }
    //Ÿ���������� Ŭ���ϸ� shopPanelȰ��ȭ

    public void CloseShop()
    {
        gameObject.SetActive(false);
    }
}
