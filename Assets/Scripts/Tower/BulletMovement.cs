using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float bulletSpeed = 1f;

    private void FixedUpdate()
    {
        transform.position += transform.right * bulletSpeed * Time.fixedDeltaTime;
    }



}
