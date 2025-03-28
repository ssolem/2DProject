using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private static readonly int IsMoving = Animator.StringToHash("IsMove");
    private static readonly int IsJumping = Animator.StringToHash("IsJump");
    private static readonly int IsJumping2 = Animator.StringToHash("IsJump2");
    private static readonly int IsDamaged = Animator.StringToHash("IsDamage");
    private static readonly int IsNearGoal = Animator.StringToHash("IsNear");
    private static readonly int IsEnding = Animator.StringToHash("IsEnd");
    private static readonly int RestartingGame = Animator.StringToHash("RestartGame");

    protected Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void IsMove(Vector2 movement)
    {
        animator.SetBool(IsMoving, movement.magnitude > 0);
    }

    public void IsMove2(float direction)
    {
        animator.SetBool(IsMoving, direction != 0);
    }

    public void IsJump()
    {
        animator.SetTrigger(IsJumping);
    }

    public void IsJump2()
    {
        animator.SetTrigger(IsJumping2);
    }


    // FirstScene
    public void NearGoal(bool near)
    {
        animator.SetBool(IsNearGoal, near);
    }

    public void IsEnd()
    {
        animator.SetTrigger(IsEnding);
    }

    public void RestartGame()
    {
        animator.SetTrigger(RestartingGame);
    }

}
