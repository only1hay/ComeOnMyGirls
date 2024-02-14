using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScan : TowerController
{
    [SerializeField] private GameObject Enemy;


    private void Update()
    {
        EnemyRange();
    }

    private void EnemyRange()
    {
        Vector2 direction = Enemy.transform.position - transform.position;
        CallRotateTower(direction);
        CallAttackTower(direction);
    }
}
