using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EnemyType
{
        ZOMBIE,
        SKELETON,
        DEMON
}
public class EnemyFactory 
{
    public GameObject zombiePrefab;
    public GameObject skeletonPrefab;
    public GameObject demonPrefab;

    public Enemy CreateEnemy(EnemyType type)
    {
        GameObject enemyGO;
        switch (type)
        {
            case EnemyType.ZOMBIE:
                enemyGO = GameObject.Instantiate(zombiePrefab);
                break;
            case EnemyType.SKELETON:
                enemyGO = GameObject.Instantiate(skeletonPrefab);
                break;
            case EnemyType.DEMON:
                enemyGO = GameObject.Instantiate(demonPrefab);
                break;
            default:
                throw new System.ArgumentException("Invalid enemy type");
        }
        return enemyGO.AddComponent<Enemy>();
    }
}
