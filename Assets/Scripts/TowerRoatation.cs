using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRoatation : MonoBehaviour
{
   private enum TargetState
    {
        SearchTarget = 0,
        TargetCatch
    }
    private TargetState State;

    [SerializeField] private GameObject Target;
    
    private void FixedUpdate()
    {
        Rotate();
    }

    private void Rotate()
    {
        float dx = Target.transform.position.x - transform.position.x;
        float dy = Target.transform.position.y - transform.position.y;

        float rotZ = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;

         transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }

}
