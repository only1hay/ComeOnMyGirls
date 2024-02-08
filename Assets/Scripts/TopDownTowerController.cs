using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownTowerController : MonoBehaviour
{
    private event Action<Vector2> OnLookEvnet;

    public void CallLookEvent(Vector2 dircetion)
    {
        OnLookEvnet?.Invoke(dircetion);
    }
}
