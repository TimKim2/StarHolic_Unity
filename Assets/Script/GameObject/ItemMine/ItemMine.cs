using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMine : MonoBehaviour {

	public Vector3 target;
	//public Animation anim;
	public bool death = false;
	public float lifetime= 7.0f;
	// Use this for initialization
	void Start () {
		//anim = gameObject.GetComponent<Animation> ();
	}
		/*
	void OnCollider2D(Collider2D other)
	//rigidBody가 무언가와 충돌할때 호출되는 함수 입니다.
	//Collider2D other로 부딪힌 객체를 받아옵니다.
	{
		if (other.gameObject.tag.Equals("Enemy"))
			//부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
		{
			//anim.Play ("explosion012anim");
			Debug.Log ("CollideWithEnemy");
			Destroy (other.gameObject);
			Destroy (this.gameObject);
			//ExterminateZone activate.
		}
		//벽과 충돌시 벡터수정 해도 ok
	}*/


	private void OnEnable(){
		Vector3 NormalizedVector = Vector3.Normalize(TouchPanel.Instance.deltaMousePos);
		target = GameObject.FindGameObjectWithTag ("Player").transform.position;
			this.transform.position = target - NormalizedVector ;
		//this.transform.position = target + Vector3.Down
	}
}
