using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDebuff : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0.6f, 0);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<MovingBall>().SpeedDebuff();
            Destroy(gameObject);
            Debug.Log("Вы получили замедление");
        }
    }
}
