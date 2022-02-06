using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
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
}
