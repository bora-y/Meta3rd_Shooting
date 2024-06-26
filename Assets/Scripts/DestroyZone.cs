using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // ���࿡ �ε��� ������Ʈ�� �Ѿ��̸�
        if(other.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            // �Ѿ��� ��Ȱ��ȭ �ϰ�
            other.gameObject.SetActive(false);
            // �Ѿ��� źâ�� ����.
            // Player �� ã��.
            GameObject player = GameObject.Find("Player");
            // ã�� Player ���� PlayerFire ������Ʈ ��������.
            PlayerFire playerFire = player.GetComponent<PlayerFire>();
            // ������ ������Ʈ�� magazine ������ �Ѿ��� �߰�����.
            playerFire.magazine.Add(other.gameObject);
        }
        // ��������
        else
        {
            // ���� �ε��� ������Ʈ�� �ı�����
            Destroy(other.gameObject);
        }
    }
}
