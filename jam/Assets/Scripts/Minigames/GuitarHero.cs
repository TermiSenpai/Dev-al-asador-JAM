using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GuitarHero : MonoBehaviour
{
    [SerializeField] private ButtonInfo[] botones;

    public void ButtonUp(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            PressButton(0);
        }
        if (context.phase == InputActionPhase.Canceled)
        {
            ReleaseButton(0);
        }
    }
    public void ButtonDown(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            PressButton(1);
        }
        if (context.phase == InputActionPhase.Canceled)
        {
            ReleaseButton(1);
        }
    }
    public void ButtonRight(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            PressButton(2);
        }
        if (context.phase == InputActionPhase.Canceled)
        {
            ReleaseButton(2);
        }
    }
    public void ButtonLeft(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            PressButton(3);
        }
        if (context.phase == InputActionPhase.Canceled)
        {
            ReleaseButton(3);
        }
    }

    private void PressButton (int button)
    {
        ButtonInfo buttonInfo = botones[button];
        if (buttonInfo == null) return;

        buttonInfo.buttonSpriteRenderer.color = buttonInfo.darkColor;
    }
    private void ReleaseButton(int button)
    {
        ButtonInfo buttonInfo = botones[button];
        if (buttonInfo == null) return;

        buttonInfo.buttonSpriteRenderer.color = buttonInfo.originalColor;
    }
    private void SpawnNotes(int button)
    {
        ButtonInfo buttonInfo = botones[button];
        if (buttonInfo == null) return;



    }
}
