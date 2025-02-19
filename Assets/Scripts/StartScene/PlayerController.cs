using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : BaseController
{
    Camera mainCamera;

    protected override void Start()
    {
        base.Start();
        mainCamera = Camera.main;
        Time.timeScale = 1.0f;
    }
    void OnMove(InputValue inputValue)
    {
        moveDirection = inputValue.Get<Vector2>().normalized;
    }

    void OnLook(InputValue inputValue)
    {
        Vector2 mousePosition = inputValue.Get<Vector2>();
        Vector2 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            SceneManager.LoadScene("FirstScene");
        }
    }
}
