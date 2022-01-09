using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SWNetwork;

public class PlayerControllerMulti : MonoBehaviour
{
    public Animator animator;
    public Camera cam;
    public Joystick joystick;
    public float movementSpeed;
    public Rigidbody2D rb;
    float mx;
    public float jumpForce = 20f;
    public LayerMask groundLayers;
    public bool isOnGround = true;
    private float prevHorizontal;
    private bool direction;
    NetworkID networkID;

    float hInput = 0;

    private void Start()
    {
        direction = true;
        networkID = GetComponent<NetworkID>();
    }

    private void Update()
    {
        if (networkID.IsMine) {
            float movement = joystick.Horizontal;
            if (joystick.Horizontal != 0) {
                if (joystick.Horizontal < 0.05 && joystick.Horizontal > -0.05) {
                    movement = 0.0f;
                } else {
                    movement = joystick.Horizontal;
                }

            }
            Move(movement);
            if (Input.GetButtonDown("Jump") && isOnGround) {
                Jump();
                isOnGround = false;
            }

            if (prevHorizontal > 0) {
                direction = true;
            } else if (prevHorizontal < 0) {
                direction = false;
            }

            if (direction) {
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            } else {
                transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }

            cam.transform.position = transform.position;

            prevHorizontal = joystick.Horizontal;
        }
    }
        

    void Move(float horizonalInput) {
        animator.SetFloat("Speed", Mathf.Abs(horizonalInput));
        
        Vector2 moveVel = rb.velocity;
        moveVel.x = horizonalInput * movementSpeed;
        rb.velocity = moveVel;

    }
    public void Jump()
    {
        if (isOnGround)
        {
            Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
            rb.velocity = movement;
            isOnGround = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isOnGround = true;

        }
    }
    public void StartMoving(float horizonalInput)
    {
        hInput = horizonalInput;
    }
}