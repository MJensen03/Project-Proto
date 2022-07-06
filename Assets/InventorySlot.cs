
using UnityEngine;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
    InventoryItemData item;
    public Image icon;
    private int slot;

    public void Start()
    {
        icon.enabled = false;
        // slots = GetComponentInParent<InventorySlot[]>();
    }
    public void addItem(InventoryItemData newItem, int i)
    {
        // Debug.Log(newItem.name)
        slot = i;
        Debug.Log(newItem.name);
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void clearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
    }


    public void moveItem()
    {
        
        InventoryManager.Instance.Swamp(item, slot);
                 
    }
    
}
