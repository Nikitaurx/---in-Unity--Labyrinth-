using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeTeleport : ActiveTeleport
{
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        navMesh.Warp(_point.position);
        print("You've fallen into a trap. Get out alive");
    }
}
