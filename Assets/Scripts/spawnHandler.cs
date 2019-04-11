using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnHandler : MonoBehaviour {
	public GameObject go;
	protected float lastSpawnTime;
	Vector3 spawnPos;
	Quaternion rot;

	// Use this for initialization
	void Start () {
		spawnPos = transform.position;
		rot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - lastSpawnTime >= 5.0f) {
			Instantiate(go, spawnPos, rot);
			lastSpawnTime = Time.time;
		}
	}
}
