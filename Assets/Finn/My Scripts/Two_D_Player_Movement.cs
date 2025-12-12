using UnityEngine;

public class Two_D_Player_Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
    public float speedLimit = 10;
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speedLimit = 20;
        }
        else
        {
            speedLimit = 10;
        }

        if (Input.GetKey(KeyCode.W))//Up
        {
            if (rb.linearVelocityY < speedLimit)
            {
                rb.AddForceY(speed);
                animator.SetFloat("VerticalSpeed", speed);
            }
        }

        if (Input.GetKey(KeyCode.A))//Left
        {
            if (rb.linearVelocityX > -speedLimit)
            {
                rb.AddForceX(-speed);
                animator.SetFloat("HorizontalSpeed", -speed);
            }
        }

        if (Input.GetKey(KeyCode.S))//Down
        {
             if (rb.linearVelocityY > -speedLimit)
             {
                rb.AddForceY(-speed);
                animator.SetFloat("VerticalSpeed", -speed);
             }
        }

        if (Input.GetKey(KeyCode.D))//Right
        {
            if (rb.linearVelocityX < speedLimit)
            {
                rb.AddForceX(speed);
                animator.SetFloat("HorizontalSpeed", speed);
            }
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            animator.SetFloat("VerticalSpeed", 0);
        }
        
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetFloat("HorizontalSpeed", 0);
        }
    }
}
