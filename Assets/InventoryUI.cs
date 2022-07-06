using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    public InventorySlot[] slots;

    public InventoryManager inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = InventoryManager.Instance;
        inventory.onItemChangedCallback += updateUI;

        slots = transform.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void updateUI()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if(i < inventory.Items.Count)
            { 
                slots[i].addItem(inventory.Items[i], i);
            }
            else
            {
                slots[i].clearSlot();
            }
        }
    }
}
