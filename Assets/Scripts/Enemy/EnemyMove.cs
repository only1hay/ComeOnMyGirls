using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��� ���� ��ũ��Ʈ ����

// ���� ������ ����

public class EnemyMove : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector3 direction;

    private void Update()
    {
        this.transform.position += direction * speed * Time.deltaTime;
    }

    // ���� ���� ������
    public void Move(Vector3 _direction)
    {
        direction = _direction;
    }
}
