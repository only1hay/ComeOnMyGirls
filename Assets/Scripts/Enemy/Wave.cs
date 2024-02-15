using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SpawnPoint에 스크립트 적용
// wave 설정(임의로 5 설정)

// 게임 시작
// 한 wave당 적 40마리

public class Wave : MonoBehaviour
{
    [SerializeField] private int maxWave = 5;

    [SerializeField] private int waveIdx = 0;            
    public int maxWaveEnemyCount = 40;  

    private EnemySpawn enemySpawn;

    private void Awake()
    {
        enemySpawn = GetComponent<EnemySpawn>();
    }

    private void Start()
    {
        waveIdx = 1;
        enemySpawn.StartWave(waveIdx);
    }

    // 게임 시작
    public void NextWave()
    {
        // 다음 웨이브로 넘어가야 할 때
        if (enemySpawn.enemyList.Count == 0 && waveIdx < maxWave + 1)
        {
            waveIdx++;
            enemySpawn.StartWave(waveIdx);
            GameManager.instance.curRound++;
        }
        if (maxWave + 1 <= waveIdx)
        {
            GameManager.instance.GameClear();
        }
    }
}
