using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigEnemy : BaseEnemy
{
   public override void Move()
    {
        Vector3 tempPos = pos;
        tempPos.x = Mathf.Sin(Time.time * Mathf.PI * 2) * 3;
        pos = tempPos;
        base.Move();
    }
}
