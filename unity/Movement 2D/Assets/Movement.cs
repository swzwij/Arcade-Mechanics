using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 12f;
    public float jumpSpeed = 500.0f;
    public float maxSpeed = 12f;
    public float maxSprint = 18f;
    public float jumpDelay = 1.5f;
    public int getal = 10;
    public Animator animator1;


    private float timer = 0.0f;


    private bool jumpTimer = false;
    private bool isGrounded = false;
    private bool isSprinting = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Sprinting
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }

        else
        {
            isSprinting = false;
        }


        if (Input.GetKey(KeyCode.D)) //naar rechts bewegen
        {
            //rb.velocity = new Vector2(speed, 0);
            rb.AddForce(new Vector2(speed, 0));
            animator1.SetFloat("speed", speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //rb.velocity = new Vector2(-speed, 0);
            rb.AddForce(new Vector2(-speed, 0));
            animator1.SetFloat("speed", speed);
        }

        /*if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            rb.AddForce = new Vector2(0, 0);
        }*/

        if (Input.GetKey(KeyCode.Space) && isGrounded == true && jumpTimer == false)
        {
            rb.AddForce(new Vector2(0, jumpSpeed));
            jumpTimer = true;
        }

        if (Physics2D.Raycast(transform.position, Vector2.down, 0.05f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            speed += 0.15f;
        }
        else
        {
            speed = 12f;
        }

        if (jumpTimer)
        {
            timer += Time.deltaTime;
        }

        if (timer > jumpDelay)
        {
            jumpTimer = false;

            timer = 0f;
        }

        if (speed > maxSpeed && isSprinting == false)
        {
            speed = maxSpeed;
        }

        if (speed > maxSprint && isSprinting == true)
        {
            speed = maxSprint;
        }
    }
}