using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour{


	public GameObject Zombie;
	private float time= 0.0f;
	public  float spawnZombieTime = 3.0f;
	// Use this for initialization
	void Start () {
		//zombie = GameObject.FindGameObjectWithTag ("Enemy"); throw
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > spawnZombieTime) {
			CreateZombie ();
			time = 0.0f;
		}
	}
	public void CreateZombie()
	{
		GameObject zombie = Instantiate (Resources.Load ("Prefabs/Zombie")) as GameObject;
		if (zombie)
			Debug.Log ("Create");
	}
}
