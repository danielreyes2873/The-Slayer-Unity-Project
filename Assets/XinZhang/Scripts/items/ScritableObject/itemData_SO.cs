using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { Useable, Weapon, Armor }

[CreateAssetMenu(fileName = "New item", menuName = "Inventory/Item Data")]
public class itemData_SO : ScriptableObject
{
    public ItemType itemType;
    public string itemName;
    public Sprite itemIcon;
    public int itemAmount;
    [TextArea]
    public string description;
    public bool stackable;

    [Header("Weapon")]
    /// <summary>
    /// The interval time between each bullet
    /// </summary>
    public float coolDown;
    /// <summary>
    /// Have to be end with eq
    /// </summary>
    public GameObject weaponPrefab;
    public int damage;
    public int maxAmmo;
    public int currentAmmo;
    public int spareAmmo;

}
