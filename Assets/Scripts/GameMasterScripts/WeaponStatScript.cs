using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStatScript : MonoBehaviour
{
    public Weapon weaponStats;

    private void Start()
    {
        Debug.Log(weaponStats.attackDamage);
        Debug.Log(weaponStats.weaponName);
    }
}
