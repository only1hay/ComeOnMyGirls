using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpanwer : MonoBehaviour
{
    [SerializeField]
    private GameObject Tower1;
    private EnemySpawn enemySpawn;
    private TowerAbility _ability;

    private void Awake()
    {
        enemySpawn = GetComponent<EnemySpawn>();
    }
    public void SpawnTower1(Transform transform)
    {
        GameObject Clone = Instantiate(Tower1, transform.position, Quaternion.identity);
        Clone.transform.parent = transform.transform;
        Clone.GetComponent<TowerAttack>().Setup(enemySpawn);
    }

    public void UpgradeTower1(GameObject tower)
    {
        tower.transform.Find("Tower(Clone)").GetComponent<TowerAbility>().bulletDamage++;
        
    }

}

