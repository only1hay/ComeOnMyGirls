using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private GameObject target;




    private void Awake()
    {

    }
    private void Update()
    {
        RotationToTarget();
    }

    private void RotationToTarget()
    {
        float closestDistSqr = Mathf.Infinity;
        float distacne = Vector3.Distance(target.transform.position,transform.position);
        if (distacne < 5 && closestDistSqr >= distacne)
        {
            float dx = target.transform.position.x - transform.position.x;
            float dy = target.transform.position.y - transform.position.y;
            float degree = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, degree);
        }
        
    }

    

   
}
