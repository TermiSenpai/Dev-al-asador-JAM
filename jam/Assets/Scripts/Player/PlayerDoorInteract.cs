using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoorInteract : MonoBehaviour
{
    [SerializeField] SpriteRenderer wall;
    [SerializeField] private bool canFadeOut = true;
    [SerializeField] private bool canFadeIn = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door") && canFadeOut) StartCoroutine(FadeOut());
        if (collision.CompareTag("Door") && canFadeIn) StartCoroutine(FadeIn());
        
    }

    IEnumerator FadeOut()
    {
        canFadeOut = false;
        for(float i = 1f; i >= -0.05f; i -= 0.1f)
        {
            changeWallColor(i);
            yield return new WaitForSeconds(0.05f);
        }
        canFadeIn = true;
    }

    IEnumerator FadeIn()
    {
        canFadeIn=false;
        for (float i = -0.05f; i <= 1; i += 0.1f)
        {
            changeWallColor(i);
            yield return new WaitForSeconds(0.05f);
        }
        canFadeOut = true;
    }

    private void changeWallColor(float alpha)
    {
        Color c = wall.material.color;
        c.a = alpha;
        wall.material.color = c;
    }
}
