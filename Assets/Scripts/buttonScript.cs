using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {

	// Use this for initialization
	public float speed = 0.5f;
	int flag ;
	public int type;
	public GameObject Character;
	void Start () {
		gameManager.sudah = false;
		flag=1;
	}

	
	// Update is called once per frame
	void Update () {
		
		escalateButton();
	}

	void OnMouseDown(){
		if(flag==1){
			PressToScore();

			PressToMoveCharacter();
		}
		gameManager.sudah = true;
	}

	void PressToScore(){
		if(transform.position.y<-21.5){
			Debug.Log("Miss");
			flag = 0;
		}
		if(transform.position.y>-21.5 && transform.position.y <= -20.5){
			Debug.Log("Too Early Boyaa");
			flag = 0;
		}
		if(transform.position.y>-20.5 && transform.position.y <= -19.5){
			Debug.Log("Perfect");
			flag = 0;
		}
		if(transform.position.y>-19.5 && transform.position.y <= -18.5){
			Debug.Log("Too Late Boyaa");
			flag = 0;
		}
		if(transform.position.y>-18.5){
			Debug.Log("Miss");
			flag = 0;
		}
	}

	void PressToMoveCharacter(){
		if(type==0){
			if(Character.transform.position.x>= -10){
				float move = Character.transform.position.x;
				move -= 10;
				Character.transform.position = new Vector3(move,Character.transform.position.y,Character.transform.position.z);
			}
		}
		if(type==1){
			//do Jump;
		}
		if(type==2){
			if(Character.transform.position.x<= 10){
				float move = Character.transform.position.x;
				move += 10;
				Character.transform.position = new Vector3(move,Character.transform.position.y,Character.transform.position.z);
			}
		}
	}

	void escalateButton(){
		if(transform.position.y>= -15 ){
			if(gameManager.sudah==false){
				Debug.Log("Miss");
			}
			transform.position = new Vector3(transform.position.x,-50,transform.position.z);
			flag = 1;
			gameManager.sudah = false;
		}
		else{
			float moveY = transform.position.y;
			moveY += speed;
			transform.position = new Vector3(transform.position.x, moveY , transform.position.z);
		}
	}
}
