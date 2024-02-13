using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SpawnPoint에 스크립트 적용
// spawnPoints에 SpawnPoint, 몬스터 이동 경로 순서대로 할당
// enemyPrefabs에 적 할당

// 적은 랜덤으로 생성
// 적을 1~3초 랜덤으로 적 스폰

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject[] enemyPrefabs;

    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    // 적 생성
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
