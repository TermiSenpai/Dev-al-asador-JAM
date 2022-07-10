using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine2 : MonoBehaviour
{
    [SerializeField] GameObject flotantText;
    [SerializeField] GameObject completedText;
    [SerializeField] GameObject unCompletedText;

    [SerializeField] public bool arkanoidCompleted;
    [SerializeField] private PlayerMove player;

    private bool istouching;

    private void Start()
    {
        desactiveTexts();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && istouching)
        {
            if (arkanoidCompleted)
            {
                completedText.SetActive(true);
                player.gameCompleted = true;
            }
            else
                unCompletedText.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !player.gameCompleted)
        {
            flotantText.SetActive(true);
            istouching = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        desactiveTexts();
        istouching = false;
    }

    private void desactiveTexts()
    {
        flotantText.SetActive(false);
        completedText.SetActive(false);
        unCompletedText.SetActive(false);
    }




}
