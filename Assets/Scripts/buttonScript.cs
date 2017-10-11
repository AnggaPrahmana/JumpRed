using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {

	// Use this for initialization
	public float speed = 0.5f;
	public int type,flag;
	public GameObject Character;

	public buttonScript[] otherButton;
	void Start () {
		flag =0;
	}

	
	// Update is called once per frame
	void Update () {
		if(!gameManager.gamePause){
			escalateButton();
		}
	}

	void OnMouseDown(){
		if(flag==0){
			PressToScore();

			PressToMoveCharacter();
			for(int i=0;i<otherButton.Length;i++){
				otherButton[i].flag = 1;
			}
		}
	}

	void PressToScore(){
		if(transform.position.y<-21.5){
			Debug.Log("Miss");
		}
		if(transform.position.y>-21.5 && transform.position.y <= -20.5){
			Debug.Log("Too Early Boyaa");
		}
		if(transform.position.y>-20.5 && transform.position.y <= -19.5){
			Debug.Log("Perfect");
		}
		if(transform.position.y>-19.5 && transform.position.y <= -18.5){
			Debug.Log("Too Late Boyaa");
		}
		if(transform.position.y>-18.5){
			Debug.Log("Miss");
		}
		flag=1;
	}

	void PressToMoveCharacter(){
		if(type==0){
			if(Character.transform.position.x >= -9){
				float move = Character.transform.position.x;
				move -= 10;
				Character.transform.position = new Vector3(move,Character.transform.position.y,Character.transform.position.z);
			}
		}
		if(type==1){
			//do Jump;
		}
		if(type==2){
			if(Character.transform.position.x <= 9){
				float move = Character.transform.position.x;
				move += 10;
				Character.transform.position = new Vector3(move,Character.transform.position.y,Character.transform.position.z);
			}
		}
	}

	void escalateButton(){
		if(transform.position.y>= -14 ){
			if(flag==0){
				Debug.Log("Miss");
				if(transform.position.y>-15){
					transform.position = new Vector3(transform.position.x,-50,transform.position.z);
				}
			}
			else{
				transform.position = new Vector3(transform.position.x,-50,transform.position.z);
			}
		}
		else{
			float moveY = transform.position.y;
			moveY += speed;
			transform.position = new Vector3(transform.position.x, moveY , transform.position.z);
			if(transform.position.y>-40&&transform.position.y<-35){
				for(int i=0;i<otherButton.Length;i++){
					otherButton[i].flag = 0;
				}
			}
		}
	}
}
