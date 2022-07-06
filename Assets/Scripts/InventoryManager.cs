using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static InventoryManager Instance;
    [SerializeField]
    private InventoryItemData empty;
    public List<InventoryItemData> Items = new List<InventoryItemData>();
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    public int size = 31;
    public int slot = 0;

    private InventoryItemData itemSwap;
    

    private void Awake()
    {
        Instance = this;
        for (int i = 0; i < size; i++)
            Items.Add(empty);
    }
    public void Add(InventoryItemData item)
    {
        Items[slot] = item;
        slot++;
        if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }



    public void Remove(InventoryItemData item)
    {

        Items.Remove(item);
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }

    public void Swamp(InventoryItemData item, int _slot)
    {



        if (itemSwap == null)
        {
            Debug.Log("Saving Items Info");
            slot = _slot;
            itemSwap = item;
        }
        else
        {
            InventoryItemData oldItem = item;
            Debug.Log("Swapping" + itemSwap + " and" + oldItem);
            Items[_slot] = itemSwap;
            Items[slot] = oldItem;
            itemSwap = null;
        }

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();

    }
}
