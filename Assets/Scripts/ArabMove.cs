using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]

public class ArabMove : MonoBehaviour
{
    private Vector2 _moveDirection;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }


    private void Move(Vector2 direction)
    {
        _animator.SetFloat("Vertical", direction.x);
        _animator.SetFloat("Horizontal", direction.y);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _moveDirection = context.ReadValue<Vector2>();
        Move(_moveDirection);
    }
}
