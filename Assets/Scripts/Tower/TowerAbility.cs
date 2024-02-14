using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAbility : MonoBehaviour
{
    public enum TowerType
    {
        None,
        bomb
    }
    public TowerType type;
    public float attackRange;
    public float bulletDamage;
    public float attackSpeed;
}
