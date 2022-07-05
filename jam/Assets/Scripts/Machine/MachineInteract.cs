using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MachineInteract : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private bool isTouchingMachine;
    [SerializeField] private PlayerMove playerMove;
    [SerializeField] private GameObject minigame;
    [SerializeField] private GameObject cameraPos;
    [SerializeField] private GameObject player;

    void Start()
    {
        minigame.SetActive(false);
        text.SetActive(false);
        isTouchingMachine = false;
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.SetActive(true);
        isTouchingMachine = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.SetActive(false);
        isTouchingMachine = false;
    }

    public void Interact(InputAction.CallbackContext callback)
    {
        if (isTouchingMachine && callback.phase == InputActionPhase.Started)
        {
            playerMove.canMove = false;
            minigame.transform.position = cameraPos.transform.position - new Vector3(0, cameraPos.transform.position.y - 0.25f, cameraPos.transform.position.z);
            minigame.SetActive(true);
            player.SetActive(false);
            //Invoke("exitminigame", 2);
        }
    }

    private void exitminigame()
    {
            minigame.SetActive(false);
            player.SetActive(true);
            playerMove.canMove = true;

    }
}
