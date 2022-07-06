using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInfo : MonoBehaviour
{
    public GameObject note;
    public SpriteRenderer buttonSpriteRenderer;
    public Color originalColor;
    public Color darkColor;
    public Transform spawn;
    public Transform despawn;

    private void Awake()
    {
        originalColor = buttonSpriteRenderer.color;
        darkColor = new Color(originalColor.r - 0.4f, originalColor.g - 0.4f, originalColor.b - 0.4f);
    }
}
