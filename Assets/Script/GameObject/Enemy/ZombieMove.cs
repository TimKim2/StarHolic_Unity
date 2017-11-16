using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour {

	public float moveSpeed = 20.0f;
	public Vector3 target;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		Destroy (gameObject, 20.0f);
		target = GameObject.FindGameObjectWithTag ("Player").transform.position;
		Vector3 vector = target - this.transform.position;
		//Vector3 vector = Vector3.Normalize(target - this.transform.position);
		//Normalize를 지우면 꿀 잼 
		this.rb.MovePosition(transform.position + vector * Time.fixedDeltaTime * moveSpeed);
	}
	private void OnEnable(){
		Debug.Log ("Spawn?");
		target = GameObject.FindGameObjectWithTag ("Player").transform.position;
		float randomPos = Random.Range(15.0f, -15.0f);
		this.transform.position=(target+ new Vector3(randomPos, randomPos, 0.0f) );
		Random.InitState ((int)Time.realtimeSinceStartup);
	}
}
