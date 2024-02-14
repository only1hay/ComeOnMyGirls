using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRotate : MonoBehaviour
{
    private SpriteRenderer TowerSprite;
    private TowerController _controller;
    private TowerAbility _ability;
    private float attackRange;
    private void Awake()
    {
        _controller = GetComponent<TowerController>();
        _ability = GetComponent<TowerAbility>();
    }

    private void Start()
    {
        _controller.OnRotateTower += RotateTower;
        attackRange = _ability.attackRange;
    }

    private void RotateTower(Vector2 direction)
    {
        
        if (attackRange >= direction.magnitude)
        {
            float dgree = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, dgree);
        }
        
    }
}
