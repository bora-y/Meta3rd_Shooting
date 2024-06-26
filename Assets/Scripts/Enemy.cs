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

            // ���࿡ player �� �� ã�Ҵٸ�
            if(player != null)
            {
                // �÷��̾ ���ϴ� ������ ������.
                // 1. �÷��̾ ���ϴ� ������ ������. (P - E)
                dir = player.transform.position - transform.position;
                // ���� ������ ũ�⸦ 1�� ���� (����ȭ, Normalize)
                dir.Normalize();
            }
            // player �� ��ã�Ҵٸ�
            //else
            //{
            //    dir = Vector3.down;
            //}
        }

        Destroy(gameObject, 10);
    }

    void Update()
    {
        // 2. �� �������� �����̰� �ʹ�.
        transform.position += dir * enemySpeed * Time.deltaTime;
        
        //�Ʒ��� ��� �����̰� �ʹ�. 
        // P = P0 + vt(v �Ʒ�)
        //transform.position += Vector3.down * enemySpeed * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {


        // ���࿡ �ε��� ������Ʈ�� 
        if(other.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            // �ε��� �Ѿ� ��Ȱ��ȭ
            other.gameObject.SetActive(false);
            //�Ѿ��̸� źâ�� ����.
            GameObject player = GameObject.Find("Player");
            PlayerFire playerFire = player.GetComponent<PlayerFire>();
            playerFire.magazine.Add(other.gameObject);
        }
        // �׷��� �ʰ� ���࿡ �ε��� ������Ʈ�� �̸��� DestroyZone �� �����ϰ� ���� �ʴٸ�
        else if (other.gameObject.name.Contains("Destroy") == false)
        {
            // �ε��� ������Ʈ ������
        
            Destroy(other.gameObject);
        }
        
       
        // ���� ������
        Destroy(gameObject);
    }
}
