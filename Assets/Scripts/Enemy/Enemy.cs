using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyStatus enemyStatus = null;

    public void Initialized(MEnemyParam param)
    {
        SetEnemyStatus(param);
    }

    public void EnemyUpdate()
    {
        if (enemyStatus.Hp <= 0)
        {
            this.gameObject.SetActive(false);
            enemyStatus.Hp = 0;
        }
    }



    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
        }
    }

    private EnemyStatus SetEnemyStatus(MEnemyParam param)
    {
        if (!param)
        {
            return null;
        }

        enemyStatus = new EnemyStatus();
        var check = HasCheckProperties(param, enemyStatus);
        if (!check)
        {
            return null;
        }

        enemyStatus.Hp = param.Hp;
        enemyStatus.Speed = param.Speed;
        enemyStatus.Attack = param.Attack;
        enemyStatus.EnemyType = param.EnemyType;

        return enemyStatus;
    }

    /// <summary>
    /// 設定した引数のプロパティの数を調べる
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <param name="param"></param>
    /// <param name="status"></param>
    /// <returns></returns>
    private bool HasCheckProperties<T1, T2>(T1 param, T2 status)
    {
        var properties1 = typeof(T1)
            .GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly).Length;
        var properties2 = typeof(T2)
            .GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly).Length;
        if (properties1 != properties2)
        {
            Debug.LogError("プロパティの数が不一致！！！");
            return false;
        }
        else
        {
            return true;
        }
    }
}
