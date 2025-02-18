using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    [SerializeField] private SpriteRenderer spriteRenderer;

    private float moveDirection = 0;

    public float MoveDirection { get => moveDirection; }

    [SerializeField] private float playerSpeed;
    public float PlayerSpeed { get => playerSpeed; }

    Animations animations;

    public PlayerInput playerInput;
    public InputAction moveAction;
    public InputAction jumpAction;

    Camera camera;

    private bool isJumping = false;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        animations = GetComponent<Animations>();

        moveAction = playerInput.actions["Move"];
        jumpAction = playerInput.actions["Jump"];
       
    }
    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move(moveDirection);
        Look(moveDirection);
        Jump();
    }

    private void Move(float direction)
    {
        if (direction == 0) 
            Stop(direction);
        direction = direction * playerSpeed;
        transform.Translate(Vector3.right * direction);

        animations.IsMove2(direction);
    }

    private void Stop(float direction)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y);
    }

    private void Look(float direction)
    {
        if (direction == 0)
        {
            spriteRenderer.flipX = spriteRenderer.flipX;
            return;
        }
        bool isRIght = direction > 0;

        spriteRenderer.flipX = isRIght ? false : true;
    }

    private void Jump()
    {
        if (isJumping)
        {
            animations.IsJump();
            isJumping = false;
        }
    }

    void OnMove(InputValue inputValue)
    {
        moveDirection = inputValue.Get<float>();
        Debug.Log(moveDirection);
        if(moveDirection != 1 && moveDirection != -1)
        {
            moveDirection = 0;
            Debug.Log(moveDirection);

        }
    }

    void OnJump(InputValue inputValue)
    {
        isJumping = jumpAction.WasPressedThisFrame();
    }
}
