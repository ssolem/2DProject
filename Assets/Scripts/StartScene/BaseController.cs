using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseController : MonoBehaviour
{
    protected Rigidbody2D rigidBody;

    [SerializeField] private SpriteRenderer spriteRenderer;
    
    protected Vector2 moveDirection = Vector2.zero;
    public Vector2 MoveDirection { get => moveDirection; }

    protected Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection { get => lookDirection; }
    // 추상 클래스로 다른 플레이어 몬스터가 쓸 수 있게끔
    // awake, start, update, fixedupdate
    // 이동, 시선처리,( 공격, 넉백, 사망 - 여유잇으면)

    [SerializeField] private int playerSpeed;
    public int PlyaerSpeed {  get => playerSpeed; }

    Animations animations;

    protected bool isJumping;



    protected virtual void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        animations = GetComponent<Animations>();
    }

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {
        Look(lookDirection);
        Jump();
    }

    protected virtual void FixedUpdate()
    {
        Move(moveDirection);
    }

    private void Move(Vector2 direction)
    {
        direction = direction * playerSpeed;

        rigidBody.velocity = direction;
        animations.IsMove(direction);
    }

    private void Look(Vector2 direction)
    {
        bool isRIght = direction.x > 0;

        spriteRenderer.flipX = isRIght ? false: true;
    }

    private void Jump()
    {
        if (isJumping)
        {
            animations.IsJump();
            isJumping = false;
        }
    }
}
