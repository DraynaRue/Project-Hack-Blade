 using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;
 
 public class MusicScript : MonoBehaviour {
	 static public float globalVolume = 1;
	 public AudioSource audioSource;

	 void Start() {
		 audioSource = GetComponent<AudioSource>(); 
	 }
     void Awake () {
		if (this.gameObject.tag == "MultiSceneMusic") {
        	GameObject[] objs = GameObject.FindGameObjectsWithTag("MultiSceneMusic");
       	 	if (objs.Length > 1) {
            	Destroy(this.gameObject);
			}
         	DontDestroyOnLoad(this.gameObject);
		}
    }
 
    void Update() {
		audioSource.volume = globalVolume;
		if (this.gameObject.tag == "MultiSceneMusic") {
         	if (SceneManager.GetActiveScene().name == "Level1Scene" || SceneManager.GetActiveScene().name == "VictoryScene" || SceneManager.GetActiveScene().name == "GameoverScene") {
            	Destroy(this.gameObject);
        	}
    	}
	}
 }