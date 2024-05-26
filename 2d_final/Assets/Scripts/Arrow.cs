using System;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * 5f;
        //GetComponent<Rigidbody2D>().velocity = Vector2.right * 5f;
    }

    private void Update()
    {
        if (transform.position.x > 8.1f)
        {
            Destroy(gameObject);
        }
    }
}