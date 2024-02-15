using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SpawnPoint에 스크립트 적용
// wave 설정(임의로 5 설정)
// 한 wave당 소환할 적 수 설정(임의로 40 설정)

// 다음 wave 호출

public class Wave : MonoBehaviour
{
    [SerializeField] private int maxWave = 5;

    public int waveIdx = 0;
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

    // 다음 wave
    public void NextWave()
    {
        // 다음 웨이브로 넘어가야 할 때
        if (enemySpawn.enemyList.Count == 0 && waveIdx < maxWave + 1)
        {
            waveIdx++;
            enemySpawn.StartWave(waveIdx);
            GameManager.instance.curRound++;
        }
        // 게임이 끝났을 때
        if (maxWave + 1 <= waveIdx)
        {
            GameManager.instance.GameClear();
        }
    }
}
