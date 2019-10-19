using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDetection : MonoBehaviour
{
    public PlayerJump jumpScript;
    public float timeBetween = .2f;
    float deltime;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        deltime += Time.deltaTime;

        if (deltime >= timeBetween)
        {
            jumpScript.FixJump();
            deltime = 0;
        }
    }
}
