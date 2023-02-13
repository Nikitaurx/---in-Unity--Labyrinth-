using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDoor : MonoBehaviour
{
    [SerializeField] float _rotate = 1;
    void Update()
    {
        transform.Rotate(0, _rotate, 0);
    }
}
