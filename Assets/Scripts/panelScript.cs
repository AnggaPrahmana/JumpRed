using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelScript : MonoBehaviour {

	public RectTransform panelMenu;
	// Use this for initialization
	bool isShow;
	float speed;
	void Start () {
		isShow = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(isShow){
			panelMenu.position = new Vector3(panelMenu.position.x,300,panelMenu.position.x);
			gameManager.gamePause = true;
		}
		else if(!isShow){
			panelMenu.position = new Vector3(panelMenu.position.x,-300,panelMenu.position.z);
			gameManager.gamePause = false;
		}
	}

	public void ShowPanelMenu(){
		isShow = !isShow;
	}

}
