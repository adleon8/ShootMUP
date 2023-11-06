using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrozenEnemy : BaseEnemy
{
    public bool frozen;
    public float frozenSpeed = 2f;
    public float unfrozenSpeed = 8f;

    private void Start()
    {
        frozen = true;
    }

    public override void Move()
    {
        StartCoroutine("Frozen");
        base.Move();
    }

    private IEnumerator Frozen()
    {
        if (frozen)
        {
            speed = frozenSpeed;
            yield return new WaitForSeconds(9f);
            frozen = false;
        }
        if (frozen == false)
        {
            speed = unfrozenSpeed;
        }
    }
}

