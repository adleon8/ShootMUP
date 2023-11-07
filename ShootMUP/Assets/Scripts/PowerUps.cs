using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public PowerUp powerUps;
    public float speed = 3f;
    public float boundary = -14f;

    private void FixedUpdate()
    {
        // Power ups enum.
        switch (powerUps)
        {
            case PowerUp.Blaster:
                Move();
                Debug.Log("Blaster");
                break;
            case PowerUp.Spread:
                Move();
                Debug.Log("Spread");                
                break;
            case PowerUp.Shield:
                Move();
                Debug.Log("Shield");
                break;
            case PowerUp.None:
                break;
            default:
                break;
        }
    }

    public virtual void Move()
    {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime; // Moving down the screen at a fixed way.
        pos = tempPos;
        if (transform.position.y <= boundary)
        {
            Destroy(gameObject);
        }
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

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

public enum PowerUp
{
    Blaster,
    Spread,
    Shield,
    None
}
