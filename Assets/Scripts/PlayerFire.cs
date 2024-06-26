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

    // �ʱ� �Ѿ� ����
    public int initBulletCnt = 6;
    // �Ѿ� źâ
    public List<GameObject> magazine = new List<GameObject>();

    void Start()
    {        
        // �Ѿ� 6�� ������
        for(int i = 0; i < initBulletCnt; i++)
        {
            GameObject bullet = Instantiate(bulletFactory);

            // ������� �Ѿ��� ��Ȱ��ȭ ����.
            bullet.SetActive(false);

            // �Ѿ��� źâ�� ����
            magazine.Add(bullet);            
        }
    }

    void Update()
    {
        // 1. ���콺 ���ʹ�ư�� ������ 
        // bool isClick = Input.GetButtonDown("Fire1");
        if(Input.GetButtonDown("Fire1"))
        //if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.LeftControl))
        {
            // źâ���� �Ѿ��� ��������.
            GameObject bullet = magazine[0];
            // ������ �Ѿ��� �ѱ��� ����
            bullet.transform.position = firePos.transform.position;
            // ������ �Ѿ��� Ȱ��ȭ ����.
            bullet.SetActive(true);
            // źû���� ������ �Ѿ��� ����.
            magazine.RemoveAt(0);

            #region �ϳ��ϳ� �Ѿ��� �����ϴ� ���
            //// 2. �Ѿ˰���(Prefab) ���� �Ѿ��� ��������.
            //GameObject bullet = Instantiate(bulletFactory);

            //// 3. ������ �Ѿ��� ��ġ�� �ѱ� ��ġ�� ����.
            //bullet.transform.position = firePos.transform.position;
            ////bullet.transform.position = transform.position + new Vector3(0, 1, 0);

            //GameObject bullet2 = Instantiate(bulletFactory);

            //bullet2.transform.position = firePos2.transform.position;
            #endregion

        }
    }
}
