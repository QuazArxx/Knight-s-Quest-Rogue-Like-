using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterMethods
{
    public GameObject player;

    private PlayerDeaths playerDeaths;
    private Vector3 playerStartPosition = GameObject.Find("Player").transform.position;

    public void PlayerDied()
    {
        playerDeaths.Deaths++;
        Debug.Log($"Total Deaths: {playerDeaths}");

        player.transform.position = playerStartPosition;
    }
}
