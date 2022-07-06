using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectPickUp : MonoBehaviour
{

    [SerializeField]
    private Transform rightHand;
    [SerializeField]
    // private InventoryManage playerInventory;
    private float lookDistance = 3;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;
        ItemController itemController;
       


        // Debug.DrawRay(transform.position, fwd * lookDistance, Color.yellow);
        if (Physics.Raycast(transform.position, fwd, out hit, lookDistance))
            if (hit.transform.CompareTag("Item"))
                if (Input.GetKeyDown(KeyCode.E))
                {
                    // playerInventory.addItem(hit.transform.gameObject);
                    // hit.transform.gameObject.SetActive(false);
                    itemController = hit.transform.GetComponent<ItemController>();
                    InventoryManager.Instance.Add(itemController.item);
                    Destroy(hit.transform.gameObject);
                }
        // Debug.Log(hit.transform.name);

    }
}
