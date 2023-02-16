using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0.6f, 0);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<MovingBall>().SpeedBonus();
            Destroy(gameObject);
            Debug.Log("Вы получили ускорение");
        }
    }
}
