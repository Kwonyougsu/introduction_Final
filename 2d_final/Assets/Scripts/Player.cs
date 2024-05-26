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

    // istrigger üũ�� �Ǿ������� ������ �浹 x => ������ ���� �͸� �ν���
    // collision => ������ �浹�� �߻��ߴ�.
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
