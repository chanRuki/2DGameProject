using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Create/PlayerModel")]
public class PlayerModel : ScriptableObject
{
    [SerializeField]
    private string playerName = "名無し";
    public string PlayerName { get => playerName; set => playerName = value; }

    [SerializeField]
    private int hp;
    public int Hp { get => hp; set => hp = value; }

    [SerializeField]
    private int speed;
    public int Speed { get => speed; set => speed = value; }
}