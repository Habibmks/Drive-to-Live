using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirController : MonoBehaviour
{
    public static float speed = 3.0f;
    public static float maxSpeed;
    public float atisHizi;



    public float lastShot;
    public static float cooldown = 10.0f;

    bool canJump;
    bool canFast;
    bool canTumble;
    public bool player1;
    public bool player2;

    Animator animator;
    Rigidbody2D rb;
    public GameObject bullet;
    public Transform AtesNoktasi;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        if (player1)
        {
            atisHizi = 3500;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                FastMove();
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                Shoot();

            }
            else
            {

            }
            Move();
        }
        if (player2)
        {
            atisHizi = -3500;
            if (Input.GetKey(KeyCode.RightShift))
            {
                FastMove();
            }
            if (Input.GetKeyDown(KeyCode.PageDown))
            {
                Shoot();

            }
            else
            {

            }
            secondMove();
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Platform")
        {
            canFast = true;
        }
        if (collision.transform.tag != "Platform")
        {
        }
    }

    public void FastMove()
    {
        if (canFast)
        {
            float moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed * 4, rb.velocity.y);
        }
    }

    public void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    public void secondMove()
    {
        float moveInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }


    public void Shoot()
    {
        if (Time.time - lastShot < cooldown)
        {
            return;
        }
        lastShot = Time.time;
        GameObject mermi = Instantiate(bullet, AtesNoktasi.position, Quaternion.identity);
        mermi.GetComponent<Rigidbody2D>().velocity = new Vector2(atisHizi * Time.deltaTime, 0);
    }


}

