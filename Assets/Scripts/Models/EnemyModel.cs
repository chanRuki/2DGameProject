using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Create/EnemyModel")]
public class EnemyModel : ScriptableObject
{
    [SerializeField]
    private int power;
    public int Power { get => power; set => power = value; }

    private int speed;
    public int Speed { get => speed; set => speed = value; }
}