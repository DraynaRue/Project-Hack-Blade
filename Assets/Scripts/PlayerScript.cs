using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
	public Rigidbody2D rb;
	public Animator ani;
	protected bool facingRight;
    protected float mousePos;
    static public bool jumping;
    static public float playerHealth;

    //PC ONLY VARIABLES
    public float jumpForce;
    float horizontal = 0.0f;

    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
		ani = GetComponent<Animator>();
        jumping = false;
        playerHealth = 100;
        ScoreScript.score = 0;
        ScoreScript.timer = 255;
	}

	private void FixedUpdate ()
    {
        if(playerHealth <= 0 || ScoreScript.timer <= 0)
        {
            ani.SetBool("isDead", true);
        }

        //PC ONLY
        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                ani.SetBool("isWalking", true);
                horizontal = Time.deltaTime * -6.0f;
                Vector3 theScale = rb.transform.localScale;
                theScale.x = -1.5f;
                rb.transform.localScale = theScale;
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                ani.SetBool("isWalking", true);
                horizontal = Time.deltaTime * 6.0f;
                Vector3 theScale = rb.transform.localScale;
                theScale.x = 1.5f;
                rb.transform.localScale = theScale;
            }
            else if (Input.GetAxis("Horizontal") == 0)
            {
                ani.SetBool("isWalking", false);
                horizontal = 0.0f;
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                if(PlayerScript.jumping == false)
                {
                    PlayerScript.jumping = true;
                    rb.velocity = new Vector2(0, jumpForce);
                    Debug.Log("Jumping:" + PlayerScript.jumping);
                }
            }
            if (Input.GetAxis("Attack") > 0)
            {
                ani.SetTrigger("Attack");
            }
            rb.transform.Translate(horizontal, 0, 0);
        }
    }

    public void ReturnToSplash ()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collider tag: " + collision.collider.tag);
        Debug.Log("OtherCollider tag: " + collision.otherCollider.tag);
        if (collision.collider.tag == "Ground" && jumping == true)
        {
            jumping = false;
            Debug.Log("Jumping:" + jumping);
        }
    }
}
