/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCopy : MonoBehaviour
{
    private Transform[] wayPoints;
    private int wayPointCount;
    private int idx = 0;
    private EnemyMove enemyMove;
    private EnemySpawn enemySpawn;

    // �� �ʱ�ȭ
    public void Init(EnemySpawn enemySpawn, Transform[] _wayPoints)
    {
        enemyMove = GetComponent<EnemyMove>();

        wayPointCount = _wayPoints.Length;
        this.wayPoints = new Transform[wayPointCount];
        this.wayPoints = _wayPoints;

        // �� ��ġ ����(spawn ��ġ��)
        transform.position = _wayPoints[idx].position;

        StartCoroutine("EnemyMove");
    }

    // �� ������
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

    // ���� ���� ������
    private void NextMove()
    {
        if (idx < wayPointCount - 1)
        {
            this.transform.position = wayPoints[idx].position;

            idx++;
            Vector3 direction = (wayPoints[idx].position - this.transform.position).normalized;
            enemyMove.Move(direction);
        }
        else
        {
            enemySpawn.DestoryEnemy(this);
        }
    }

    
}*/
