using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SpawnPoint에 스크립트 적용
// wayPoints에 SpawnPoint, 몬스터 이동 경로 순서대로 할당
// enemyPrefabs에 적 MonsterHHS, MonsterLHS, MonsterTIL 순서대로 할당

// SpawnPoint 오브젝트에 SpawnPoint Tag 설정

// 적은 랜덤으로 생성
// -> 1 wave에는 MonsterHHS 생성
// -> 2 wave에는 MonsterHHS, MonsterLHS 랜덤 생성
// -> 3 wave 이후는 MonsterHHS, MonsterLHS, MonsterTIL 랜덤 생성
// 적을 1~3초 랜덤으로 적 스폰
// 적이 생성 되었을 때 enemyList에 넣어서 관리
// 적이 죽었을 때 처리

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private Transform[] wayPoints;
    [SerializeField] private GameObject[] enemyPrefabs;

    public List<Enemy> enemyList;
    private int enemyCount;

    private Wave wave;

    private void Awake()
    {
        wave = GetComponent<Wave>();
        // 적 리스트 할당
        enemyList = new List<Enemy>();
    }

    public void StartWave(int _wave)
    {
        enemyCount = wave.maxWaveEnemyCount;
        StartCoroutine(SpawnEnemy());
    }

    // 적 생성
    private IEnumerator SpawnEnemy()
    {
        // 현재 스폰된 적의 수
        int spawnEnemyCount = 0;

        // 현재 wave에 아직 스폰해야할 적이 남아있다면
        while (spawnEnemyCount < wave.maxWaveEnemyCount)
        {
            int idx = Random.Range(0, 3); // @@@@@이거 Length로 바꿔보기(라운드 당 몬스터 종류 제어)!!!!!
            GameObject clone = Instantiate(enemyPrefabs[idx], this.transform.position, Quaternion.identity);
            Enemy enemy = clone.GetComponent<Enemy>();

            enemy.Init(wayPoints);
            enemyList.Add(enemy);

            float spawnTime = Random.Range(1, 4);
            yield return new WaitForSeconds(spawnTime);
        }

        wave.StartGame();
    }

    // 적이 죽었을 때
    public void EnemyDie(Enemy _enemy, GameObject gameObject)
    {
        // 현재 wave의 적 숫자 감소
        enemyCount--;
        // enemyList에서 적 정보 삭제
        enemyList.Remove(_enemy);
        // 적 삭제
        Destroy(gameObject);
    }
}
