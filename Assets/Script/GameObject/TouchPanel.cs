using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchPanel : MonoBehaviour, IPointerUpHandler, IPointerDownHandler{

	bool currentState = false;

	public PlayerMove player;

	Vector3 beforeMousePos;
	Vector3 currentMousePos;

	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMove>();
	}

	public void OnPointerDown(PointerEventData eventData){

		currentState = true;
		beforeMousePos = Input.mousePosition;
		Debug.Log ("Down");
	}

	public void OnPointerUp(PointerEventData eventData){

		currentState = false;
		beforeMousePos = currentMousePos;
		Debug.Log ("Up");
	}

	void FixedUpdate (){
		
		if (currentState) {

			currentMousePos = Input.mousePosition;

			if (beforeMousePos != currentMousePos) {
				Vector3 deltaMousePos = currentMousePos - beforeMousePos;
				/*여기서 워프 잡으려면 IScrollHandler parent make.
				 OnScroll(PointerEventData eventData){
				 	currentState = true; 로 교체 
				 }
				namespace UnityEngine.EventSystems
				{
					public interface IScrollHandler : IEventSystemHandler
					{
						//
						// Methods
						//
						void OnScroll (PointerEventData eventData);
					}
				}
				*/
				//Normalize로 단위벡터로 만듬
				//deltaMousePos;
				player.Move (deltaMousePos);

				beforeMousePos = currentMousePos;
			}
		}
	}
}