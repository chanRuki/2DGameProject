using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private MappingManager mappingManager = null;
    private EnemyViewModel enemyViewModel = null;
    private void Start()
    {
        mappingManager = GameManager.Instance.GetComponent<MappingManager>();
        enemyViewModel = mappingManager.FetchEnemyDate(GameManager.Instance.ModelDataBase.EnemyModel);
    }
}
