using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private MappingManager mappingManager = null;
    private PlayerViewModel playerViewModel = null;
    private void Start()
    {
        mappingManager = GameManager.Instance.GetComponent<MappingManager>();
        playerViewModel = mappingManager.FetchPlayerData(GameManager.Instance.ModelDataBase.PlayerModel);
    }

    public void OnPlayerMove()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-Vector3.right * playerViewModel.Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * playerViewModel.Speed * Time.deltaTime);
        }
    }

    public void PlayerHpChange(int damege)
    {
        playerViewModel.PlayerHp = playerViewModel.PlayerHp - damege;
        Debug.Log($"HP :{playerViewModel.PlayerHp}");
    }

}
