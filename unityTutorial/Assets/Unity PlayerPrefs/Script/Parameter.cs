using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameter : MonoBehaviour
{
    private int attack = 10;

    void Start()
    {
        #region �μ�
        //�Լ��� ȣ��� �� �Ű������� ������ �����ϴ� ��

        Debug.Log("attack�� ��:" + attack);
        Damage(attack);
        Debug.Log("attack�� ��:" + attack);

        #endregion
    }

    #region �Ű�����
    //�Լ��� ���ǿ��� ���޹��� �μ��� �Լ� ���η� ���� ���� ����
    void Damage(int damage)
    {
        damage = 100;
    }
    #endregion
}
