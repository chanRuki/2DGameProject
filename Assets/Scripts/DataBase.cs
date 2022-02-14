using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    [SerializeField]
    private MEnemyParam mEnemyParam = null;
    public MEnemyParam MEnemyParam { get => mEnemyParam; set => mEnemyParam = value; }
}
