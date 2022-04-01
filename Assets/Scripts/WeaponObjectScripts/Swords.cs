using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : ItemDatabase
{
    public string weaponName;
    public string weaponID;
    public string weaponRarity;
    public string weaponType;

    public Texture2D weaponTexture = null;
    public Rigidbody2D weaponRigidbody = null;
    public CapsuleCollider2D weaponCollider = null;

    public int attackDamage;
}

[CreateAssetMenu(menuName = "Sword")]
public class Swords : Weapons
{
    
}

[CreateAssetMenu(menuName = "Bow")]
public class Bows : Weapons
{
    
}