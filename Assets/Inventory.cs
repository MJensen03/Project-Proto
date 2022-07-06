using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update

    private InventoryManager inventoryManager;
    public Transform rightHand;
    private bool isEquipped = false;
    void Start()
    {
        isEquipped = false;
        inventoryManager = InventoryManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        Equip();
    }

    public void Equip()
    {
        // Debug.Log("1");

        if (Input.GetKeyDown(KeyCode.Alpha1) && isEquipped == false)
        {
            isEquipped = true;
            GameObject item = Instantiate(inventoryManager.Items[0].prefab);
            item.transform.parent = rightHand;
            item.transform.localPosition = Vector3.zero;
            item.transform.localRotation = inventoryManager.Items[0].prefab.transform.localRotation;
        }
    }
}
