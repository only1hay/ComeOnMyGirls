using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSystem : MonoBehaviour
{
    private TowerAbility _ability;

    private void Awake()
    {
        _ability = GetComponent<TowerAbility>();
    }

    private void Start()
    {
        Setup();
    }

    private void Setup()
    {
        
        switch (_ability.type)
        {
            case TowerAbility.Type.Nomal:
                _ability.attackRange = 5f;
                _ability.attackSpeed = 1;
                _ability.bulletDamage = 3;
                break;
            case TowerAbility.Type.Laser:
                _ability.attackRange = 5f;
                _ability.attackSpeed = 0.2f;
                _ability.bulletDamage = 0.2f;
                break;
            case TowerAbility.Type.Bomb:
                _ability.attackRange = 5f;
                _ability.attackSpeed = 3f;
                _ability.bulletDamage = 10;
                break;
            default:
                break;
        }
    }
}
