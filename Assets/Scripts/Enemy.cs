using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // �ӷ�
    public float enemySpeed = 4;

    // �̵� ����
    Vector3 dir;

    // �÷��̾�
    public GameObject player;

    void Start()
    {


        // ������ ���� ���� (0 ~ 9)
        int rand = Random.Range(0, 10);
        // ���࿡ ������ ���� 4 ���� ������ (40% Ȯ��)
        if(rand < 4)
        {
            // ������ �Ʒ��� ����.
            dir = Vector3.down;
        }
        // �׷��� ������ (������ 60% Ȯ��)
        else
        {
            // �÷��̾ ã��
            player = GameObject.Find("Player");
            
            // �÷��̾ ���ϴ� ������ ������.
            // 1. �÷��̾ ���ϴ� ������ ������. (P - E)
            dir = player.transform.position - transform.position;
            // ���� ������ ũ�⸦ 1�� ���� (����ȭ, Normalize)
            dir.Normalize();
        }             
    }

    void Update()
    {
        // 2. �� �������� �����̰� �ʹ�.
        transform.position += dir * enemySpeed * Time.deltaTime;
        
        //�Ʒ��� ��� �����̰� �ʹ�. 
        // P = P0 + vt(v �Ʒ�)
        //transform.position += Vector3.down * enemySpeed * Time.deltaTime;

    }
}
