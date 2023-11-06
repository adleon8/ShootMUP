using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    // -----VARIABLES-----
    public float health = 3;

    // -----MOVEMENT-----
    public float speed = 6f;
    public float boundary = -14f;




    private void Update()
    {
        Move();

        // Checks bounds.
        if (transform.position.y <= boundary)
        {
            Destroy(gameObject);
        }
    }


    public virtual void Move()
    {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime; // Moving down the screen at a fixed way.
        pos = tempPos;
    }

    public Vector3 pos
    {
        get
        {
            return this.transform.position;
        }
        set
        {
            this.transform.position = value;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Laser")
        {
            Damage();
        }
    }


    private void Death()
    {
        Destroy(gameObject);
    }

    private IEnumerator Blink()
    {
        for (int index = 0; index < 2; index++)
        {
            if (index % 2 == 0)
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = true;
            }
            yield return new WaitForSeconds(.1f);
        }
        GetComponent<MeshRenderer>().enabled = true;
    }

    public void Damage()
    {
        health--;
        StartCoroutine(Blink());
        if (health <= 0)
        {
            Death();
        }
    }

}
