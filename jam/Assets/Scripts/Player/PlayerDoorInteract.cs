using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerDoorInteract : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] Tilemap tileMap;
    [SerializeField] private GameObject exteriorWall;
    [SerializeField] private float fadeSpeed;
    [SerializeField] private bool canFadeOut = true;
    [SerializeField] private bool canFadeIn = false;

    private void Start()
    {
        exteriorWall.SetActive(true);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door") && canFadeOut) StartCoroutine(FadeOut());
        if (collision.CompareTag("Door") && canFadeIn) StartCoroutine(FadeIn());
        
    }

    IEnumerator FadeOut()
    {
        canFadeOut = false;
        for(float i = 1f; i >= -0.05f; i -= fadeSpeed)
        {
            changeWallColor(i);
            yield return new WaitForSeconds(0.05f);
        }
        canFadeIn = true;
    }

    IEnumerator FadeIn()
    {
        canFadeIn=false;
        for (float i = -0.05f; i <= 1; i += fadeSpeed)
        {
            changeWallColor(i);
            yield return new WaitForSeconds(0.05f);
        }
        canFadeOut = true;
    }

    private void changeWallColor(float alpha)
    {
        if(tileMap != null)
        {
            Color tileColor = tileMap.color;
            tileColor.a = alpha;
            tileMap.color = tileColor;
        }
        if(sprite != null)
        {
            Color spriteColor = sprite.material.color;
            spriteColor.a = alpha;
            sprite.material.color = spriteColor;
        }
    }
}
