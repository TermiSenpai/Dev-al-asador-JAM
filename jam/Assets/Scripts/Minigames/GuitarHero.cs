using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GuitarHero : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] botones;
    public InputAction playerController;

    private void OnEnable()
    {
        playerController.Enable();
    }
    private void OnDisable()
    {
        playerController.Disable();
    }
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PressButton(0);
        }
    }

    private void PressButton(int button)
    {
        botones[button].color = Color.red;
    }
}
