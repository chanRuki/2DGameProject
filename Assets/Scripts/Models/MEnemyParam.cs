using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scrips.Models;

[CreateAssetMenu(fileName = "MEnemyParam", menuName = "ScriptableObjects/Create/MEnemyParam")]
public class MEnemyParam : ScriptableObject
{
    [SerializeField]
    private string enemyName;
    public string EnemyName { get => enemyName; set => enemyName = value; }
    
    [SerializeField]
    private int hp;
    public int Hp { get => hp; set => hp = value; }

    [SerializeField]
    private int speed;
    public int Speed { get => speed; set => speed = value; }

    [SerializeField]
    private int attack;
    public int Attack { get => attack; set => attack = value; }
    
    [SerializeField]
    private Constans.EnemyType enemyType;
    public Constans.EnemyType EnemyType { get => enemyType; }
}
