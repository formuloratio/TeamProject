using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float jumpForce = 5f;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 newVelocity = new Vector2(
            horizontalInput * moveSpeed,
            rb.velocity.y
        );

        rb.velocity = newVelocity;
    }
}
