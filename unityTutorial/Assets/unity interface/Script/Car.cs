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
    //접근지정자 선언 x시, private 자동 지정

   

    private void Start()
    {
        //변수는 프로그램이 실행되는 동안 값을 바꿀 수 있으며
        //원래 저장되어 있는 값은 새로 저장되는 값에 의해 지워진다

        character = 'B';
        pi = 6.65f;
        wname = "ava";

        Debug.Log("character 변수의 값:"+ character);
        Debug.Log("int 변수의 값:" + integer);
        Debug.Log("pi 변수의 값:" + pi);
        Debug.Log("name 변수의 값:" + wname);
    }

    #endregion

    #region 함수
    //하나의 특정한 목적의 작업 수행 코드의 집합
    private void Stop()
    {
        Debug.Log("정지");
    }
    private void Update()
    {
        //조건문: 조건에 따라 동작 실행 명령문
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Stop();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("핸들 조정");
        }
        else
        {
            Debug.Log("시동 꺼짐");
        }
    }
    #endregion
}