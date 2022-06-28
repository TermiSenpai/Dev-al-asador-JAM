using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Vector2 curMoveInput;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] private float speed;

    void Update()
    {
        playerMove();
    }

    private void playerMove()
    {
        rigid.velocity = curMoveInput * speed;
    }

    #region input actions
    public void Move(InputAction.CallbackContext context)
    {
        // read if AD is keydown or not
        if (context.phase == InputActionPhase.Performed)
        {
            curMoveInput = context.ReadValue<Vector2>();
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            curMoveInput = Vector2.zero;
        }
    }
    #endregion
}