using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scrips.Models;

[CreateAssetMenu(fileName = "enemy name", menuName = "ScriptableObjects/Models/MEnemyBase")]
public class MEnemyBase : ScriptableObject
{
    [SerializeField]
    private string enemyName;
    public string EnemyName { get => enemyName; set => enemyName = value; }
    
    [SerializeField]
    private float hp;
    public float Hp { get => hp; set => hp = value; }

    [SerializeField]
    private float speed;
    public float Speed { get => speed; set => speed = value; }

    [SerializeField]
    private float attack;
    public float Attack { get => attack; set => attack = value; }
    
    [SerializeField]
    private Constans.EnemyType enemyType;
    public Constans.EnemyType EnemyType { get => enemyType; }
}
