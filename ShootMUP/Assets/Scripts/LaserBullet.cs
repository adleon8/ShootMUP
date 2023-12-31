using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour
{
    // -----VARIABLES-----
    public float speed = 10f;           // Speed variable.
    public Rigidbody rigidbody;         // Rigidbody.
    private float yPosition;
    private float maxHeight = 17f;

    void Start()
    {
        rigidbody.velocity = transform.up * speed;

        yPosition = transform.position.y;
    }


    private void FixedUpdate()
    {
       if (yPosition >= maxHeight)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
