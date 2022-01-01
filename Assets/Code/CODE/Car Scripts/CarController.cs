using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public SkillsCooldown sc;
    public int speed;
    public int jumpSpeed;
    public int maxSpeed;
    public float RotationSpeed;
    public float atisHizi;

    bool canJump;
    bool canFast;
    bool canTumble;

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
        if (Input.GetKeyDown(KeyCode.X))
        {
            Shoot();

        }
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

        }
        Move();
        Tumble();
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
            canTumble = true;
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
            rb.velocity = new Vector2(moveInput * speed *4, rb.velocity.y);
        }
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    void Tumble()
    {
        float moveInput = Input.GetAxis("Horizontal");
        if (canTumble)
        {
            if (moveInput != 0)
            {
                rb.AddTorque(RotationSpeed * moveInput * (-1));
            }
        }
    }

    private void Shoot()
    {

            GameObject mermi = Instantiate(bullet, AtesNoktasi.position, Quaternion.identity);
            mermi.GetComponent<Rigidbody2D>().velocity = new Vector2(atisHizi * Time.deltaTime, 0);
        
       
    }
  
        

    


}
