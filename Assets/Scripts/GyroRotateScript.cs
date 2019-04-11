using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroRotateScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
        ScoreScript.score += (int)ScoreScript.timer;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 rot = transform.localRotation.eulerAngles;
        Vector3 gyroAttitude = Input.gyro.attitude.eulerAngles;
        rot.z = gyroAttitude.z + 90.0f;
        Debug.Log(gyroAttitude.x + "\t" + gyroAttitude.y + "\t" + gyroAttitude.z);
        transform.localRotation = Quaternion.Euler(-rot);
	}
}
