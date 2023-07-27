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
        //변수는 프로그램이 실행되는 동안 값을 바꿀 수 있으며
        //원래 저장되어 있는 값은 새로 저장되는 값에 의해 지워진다

        character = 'B';
        integer = 5000;
        pi = 6.65f;
        wname = "ava";

        Debug.Log("character 변수의 값:"+ character);
        Debug.Log("int 변수의 값:" + integer);
        Debug.Log("pi 변수의 값:" + pi);
        Debug.Log("name 변수의 값:" + wname);
    }

     #endregion
}