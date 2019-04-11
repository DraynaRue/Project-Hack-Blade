using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectScript : MonoBehaviour {
    static public int levelsCompleted;
    public Button level1Btn;
    public Button level2Btn;

	// Use this for initialization
	void Start () {
		if (levelsCompleted == 0){
			levelsCompleted = 0;
        	level1Btn.image.color = new Color32(255,255,255,255);
        	level2Btn.image.color = new Color32(255,255,255,120);
			level2Btn.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (levelsCompleted == 1) {
			level2Btn.image.color = new Color32(255,255,255,255);
            level2Btn.enabled = true;
        }
	}
}
