using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
    protected float lastTime;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // To reenable transitions enable TransitCanvas, uncomment the StartCoroutine calls below and comment out the LoadScene calls except those inside the Coroutine itself
    public void LoadLevel1 () {
        //StartCoroutine(LoadScene("Level1Scene"));
        SceneManager.LoadScene("Level1Scene");
    }

    public void LoadLevel2 () {
        //StartCoroutine(LoadScene("Level2Scene"));
        SceneManager.LoadScene("Level2Scene");
    }
    
    public void LoadGameComplete () {
        //StartCoroutine(LoadScene("GameCompleteScene"));
        SceneManager.LoadScene("GameCompleteScene");
    }
    public void MainMenu() {
        //StartCoroutine(LoadScene("MenuScene"));
        SceneManager.LoadScene("MenuScene");
    }

    public void LevelSelect () {
        //StartCoroutine(LoadScene("LevelSelectScene"));
        SceneManager.LoadScene("LevelSelectScene");
    }

    IEnumerator LoadScene(string sceneName) {
        AsyncOperation asyncload = SceneManager.LoadSceneAsync(sceneName);
        while (!asyncload.isDone) {
            if (Time.time - lastTime >= 0.1f && TransitionScript.transition.fillAmount < 1.0f) {
                TransitionScript.transition.fillAmount += 0.1f;
                lastTime = Time.time;
            }
            yield return null;
        }
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Level1Scene"));
    }

    public void PauseGame () {
        Time.timeScale = 0;
    }

    public void UnpauseGame () {
        Time.timeScale = 1;
    }

    public void CloseGame () {
        Application.Quit();
    }
}
