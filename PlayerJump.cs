using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpHeight;
    Rigidbody player;
    bool timeOut = false;
    bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded)
            {
                Vector3 oldvel = player.velocity;
                Vector3 jvel = new Vector3(oldvel.x, jumpHeight, oldvel.z);


                player.velocity = jvel;
                isGrounded = false;
                //Invoke("FixJump", 1);
            }


        }
    }
    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    public void FixJump()
    {
        timeOut = false;
    }
}
