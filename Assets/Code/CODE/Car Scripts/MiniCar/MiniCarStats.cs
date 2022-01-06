using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniCarStats : MonoBehaviour
{
    public static int MaxHealth = 370;
    public int CurrentHealth;

    public bool player1;
    public bool player2;

    public HealthBar healthBarr;
    public HealthBar healthBarr2;

    void Start()
    {
        if (player1)
        {
            CurrentHealth = MaxHealth;
            healthBarr.setMaxHealth(MaxHealth);
        }
        else if (player2)
        {
            CurrentHealth = MaxHealth;
            healthBarr2.setMaxHealth(MaxHealth);
        }

    }
    void Update()
    {
        if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(3);
        }

    }
    void TakeDamage(int damage)
    {
        if (player1)
        {
            CurrentHealth -= damage;
            healthBarr.SetHealth(CurrentHealth);
        }
        else if (player2)
        {
            CurrentHealth -= damage;
            healthBarr2.SetHealth(CurrentHealth);
        }

    }

    public void Regen()
    {
        if (player1)
        {
            CurrentHealth += 40;
            healthBarr.SetHealth(CurrentHealth);
        }
        else if (player2)
        {
            CurrentHealth += 40;
            healthBarr2.SetHealth(CurrentHealth);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage(10);
        }
        if (collision.gameObject.tag == "MiniCarSkill")
        {
            TakeDamage(120);
        }
        if (collision.gameObject.tag == "Regen")
        {
            Regen();
        }
        if (collision.gameObject.tag == "RaceCarSkill")
        {
            TakeDamage(100);
        }
        if (collision.gameObject.tag == "JeapSkill")
        {
            TakeDamage(90);
        }
        if (collision.gameObject.tag == "ItfaiyeSkill")
        {
            TakeDamage(80);
        }
    }
}
