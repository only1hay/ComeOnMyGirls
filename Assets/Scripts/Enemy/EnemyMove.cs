using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 모든 적에 스크립트 적용
// 모든 적 프리펩 anim에 맞는 Animator 할당

// 적의 움직임 제어

public class EnemyMove : MonoBehaviour
{
    enum MoveStates
    {
        left = 1,
        right = 2,
        back = 3,
        front = 4
    }

    [SerializeField] private Animator anim;

    public float speed = 2.0f;
    private Vector3 direction;

    private void Update()
    {
        Move();
    }

    // 적의 움직임
    private void Move()
    {
        this.transform.position += direction * speed * Time.deltaTime;
    }

    // 적 움직임 애니메이션 상태 변화
    private void MoveState(Vector3 _direction)
    {
        // 오른쪽으로 움직일 때
        if (_direction.x > 0)
        {
            anim.SetInteger("AnimState", (int)MoveStates.right);
        }
        // 왼쪽으로 움직일 때
        else if (_direction.x < 0)
        {
            anim.SetInteger("AnimState", (int)MoveStates.left);
        }
        // 위로 움직일 때
        else if (_direction.y > 0)
        {
            anim.SetInteger("AnimState", (int)MoveStates.back);
        }
        // 아래로 움직일 때
        else if (_direction.y < 0)
        {
            anim.SetInteger("AnimState", (int)MoveStates.front);
        }
    }

    // 적의 움직임 방향
    public void MoveDirection(Vector3 _direction)
    {
        direction = _direction;

        MoveState(_direction);
    }
}
