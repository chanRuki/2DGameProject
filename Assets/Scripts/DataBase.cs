using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    [SerializeField]
    private MEnemyBase mEnemyBase = null;
    public MEnemyBase MEnemyBase { get => mEnemyBase; set => mEnemyBase = value; }
}
