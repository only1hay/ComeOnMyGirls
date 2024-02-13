using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Transform target;
    Camera mainCamera;

    public UI_ShopPanel shopPanel;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
        //transform.position = mainCamera.WorldToScreenPoint(target.position);
        shopPanel.OpenShop(target);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
