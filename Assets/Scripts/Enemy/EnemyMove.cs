using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 모든 적에 스크립트 적용

// 적의 움직임 제어

public class EnemyMove : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector3 direction;

    private void Update()
    {
        this.transform.position += direction * speed * Time.deltaTime;
    }

    // 적의 다음 움직임
    public void Move(Vector3 _direction)
    {
        direction = _direction;
    }
}
