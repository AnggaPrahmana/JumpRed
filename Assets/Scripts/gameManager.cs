using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

	// Use this for initialization
<<<<<<< HEAD
	public static bool gamePause=false;
	public static bool loseGame=false;
	public static bool twistTime=false;
=======
	public static bool gamePause;
	public Text score;
	public Text Highscore;
	public float scoreCount;
	public float HighscoreCount;
	public float scoreperSecond;
	public bool scoreIncreasing;
>>>>>>> cba2a3409dbdfdfb342a2ed6834e3bcfa01b2f57
	void Start () {
		if(PlayerPrefs.HasKey("Highscore")){
			HighscoreCount = PlayerPrefs.GetFloat("Highscore");
		}
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		if(Input.GetKeyDown(KeyCode.Space)){
			loseGame = !loseGame;
			Debug.Log(loseGame);
		}
=======
		if(!gameManager.gamePause){
		
		if(scoreIncreasing){
			scoreCount += scoreperSecond + 2;
		}
		
		if(scoreCount > HighscoreCount){
			HighscoreCount = scoreCount;
			PlayerPrefs.SetFloat("Highscore", HighscoreCount);
		}
		score.text = "" + Mathf.Round (scoreCount);
		Highscore.text = "" + Mathf.Round (HighscoreCount);

	}
>>>>>>> cba2a3409dbdfdfb342a2ed6834e3bcfa01b2f57
	}

	public void test(){
		Debug.Log("aaaa");
	}
}
