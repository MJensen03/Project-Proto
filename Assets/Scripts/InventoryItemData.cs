using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Inventory Item Data")]
public class InventoryItemData : ScriptableObject
{
    public string itemID;
    public string displayName;
    public Sprite icon;
    public GameObject prefab;
}
