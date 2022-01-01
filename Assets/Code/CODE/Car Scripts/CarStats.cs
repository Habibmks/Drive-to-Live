using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarStats : MonoBehaviour
{
    public int MaxHealth = 100;
    public int CurrentHealth;
    public HealthBar healthBarr;
    void Start()
    {
        CurrentHealth = MaxHealth;
        healthBarr.setMaxHealth(MaxHealth);
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
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TakeDamage(1);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (CurrentHealth < MaxHealth)
            {
                Regen();
            }
        }
       
        
    }
    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        healthBarr.SetHealth(CurrentHealth);
    }

    public void Regen()
    {
        CurrentHealth += 15;
        healthBarr.SetHealth(CurrentHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage(10);
        }
        if (collision.gameObject.tag == "Regen")
        {
            Regen();
        }
    }
}
