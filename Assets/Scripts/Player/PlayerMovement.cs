using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; 
    Rigidbody2D rb;
    public float jumpSpeed = 4f;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

   


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }


    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(horizontalInput*speed, rb.velocity.y);

        //Flip player
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
       else if (horizontalInput < - 0.01f)
            transform.localScale = new Vector3(-1,1,1);

      

        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }


  
}
