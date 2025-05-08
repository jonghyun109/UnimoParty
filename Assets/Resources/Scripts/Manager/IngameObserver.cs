using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameObserver : MonoBehaviour
{
    public event Action<DataCenter> OnGameDataChange;

    public UserPlayer UserPlayer { get; private set; }
    private DataCenter gamedata = new DataCenter(3, 0);

    public void ResetData()
    {
        gamedata = new DataCenter(3, 0);
        OnGameDataChange?.Invoke(gamedata.Clone());
    }

    public void HitPlayer()
    {
        --gamedata.life;
        var tempGameData = gamedata.Clone();
        OnGameDataChange?.Invoke(tempGameData);
    }

    public void AddScore()
    {
        ++gamedata.score;
        var tempGameData = gamedata.Clone();
        OnGameDataChange?.Invoke(tempGameData);
    }

    public void EndGame()
    {

    }
}
