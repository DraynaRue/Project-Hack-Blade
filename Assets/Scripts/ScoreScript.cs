using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	static public int score;
	static public float timer;
	public Text scoreT;
	public Text timerT;
	protected float lastTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreT.text = "Score: " + score;
		if (Time.time - lastTime >= 1.0f && timerT != null) {
			timer -= 1;
			timerT.text = "Time: " + timer;
			lastTime = Time.time;
		}
	}
}
