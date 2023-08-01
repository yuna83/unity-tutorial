using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region 클래스

 // 사용자 정의 데이터 유형으로 속성과 함수 포함
 // 클래스를 통해 객체 생성하여 접근, 사용할 수 있는 집합체

public class Item
{
    // 생성자란 클래스의 인스턴스가 생성되는 시점에서
    // 호출되는 특수한 멤버 함수
    public Item()
    {
        Debug.Log("Item이 생성되었습니다");
    }
}
#endregion

public class Monster : MonoBehaviour
{
    Item item = new Item();

    public GameObject prefab;


 
    public void Create()
    {

        int x = Random. Range(0, 10);
        int y = Random. Range(0, 5);
        int z = Random. Range(-5, 0);
        Instantiate(prefab, new Vector3(x,y,z), Quaternion.Euler(0, 180, 0));
        
    }
}
