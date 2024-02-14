using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSystem : MonoBehaviour
{
    private TowerAbility _ability;

    private void Awake()
    {
        _ability = GetComponent<TowerAbility>();
        Setup();
    }

    private void Setup()
    {
        _ability.attackRange = 2f;
    }

}
