using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    public float timerSpeedBonus;
    public float timerSpeedDebuff;
    [SerializeField] private float timerSpeedMax;
    private Vector2 velocity;


    public GameObject _Player;
    public GameObject _SpeedBonus;
    public GameObject _SpeedDebuff;
    private Reference _reference;


    private void Awake()
    {
        _Player = GameObject.FindGameObjectWithTag("Player");
        _SpeedBonus = GameObject.FindGameObjectWithTag("Speed_Bonus");
        _SpeedDebuff = GameObject.FindGameObjectWithTag("Speed_Debuff");

        _reference = new Reference();
    }

    void Start()
    {
        // _checkBonus += CheckSpeedBonus;
        // _checkBonus += CheckSpeedDebuff;
        _event1 += ChangeColorBonus;
        _event2 += ChangeColorDebuff;
        //_reference.FinishScreen.gameObject.SetActive(true);
        //var endScreen = Resources.Load<GameObject>("UI/FinishScreen");
    }

    void Update()
    {
        if (timerSpeedBonus > 0)
        {
            timerSpeedBonus = CheckSpeed(_event1, speedBonus, timerSpeedBonus);
        }
        else if (timerSpeedDebuff > 0)
        {
            timerSpeedDebuff = CheckSpeed(_event2, speedDebuff, timerSpeedDebuff);
        }
        else
        {
            _Player.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            currentSpeed = basementSpeed;
        }

        velocity.x = Input.GetAxis("Horizontal") * currentSpeed * Time.deltaTime;
        velocity.y = Input.GetAxis("Vertical") * currentSpeed * Time.deltaTime;

        transform.Translate(velocity.x, 0f, velocity.y);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Speed_Bonus")
        {
            timerSpeedBonus = TimerBonus(other.gameObject, timerSpeedBonus);
            //Destroy(other.gameObject);
            Debug.Log("Вы получили ускорение");
        }
        if (other.gameObject.tag == "Speed_Debuff")
        {
            timerSpeedDebuff = TimerBonus(other.gameObject, timerSpeedDebuff);
            //Destroy(other.gameObject);
            Debug.Log("Вы получили замедление");
        }
        if (other.gameObject.tag == "Finish")
        {
            print("You succesfully finished the maze. Congratulations!");
            _reference.FinishScreen.gameObject.SetActive(true);

        }
        if (other.gameObject.tag == "Bullet")
        {
            _reference.LoseScreen.gameObject.SetActive(true);
        }
    }
    public float TimerBonus(GameObject _bonusObj, float _timer)//GameObject _bonusObj, float _timer)
    {
        _timer = timerSpeedMax;
        Destroy(_bonusObj.gameObject);
        return _timer;
    }

    void ChangeColorBonus(EventArgs obj)
    {
        _Player.GetComponent<Renderer>().material.color = new Color(50, 50, 0);
    }
    void ChangeColorDebuff(EventArgs obj)
    {
        _Player.GetComponent<Renderer>().material.color = new Color(0, 0, 50);
    }

    public float CheckSpeed(Action<EventArgs> action, float speed, float timerSpeed)
    {
        action?.Invoke(new EventArgs());
        Debug.Log("Время изменения скорости");
        currentSpeed = speed;
        timerSpeed--;
        return timerSpeed;
    }

}
