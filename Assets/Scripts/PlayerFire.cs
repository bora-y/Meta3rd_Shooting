using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerFire : MonoBehaviour
{
    // �Ѿ˰���(Prefab)
    public GameObject bulletFactory;
    // �ѱ�
    public GameObject firePos;
    public GameObject firePos2;

    void Start()
    {
       
    }

    void Update()
    {
        // 1. ���콺 ���ʹ�ư�� ������ 
        // bool isClick = Input.GetButtonDown("Fire1");
        if(Input.GetButtonDown("Fire1"))
        //if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.LeftControl))
        {
            // 2. �Ѿ˰���(Prefab) ���� �Ѿ��� ��������.
            GameObject bullet = Instantiate(bulletFactory);

            // 3. ������ �Ѿ��� ��ġ�� �ѱ� ��ġ�� ����.
            bullet.transform.position = firePos.transform.position;
            //bullet.transform.position = transform.position + new Vector3(0, 1, 0);

            GameObject bullet2 = Instantiate(bulletFactory);

            bullet2.transform.position = firePos2.transform.position;
        }
    }
}
