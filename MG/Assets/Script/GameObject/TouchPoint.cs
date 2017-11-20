using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPoint : MonoBehaviour {

	private Vector3 touchPointPos;

	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag.Equals ("Player")) {
			Destroy (this.gameObject); 
		}
	}
	private void OnEnable(){
		Debug.Log ("TouchPoint");
		Random.InitState ((int)Time.realtimeSinceStartup);
		Vector3 playerPos = GameObject.FindGameObjectWithTag ("Player").transform.position;
		float check;
		do {
			float randomXPos = Random.Range (5.5f, -5.5f);
			float randomYPos = Random.Range (10.0f, -10.0f);
			touchPointPos = new Vector3 (randomXPos, randomYPos, 0.0f);
			check = Vector3.Distance (playerPos, touchPointPos);
		} while(check > 5);
		this.transform.position=touchPointPos;
	}
}
