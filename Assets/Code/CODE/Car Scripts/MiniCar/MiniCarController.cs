using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCarController : MonoBehaviour
{
    public static float speed = 11.0f;
    public static float jumpSpeed = 650;
    public static float maxSpeed;
    public static float RotationSpeed = 0.4f;
    public float atisHizi;
    public float skillAtisHizi;
    public float hiz = 20f;



    public float lastShot;
    public float lastSkilShot;
    public static float cooldown = 0.7f;
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
            atisHizi = 4500;
            skillAtisHizi = 4700;
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
            atisHizi = -4500;
            skillAtisHizi = -4700;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Jump();
            }
            if (Input.GetKeyDown(KeyCode.Delete))
            {
                Shoot();
            }
            if (Input.GetKeyDown(KeyCode.PageDown))
            {
                SkillShot();
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
        if (lastShot == 0)
        {
            lastShot = Time.time;
        }
        else if (Time.time - lastShot < cooldown)
        {
            return;
        }
        lastShot = Time.time;
        GameObject mermi = Instantiate(bullet, AtesNoktasi.position, AtesNoktasi.rotation);
        mermi.GetComponent<Rigidbody2D>().AddForce(AtesNoktasi.right * 20, ForceMode2D.Impulse);
    }
    public void SkillShot()
    {
        if (lastSkilShot ==0)
        {
            lastSkilShot = Time.time;
        }
        else if (Time.time - lastSkilShot < skillCooldown)
        {
            return;
        }
        lastSkilShot = Time.time;
        GameObject skillShot = Instantiate(skillShott, SkillShotPoint.position, SkillShotPoint.rotation);
        skillShot.GetComponent<Rigidbody2D>().AddForce(SkillShotPoint.right * 25, ForceMode2D.Impulse);
        
    }
}
