using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] public Vector3 targetPosition;

    public float moveTimeSpeed;

    private Vector3 startPos;

    float t = 0;

    void Start()
    {
        startPos = transform.position;

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
}