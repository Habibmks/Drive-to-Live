using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCarController : MonoBehaviour
{
    public static float speed = 7.0f;
    public static float jumpSpeed = 450;
    public static float maxSpeed;
    public static float RotationSpeed = 0.5f;
    public float atisHizi;
    public float skillAtisHizi;



    public float lastShot;
    public float lastSkilShot;
    public static float cooldown = 1.0f;
    public static float skillCooldown = 15.0f;

    bool canJump;
    bool canTumble = true;
    public bool player1;
    public bool player2;

    Animator animator;
    Rigidbody2D rb;
    public GameObject bullet;
    public Transform AtesNoktasi;
    public GameObject skillShott;
    public Transform SkillShotPoint;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        if (player1)
        {
            atisHizi = 1000;
            skillAtisHizi = 1800;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                Shoot();

            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                SkillShot();
            }
            else
            {

            }
            Move();
            Tumble();
        }
        if (player2)
        {
            atisHizi = -1000;
            skillAtisHizi = -1800;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Jump();
            }
            if (Input.GetKeyDown(KeyCode.PageDown))
            {
                Shoot();

            }
            else
            {

            }
            secondMove();
            secondTumble();
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Platform")
        {
            canJump = true;
        }

    }
    public void Jump()
    {
        if (canJump == true)
        {
            rb.AddForce(Vector2.up * jumpSpeed);
            canJump = false;
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

    public void Tumble()
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
    public void secondTumble()
    {
        float moveInput = Input.GetAxis("Vertical");
        if (canTumble)
        {
            if (moveInput != 0)
            {
                rb.AddTorque(RotationSpeed * moveInput * (-1));
            }
        }
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
    public void SkillShot()
    {
        if (Time.time - lastShot < cooldown)
        {
            return;
        }
        lastSkilShot = Time.time;
        GameObject skillShot = Instantiate(skillShott, SkillShotPoint.position, Quaternion.identity);
        skillShot.GetComponent<Rigidbody2D>().velocity = new Vector2(skillAtisHizi * Time.deltaTime, 0);
    }
}
