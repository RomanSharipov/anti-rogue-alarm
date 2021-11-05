using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ArabMouseLook : MonoBehaviour
{
    [SerializeField] private float _sensevityX = 5f;

    private float _mouseX;

    public void View(InputAction.CallbackContext context)
    {
        _mouseX = context.ReadValue<float>() * Time.deltaTime* _sensevityX;
        transform.Rotate(0, _mouseX, 0);
    }
}
