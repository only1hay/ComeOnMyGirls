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
        _ability.attackRange = 5f;
        _ability.attackSpeed = 1;
    }
}
