using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Ŭ����

 // ����� ���� ������ �������� �Ӽ��� �Լ� ����
 // Ŭ������ ���� ��ü �����Ͽ� ����, ����� �� �ִ� ����ü

public class Item
{
    // �����ڶ� Ŭ������ �ν��Ͻ��� �����Ǵ� ��������
    // ȣ��Ǵ� Ư���� ��� �Լ�
    public Item()
    {
        Debug.Log("Item�� �����Ǿ����ϴ�");
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
