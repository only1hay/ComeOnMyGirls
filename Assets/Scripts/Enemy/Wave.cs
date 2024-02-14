using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SpawnPoint에 스크립트 적용
// wave 설정(임의로 5 설정)

// 게임 시작
// 한 wave당 적 40마리

public class Wave : MonoBehaviour
{
    [SerializeField] private int waves = 5;

    private int waveIdx = 0;
    public int maxWaveEnemyCount = 40;

    private EnemySpawn enemySpawn;

    private void Awake()
    {
        enemySpawn = GetComponent<EnemySpawn>();
    }

    private void Start()
    {
        StartGame();
    }

    // 게임 시작
    public void StartGame()
    {
        // 다음 웨이브로 넘어가야 할 때
        if (enemySpawn.enemyList.Count == 0 && waveIdx < waves + 1)
        {
            waveIdx++;
            enemySpawn.StartWave(waves);
        }

        // @@@@@ 게임 오버 구현!!!!!
    }
}
