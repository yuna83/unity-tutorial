using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameter : MonoBehaviour
{
    private int attack = 10;

    void Start()
    {
        #region 인수
        //함수가 호출될 떄 매개변수를 실제로 전달하는 값

        Debug.Log("attack의 값:" + attack);
        Damage(attack);
        Debug.Log("attack의 값:" + attack);

        #endregion
    }

    #region 매개변수
    //함수의 정의에서 전달받은 인수를 함수 내부로 전달 위한 변수
    void Damage(int damage)
    {
        damage = 100;
    }
    #endregion
}
