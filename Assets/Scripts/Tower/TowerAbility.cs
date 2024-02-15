using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAbility : MonoBehaviour
{
    public enum Type
    {
        Nomal = 0,
        Sniper,
        Laser,
        Bomb
    }

    public Type type;
    public float attackSpeed;
    public float attackRange;

}
