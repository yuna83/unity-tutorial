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
        #region 이동공식
        //transform.position:자신의 위치
        //transform.position += Vector3.forward * speed * Time.deltaTime;
        #endregion

        //Input.GetAxis(): 매개변수 Horizontal을 넣으면
        // x좌표에 대한 정보 -1~1 사이의 값을 반환하는 함수
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0, z);

        //벡터의 정규화
        direction.Normalize();

        transform.Translate(new Vector3(x, 0, z) * speed * Time.deltaTime);
    }
}
