using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    [SerializeField]
    private GameObject sprite;
    [SerializeField]
    private GameObject spawn;
    [SerializeField]
    private Vector2 moveDirection = Vector2.zero;
    private void Rad()
    {
        Vector2 newDirection = spawn.transform.position - sprite.transform.position;
        newDirection = newDirection.normalized;
        moveDirection = newDirection;
    }

    private void Awake()
    {
        sprite = GameObject.Find("MainSprite");
        spawn = GameObject.Find("BulletSpawnPoint");
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
