using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour {
	public string sceneName;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			SceneManager.LoadScene(sceneName);
			if (LevelSelectScript.levelsCompleted == 0){
				LevelSelectScript.levelsCompleted = 1;
			}
			if (LevelSelectScript.levelsCompleted == 1){
				LevelSelectScript.levelsCompleted = 2;
			}
		}
	}
}
