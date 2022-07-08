using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        source.Play();
    }
}
