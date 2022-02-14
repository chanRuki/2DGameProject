using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab = null;
    [SerializeField]
    private int enemyMax = 0;

    private List<Enemy> enemies = new List<Enemy>();

    public void Start()
    {
        for (int i = 0; i < enemyMax; i++)
        {
            CreateEnemy(GameManager.Instance.DataBase.MEnemyParam);
        }
    }

    public Enemy CreateEnemy(MEnemyParam param)
    {
        var enemyObj = Instantiate(enemyPrefab);
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
