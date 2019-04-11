using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
	public Rigidbody2D rb;
	public Animator ani;
	protected bool facingRight;
    protected float mousePos;
    static public bool jumping;
    static public float playerHealth;

    void Start() {
		rb = GetComponent<Rigidbody2D>();
		ani = GetComponent<Animator>();
        jumping = false;
        playerHealth = 100;
        ScoreScript.score = 0;
        ScoreScript.timer = 255;
	}

	private void FixedUpdate () {
        if(playerHealth <= 0 || ScoreScript.timer <= 0) {
            ani.SetBool("isDead", true);
        }
    }

    public void ReturnToSplash () {
        SceneManager.LoadScene("GameOverScene");
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Collider tag: " + collision.collider.tag);
        Debug.Log("OtherCollider tag: " + collision.otherCollider.tag);
        if (collision.collider.tag == "Ground" && jumping == true) {
            jumping = false;
            Debug.Log("Jumping:" + jumping);
        }
    }
}
