using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRotate : MonoBehaviour
{
    private SpriteRenderer TowerSprite;
    private TowerController _controller;


    private void Awake()
    {
        _controller = GetComponent<TowerController>();
    }

    private void Start()
    {
        _controller.OnRotateTower += RotateTower;
    }

    private void RotateTower(Vector2 direction)
    {
        float dgree = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,dgree);
    }
}
