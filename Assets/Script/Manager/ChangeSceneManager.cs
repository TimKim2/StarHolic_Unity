using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneManager : MonoBehaviour {

    private static ChangeSceneManager m_ChangeSceneManager;

    public static ChangeSceneManager instance
    {
        get
        {
            if (!m_ChangeSceneManager)
            {
                m_ChangeSceneManager = GameObject.FindObjectOfType<ChangeSceneManager>();
            }
            return m_ChangeSceneManager;
        }
    }

    public void ChangeToGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void ChangeToPlayScene()
    {
        SceneManager.LoadScene("PlayScene");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
