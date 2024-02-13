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
        
    }

    private void Awake()
    {
        StartCoroutine("Attack");
    }
    private IEnumerator Attack()
    {
        while (true)
        {
            GameObject newBullet = Instantiate(bullet, bulletSys);
            newBullet.transform.position = muzzle.position;
            yield return new WaitForSeconds(1f);
        }
        
    }

}
