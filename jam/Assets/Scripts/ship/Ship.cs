using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private PlayerMove player;
    [SerializeField] private GameObject unCompletedText;
    [SerializeField] private GameObject interactText;

    [SerializeField] private GameCompleted game;

    private bool istouching;


    private void Start()
    {
        unCompletedText.SetActive(false);
        interactText.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && istouching)
        {
            if (player.gameCompleted)
            {
                StartCoroutine(game.fadeIN());
                player.canMove = false;
                interactText.SetActive(false);
            }
            else
            {
                unCompletedText.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            istouching = true;
            interactText.SetActive(true);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        istouching = false;
        unCompletedText.SetActive(false);
        interactText.SetActive(false);
    }

}
