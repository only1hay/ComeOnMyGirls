using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownTowerController : MonoBehaviour
{
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}
