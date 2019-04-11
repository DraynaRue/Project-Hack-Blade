using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
    public Animator ani;
    public Rigidbody2D rb;
    public float jumpForce;
    protected bool movingRight;
    protected bool movingLeft;
    protected float mousePos;
    float horizontal = 0.0f;

    // Use this for initialization
    void Start () {
        movingLeft = false;
        movingRight = false;
    }

    private void FixedUpdate () {
        if (movingLeft == true && movingRight == false) {
            horizontal = Time.deltaTime * -6.0f;
            Vector3 theScale = rb.transform.localScale;
            theScale.x = -1.5f;
            rb.transform.localScale = theScale;
        }
        if (movingRight == true && movingLeft == false) {
            horizontal = Time.deltaTime * 6.0f;
            Vector3 theScale = rb.transform.localScale;
            theScale.x = 1.5f;
            rb.transform.localScale = theScale;
        }
        rb.transform.Translate(horizontal, 0, 0);
    }

    public void StopMoving () {
        ani.SetBool("isWalking", false);
        movingRight = false;
        movingLeft = false;
        horizontal = 0.0f;
    }

    public void PlayerAttack () {
        ani.SetTrigger("Attack");
    }

    public void PlayerJump () {
        if(PlayerScript.jumping == false) {
            PlayerScript.jumping = true;
            rb.velocity = new Vector2(0, jumpForce);
            Debug.Log("Jumping:" + PlayerScript.jumping);
        }
    }

    public void PlayerMoveLeft() {
        ani.SetBool("isWalking", true);
        movingRight = false;
        movingLeft = true;
    }

    public void PlayerMoveRight () {
        ani.SetBool("isWalking", true);
        movingRight = true;
        movingLeft = false;
    }
}
