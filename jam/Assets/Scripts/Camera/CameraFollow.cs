using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //L?mite
    public float minX;
    public float maxX;

    // Jugador
    public GameObject target;
    private Vector3 targetPos;

    private void Update()
    {
        cameraMove();
        cameraLimit();
    }

    private void cameraMove()
    {
        // Ajusto la posici?n
        targetPos = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);

        transform.position = targetPos;
    }

    private void cameraLimit()
    {
        if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }
        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
    }
}
