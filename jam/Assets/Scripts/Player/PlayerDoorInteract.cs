using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoorInteract : MonoBehaviour
{
    [SerializeField] SpriteRenderer wall;
    private bool canFade = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door") && canFade) StartCoroutine(FadeOut());
        
    }

    IEnumerator FadeOut()
    {
        canFade = false;
        for(float i = 1f; i >= -0.05f; i -= 0.05f)
        {
            changeWallColor(i);
            yield return new WaitForSeconds(0.05f);
        }
    }

    //IEnumerator FadeIn()
    //{
    //    for(float i = 0.05f; i <= 1; i += 0.05f)
    //    {
    //        changeWallColor(i);
    //        yield return new WaitForSeconds(0.05f);
    //    }
    //}

    private void changeWallColor(float alpha)
    {
        Color c = wall.material.color;
        c.a = alpha;
        wall.material.color = c;
    }
}
