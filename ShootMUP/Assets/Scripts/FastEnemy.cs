using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastEnemy : BaseEnemy
{
    public float fastSpeed = 10f;

    private void Awake()
    {
        speed = fastSpeed;
    }
    public override void Move()
    {
        // Create a local Vector variable and set to pos
        Vector3 tempPos = pos;
        tempPos.x = Mathf.Cos(Time.time * Mathf.PI * 2) * 4;
        pos = tempPos;

        base.Move(); // Calls the parent Enemy class' original function so that new class also moves downward. 
    }
}
