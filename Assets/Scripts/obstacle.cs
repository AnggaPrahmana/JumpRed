using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour {
	public GameObject ob;

	// Use this for initialization
	void Start () {
		StartCoroutine (spawnerob ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	IEnumerator spawnerob(){
		while (true) {
			//spawn asteroid
			GameObject spawnedob = (GameObject) Instantiate(ob);
			//random posisi x dari asteroid
			float randomX = Random.Range (-7.5f, 7.5f);
			spawnedob.transform.position = new Vector3 (randomX, 7, 0);
			//random tipe asteroid
			spawnedob.GetComponent<SpriteRenderer> ().sprite = spawnedob.GetComponent<obScript> ().arrayObstacle [Random.Range (0, 2)];
			spawnedob.GetComponent<obScript> ().speed = Random.Range (0.15f, 0.5f);

			yield return new WaitForSeconds (0f);
		}
	}
}
