using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ChangeObj))]
public class ChangeObjEditor : UnityEditor.Editor
{
    // public GameObject obj;
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        ChangeObj testTarget = (ChangeObj)target;

        EditorGUILayout.LabelField("Радиус объекта");
        testTarget._radiusObj = EditorGUILayout.Slider(testTarget._radiusObj, 1, 10);
        EditorGUILayout.LabelField("Цвет объекта");
        testTarget.color = EditorGUILayout.ColorField(testTarget.color);

        //testTarget.profColor = GUILayout.Toggle(testTarget.profColor, "Режим Pro");
        testTarget.profColor = EditorGUILayout.BeginToggleGroup("Режим Pro", testTarget.profColor);
        EditorGUILayout.LabelField("Параметр r");
        testTarget.r = EditorGUILayout.IntSlider(testTarget.r, 0, 100);
        EditorGUILayout.LabelField("Параметр g");
        testTarget.g = EditorGUILayout.IntSlider(testTarget.g, 0, 100);
        EditorGUILayout.LabelField("Параметр b");
        testTarget.b = EditorGUILayout.IntSlider(testTarget.b, 0, 100);
        EditorGUILayout.LabelField("Параметр a");
        testTarget.a = EditorGUILayout.IntSlider(testTarget.a, 0, 100);
        EditorGUILayout.EndToggleGroup();

    }
}
