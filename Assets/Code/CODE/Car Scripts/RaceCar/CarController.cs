using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public static float speed = 5.5f;
    public static float jumpSpeed = 450;
    public static float RotationSpeed = 0.4f;
    public float atisHizi ;
    public float skillHizi;



    public float lastShot;
    public float lastSkillShot;
    public static float skillCooldown = 15.0f;
    public static float shootCooldown = 1.0f;

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
            atisHizi = 3500;
            skillHizi = 4500;
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
            atisHizi = -3500;
            skillHizi = -5000;
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
        if (Time.time - lastShot < shootCooldown)
        {
            return;
        }
        lastShot = Time.time;
        GameObject mermi = Instantiate(bullet, AtesNoktasi.position, Quaternion.identity);
        mermi.GetComponent<Rigidbody2D>().velocity = new Vector2(atisHizi * Time.deltaTime, -AtesNoktasi.position.y);
    }

    public void SkillShot()
    {
        if (Time.time - lastSkillShot < skillCooldown)
        {
            return;
        }
        lastSkillShot = Time.time;
        GameObject skill = Instantiate(NormalCarSkill, skillNoktasi.position, Quaternion.identity);
        skill.GetComponent<Rigidbody2D>().velocity = new Vector2(skillHizi * Time.deltaTime, 0);
    }




}
