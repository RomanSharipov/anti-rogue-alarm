using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float sensevityX = 3f;

    private float mouseX;

    public void View(InputAction.CallbackContext context)
    {
        mouseX = context.ReadValue<float>() * Time.deltaTime* sensevityX;
        transform.Rotate(0, mouseX, 0);
    }
}
