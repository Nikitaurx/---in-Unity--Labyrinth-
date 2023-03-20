using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountWin : MonoBehaviour
{
    public GameObject Player;
    public int _countWin = 0;
    public int _countWinOnStart = 0;
    void Start()
    {
        LoadResult();
        Debug.Log($"Количество прохождений: {_countWin}");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _countWin++;
            SaveResult();
        }
    }
    void SaveResult()
    {
        PlayerPrefs.SetInt("Count win", _countWin);
        PlayerPrefs.Save();
    }
    void LoadResult()
    {
        if (PlayerPrefs.HasKey("Count win"))
        {
            _countWin = PlayerPrefs.GetInt("Count win");
        }
        else Debug.LogError("There is no save data!");
    }
    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        _countWin = 0;
    }
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
}
