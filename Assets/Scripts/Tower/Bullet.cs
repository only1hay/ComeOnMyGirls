using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    private void FixedUpdate()
    {

        transform.position -= transform.up * 10f * Time.fixedDeltaTime ;
        float distance = Vector3.Distance(transform.position, transform.parent.position);
        if (distance >= 5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            float damage = transform.parent.GetComponent<TowerAbility>().bulletDamage;
            collision.gameObject.GetComponent<Enemy>().EnemyAttacked(damage);
            Destroy(gameObject);
        }
    }



}
