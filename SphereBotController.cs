using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBotController : MonoBehaviour
{
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.J))
        {
            animator.SetBool("J pressed", true);
        }
        else if(!Input.GetKey(KeyCode.J))
        {
            animator.SetBool("J pressed", false);
        }
        if (Input.GetKey(KeyCode.K))
        {
            animator.SetBool("K Pressed", true);
        }
        else if (!Input.GetKey(KeyCode.K))
        {
            animator.SetBool("K Pressed", false);
        }
    }
}
