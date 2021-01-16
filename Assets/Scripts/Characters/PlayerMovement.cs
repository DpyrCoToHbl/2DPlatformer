using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private LayerMask _groundExample;
    [SerializeField] private Animator _animator;

    private Rigidbody2D _rigidbody;
    private bool isFacingRight = true;
    internal bool isGrounded;
    private float _move;

    private void Start()
    {
        _animator.SetTrigger("Idle");
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (_move > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (_move < 0 && isFacingRight)
        {
            Flip();
        }
    }

    private void Update()
    {
        _move = Input.GetAxis("Horizontal");
        if (_move == 0)
        {
            _animator.SetTrigger("Idle");
        }
        if (_move != 0)
        {
            _rigidbody.velocity = new Vector2(_move * _speed, _rigidbody.velocity.y);
            _animator.SetTrigger("Run");
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300));
            _animator.SetTrigger("Jump");
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
