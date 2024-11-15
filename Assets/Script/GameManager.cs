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
        zombie.Spawn();

        Enemy skeleton = enemyFactory.CreateEnemy(EnemyType.SKELETON);
        skeleton.Speed = 2.5f;
        skeleton.Spawn();

        Enemy demon = enemyFactory.CreateEnemy(EnemyType.DEMON);
        demon.Damage = 50f;
        demon.Spawn();
    }
}
