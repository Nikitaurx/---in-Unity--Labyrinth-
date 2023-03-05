using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Number3 : MonoBehaviour
{
    void Start()
    {
        System.Random rnd = new System.Random();

        List<int> list = new List<int>();
        while (list.Count() < 10)
        {
            list.Add(rnd.Next(0, 5));
        }
        foreach (int element in list)
        {
            Debug.Log($" {element}");
        }
        // a)
        Debug.Log("Задание 3 a)");
        for (int i = 0; i < list.Count(); i++)
        {
            int count = 1;//счетчик одинаковых элементов
            for (int j = 0; j < list.Count(); j++)
            {
                if (list[i].Equals(list[j]))
                {
                    if (j == i) continue;
                    count++;
                    list.RemoveAt(j);
                    j = 0;
                }
            }
            Debug.Log($" {list[i]} : в количестве {count} экземпляра(ов)");
        }

        // b)
        Debug.Log("Задание 3 b)");
        List<int> listLinq = new List<int>(); //создаем новый список для linq
        while (listLinq.Count() < 10)
        {
            listLinq.Add(rnd.Next(0, 5));
        }
        foreach (int element in listLinq)
        {
            Debug.Log($" {element}");
        }

        var countLinq = from element in listLinq group element by element;
        foreach (var element in countLinq)
            Debug.Log($" {element.Key} : в количестве {element.Count()} экземпляра(ов)");

        // c)
        Debug.Log("Задание 3 c)");
        var countLinq1 = listLinq.GroupBy(i => i);
        foreach (var element in countLinq)
            Debug.Log($" {element.Key} : в количестве {element.Count()} экземпляра(ов)");
    }
}
