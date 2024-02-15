using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpanwer : MonoBehaviour
{
    [SerializeField]
    private GameObject TowerPrefab1;
    [SerializeField]
    private GameObject TowerPrefab2;
    [SerializeField]
    private GameObject TowerPrefab3;
    private EnemySpawn enemySpawn;
    private TowerAbility _ability;
    private GameObject Tower;

    private void Awake()
    {
        enemySpawn = GetComponent<EnemySpawn>();
    }
    public void SpawnTower1(Transform transform, int index)
    {
        switch (index)
        {
            case 400: Tower = TowerPrefab1; break;
            case 450: Tower = TowerPrefab2; break;
            case 500: Tower = TowerPrefab3; break;
        }
        GameObject Clone = Instantiate(Tower, transform.position, Quaternion.identity);
        Clone.transform.parent = transform.transform;
        Clone.GetComponent<TowerAttack>().Setup(enemySpawn);
    }

    public void UpgradeTower1(GameObject tower)
    {
        tower.transform.Find("Tower(Clone)aw").GetComponent<TowerAbility>().bulletDamage++;
    }

}

