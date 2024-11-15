using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EnemyFactory;

public class GameManager : MonoBehaviour
{
    private EnemyFactory enemyFactory;

    public GameObject zombiePrefab;
    public GameObject skeletonPrefab;
    public GameObject demonPrefab;

    void Start()
    {
        enemyFactory = new EnemyFactory();

        enemyFactory.zombiePrefab = zombiePrefab;
        enemyFactory.skeletonPrefab = skeletonPrefab;
        enemyFactory.demonPrefab = demonPrefab;

        Enemy zombie = enemyFactory.CreateEnemy(EnemyType.ZOMBIE);
        zombie.Health = 100f;
        zombie.Speed = 1.5f;
        zombie.Damage = 1;
        zombie.Spawn();

        Enemy skeleton = enemyFactory.CreateEnemy(EnemyType.SKELETON);
        skeleton.Health = 50;
        skeleton.Speed = 2.5f;
        skeleton.Damage = 2f;
        skeleton.Spawn();

        Enemy demon = enemyFactory.CreateEnemy(EnemyType.DEMON);
        demon.Health = 200;
        demon.Speed = 5;
        demon.Damage = 50f;
        demon.Spawn();
    }
}
