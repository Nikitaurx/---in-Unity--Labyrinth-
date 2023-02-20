using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpeedBonus : MovingBall
{
    void Update()
    {
        try
        {
            //if (_speedBonus != null)
            _SpeedBonus.transform.Rotate(0, 0.6f, 0);
            // Бонус подобран и уничтожен, но Rotate пытается повернуть его
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }

}
