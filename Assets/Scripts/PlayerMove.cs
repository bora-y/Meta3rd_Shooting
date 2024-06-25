using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ּ�: Ctrl �������·� K->C
// �ּ� Ǯ�� : Ctrl �������·� K -> U
// �ڵ� ���� : Ctrl �������·� K -> F

/*
 ������� �Է��� �޾Ƽ� �̵������� ���ϰ�
�� �������� �����̰� �ʹ�.
 */


public class PlayerMove : MonoBehaviour
{
    // �̵� �ӷ�
    public float moveSpeed = 5;    

    void Start()
    {
    }

    void Update()
    {
        //1.������� �Է��� ����(w, a, s, d)
        // a : -1, d : 1, ������ ������ : 0
        float h = Input.GetAxis("Horizontal");
        // w : 1, s : -1, ������ ������ : 0
        float v = Input.GetAxis("Vertical");

        //2.�Է� ���� ���� �̿��ؼ� �̵������� ������.
        Vector3 dirH = Vector3.right * h;
        Vector3 dirV = Vector3.up * v;
        Vector3 dir = dirH + dirV;

        // dir �� ũ�⸦ 1�� ������.
        dir.Normalize();

        //3.������ �̵��������� ��������. (�ӷ� 5)
        //transform.Translate(dir * moveSpeed * Time.deltaTime);
        // �̵� ���� (P = P0 + vt)
        //transform.position = transform.position + dir * moveSpeed * Time.deltaTime;
        transform.position += dir * moveSpeed * Time.deltaTime;


        // 1. ���������� �̵��ϰ�ʹ�.
        // transform.Translate(Vector3.right * 5 * Time.deltaTime); 
    }
}
