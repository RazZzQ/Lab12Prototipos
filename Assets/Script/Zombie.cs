using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    private void Start()
    {
        Type = EnemyType.ZOMBIE; 
    }
    public override void Spawn()
    {
        Debug.Log("Zombie Spawned with Health: " + Health);
    }
}
