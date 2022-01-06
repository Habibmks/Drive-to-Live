using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItfaiyeController : MonoBehaviour
{
    public static float leftSpeed;
    public static float rightSpeed;
    public static float normalSpeed = 5.5f;
    public static float maxLeftSpeed = 10.0f;
    public static float maxRightSpeed = 10.0f;
    public float atisHizi;
    public float skillHizi;



    public float lastShot;
    public float lastSkillShot;
    public float lastFastMove;
    public static float skillCooldown = 15.0f;
    public static float shootCooldown = 0.7f;
    public static float fastMoveCooldown = 10.0f;
    public static float fastMoveCounter;

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
        fastMoveCounter = 2.0f;
        if (player1)
        {
            leftSpeed = normalSpeed;
        }
        if (player2)
        {
            rightSpeed = normalSpeed;
        }
        
        
    }

    private void Update()
    {
        if (player1)
        {
            atisHizi = 4500;
            skillHizi = 4700;
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                lastFastMove = 0.0f;
                if (Time.time - lastFastMove < fastMoveCooldown)
                {
                    return;
                }
                lastFastMove = Time.time;
                leftSpeed = maxLeftSpeed;
                StartCoroutine("SpeedDuration");
                   
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
        }
        if (player2)
        {
            atisHizi = -4500;
            skillHizi = -4700;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {

                rightSpeed = maxRightSpeed;
                StartCoroutine("SpeedDuration");
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
        }


    }

    IEnumerator SpeedDuration()
    {
        yield return new WaitForSeconds(fastMoveCounter);
        if (player1)
        {
            leftSpeed = normalSpeed;
        }
        if (player2)
        {
            rightSpeed = normalSpeed;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Platform")
        {

        }
    }

    public void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * leftSpeed, rb.velocity.y);
    }

    public void secondMove()
    {
        float moveInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveInput * rightSpeed, rb.velocity.y);
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
        GameObject skill = Instantiate(NormalCarSkill, skillNoktasi.position, skillNoktasi.rotation);
        skill.GetComponent<Rigidbody2D>().AddForce(skillNoktasi.right * 25, ForceMode2D.Impulse);
    }
}
