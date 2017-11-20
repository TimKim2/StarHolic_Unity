using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    float score;

    private static ScoreManager m_ScoreManager;
    public static ScoreManager Instance
    {
        get
        {
            if (!m_ScoreManager)
            {
                m_ScoreManager = FindObjectOfType(typeof(ScoreManager)) as ScoreManager;
            }
            return m_ScoreManager;
        }
    }

  
	// Use this for initialization
	void Start () {
        score = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(score);
        score += Time.deltaTime;
        scoreText.text = ((int)score).ToString();
	}

    public void SetHighScore()
    {
        Debug.Log (score);
        Debug.Log(DataAsset.Instance.highScore);

        if (DataAsset.Instance.highScore < score)
        {
            DataAsset.Instance.highScore = (int)score;
            SaveLoadManager.Instance.SaveHighScore();
        }
    }
}
