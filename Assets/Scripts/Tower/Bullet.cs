using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    private void FixedUpdate()
    {

        transform.position -= transform.up * 10f * Time.fixedDeltaTime ;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {

            collision.gameObject.GetComponent<Enemy>().EnemyAttacked(1);
            Destroy(gameObject);
        }
    }



}
