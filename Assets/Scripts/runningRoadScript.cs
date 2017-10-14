using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runningRoadScript : MonoBehaviour {

	public Transform targetSpawner;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!gameManager.gamePause){
			if(!gameManager.loseGame){
				if(transform.position.y <= -100){
					transform.position = new Vector3(targetSpawner.position.x,targetSpawner.position.y+145,targetSpawner.position.z);
				}	
				else {
					float moveY = transform.position.y;
					moveY -= 0.5f;
					transform.position = new Vector3(transform.position.x,moveY,transform.position.z);
				}
			}
		}
	}
}
