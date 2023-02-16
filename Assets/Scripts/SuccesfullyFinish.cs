using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccesfullyFinish : MonoBehaviour
{
    GameObject _player;
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            print("You succesfully finished the maze. Congratulations!");
            Destroy(_player);
        }
    }
    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

}
