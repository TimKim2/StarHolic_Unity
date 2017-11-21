using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour {

	public float moveSpeed = 3.0f;
	public Vector3 target;
	public float lifetime = 20.0f;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		//Destroy (gameObject, lifetime);
		target = GameObject.FindGameObjectWithTag ("Player").transform.position;
		Vector3 vector = Vector3.Normalize(target - this.transform.position);
		//Vector3 vector = Vector3.Normalize(target - this.transform.position);
		//Normalize를 지우면 꿀 잼 
		this.rb.MovePosition(transform.position + vector * Time.fixedDeltaTime * moveSpeed);
	}
	private void OnEnable(){
		Debug.Log ("Spawn?");
		Random.InitState ((int)Time.realtimeSinceStartup);
		float randomXPos = Random.Range(5.5f, -5.5f);
		float randomYPos = Random.Range(10.0f, -10.0f);
		//target = GameObject.FindGameObjectWithTag ("Player").transform.position;
		this.transform.position=new Vector3(randomXPos, randomYPos, 0.0f);
		
	}
}
