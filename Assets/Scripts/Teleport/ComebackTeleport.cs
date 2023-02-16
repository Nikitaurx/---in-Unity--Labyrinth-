using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComebackTeleport : ActiveTeleport
{
    void OnTriggerEnter(Collider other)
    {
        navMesh.Warp(_point.position);
        print("You got out of the trap. Keep looking for a way out of the maze");
    }
}
