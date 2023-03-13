using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObj : MonoBehaviour
{

    public GameObject obj;
    public float _radiusObj = 0;
    public Color color;
    public int r = 0;
    public int g = 0;
    public int b = 0;
    public int a = 0;
    public bool profColor = false;

    private void Start()
    {
        //color = Color.grey;

        Debug.Log(obj);
    }
    private void Update()
    {
        ChangeColor();
        ChangeRadius();
    }

    public void ChangeColor()
    {
        if (profColor)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(r, g, b, a);
        }
        else gameObject.GetComponent<Renderer>().material.color = color;

    }
    public void ChangeRadius()
    {
        obj.transform.localScale = new Vector3(_radiusObj, _radiusObj, _radiusObj);
    }
}
