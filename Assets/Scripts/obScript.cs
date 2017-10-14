using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obScript : MonoBehaviour {
	public Sprite[] arrayObstacle;

	public float speed = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!gameManager.gamePause){
		transform.position = new Vector3 (transform.position.x, transform.position.y - speed, transform.position.z);
			if(transform.position.y <= -100){
				transform.position = new Vector3(transform.position.x,transform.position.y+145,transform.position.z);
			}

}
	}
}
