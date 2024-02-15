using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 모든 적에 스크립트 적용
// 적 프리펩에 hp, reward 설정

// 모든 적 프리펩에 Enemy Tag 설정

// 적 초기화, 현재 움직임과 다음 움직임 제어

public class Enemy : MonoBehaviour
{
    [SerializeField] private int hp = 1;
    public int reward = 100;

    private Transform[] wayPoints;
    private int wayPointCount;
    private int idx = 0;

    private EnemyMove enemyMove;
    private EnemySpawn enemySpawn;
    private Wave wave;

    // 적 초기화
    public void Init(Transform[] _wayPoints)
    {
        enemyMove = GetComponent<EnemyMove>();
        enemySpawn = GameObject.FindGameObjectWithTag("SpawnPoint").GetComponent<EnemySpawn>();
        wave = GameObject.FindGameObjectWithTag("SpawnPoint").GetComponent<Wave>();

        wayPointCount = _wayPoints.Length;
        this.wayPoints = new Transform[wayPointCount];
        this.wayPoints = _wayPoints;

        // wave 마다 적의 스탯 초기화
        hp *= wave.waveIdx;
        enemyMove.speed *= wave.waveIdx;

        // 적 위치 설정(spawn 위치로)
        transform.position = _wayPoints[idx].position;

        StartCoroutine(EnemyMove());
    }

    // 적 움직임
    private IEnumerator EnemyMove()
    {
        NextMove();

        while (true)
        {
            if (Vector3.Distance(this.transform.position, wayPoints[idx].position) < 0.2f * enemyMove.speed)
            {
                NextMove();
            }

            yield return null;
        }
    }

    // 적의 다음 움직임
    private void NextMove()
    {
        if (idx < wayPointCount - 1)
        {
            this.transform.position = wayPoints[idx].position;

            idx++;
            Vector3 direction = (wayPoints[idx].position - this.transform.position).normalized;
            enemyMove.MoveDirection(direction);
        }
        else
        {
            enemySpawn.EnemyDie(this, gameObject);
            GameManager.instance.AddTIL();
        }
    }

    // 적이 공격 받았을 때
    public void EnemyAttacked(int _damage)
    {
        hp -= _damage;

        // 적의 hp가 0이면 
        if (hp <= 0)
        {
            enemySpawn.EnemyDie(this, gameObject);
            GameManager.instance.AddGold();
            GameManager.instance.AddKillScore();
        }
    }
}
