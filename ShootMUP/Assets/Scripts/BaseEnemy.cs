using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    // -----VARIABLES-----
    public float health = 3;
    public float laserDamage = 1;

    private void FixedUpdate()
    {
        
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
