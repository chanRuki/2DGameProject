using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager
{
    public delegate void OnScoreUpdate(int score);
    public OnScoreUpdate ScoreUpdateHandler;

    public void ExeScoreUpdateProcess()
    {
        ScoreUpdateHandler?.Invoke(100);
    }
}
