using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMasterScript : MonoBehaviour
{
    public Text deathCounter;
    private PlayerDeaths playerDeaths = new PlayerDeaths();
    private PlayerJumps playerJumps = new PlayerJumps();

    private void Start ()
    {
        playerJumps.Jumps = 3;
    }
    // Update is called once per frame
    void Update()
    {
        deathCounter.text = $"Deaths: {playerDeaths.Deaths}";
    }
}
