using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBall : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    private float speed;
    public float speedBonus;
    public float speedDebuff;
    private Vector2 velocity;
    float timerSpeedBonus;
    float timerSpeedDebuff;
    [SerializeField] float timerSpeedMax;
    void Update()
    {
        if (timerSpeedBonus > 0)
        {
            Debug.Log("Вы получили ускорение");
            speed = speedBonus;
            timerSpeedBonus--;
        }
        else if (timerSpeedDebuff > 0)
        {
            speed = speedDebuff;
            timerSpeedDebuff--;
        }
        else { speed = movementSpeed; }

        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(velocity.x, 0f, velocity.y);
    }
    public void SpeedBonus()
    {
        timerSpeedBonus = timerSpeedMax;
    }
    public void SpeedDebuff()
    {
        timerSpeedDebuff = timerSpeedMax;
    }

}
