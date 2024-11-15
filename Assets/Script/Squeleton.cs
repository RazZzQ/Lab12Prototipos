using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squeleton : Enemy
{
    private void Start()
    {
        Type = EnemyType.SKELETON;
    }
    public override void Spawn()
    {
        Debug.Log("Skeleton Spawned with Speed: " + Speed);
    }
}
