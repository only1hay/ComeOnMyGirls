using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    private TowerAbility _ability; 
    private TowerController _controller;
    private float attackRange;
    private bool isAttack = false;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnPoint;

    private void Awake()
    {
        _ability = GetComponent<TowerAbility>();
        _controller = GetComponent<TowerController>();
    }

    private void Start()
    {
        _controller.OnAttackTower += AttackDgree;
    }

    private void Update()
    {
        Attack();
    }

    private void AttackDgree(Vector2 direction)
    {
        attackRange = direction.magnitude;
    }


    
    private void Attack()
    {
        if (attackRange > 0)
        {
            if (attackRange <= _ability.attackRange && !isAttack)
            {
                StartCoroutine("AttackToTarget");
                isAttack = true;
            }
            else if (attackRange > _ability.attackRange && isAttack)
            {
                StopCoroutine("AttackToTarget");
                isAttack = false;
            }
        }
        
    }

    private IEnumerator AttackToTarget()
    {
        while (true)
        {

            yield return new WaitForSeconds(_ability.attackSpeed);
            SpawnBullet();
        }
    }

    private void SpawnBullet()
    {
        Instantiate(bullet, spawnPoint.position,spawnPoint.rotation);
    }
}
