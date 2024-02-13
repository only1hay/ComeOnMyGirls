using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCopy : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject[] enemyPrefabs;
    private List<Enemy> enemies;

    private void Awake()
    {
        enemies = new List<Enemy>();
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
            enemies.Add(enemy);

            float spawnTime = Random.Range(1, 4);
            yield return new WaitForSeconds(spawnTime);
        }
    }

    public void DestroyEnemty(Enemy enemy)
    {
        enemies.Remove(enemy);
        Destroy(enemy.gameObject);
    }
}
