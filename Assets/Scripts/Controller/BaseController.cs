using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseController : MonoBehaviour
{
    protected Rigidbody2D rigidbody;

    [SerializeField] private SpriteRenderer spriteRenderer;
    
    protected Vector2 moveDirection = Vector2.zero;
    public Vector2 MoveDirection { get => moveDirection; }

    protected Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection { get => lookDirection; }
    // 추상 클래스로 다른 플레이어 몬스터가 쓸 수 있게끔
    // awake, start, update, fixedupdate
    // 이동, 시선처리,( 공격, 넉백, 사망)

    protected virtual void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {

    }

    protected virtual void FixedUpdate()
    {

    }

    private void Move(Vector2 direction)
    {
        direction = direction; // 속도

        rigidbody.velocity = direction;
    }

    private void Look(Vector2 direction)
    {

    }

}
