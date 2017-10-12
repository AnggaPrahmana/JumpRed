using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

	public swipe swipeControls;
	public Transform character;
	private Vector3 desiredPosition;


	private void Update(){
		if(swipeControls.SwipeLeft)
			//desiredPosition += Vector3.left;
			character.transform.position = new Vector3(-10,character.transform.position.y,character.transform.position.z);
		if(swipeControls.SwipeRight)
			//desiredPosition += Vector3.right;
			character.transform.position = new Vector3(10,character.transform.position.y,character.transform.position.z);
		if(swipeControls.SwipeUp)
			desiredPosition += Vector3.up;
		if(swipeControls.SwipeDown)
			desiredPosition += Vector3.down;

		//character.transform.position = Vector3.MoveTowards(character.transform.position,desiredPosition,100f * Time.deltaTime);

		if(swipeControls.Tap){
			Debug.Log("aaaa");
		}
	}
}
