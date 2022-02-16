using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    private int score;
    

    public int Score { get => score; set => score = value; }
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
