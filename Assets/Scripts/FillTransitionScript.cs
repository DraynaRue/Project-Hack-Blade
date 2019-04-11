using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillTransitionScript : MonoBehaviour {
    protected float lastTime;
    // Use this for initialization
    void Start () {
        TransitionScript.transition.fillAmount = 1.0f;
        StartCoroutine(UnwindTransition());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator UnwindTransition() {
        while (TransitionScript.transition.fillAmount >= 0.0f) {
            if (Time.time - lastTime >= 0.1f) {
                TransitionScript.transition.fillAmount -= 0.1f;
                lastTime = Time.time;
            }
            yield return null;
        }
        lastTime = 0;
    }
}
