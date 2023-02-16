using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlate : MonoBehaviour
{
    GameObject _player;
    GameObject _finalGate;

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            print("You have activated the stove. She set something in motion");
            Destroy(_finalGate);
        }
    }
    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _finalGate = GameObject.FindGameObjectWithTag("Gate");
    }
}
