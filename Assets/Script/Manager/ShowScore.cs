using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

    public Text highScoreText;

	// Use this for initialization
	void Start () {
        highScoreText.text = "HighScore :" + SaveLoadManager.Instance.LoadHighScore().ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
