using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour {

	public Vector3 target;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		target = GameObject.FindGameObjectWithTag ("Player").transform.position;
		transform.position = target + Vector3.back;
	}
}
