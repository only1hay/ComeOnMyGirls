using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Description : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField]GameObject description;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        description.SetActive(true);
    }
    //마우스가 올라가면 설명란 나옴

    public void OnPointerExit(PointerEventData eventData)
    {
        description.SetActive(false);
    }   

}
