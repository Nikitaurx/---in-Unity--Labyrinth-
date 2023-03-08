using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeRadarObj : MonoBehaviour
{
    [SerializeField] private GameObject _ico;
    private void OnValidate()
    {
        _ico = Resources.Load<GameObject>("MiniMap/RadarObject");
    }
    private void OnDisable()
    {
        Radar.RemoveRadarObject(gameObject);
    }
    private void OnEnable()
    {
        Radar.RegisterRadarObject(gameObject, _ico);
    }
}
