using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public int money = 0;

    void Awake()
    {
        Load();
    }
    public void Save()
    {
        PlayerPrefs.SetInt("Money",money);
    }

    public void Load()
    {
        money = PlayerPrefs.GetInt("Money");
    }

    public void IncreaseMoney()
    {
        money++;
    }
}
