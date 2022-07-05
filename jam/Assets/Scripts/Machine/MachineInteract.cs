using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MachineInteract : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private bool isTouchingMachine;
    [SerializeField] private PlayerMove player;
    [SerializeField] private GameObject minigame;
    [SerializeField] private GameObject cameraPos;

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
            player.canMove = false;
            //minigame.transform.position = cameraPos.transform.position - new Vector3(0,0,cameraPos.transform.position.z);
            minigame.SetActive(true);
        }
    }

    // TEMPORAL
    public void Pause(InputAction.CallbackContext callback)
    {
        if (isTouchingMachine && callback.phase == InputActionPhase.Started)
        {
            player.canMove = true;
            minigame.SetActive(false);
        }
    }
}
