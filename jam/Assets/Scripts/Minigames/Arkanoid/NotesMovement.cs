using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesMovement : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    [SerializeField] private string visibleLayer;
    [SerializeField] private SpriteRenderer sprite;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += (direction * Time.deltaTime * speed);
    }

    private void destroyNote()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perfect"))
        {
            Debug.Log("Perfect");
            destroyNote();
        }

        if (collision.CompareTag("Good"))
        {
            Debug.Log("Good");
            destroyNote();
        }

        if (collision.CompareTag("Lose"))
        {
            Debug.Log("Lose");
            destroyNote();
        }

        if (collision.CompareTag("Frame"))
        {
            sprite.sortingLayerName = visibleLayer;
        }

    }
}
