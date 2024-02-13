using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ShopPanel : MonoBehaviour
{
    Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        CloseShop();
    }

    public void OpenShop(Transform target)
    {
        gameObject.SetActive(true);
        transform.position = mainCamera.WorldToScreenPoint(target.position);
    }

    public void CloseShop()
    {
        gameObject.SetActive(false);
    }
}
