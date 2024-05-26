using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private int HP;
    Rigidbody2D rb;
    void Start()
    {
        HP = 5;
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        
    }

    public void OnMove(InputValue value)
    {
        Vector2 dir = value.Get<Vector2>();
        rb.velocity = dir * 5;
    }

    // istrigger 체크가 되어있으면 물리적 충돌 x => 범위에 들어온 것만 인식함
    // collision => 물리적 충돌이 발생했다.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Arrow"))
        {
            HP -= 1;
            Destroy(other.gameObject);
            if (HP == 0)
            {
                GameManager.instance.GameOver();
            }
            

        }
    }
}
