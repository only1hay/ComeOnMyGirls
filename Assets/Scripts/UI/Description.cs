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

    //public void OnPointerEnter()
    //{
    //    Debug.Log("마우스온");
    //    description.SetActive(true);
    //}

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("마우스온");
        description.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        description.SetActive(false);
    }   
}
