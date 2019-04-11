using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    // Use this for initialization
    protected float lastDamageTime;
    protected float horizontal;
    public float moveSpeed;
    protected Vector3 theScale;
    public Rigidbody2D rb;
    public int scoreVal;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        theScale = rb.transform.localScale;
        horizontal = Time.deltaTime * -moveSpeed;
    }
   
    void FixedUpdate() {
            rb.transform.Translate(horizontal, 0, 0);
    }
    
    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Ground") {
            horizontal *= -1;
            theScale.x *= -1;
            rb.transform.localScale = theScale;
        }
        if (collider.tag == "Sword") {
            Destroy(gameObject);
            ScoreScript.score += scoreVal;
        }
    }

    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.collider.tag == "Player" && Time.time - lastDamageTime >= 0.5) {
            PlayerScript.playerHealth -= 5;
            lastDamageTime = Time.time;
        }
    }
}
