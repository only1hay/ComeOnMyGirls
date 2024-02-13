using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    [SerializeField]
    private Vector2 sprite;
    [SerializeField]
    private Vector2 spawn;

    private void Rad()
    {
        Vector2 newDirection = sprite - spawn;
        newDirection = newDirection.normalized;


    }

}
