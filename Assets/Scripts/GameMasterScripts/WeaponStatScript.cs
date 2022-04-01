using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStatScript : MonoBehaviour
{
    public Swords swordStats;

    private void Start()
    {
        Debug.Log(swordStats.attackDamage);
        Debug.Log(swordStats.weaponName);
    }
}
