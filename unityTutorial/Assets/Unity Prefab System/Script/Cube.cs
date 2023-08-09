using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed = 5.0f;
  

    // Update is called once per frame
    void Update()
    {
        transform.Rotate
            (
                speed * Time.deltaTime, 
                speed * Time.deltaTime, 
                speed * Time.deltaTime
            );
    }
}
