using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{


    bool isSwinging = false;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            // Debug.Log("Click");
            isSwinging = true;
            animator.SetBool("isSwinging", true);
        }
        else
        {
            animator.SetBool("isSwinging", false);
        }
            
    }
}
