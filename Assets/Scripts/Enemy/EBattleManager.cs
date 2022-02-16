using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBattleManager : MonoBehaviour
{
    [SerializeField]
    private EnemyManager enemyManager1 = null;
    [SerializeField]
    private EnemyManager enemyManager2 = null;
    [SerializeField]
    private EnemyManager enemyManager3 = null;

    private void Start()
    {
        enemyManager1.completeHandler = CallEnemyCreate;
        
    }

    private void Update()
    {
        enemyManager1.EnemyUpdate();
        enemyManager2.EnemyUpdate();
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    enemyManager1.ExeProcess();
        //}
    }

    private void CallEnemyCreate(string result)
    {
        Debug.Log("ˆ—Š®—¹ : " + result);
    }
}
