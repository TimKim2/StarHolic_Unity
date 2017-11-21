using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExterminateZone : MonoBehaviour {

	public Animator anim;
	public float lifeTime;
	public bool isDestroy;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		isDestroy = false;
	}
	void OnTriggerEnter2D(Collider2D other)
	//rigidBody가 무언가와 충돌할때 호출되는 함수 입니다.
	//Collider2D other로 부딪힌 객체를 받아옵니다.
	{
		if (other.gameObject.tag.Equals("Enemy"))
			//부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
		{
			Destroy (other.gameObject);
			Debug.Log ("a");
			isDestroy = true;
			/*
			Destroy(this.gameObject);
			//자신을 파괴합니다. */
		}
	}

	// Update is called once per frame
	void Update () {
		if (isDestroy) {
			anim.Play ("explosion012anim");
			Destroy(gameObject.transform.parent.gameObject, 0.5f);
		}
	}


}
