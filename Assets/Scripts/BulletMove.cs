using UnityEngine;

public class BulletMove : MonoBehaviour
{
    GameObject _player;
    [SerializeField] public Vector3 targetPosition;

    public float moveTimeSpeed;

    private Vector3 startPos;

    float t = 0;

    void Start()
    {
        startPos = transform.position;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            print("You fell in the maze, like many others.");
            Destroy(_player);
        }
    }
    void Update()
    {
        t += Time.deltaTime;
        transform.position = Vector3.Lerp(startPos, targetPosition, t / moveTimeSpeed);
        if (t >= 2)
        {
            transform.position = targetPosition;
            t = 0;
        }
    }
    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
}