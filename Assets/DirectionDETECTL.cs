using UnityEngine;

public class DirectionDETECTL : MonoBehaviour
{


    private Animator anim;
    private Rigidbody2D rb; 
    public bool facingRight = true;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        
        anim.SetFloat("SpeedX", horizontalInput);
        if (horizontalInput > 0)
        {
            facingRight = true;
            Debug.Log("Moving Right");
        }
        else if (horizontalInput < 0)
        {
            facingRight = false;
            Debug.Log("Moving Left");
        }
    }
}
