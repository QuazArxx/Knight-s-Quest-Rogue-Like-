using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    private List<ItemDatabase> inventory;
}

public class PlayerDeaths
{
    private int deathTotal;

    public PlayerDeaths()
    {
        deathTotal = 0;
    }

    public int Deaths 
    { 
        get => deathTotal;
        set => deathTotal = value;
    }
}

public class PlayerJumps
{
    private int jumpTotal;

    public PlayerJumps()
    {
        jumpTotal = 1;
    }

    public int Jumps
    {
        get => jumpTotal;
        set => jumpTotal = value;
    }
}