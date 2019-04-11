using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolumeSliderScript : MonoBehaviour {
	public Slider slider;
	// Use this for initialization

	// To reenable the VolumeSlider enable the Slider objects in both MenuScene and Level1Scene
	void Start () {
		slider = GetComponent<Slider>();
		slider.value = MusicScript.globalVolume;
	}
	
	// Update is called once per frame
	void Update () {
		MusicScript.globalVolume = slider.value;
	}
}
