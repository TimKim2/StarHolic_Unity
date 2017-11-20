using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed = 50.0f;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Move(Vector3 vector){
		Debug.Log (vector);
		Debug.Log (Time.fixedDeltaTime);
		Debug.Log (moveSpeed);
		this.rb.MovePosition (transform.position + Time.fixedDeltaTime * moveSpeed * vector); 

	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            ScoreManager.Instance.SetHighScore();
            ChangeSceneManager.instance.ChangeToGameOverScene();

        }
        
    }
}
