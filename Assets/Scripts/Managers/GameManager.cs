using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    private ModelDataBase modelDataBase = null;
    private GameObject player = null;
    private int score;

    public ModelDataBase ModelDataBase { get => modelDataBase; }
    public GameObject Player { get => player; }
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
    public int Score { get => score; set => score = value; }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        modelDataBase = GetComponent<ModelDataBase>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
