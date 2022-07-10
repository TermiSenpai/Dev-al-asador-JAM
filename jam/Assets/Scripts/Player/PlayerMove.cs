using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public Vector2 curMoveInput;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] private float speed;
    [SerializeField] public bool canMove;
    [SerializeField] Animator anim;
    [SerializeField] private bool facingRight;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] public bool gameCompleted;

    private void Start()
    {
    }

    void Update()
    {
        playerMove();

        if (curMoveInput.x < 0 && facingRight)
        {
            flip();
        }
        if (curMoveInput.x > 0 && !facingRight)
        {
            flip();
        }
    }

    private void playerMove()
    {
        rigid.velocity = curMoveInput * speed;
    }

    private void flip()
    {
        Vector2 newscale = transform.localScale;
        newscale.x *= -1;
        transform.localScale = newscale;

        facingRight = !facingRight;
    }

    #region input actions
    public void Move(InputAction.CallbackContext context)
    {
        if (canMove)
        {
            // read if AD is keydown or not
            if (context.phase == InputActionPhase.Performed)
            {
                curMoveInput = context.ReadValue<Vector2>();
                anim.SetBool("Walking", true);

            }
            else if (context.phase == InputActionPhase.Canceled)
            {
                curMoveInput = Vector2.zero;
                anim.SetBool("Walking", false);
            }

        }
    }

    public void Pause(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Started)
        {
            curMoveInput = Vector2.zero;
            canMove = false;
            mainMenu.SetActive(true);
            anim.SetBool("Walking", false);
        }
    }
    #endregion


    #region getters
    public bool getCanMove()
    {
        return canMove;
    }
    #endregion

    #region setters
    public void setCanMove(bool set)
    {
        canMove = set;
    }

    public bool getFacing()
    {
        return facingRight;
    }
    #endregion
}
