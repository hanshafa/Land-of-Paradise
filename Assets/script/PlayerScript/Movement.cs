using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float input;
    public float speed;
    
    //MoveDialogBool
    public bool canMove = true;

    [SerializeField]public Animator animator;
    
    public SpriteRenderer spriteRenderer;
    public float jumpForce;

    public LayerMask groundLayer;
    private bool isGrounded;
    public Transform feetposition;
    public float groundedCheckCircle;


    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerRb.freezeRotation = true;
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (!canMove) return;

        MovementPlayer();
       
    }
    
    private void MovementPlayer()
    {
        animator.SetFloat("Speed", Mathf.Abs(input));

        input = Input.GetAxisRaw("Horizontal");
        if (input < 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (input > 0)
        {
            spriteRenderer.flipX = true;
        }
        isGrounded = Physics2D.OverlapCircle(feetposition.position, groundedCheckCircle, groundLayer);
        if (isGrounded == true && Input.GetButton("Jump"))
        {
            playerRb.velocity = Vector2.up * jumpForce;
            animator.SetBool("isJump", true);
        }
        if (isGrounded == true && !Input.GetButton("Jump"))
        {
            animator.SetBool("isJump", false);
        }

    }

    private void FixedUpdate()
    {
        playerRb.velocity = new Vector2(input * speed, playerRb.velocity.y);

        

    }

}

