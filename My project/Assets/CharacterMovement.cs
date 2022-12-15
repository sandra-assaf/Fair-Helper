using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpSpeed;
    private bool isJumping = false;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(dirX * speed));
        if (dirX > 0.1)
        {
            animator.SetFloat("XInput", 1);
        } else if (dirX < 0)
        {
            animator.SetFloat("XInput", -1);
        }
        

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            this.gameObject.GetComponent<Collider2D>().isTrigger = true;
            isJumping = true;
        }

        if(rb.velocity.y < 0 && this.gameObject.GetComponent<Collider2D>().isTrigger)
        {
             this.gameObject.GetComponent<Collider2D>().isTrigger = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            isJumping = false;
        }
    }

}
