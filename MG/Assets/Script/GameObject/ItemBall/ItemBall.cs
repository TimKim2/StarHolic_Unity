using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBall : MonoBehaviour {

	public Rigidbody2D rb;
	public Vector3 player;
	public bool death = false;
	public float lifetime= 7.0f;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		//anim = gameObject.GetComponent<Animation> ();
	}
	void Update(){
		//Destroy(gameObject, lifetime);
	}
	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag.Equals("Enemy")){
			Destroy(other.gameObject);
			Debug.Log ("ball");
		}
	}
	private void OnEnable(){
		Vector3 NormalizedVector = Vector3.Normalize(TouchPanel.Instance.deltaMousePos);
		player = GameObject.FindGameObjectWithTag ("Player").transform.position;
		this.rb.transform.position = player + 3 * NormalizedVector ;
	}
}
