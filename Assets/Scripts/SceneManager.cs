using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    ScoreManager scoreManager = null;
    
    private void Start()
    {
        scoreManager = new ScoreManager();
        scoreManager.ScoreUpdateHandler = CallScoreUpdate;
    }

    private void Update()
    {
        // 敵を倒すとスコアがカウントされる
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreManager.ExeScoreUpdateProcess();
            Debug.Log($"Score:{GameManager.Instance.Score}");
        }
    }

    public void CallScoreUpdate(int score)
    {
        var temp = GameManager.Instance.Score;
        GameManager.Instance.Score = temp + score;
    }
}
