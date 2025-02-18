using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : BaseController
{
    Camera camera;

    protected override void Start()
    {
        base.Start();
        camera = Camera.main;
    }
    void OnMove(InputValue inputValue)
    {
        moveDirection = inputValue.Get<Vector2>().normalized;
    }

    void OnLook(InputValue inputValue)
    {
        Vector2 mousePosition = inputValue.Get<Vector2>();
        Vector2 worldPosition = camera.ScreenToWorldPoint(mousePosition);
        lookDirection = worldPosition - (Vector2)transform.position;
            
    }

    void OnJump(InputValue inputValue)
    {
        Debug.Log(inputValue.isPressed);
        if(inputValue.isPressed)
        {
            isJumping = inputValue.isPressed;
        }
    }
}
