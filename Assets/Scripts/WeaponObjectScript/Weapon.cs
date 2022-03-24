using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapon")]
public class Weapon : ScriptableObject
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