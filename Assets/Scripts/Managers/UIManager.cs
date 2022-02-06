using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public event Action<int> OnUpdateScore;

    private void Update()
    {
        // ƒeƒXƒg
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.Score += 10;
        }
        OnUpdateScore?.Invoke(GameManager.Instance.Score);
    }
}
