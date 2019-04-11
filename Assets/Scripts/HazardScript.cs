using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardScript : MonoBehaviour {
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "Player") {
			PlayerScript.playerHealth -= PlayerScript.playerHealth;
			rb.velocity = new Vector2(0, 20);
		}
		if (collider.tag == "Enemy") {
			Destroy(collider.gameObject, 1.0f);
		}
	}
}
