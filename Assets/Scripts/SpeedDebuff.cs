using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpeedDebuff : MovingBall
{
    void Update()
    {
        try
        {
            //if (_speedDebuff != null)
            _SpeedDebuff.transform.Rotate(0, 0.6f, 0);
            // Бонус подобран и уничтожен, но Rotate пытается повернуть его
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }

    }

}
