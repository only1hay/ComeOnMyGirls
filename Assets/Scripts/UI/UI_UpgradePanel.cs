using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_UpgradePanel : MonoBehaviour
{
    Camera mainCamera;

    public void Init()
    {
        mainCamera = Camera.main;
        CloseUpgrade();
    }

    public void OpenUpgrade(Transform tower)
    {
        gameObject.SetActive(true);
        //transform.position = mainCamera.WorldToScreenPoint(towerPosition.position);
    }
    //Ÿ���������� Ŭ���ϸ� shopPanelȰ��ȭ

    public void CloseUpgrade()
    {
        gameObject.SetActive(false);
    }
}
