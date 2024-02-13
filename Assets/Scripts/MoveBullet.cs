using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    [SerializeField]
    private Vector2 sprite;
    [SerializeField]
    private Vector2 spawn;
    [SerializeField]
    private Vector2 moveDirection = Vector2.zero;
    private void Rad()
    {
        Vector2 newDirection = sprite - spawn;
        newDirection = newDirection.normalized;
        moveDirection = newDirection;
    }

    private void Awake()
    {
        Rad();
    }

    private void FixedUpdate()
    {
        Move(moveDirection);
    }



    private void Move(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y,0) * Time.fixedDeltaTime;
    }

}
