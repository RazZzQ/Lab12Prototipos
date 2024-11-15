using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : Enemy
{
    private void Start()
    {
        Type = EnemyType.DEMON;
    }
    public override void Spawn()
    {
        Debug.Log("Demon Spawned with Damage: " + Damage);
    }
}
