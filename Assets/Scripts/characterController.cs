using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

	public swipe swipeControls;
	public Transform character;

	public static bool isJump =false;
	public gameManager gM;
	private Vector3 desiredPosition;

	public float spriteBlinkingTimer = 0.0f;
 	public float spriteBlinkingMiniDuration = 0.1f;
 	public float spriteBlinkingTotalTimer = 0.0f;
 	public float spriteBlinkingTotalDuration = 1.0f;
 	public bool startBlinking = false;
	void Start(){
		
	}

	void Update(){
		float moveLR = character.transform.position.x;
		if(!gameManager.loseGame){
			if(!gameManager.gamePause){
				if(swipeControls.SwipeLeft){
					if(character.transform.position.x >-10){
						moveLR -= 10;
						//do animation left
					}
				}
				if(swipeControls.SwipeRight){
					if(character.transform.position.x <10){
						moveLR += 10;
						//do animation right
					}
				}
				if(swipeControls.SwipeUp){
					//do animation jump
					Debug.Log("jump");
				}
				if(swipeControls.SwipeDown){
					//do animation slide
					Debug.Log("slide");
				}
				if(swipeControls.Tap){
					if(gameManager.twistTime){
						Debug.Log("tap");
					}
				}
			}
		}
		character.transform.position = new Vector3(moveLR,character.transform.position.y,character.transform.position.z);

		if(Input.GetKeyDown(KeyCode.X)){
			startBlinking = true;
			
		}

		 if(startBlinking == true)
        { 
            SpriteBlinkingEffect();
        }
	}

	private void SpriteBlinkingEffect(){
        spriteBlinkingTotalTimer += Time.deltaTime;
        if(spriteBlinkingTotalTimer >= spriteBlinkingTotalDuration){
             startBlinking = false;
             spriteBlinkingTotalTimer = 0.0f;
        	 this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
             return;
        }
     
     	spriteBlinkingTimer += Time.deltaTime;
     	if(spriteBlinkingTimer >= spriteBlinkingMiniDuration){
        	 spriteBlinkingTimer = 0.0f;
         	if (this.gameObject.GetComponent<SpriteRenderer> ().enabled == true) {
            	this.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
         	} 
			else {
             	this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
         	}
     	}
	}
	
	//void OnTriggerEnter2D(Collider2D col){}
}
