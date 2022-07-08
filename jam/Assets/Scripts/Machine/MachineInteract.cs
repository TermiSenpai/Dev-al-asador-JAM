using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MachineInteract : MonoBehaviour
{
    [Header("ELEMENTS")]
    [SerializeField] private PlayerMove playerMove;
    [SerializeField] private GameObject cameraPos;
    [SerializeField] private GameObject player;
    [SerializeField] private bool isTouchingMachine;
    [SerializeField] private GameObject text;
    [SerializeField] private Animator animator;

    [Header("OPEN LEVEL")]
    [SerializeField] private GameObject minigame;


    [Header("LEVEL MUSIC")]
    [SerializeField] private float delayStartTime;
    [SerializeField] public bool levelCompleted;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip musicToPlay;
    [SerializeField] private float musicDuration;
    [SerializeField] private AudioSource completedSound;

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
        if(!levelCompleted)
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
        if (isTouchingMachine && callback.phase == InputActionPhase.Started && !levelCompleted)
        {
            source.clip = musicToPlay;
            playerMove.canMove = false;
            minigame.transform.position = cameraPos.transform.position - new Vector3(0, cameraPos.transform.position.y - 0.25f, cameraPos.transform.position.z);
            minigame.SetActive(true);
            player.SetActive(false);
            source.PlayDelayed(delayStartTime);
            Invoke("exitminigame", musicDuration);
        }
    }

    private void exitminigame()
    {
        source.Stop();
        animator.SetBool("Completed", true);
        levelCompleted = true;
        minigame.SetActive(false);
        player.SetActive(true);
        playerMove.canMove = true;
        playerMove.curMoveInput = Vector2.zero;
        completedSound.Play();
    }
}
