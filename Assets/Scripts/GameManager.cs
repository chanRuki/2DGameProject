using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    [SerializeField]
    private DataBase dataBase = null;

    public DataBase DataBase { get => dataBase; set => dataBase = value; }
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (GameManager)FindObjectOfType(typeof(GameManager));
                if (instance == null)
                {
                    Debug.LogError("GameManager Instance Error");
                }
            }
            return instance;
        }
    }
}
