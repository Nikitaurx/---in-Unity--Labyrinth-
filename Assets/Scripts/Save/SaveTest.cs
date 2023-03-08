using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveTest : MonoBehaviour
{
    public Vector3Serializable _posBonus;
    public GameObject _SpeedDebuff;
    private JsonData<SavedData> _jsonData = new JsonData<SavedData>();
    private SavedData _savedDataDebuff = new SavedData();
    void Start()
    {
        _posBonus = _SpeedDebuff.transform.position; //создаем сериалайзебл позицию объекта

        _savedDataDebuff.Name = _SpeedDebuff.name; // описываем savedData объект
        _savedDataDebuff.Position = _posBonus;
        if (_SpeedDebuff != null) { _savedDataDebuff.IsEnabled = true; }
        else { _savedDataDebuff.IsEnabled = false; }


        var path = Path.Combine(Application.streamingAssetsPath, "JsonData.xml");
        _jsonData.Save(_savedDataDebuff, path);
        //Debug.Log(save);
    }
    void Awake()
    {
        _SpeedDebuff = GameObject.Find("SpeedDebuff_2");
    }
}
