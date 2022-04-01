using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMasterScript : MonoBehaviour
{
    public GameObject player;

    public Text deathCounter;

    private Vector3 playerStartPosition;

    private PlayerDeaths playerDeaths = new PlayerDeaths();
    private PlayerJumps playerJumps = new PlayerJumps();

    private void Start ()
    {
        playerJumps.Jumps = 1;

        playerStartPosition = player.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        deathCounter.text = $"Deaths: {playerDeaths.Deaths}";
    }

    public void PlayerDied()
    {
        playerDeaths.Deaths++;
        Debug.Log($"Total Deaths: {playerDeaths}");

        player.transform.position = playerStartPosition;
    }
}
