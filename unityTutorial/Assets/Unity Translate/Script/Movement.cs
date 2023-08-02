using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region �̵�����
        //transform.position:�ڽ��� ��ġ
        //transform.position += Vector3.forward * speed * Time.deltaTime;
        #endregion

        //Input.GetAxis(): �Ű����� Horizontal�� ������
        // x��ǥ�� ���� ���� -1~1 ������ ���� ��ȯ�ϴ� �Լ�
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0, z);

        //������ ����ȭ
        direction.Normalize();

        transform.Translate(new Vector3(x, 0, z) * speed * Time.deltaTime);
    }
}
