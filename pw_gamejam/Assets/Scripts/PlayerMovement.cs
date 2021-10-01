using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{

    public CharacterController2D controller;
    public Animator animator;
    public Rigidbody2D rb;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    private bool airBorn = false;

    // Update is called once per frame
    void Update () 
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.gravityScale = 1;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            rb.gravityScale = 3;
        }
    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
        rb.gravityScale = 3;
    }

    void FixedUpdate ()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}