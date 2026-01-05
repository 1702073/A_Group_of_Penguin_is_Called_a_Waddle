using UnityEngine;
[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))] // Base Unity Stuff

[RequireComponent(typeof(Enemy_Health_and_Damage), typeof(Enemy_Drops))] // Enemy Scripts

public class Enemy_Movement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Animator _animator;
    public GameObject player;

    private Vector2 _whereToGo;
    public float moveSpeed = 5f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    { 
        //determine where to go and move towards player
        _whereToGo = (player.transform.position - transform.position).normalized;
        
        //transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        
        _rb.linearVelocity = moveSpeed * _whereToGo;




        if (_whereToGo != Vector2.zero)
        {
            _animator.SetFloat("xMovement", _whereToGo.x);
        }


        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
            return;
        }
    }
}
