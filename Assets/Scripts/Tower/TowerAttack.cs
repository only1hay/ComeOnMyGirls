using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TowerState
{
    SetTarget = 0,
    GetTarget
}

public class TowerAttack : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject topSprite;
    [SerializeField] TowerState state = TowerState.SetTarget;
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform target;
    private TowerAbility _ability;
    private EnemySpawn enemySpawn;


    public void Setup(EnemySpawn enemySpawn)
    {
        _ability = GetComponent<TowerAbility>();
        this.enemySpawn = enemySpawn;
        ChangeState(TowerState.SetTarget);
    }

    public void ChangeState(TowerState towerState)
    {
        StopCoroutine(state.ToString());
        state = towerState;
        StartCoroutine(state.ToString());
    }

    private void Update()
    {
        if (target != null)
        {
            RotateTower();
        }
    }

    private void RotateTower()
    {
        Vector2 towerAim = target.position - transform.position;
        float dgree = Mathf.Atan2(towerAim.y, towerAim.x) * Mathf.Rad2Deg;
        topSprite.transform.rotation = Quaternion.Euler(0,0,dgree);
    }

    private IEnumerator SetTarget()
    {
        while (true)
        {
            float CloseTarget = Mathf.Infinity;
            for (int i = 0; i < enemySpawn.enemyList.Count; i++)
            {
                float distance = Vector3.Distance(enemySpawn.enemyList[i].transform.position, transform.position);
                if (distance <= _ability.attackRange && distance <= CloseTarget)
                {
                    CloseTarget = distance;
                    target = enemySpawn.enemyList[i].transform;
                }
            }
            if (target!=null)
            {
                ChangeState(TowerState.GetTarget);
            }
            yield return null;
        }
    }

    private IEnumerator GetTarget()
    {
        while ( true)
        {
            if (target == null)
            {
                ChangeState(TowerState.SetTarget);
                break;
            }
            
            float distance = Vector3.Distance(target.position, transform.position);
            if (distance > _ability.attackRange)
            {
                target = null;
                ChangeState(TowerState.SetTarget);
                break;
            }

            yield return new WaitForSeconds(_ability.attackSpeed);

            SpawnBullet();
        }
    }

    private void SpawnBullet()
    {
        GameObject bulletClone =  Instantiate(bullet,spawnPoint.transform.position,spawnPoint.transform.rotation);
        bulletClone.transform.parent = transform;
        Destroy(bulletClone, 5f);
    }
}
