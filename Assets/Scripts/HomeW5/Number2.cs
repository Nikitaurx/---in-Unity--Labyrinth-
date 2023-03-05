using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Number2 : MonoBehaviour
{
    string str1 = ("Hello, my little friends");
    void Start()
    {
        Debug.Log("Количество символов в строке" + ' ' + str1.Length);

        Debug.Log("Количество символов в строке без пробела" + ' ' + Extension.MyLength(str1));
    }

}

public static class Extension
{
    public static int MyLength(this string str)
    {
        int totalCharWithoutSpace = 0;
        string[] userString = str.Split(' ');
        foreach (string stringValue in userString)
        {
            totalCharWithoutSpace += stringValue.Length;
        }
        return totalCharWithoutSpace;
    }
}
