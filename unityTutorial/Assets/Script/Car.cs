using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Car : MonoBehaviour
{
    #region

    char character = 'A';

    public int integer = 100;

    private float pi = 3.14f;

    string wname = "sonata";
    //���������� ���� x��, private �ڵ� ����

   

    private void Start()
    {
        //������ ���α׷��� ����Ǵ� ���� ���� �ٲ� �� ������
        //���� ����Ǿ� �ִ� ���� ���� ����Ǵ� ���� ���� ��������

        character = 'B';
        pi = 6.65f;
        wname = "ava";

        Debug.Log("character ������ ��:"+ character);
        Debug.Log("int ������ ��:" + integer);
        Debug.Log("pi ������ ��:" + pi);
        Debug.Log("name ������ ��:" + wname);
    }

    #endregion

    #region �Լ�
    //�ϳ��� Ư���� ������ �۾� ���� �ڵ��� ����
    private void Stop()
    {
        Debug.Log("����");
    }
    private void Update()
    {
        //���ǹ�: ���ǿ� ���� ���� ���� ��ɹ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Stop();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("�ڵ� ����");
        }
        else
        {
            Debug.Log("�õ� ����");
        }
    }
    #endregion
}