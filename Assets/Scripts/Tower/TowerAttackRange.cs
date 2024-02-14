using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttackRange : MonoBehaviour
{
    public GameObject attackRangeIndicatorPrefab;
    private GameObject attackRangeIndicator;

    private TowerAbility _ability;

    private void Awake()
    {
        _ability = GetComponent<TowerAbility>();
    }

    private void OnMouseEnter()
    {
        attackRangeIndicator = Instantiate(attackRangeIndicatorPrefab,transform.position, Quaternion.identity);
        float range = _ability.attackRange;
        attackRangeIndicator.transform.localScale = new Vector3(range*2, range * 2, range*2);
    }

    private void OnMouseExit()
    {
        if (attackRangeIndicator != null)
        {
            Destroy(attackRangeIndicator);
        }
    }
}
