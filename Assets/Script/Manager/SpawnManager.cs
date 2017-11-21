using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour{


	public GameObject Zombie;
	private float timeZombie= 0.0f;
	public  float spawnZombieTime = 3.0f;
	private float timeTouchPoint = 0.0f;
	public float spawnTouchPoint = 10.0f;
	private static SpawnManager m_Instance;

	public static SpawnManager Instance
	{
		get{
			if (!m_Instance) {
				m_Instance = FindObjectOfType (typeof(SpawnManager)) as SpawnManager;
			}

			return m_Instance;
		}
	}

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timeZombie += Time.deltaTime;

		if (timeZombie > spawnZombieTime) {
			CreateZombie ();
			CreateMine ();
			timeZombie = 0.0f;
		}
		//if (Time.realtimeSinceStartup % 5 == 0){ CreateMine ();} //귀찮아서 이렇게 
		if (GameObject.FindGameObjectWithTag("TouchPoint") == null) {
			timeTouchPoint += Time.deltaTime;
			if (timeTouchPoint > spawnTouchPoint) {
				timeTouchPoint = 0.0f;
				CreateTouchPoint ();
			}
		}

	}
	public void CreateZombie()
	{
		GameObject zombie = Instantiate (Resources.Load ("Prefabs/Zombie")) as GameObject;
		if (zombie)
			Debug.Log ("CreateZombie");
	}
	public void CreateMine(){
		GameObject mine = Instantiate (Resources.Load ("Prefabs/ItemMine")) as GameObject;
		if (mine)
			Debug.Log ("CreateMine");
	}
	public void CreateTouchPoint(){
		GameObject touchPoint = Instantiate (Resources.Load ("Prefabs/TouchPoint")) as GameObject;
		if (touchPoint)
			Debug.Log ("CreateTouchPoint");
	}

}
