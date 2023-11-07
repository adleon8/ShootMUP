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


    // -----POWERUPS-----
    [SerializeField]
    private float randomPowerUp;

    public GameObject blasterPrefab;
    public GameObject spreadPrefab;
    public GameObject shieldPrefab;


    private void Start()
    {
        /*
        randomPowerUp = Random.Range(0, 1); 
        if (randomPowerUp < 1)
        {
            Instantiate(blasterPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (randomPowerUp == 1)
        {
            Instantiate(spreadPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        */
    }

    private void Update()
    {
        Move();

        // Checks bounds.
        if (transform.position.y <= boundary)
        {
            Destroy(gameObject);
        }
    }

    public int RandomPowerUp()
    {
        return Random.Range(0, 6);
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
        int randomPower = RandomPowerUp();
        if (randomPower == 3)
        {
            Instantiate(blasterPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (randomPower == 4)
        {
            Instantiate(spreadPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (randomPower == 5)
        {
            Instantiate(blasterPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }

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




