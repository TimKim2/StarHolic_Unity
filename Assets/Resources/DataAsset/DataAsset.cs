using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu]
public class DataAsset : ScriptableObject {

    private const string loadPath = "DataAsset";

    [SerializeField]
    public int gold = 0;
    [SerializeField]
    public int highScore = 0;

    private static DataAsset m_data;

    public static DataAsset Instance
    {
        get
        {
            Debug.Log("loadPath");
            if (!m_data)
                m_data = Resources.Load<DataAsset>(loadPath);

            if (!m_data)
                Debug.Log("NULL");
            return m_data;
        }
        set { m_data = value; }

    }
}
