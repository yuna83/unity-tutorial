using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    
    int Add(int x, int y)
    {
        //�Ű�����: �Լ��� ���Ǿּ� ���޹��� �μ���
        //�Լ� ���η� �����ϱ� ���� ����ϴ� ����
        return x + y;
    }

    int Substract(int x, int y)
    {
        return x - y;
    }

    int Multiple(int x, int y)
    {
        return x * y;
    }

    int Divide(int x, int y)
    {
        return x / y;
    }

    void Start()
    {
        Debug.Log(Add(10, 20));
    }

    
}
