using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float horizontal;
    public float vertical;
    public Rigidbody2D rb;


    private void Update()
    {
        CheckInputs();
    }

    void CheckInputs()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        rb.gravityScale = 0;
        Vector2 playerInput = new Vector2(horizontal, vertical).normalized * speed;
        rb.velocity = playerInput;
    }
}
