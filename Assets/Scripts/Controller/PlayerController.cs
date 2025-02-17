using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : BaseController
{
    void OnMove(InputValue inputValue)
    {
        moveDirection = inputValue.Get<Vector2>().normalized;
    }

    void OnLook(InputValue inputValue)
    {

    }
}
