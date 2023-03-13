using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MyMenu : EditorWindow
{
    public static GameObject ObjectInstantiate;
    public string _nameObject = "New Custom Object";
    public bool _groupEnabled;
    public bool _randomColor = true;
    public int _countObject = 1;
    public float _radius = 10;
    public float _radiusObj = 1;
    private void OnGUI()
    {
        GUILayout.Label("Создание объекта", EditorStyles.boldLabel);

        ObjectInstantiate = EditorGUILayout.ObjectField("Вставьте объект",
            ObjectInstantiate, typeof(GameObject), true) as GameObject;

        _nameObject = EditorGUILayout.TextField("Имя объекта", _nameObject);
        GUILayout.Space(10);
        _groupEnabled = EditorGUILayout.BeginToggleGroup("Дополнительные настройки", _groupEnabled);
        GUILayout.Space(10);
        _randomColor = EditorGUILayout.Toggle("Случайный цвет", _randomColor);
        _countObject = EditorGUILayout.IntSlider("Количество объектов", _countObject, 1, 100);
        _radius = EditorGUILayout.Slider("Радиус окружности", _radius, 10, 50);
        _radiusObj = EditorGUILayout.Slider("Размер объекта", _radiusObj, 1, 10);
        EditorGUILayout.EndToggleGroup();

        GUILayout.Space(10);
        var button = GUILayout.Button("Создать объекты");
        if (button)
        {
            if (ObjectInstantiate)
            {
                GameObject root = new GameObject("Root");
                for (int i = 0; i < _countObject; i++)
                {
                    float angle = i * Mathf.PI * 2 / _countObject;
                    Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * _radius;
                    GameObject temp = Instantiate(ObjectInstantiate, pos, Quaternion.identity);
                    temp.name = _nameObject + "(" + i + ")";
                    temp.transform.parent = root.transform;
                    temp.transform.localScale = new Vector3(_radiusObj, _radiusObj, _radiusObj);

                    var tempRenderer = temp.GetComponent<Renderer>();
                    if (tempRenderer && _randomColor)
                    {
                        tempRenderer.material.color = Random.ColorHSV();
                    }
                }
            }
        }
    }
}
