using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D), typeof(PlayerInput))]
public class Player_Movement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Animator _animator;

    private Vector2 _moveAmount;
    public float moveSpeed = 5f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _rb.linearVelocity = _moveAmount;
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        Vector2 inputVector = ctx.ReadValue<Vector2>();
        _moveAmount = inputVector * moveSpeed;

        if (_moveAmount != Vector2.zero)
        {
            _animator.SetFloat("xMovement", inputVector.x);
            _animator.SetFloat("yMovement", inputVector.y);
        }
    }

    public void SpeedUp(float speedIncrease)
    {
        moveSpeed += speedIncrease;
        if(moveSpeed > 11)
        {
            moveSpeed = 11;
        } 
    }
}
