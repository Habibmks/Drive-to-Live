using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItfaiyeSkill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Platform")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Regen")
        {
            Destroy(gameObject);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
