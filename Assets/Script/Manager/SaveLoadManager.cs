using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour {

    private static SaveLoadManager m_Instance;
    public static SaveLoadManager Instance
    {
        get{
            if (!m_Instance){
                m_Instance = FindObjectOfType(typeof(SaveLoadManager)) as SaveLoadManager;
            }

            return m_Instance;
        }
    }

    public void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore",DataAsset.Instance.highScore);
    }
    public int LoadHighScore()
    {
        return PlayerPrefs.GetInt ("HighScore");
    }
}
