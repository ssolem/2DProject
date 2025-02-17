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
    // �߻� Ŭ������ �ٸ� �÷��̾� ���Ͱ� �� �� �ְԲ�
    // awake, start, update, fixedupdate
    // �̵�, �ü�ó��,( ����, �˹�, ���)

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
        direction = direction; // �ӵ�

        rigidbody.velocity = direction;
    }

    private void Look(Vector2 direction)
    {

    }

}
