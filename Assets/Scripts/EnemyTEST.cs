using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyTEST : MonoBehaviour
{
    int HP = 10;

    private void Update()
    {
        Death();
    }

    private void Death()
    {
        if (HP < 0)
        {
            Destroy(gameObject);
        }
    }
}
