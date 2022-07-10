using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private PlayerMove playerMovement;

    [SerializeField] private GameObject canva;
    [SerializeField] private MenuController controller;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            startGame();

        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            controller.openOptionsMenu();

        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            controller.exitGame();

    }

    public void startGame()
    {
        playerMovement.canMove = true;
        canva.SetActive(false);
    }
}
