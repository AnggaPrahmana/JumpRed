﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe : MonoBehaviour {

	// Use this for initialization
	private bool tap,swipeLeft,swipeRight,swipeUp,swipeDown;
	private bool isDraging = false;
	private Vector2 startTouch, swipeDelta;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		tap = swipeLeft = swipeRight = swipeUp = swipeDown = false;

		pcInput();		

		mobileInput();

		swipeDelta = Vector2.zero;
		if(isDraging){
			if(Input.touches.Length > 0){
				swipeDelta = Input.touches[0].position - startTouch;
			}
			else if(Input.GetMouseButton(0)){
				swipeDelta = (Vector2)Input.mousePosition - startTouch;
			}
		}

		if (swipeDelta.magnitude > 125){
			float x = swipeDelta.x;
			float y = swipeDelta.y;

			if(Mathf.Abs(x) > Mathf.Abs(y)){
				if(x<0){
					swipeLeft = true;
				}
				else{
					swipeRight = true;
				}
			}
			else{
				if(y<0){
					swipeDown = true;
				}
				else{
					swipeUp = true;
				}
			}
			Reset();
		}
	}

	void pcInput(){
		if(Input.GetMouseButtonDown(0)){
			tap = true;
			isDraging = true;
			startTouch = Input.mousePosition;
		}
		else if(Input.GetMouseButtonDown(0)){
			Reset();
		}
	}

	void mobileInput(){
		if(Input.touches.Length >0){
			if(Input.touches[0].phase == TouchPhase.Began){
				isDraging = true;
				tap = true;
				startTouch = Input.touches[0].position;
			}
			else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled){
				isDraging =true;
				Reset();
			}
		}
	}
	private void Reset(){
		startTouch = swipeDelta = Vector2.zero;
		isDraging = false;
	}
	public bool Tap {get {return tap;}}
	public Vector2 SwipeDelta{get {return swipeDelta;}}
	public bool SwipeLeft{get {return swipeLeft;}}
	public bool SwipeRight{get {return swipeRight;}}
	public bool SwipeUp{get {return swipeUp;}}
	public bool SwipeDown{get{return swipeDown;}}
}
