using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed = 1.0f;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void OnBecameInvisible(){
		Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position); //캐릭터의 월드 좌표를 뷰포트 좌표계로 변환해준다.
		viewPos.x = Mathf.Clamp(viewPos.x,-5.13f,5.13f); //x값을 0이상, 1이하로 제한한다.
		viewPos.y = Mathf.Clamp(viewPos.y,-9.5f,9.5f); //y값을 0이상, 1이하로 제한한다.
		Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos); //다시 월드 좌표로 변환한다.
		transform.position = worldPos; //좌표를 적용한다.

	}
	public void Move(Vector3 vector){
		//Debug.Log (vector);
		//Debug.Log (Time.fixedDeltaTime);
		//Debug.Log (moveSpeed);
		this.rb.MovePosition (transform.position + Time.fixedDeltaTime * moveSpeed * vector); 
	}
}
