using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // �ӷ�
    public float moveSpeed = 7;

    void Start()
    {
        
    }

    void Update()
    {
        // ���� ��� �ö󰡰� �ʹ�. (P = P0 + vt)
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;
    }
       

}
