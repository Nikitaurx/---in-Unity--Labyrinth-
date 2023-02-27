using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference
{

    private MovingBall _movingBall;
    private Camera _mainCamera;
    private Canvas _canvas;
    private GameObject _endGame;

    public Canvas Canvas
    {
        get
        {
            if (_canvas == null)
            {
                _canvas = Object.FindObjectOfType<Canvas>();
            }
            return _canvas;
        }
    }
    public GameObject FinishScreen
    {
        get
        {
            if (_endGame == null)
            {
                var gameObject = Resources.Load<GameObject>("UI/FinishScreen");
                _endGame = Object.Instantiate(gameObject, Canvas.transform);
            }
            return _endGame;
        }
    }
    public GameObject LoseScreen
    {
        get
        {
            if (_endGame == null)
            {
                var gameObject = Resources.Load<GameObject>("UI/LoseScreen");
                _endGame = Object.Instantiate(gameObject, Canvas.transform);
            }
            return _endGame;
        }
    }
}
