using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private MEnemyBase enemyPram = null;
    [SerializeField]
    private GameObject enemyPrefab = null;
    [SerializeField]
    private int enemyMax = 0;
    

    private List<Enemy> enemies = new List<Enemy>();

    public void Start()
    {
        for (int i = 0; i < enemyMax; i++)
        {
            CreateEnemy(enemyPram);
        }
    }

    public Enemy CreateEnemy(MEnemyBase param)
    {
        var enemyObj = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        enemyObj.transform.parent = this.transform;
        var enemy = enemyObj.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Initialized(param);
            enemies.Add(enemy);

            return enemy;
        }

        return null;
    }

    public void EnemyUpdate()
    {
        foreach (var enemy in enemies)
        {
            enemy.EnemyUpdate();
        }
    }
}
