using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SpawnPoint�� ��ũ��Ʈ ����
// spawnPoints�� SpawnPoint, ���� �̵� ��� ������� �Ҵ�
// enemyPrefabs�� �� �Ҵ�

// ���� �������� ����
// ���� 1~3�� �������� �� ����

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject[] enemyPrefabs;

    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    // �� ����
    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            int idx = Random.Range(0, 3);
            GameObject clone = Instantiate(enemyPrefabs[idx], this.transform.position, Quaternion.identity);
            Enemy enemy = clone.GetComponent<Enemy>();

            enemy.Init(spawnPoints);

            float spawnTime = Random.Range(1, 4);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
