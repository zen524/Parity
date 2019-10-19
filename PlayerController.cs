using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 300;
    Rigidbody rb;

    float ws;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        moveDirection = (horizontal * transform.right + vertical * transform.forward).normalized;


    }
    
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            ws = 3.5f * walkSpeed;
        }
        else
        {
            ws = walkSpeed;
        }
        Vector3 yVelFix = new Vector3(0f, rb.velocity.y, 0f);
        rb.velocity = moveDirection * ws * Time.deltaTime;
        rb.velocity += yVelFix;
    }
}
