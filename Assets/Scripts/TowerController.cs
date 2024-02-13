using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public enum State
    {
        SearchEnemy = 0,
        TargetEnemy
    }

    [SerializeField] private GameObject bullet;
    [SerializeField] private State state;
    [SerializeField] private Transform bulletSys;
    [SerializeField] private Transform muzzle;
    private void Update()
    {
        Attack();
    }
    private void Attack()
    {
        GameObject newBullet = Instantiate(bullet,bulletSys);
        newBullet.transform.position = muzzle.position;
    }

}
