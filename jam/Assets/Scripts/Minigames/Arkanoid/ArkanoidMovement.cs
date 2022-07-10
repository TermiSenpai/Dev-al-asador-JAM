using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ArkanoidMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        transform.Rotate(0,0,-horizontal * rotationSpeed * Time.deltaTime);
    }
}

