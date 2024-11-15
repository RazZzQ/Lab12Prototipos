using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health;
    public float Speed;
    public float Damage;
    public EnemyType Type { get; protected set; }
    public virtual void Spawn() { }
}
