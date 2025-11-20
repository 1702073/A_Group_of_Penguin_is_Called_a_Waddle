using UnityEngine;
[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]

public class Enemy_Movement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector2 _whereToGo;
    public float moveSpeed = 5f;
    public GameObject player;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    { 
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
            return;
        }

        //determine where to go and move towards player
        _whereToGo = (player.transform.position - transform.position).normalized;
        
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        
        _rb.linearVelocity = moveSpeed * _whereToGo;
    }
}
