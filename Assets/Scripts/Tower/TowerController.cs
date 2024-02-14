using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public event Action<Vector2> OnRotateTower;
    public event Action<Vector2> OnAttackTower;

    public void CallRotateTower(Vector2 direction)
    {
        OnRotateTower?.Invoke(direction);
    }

    public void CallAttackTower(Vector2 direction)
    {
        OnAttackTower?.Invoke(direction);
    }
}

