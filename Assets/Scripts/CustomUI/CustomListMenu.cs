using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomListMenu
{
    [MenuItem("Geekbrains/Утилита создания объектов ")]
    private static void MenuOption()
    {
        EditorWindow.GetWindow(typeof(MyMenu), false, "Geekbrains");
    }

}

