using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    [SerializeField]

    private float mouseSens = 100f;

    [SerializeField]
    private Transform playerBody;

    private float xRotation = 0f;
    // Start is called before the first frame update
    private bool pauseMouse;
    void Start()
    {
        pauseMouse = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab) && !pauseMouse)
        {
            Cursor.lockState = CursorLockMode.None;
            pauseMouse = true;
        }
        else if(Input.GetKeyDown(KeyCode.Tab) && pauseMouse)
        {
            Cursor.lockState = CursorLockMode.Locked;
            pauseMouse = false;
        }

        if(!pauseMouse)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
       
    }
}
