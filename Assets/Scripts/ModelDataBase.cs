using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelDataBase : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private PlayerModel playerModel = null;
    public PlayerModel PlayerModel { get => playerModel; set => playerModel = value; }

    [SerializeField]
    private EnemyModel enemyModel = null;
    public EnemyModel EnemyModel { get => enemyModel; set => enemyModel = value; }
}
