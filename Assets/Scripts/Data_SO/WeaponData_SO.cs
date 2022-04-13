using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Data", menuName = "Weapon/Weapon Stats")]
public class WeaponData_SO : ScriptableObject
{
    //if you do not need any state, just leave it as 0
    [Header("Weapon Info")]
    public string weaponName;
    public int weaponDamage;

    public int currentBullet;
    public int maxBullet;
}
