using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

	// Use this for initialization
	public static bool gamePause;
	public Text score;
	public Text Highscore;
	public float scoreCount;
	public float HighscoreCount;
	public float scoreperSecond;
	public bool scoreIncreasing;
	void Start () {
		if(PlayerPrefs.HasKey("Highscore")){
			HighscoreCount = PlayerPrefs.GetFloat("Highscore");
		}
	}
	
	// Update is called once per frame
	void Update () {
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
	}

	public void test(){
		Debug.Log("aaaa");
	}
}
