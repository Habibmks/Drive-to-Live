using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{
    public float fallSpeed;
    Rigidbody2D rb;
    private Vector2 screenBound;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, fallSpeed);
        screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 
            Camera.main.transform.position.z));

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
    }
}
