using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class MappingManager : MonoBehaviour
{
    /// <summary>
    /// PlayerModelからPlayerViewModelに詰め替える
    /// </summary>
    public PlayerViewModel FetchPlayerData(PlayerModel playerModel)
    {
        if (playerModel == null)
        {
            return null;
        }

        var viewModel = new PlayerViewModel();
        bool check = HasCheckProperties(playerModel, viewModel);
        if (!check)
        {
            return null;
        }

        viewModel.PlayerName = playerModel.PlayerName;
        viewModel.PlayerHp = playerModel.Hp;
        viewModel.Speed = playerModel.Speed;

        return viewModel;
    }

    public EnemyViewModel FetchEnemyDate(EnemyModel enemyModel)
    {
        if (enemyModel == null)
        {
            return null;
        }

        var viewModel = new EnemyViewModel();
        bool check = HasCheckProperties(enemyModel, viewModel);
        if (!check)
        {
            return null;
        }

        viewModel.Power = enemyModel.Power;
        viewModel.Speed = enemyModel.Speed;

        return viewModel;
    }

    public bool HasCheckProperties<T1, T2>(T1 model, T2 viewModel)
    {
        var properties1 = typeof(T1)
            .GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly).Length;
        var properties2 = typeof(T2)
            .GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly).Length;

        if (properties1 != properties2)
        {
            Debug.LogError("プロパティの数が不一致！！！");
            return false;
        }
        else
        {
            return true;
        }
    }
}
