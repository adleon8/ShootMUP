using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalkerEnemy : BaseEnemy
{
    public float stalkerSpeed = 5f;

    private void Awake()
    {
        speed = stalkerSpeed;
    }

    public override void Move()
    {
        //if player is left of enemy do this
        if (GameObject.FindGameObjectWithTag("Player").transform.position.x < this.transform.position.x)
        {
            //makes enemy move left
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        else
        {
            //makes enemy move right
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        base.Move();
    }
}
