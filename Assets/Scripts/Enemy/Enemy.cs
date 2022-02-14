using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyStatus enemyStatus = null;

    public void Initialized(MEnemyParam param)
    {
        FetchEnemyStatus(param);
    }

    public void EnemyUpdate()
    {
        if (enemyStatus.Hp <= 0)
        {
            this.gameObject.SetActive(false);
            enemyStatus.Hp = 0;
        }
    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            enemyStatus.Hp = enemyStatus.Hp - 50;
        }
    }

    private EnemyStatus FetchEnemyStatus(MEnemyParam param)
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

        return enemyStatus;
    }

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
