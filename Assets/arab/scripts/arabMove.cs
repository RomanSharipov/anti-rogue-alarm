using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class arabMove : MonoBehaviour
{
    private Vector2 _moveDirection;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _moveDirection = context.ReadValue<Vector2>();
        Move(_moveDirection);
    }

    void Move(Vector2 direction)
    {
        animator.SetFloat("Vertical", direction.x);
        animator.SetFloat("Horizontal", direction.y);
    }
}
