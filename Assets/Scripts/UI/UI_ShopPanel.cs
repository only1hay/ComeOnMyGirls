using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ShopPanel : MonoBehaviour
{
    Camera mainCamera;
    // Start is called before the first frame update
    public void Init()
    {
        mainCamera = Camera.main;
        CloseShop();
    }

    public void OpenShop(Transform towerPosition)
    {
        gameObject.SetActive(true);
        transform.position = mainCamera.WorldToScreenPoint(towerPosition.position);
    }

    public void CloseShop()
    {
        gameObject.SetActive(false);
    }
}
