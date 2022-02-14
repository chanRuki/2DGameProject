using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MEnemyParam", menuName = "ScriptableObjects/Create/MEnemyParam")]
public class MEnemyParam : ScriptableObject
{
    [SerializeField]
    private int hp;
    public int Hp { get => hp; set => hp = value; }

    [SerializeField]
    private int speed;
    public int Speed { get => speed; set => speed = value; }

    [SerializeField]
    private int attack;
    public int Attack { get => attack; set => attack = value; }
}
