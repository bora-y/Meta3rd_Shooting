using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Enemy ����
    public GameObject enemyFactory;

    // �����ð�(���ؽð�)
    public float createTime = 0;
    // ����ð�(�����ð�)
    public float currTime = 0;
   
    void Start()
    {
        // �����ð��� ������ ������ ���� (0.5 ~ 1.5)
        createTime = Random.Range(0.5f, 1.5f);
    }

    void Update()
    {
        // �ð��� �帣�� ����(DeltaTime ����)
        currTime += Time.deltaTime;

        // ���࿡ 1�ʰ� �����ٸ� (����ð� > �����ð� )
        if (currTime > createTime)
        {           
            // Enemy �� �ϳ� ��������.
            GameObject enemy = Instantiate(enemyFactory);
            // ������ Enemy�� ���� ��ġ�� ����.
            enemy.transform.position = transform.position;
            // ����ð��� �ʱ�ȭ
            currTime = 0;
            // �����ð��� ������ ������ ���� (0.5 ~ 1.5)
            createTime = Random.Range(0.5f, 1.5f);
        }
    }
}
