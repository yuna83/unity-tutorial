using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewObject : MonoBehaviour
{
    int[] array = new int[3];

    #region 예외 처리

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


    #region 박싱과 언박싱

    //박싱: 값 타입을 참조 타입으로 변환하는 과정
    //언박싱: 참조 타입을 값 타입으로 변환하는 과정

    void Start()
    {
        int data = 10;
        //참조 타입에 값 타입이 들어감
        object obj = data;

        //값 타입에 참조 타입이 들어감
        int result = (int)obj;
    }

    #endregion
}
