using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonData<T> : IData<T>
{
    public void Save(T data, string path = null)
    {
        var str = JsonUtility.ToJson(data);
        //File.WriteAllText(path, Crypto.CryptoXOR(str));
        File.WriteAllText(path, str);
    }

    public T Load(string path = null)
    {
        var str = File.ReadAllText(path);
        //File.WriteAllText(path, Crypto.CryptoXOR(str));
        return JsonUtility.FromJson<T>(str);
    }
}
