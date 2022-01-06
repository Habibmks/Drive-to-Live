using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public static float speed = 8.0f;
    public static float jumpSpeed = 600;
    public static float RotationSpeed = 0.4f;
    public float atisHizi ;
    public float skillHizi;



    public float lastShot;
    public float lastSkillShot;
    public static float skillCooldown = 15.0f;
    public static float shootCooldown = 0.7f;

     bool canJump;
     bool canTumble = true;
    public bool player1;
    public bool player2;

    Animator animator;
    Rigidbody2D rb;
    public GameObject bullet;
    public Transform AtesNoktasi;
    public GameObject NormalCarSkill;
    public Transform skillNoktasi;


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
            skillHizi = 4700;
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
            skillHizi = -4700;
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
        else if (Time.time - lastShot < shootCooldown)
        {
            return;
        }
        lastShot = Time.time;
        GameObject mermi = Instantiate(bullet, AtesNoktasi.position, AtesNoktasi.rotation);
        mermi.GetComponent<Rigidbody2D>().AddForce(AtesNoktasi.right * 20, ForceMode2D.Impulse);
    }

    public void SkillShot()
    {
        if (lastSkillShot == 0)
        {
            lastSkillShot = Time.time;
        }
        else if (Time.time - lastSkillShot < skillCooldown)
        {
            return;
        }
        lastSkillShot = Time.time;
        GameObject skillShot = Instantiate(NormalCarSkill, skillNoktasi.position, skillNoktasi.rotation);
        skillShot.GetComponent<Rigidbody2D>().AddForce(skillNoktasi.right * 25, ForceMode2D.Impulse);
    }




}
