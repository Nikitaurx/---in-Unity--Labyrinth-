using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovingBall : MonoBehaviour//, ICheckSpeed;
{
    // public delegate void CheckBonusDelegate();
    // private CheckBonusDelegate _checkBonus;

    private event Action<EventArgs> _event1;
    private event Action<EventArgs> _event2;


    [SerializeField] private float basementSpeed = 5f;
    private float currentSpeed;
    public float speedBonus;
    public float speedDebuff;
    private Vector2 velocity;
    float timerSpeedBonus;
    float timerSpeedDebuff;
    [SerializeField] float timerSpeedMax;


    public GameObject _Player;
    public GameObject _SpeedBonus;
    public GameObject _SpeedDebuff;

    void Start()
    {
        // _checkBonus += CheckSpeedBonus;
        // _checkBonus += CheckSpeedDebuff;
        _event1 += ChangeColorBonus;
        _event2 += ChangeColorDebuff;
    }

    void Update()
    {
        //_checkBonus?.Invoke();
        // CheckSpeedBonus();
        // CheckSpeedDebuff();
        if (timerSpeedBonus > 0)
        {
            _event1?.Invoke(new EventArgs());
            Debug.Log("Вы получили ускорение");
            currentSpeed = speedBonus;
            timerSpeedBonus--;
        }
        else if (timerSpeedDebuff > 0)
        {
            _event2?.Invoke(new EventArgs());
            Debug.Log("Вы получили замедление");
            currentSpeed = speedDebuff;
            timerSpeedDebuff--;
        }
        else
        {
            currentSpeed = basementSpeed;
            _Player.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        }

        velocity.x = Input.GetAxis("Horizontal") * currentSpeed * Time.deltaTime;
        velocity.y = Input.GetAxis("Vertical") * currentSpeed * Time.deltaTime;

        transform.Translate(velocity.x, 0f, velocity.y);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Speed_Bonus")
        {
            timerSpeedBonus = TimerBonus(_SpeedBonus, timerSpeedBonus);
            Debug.Log("Вы получили ускорение");
        }

        if (other.gameObject.tag == "Speed_Debuff")
        {
            timerSpeedDebuff = TimerBonus(_SpeedDebuff, timerSpeedDebuff);
            Debug.Log("Вы получили замедление");
        }
    }
    public float TimerBonus(GameObject _bonusObj, float _timer)
    {
        _timer = timerSpeedMax;
        Destroy(_bonusObj.gameObject);
        return _timer;
    }
    void ChangeColorBonus(EventArgs obj)
    {
        _Player.GetComponent<Renderer>().material.color = new Color(0, 100, 100);
    }
    void ChangeColorDebuff(EventArgs obj)
    {
        _Player.GetComponent<Renderer>().material.color = new Color(0, 0, 100);
    }
    void CheckSpeedBonus()
    {
        if (timerSpeedBonus > 0)
        {
            _event1?.Invoke(new EventArgs());
            Debug.Log("Вы ускоренны");
            currentSpeed = speedBonus;
            timerSpeedBonus--;
        }
        else
        {
            currentSpeed = basementSpeed;
            _Player.GetComponent<Renderer>().material.color = new Color(10, 10, 10);
        }
    }
    void CheckSpeedDebuff()
    {
        if (timerSpeedDebuff > 0)
        {
            _event2?.Invoke(new EventArgs());
            Debug.Log("Вы замедленны");
            currentSpeed = speedDebuff;
            timerSpeedDebuff--;
        }
        else
        {
            currentSpeed = basementSpeed;
            _Player.GetComponent<Renderer>().material.color = new Color(10, 10, 10);
        }
    }
    void Awake()
    {
        _Player = GameObject.FindGameObjectWithTag("Player");
        _SpeedBonus = GameObject.FindGameObjectWithTag("Speed_Bonus");
        _SpeedDebuff = GameObject.FindGameObjectWithTag("Speed_Debuff");
    }

}
