using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed;
    public int jumpSpeed;
    public int maxSpeed;
    bool canJump;
    bool canFast;
    Animator animator;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            FastMove();
        }
        else
        {
            Move();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Platform")
        {
            canJump = true;
            canFast = true;
        }
        if (collision.transform.tag != "Platform")
        {

        }
    }
    private void Jump()
    {
        if (canJump == true)
        {
            rb.AddForce(Vector2.up * jumpSpeed);
            canJump = false;
        }
    }
    private void FastMove()
    {
        if (canFast)
        {
            float moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed * 4, rb.velocity.y);
        }
    }

    private void Move()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}

