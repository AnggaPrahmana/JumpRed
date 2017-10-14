using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	// Use this for initialization
	public static bool gamePause=false;
	public static bool loseGame=false;
	public static bool twistTime=false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			loseGame = !loseGame;
			Debug.Log(loseGame);
		}
	}

	public void test(){
		Debug.Log("aaaa");
	}
}
