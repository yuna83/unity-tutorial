using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewObject : MonoBehaviour
{
    int[] array = new int[3];

    #region ���� ó��

    private void Awake()
    {
        try
        {
            for(int i=0;i<5;i++)
            { 
                array[i] = i; 
            }
        }
        catch(Exception error)
        {
            Debug.Log(error);
        }
    }


    #endregion


    #region �ڽ̰� ��ڽ�

    //�ڽ�: �� Ÿ���� ���� Ÿ������ ��ȯ�ϴ� ����
    //��ڽ�: ���� Ÿ���� �� Ÿ������ ��ȯ�ϴ� ����

    void Start()
    {
        int data = 10;
        //���� Ÿ�Կ� �� Ÿ���� ��
        object obj = data;

        //�� Ÿ�Կ� ���� Ÿ���� ��
        int result = (int)obj;
    }

    #endregion
}
