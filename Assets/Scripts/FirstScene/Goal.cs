using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Goal : MonoBehaviour
{
    public Player player;
    Animations animations;

    [SerializeField] private SpriteRenderer spriteRenderer;

    private float goalDistance;
    public float GoalDistance {get => goalDistance;}

    private bool isNearGoal = false;
    private bool isEnding = false;

    public PlayerInput playerInput;
    public InputAction endAction;

    private void Start()
    {
        animations = GetComponent<Animations>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        endAction = playerInput.actions["End"];
    }

    private void Update()
    {
        GetDistance();
        IsEnd();
    }

    private void GetDistance()
    {
        Vector2 distance = player.transform.position - spriteRenderer.transform.position;
        goalDistance = Mathf.Abs(distance.magnitude);

        isNearGoal = goalDistance > 1f ? false : true;
        IsNear(isNearGoal);
    }

    public void IsNear(bool near)
    {
        animations.NearGoal(isNearGoal);
    }

    void OnEnd(InputValue inputValue)
    {
        isEnding = endAction.WasPressedThisFrame();
    }

    private void IsEnd()
    {
        if (!isNearGoal)
            return;
        else
        {

        }
    }

}
