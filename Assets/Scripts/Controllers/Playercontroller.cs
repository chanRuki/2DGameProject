using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerManager playerManager = null;
    private void Start()
    {
        playerManager = GetComponentInParent<PlayerManager>();
    }

    private void Update()
    {
        playerManager.OnPlayerMove();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        playerManager.PlayerHpChange(GameManager.Instance.ModelDataBase.EnemyModel.Power);
    }
}