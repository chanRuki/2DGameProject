using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    void Start()
    {
        var neko = GetComponentInParent<UIManager>();
        neko.OnUpdateScore += OnUpdateNotifiScore;
    }

    public void OnUpdateNotifiScore(int score)
    {
        this.gameObject.GetComponent<Text>().text = score.ToString();
    }
}
