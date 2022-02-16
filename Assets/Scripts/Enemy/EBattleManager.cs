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

    private void Update()
    {
        enemyManager1.EnemyUpdate();
        enemyManager2.EnemyUpdate();
        //enemyManager3.EnemyUpdate();
    }
}
