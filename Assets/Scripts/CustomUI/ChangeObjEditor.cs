using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ChangeObj))]
public class ChangeObjEditor : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        //DrawDefaultInspector();
        ChangeObj testTarget = (ChangeObj)target;

        testTarget.color = EditorGUILayout.ColorField(testTarget.color);
        //testTarget.profColor = GUILayout.Toggle(testTarget.profColor, "Режим Pro");
        testTarget.profColor = EditorGUILayout.BeginToggleGroup("Режим Pro", testTarget.profColor);
        testTarget.r = EditorGUILayout.IntSlider(testTarget.r, 0, 100);
        testTarget.g = EditorGUILayout.IntSlider(testTarget.g, 0, 100);
        testTarget.b = EditorGUILayout.IntSlider(testTarget.b, 0, 100);
        testTarget.a = EditorGUILayout.IntSlider(testTarget.a, 0, 100);
        testTarget._radiusObj = EditorGUILayout.Slider(testTarget._radiusObj, 1, 10);
    }
}
