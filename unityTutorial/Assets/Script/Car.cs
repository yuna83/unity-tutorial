using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Car : MonoBehaviour
{
    #region

    char character = 'A';

    int integer = 100;

    float pi = 3.14f;

    string wname = "sonata";

   

    private void Start()
    {
        //������ ���α׷��� ����Ǵ� ���� ���� �ٲ� �� ������
        //���� ����Ǿ� �ִ� ���� ���� ����Ǵ� ���� ���� ��������

        character = 'B';
        integer = 5000;
        pi = 6.65f;
        wname = "ava";

        Debug.Log("character ������ ��:"+ character);
        Debug.Log("int ������ ��:" + integer);
        Debug.Log("pi ������ ��:" + pi);
        Debug.Log("name ������ ��:" + wname);
    }

     #endregion
}