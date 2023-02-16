using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTeleport : ActiveTeleport
{
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        navMesh.Warp(_point.position);
        print("You are at the finish line!");
    }
}
