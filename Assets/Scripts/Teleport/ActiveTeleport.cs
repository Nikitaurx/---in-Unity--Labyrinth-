using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ActiveTeleport : MonoBehaviour
{
    GameObject Player;
    //[SerializeField] public Transform _player;
    public Transform _point;
    //public bool _teleport;

    public Rigidbody rb;
    public NavMeshAgent navMesh;
    void Start()
    {
        rb = Player.GetComponent<Rigidbody>();
        navMesh = Player.GetComponent<NavMeshAgent>();
        Player.gameObject.GetComponent<NavMeshAgent>().enabled = true;

    }
    // void OnTriggerEnter(Collider other)
    // {
    //     navMesh.Warp(_point.position);
    //     print("You've fallen into a trap. Get out alive");
    // }
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
}
