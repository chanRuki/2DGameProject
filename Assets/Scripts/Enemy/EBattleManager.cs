using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBattleManager : MonoBehaviour
{
    [SerializeField]
    private EnemyManager enemyManager = null;
    private void Update()
    {
        enemyManager.EnemyUpdate();
    }
}
